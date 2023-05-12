#include "main.h"

void CLK(uint32_t n){
	while(n>0){
		HAL_GPIO_WritePin(CLK_GPIO_Port,CLK_Pin,1);
		HAL_GPIO_WritePin(CLK_GPIO_Port,CLK_Pin,0);
		n = n-1;
	}
}

void LATCH() {
	HAL_GPIO_WritePin(LAT_GPIO_Port,LAT_Pin,1);
	HAL_GPIO_WritePin(LAT_GPIO_Port,LAT_Pin,0);
}

void LCD_put4bit_RS0(uint8_t ch) {
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>7&1);
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>6&1);
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>5&1);
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>4&1);
	CLK(1);
	
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1); 
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0); 
	CLK(1);
	LATCH();
	
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>7&1);
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>6&1);
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>5&1);
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>4&1);
	CLK(1);
	
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0); 
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0); 
	CLK(1);
	LATCH();
}

void LCD_put_RS0(uint8_t ch) {
	LCD_put4bit_RS0(ch);
	LCD_put4bit_RS0(ch<<4);
	HAL_Delay(1);
}

void LCD_put4bit_RS1(uint8_t ch) {
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>7&1);
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>6&1);
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>5&1);
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>4&1);
	CLK(1);
	
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1); 
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1); 
	CLK(1);
	LATCH();
	
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>7&1);
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>6&1);
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>5&1);
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,ch>>4&1);
	CLK(1);
	
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0); 
	CLK(1);
	HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1); 
	CLK(1);
	LATCH();
}

void LCD_put_RS1(uint8_t ch) {
	LCD_put4bit_RS1(ch);
	LCD_put4bit_RS1(ch<<4);
	HAL_Delay(1);
}

void LCD_init() {
	HAL_Delay(15);
	LCD_put4bit_RS0(0x30);
	HAL_Delay(5);
	LCD_put4bit_RS0(0x30);
	HAL_Delay(1);
	LCD_put4bit_RS0(0x30);
	HAL_Delay(1);
	LCD_put4bit_RS0(0x20); 
	LCD_put_RS0(0x28); // 0B00101000 8bit, N=1 (2 lines); F=0 (5x8)
	LCD_put_RS0(0x08);
	LCD_put_RS0(0x01);
	LCD_put_RS0(0x06); // 0B00000110 Increase ID=1, S/C=0 Cursor move
	// End of LCD initialization procedure
	LCD_put_RS0(0x0D); // 0B00001011 D = 1, C = 0, B = 1 Blink the cursor
}

void LCD_gotoXY(uint8_t X, uint8_t Y) {
	LCD_put_RS0(0x80+0x40*Y + X);
}

void LCD_printf(const uint8_t *p) { // *p address
	uint8_t i = 0;
	while ( *(p+i) != 0) {
		LCD_put_RS1( *(p+i));
		i++;
	}
}