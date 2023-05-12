#include "main.h"

#define LCD_8bit 			 // Select LCD_8bit or LCD_4bit

#if defined(LCD_8bit)
void LCD_put(uint8_t ch) {
	HAL_GPIO_WritePin(LCD_RW_GPIO_Port,LCD_RW_Pin,GPIO_PIN_RESET); // write to LCD
	HAL_GPIO_WritePin(LCD_D7_GPIO_Port,LCD_D7_Pin,ch>>7&1);
	HAL_GPIO_WritePin(LCD_D6_GPIO_Port,LCD_D6_Pin,ch>>6&1);
	HAL_GPIO_WritePin(LCD_D5_GPIO_Port,LCD_D5_Pin,ch>>5&1);
	HAL_GPIO_WritePin(LCD_D4_GPIO_Port,LCD_D4_Pin,ch>>4&1);
	HAL_GPIO_WritePin(LCD_D3_GPIO_Port,LCD_D3_Pin,ch>>3&1);
	HAL_GPIO_WritePin(LCD_D2_GPIO_Port,LCD_D2_Pin,ch>>2&1);
	HAL_GPIO_WritePin(LCD_D1_GPIO_Port,LCD_D1_Pin,ch>>1&1);
	HAL_GPIO_WritePin(LCD_D0_GPIO_Port,LCD_D0_Pin,ch&1);
	HAL_GPIO_WritePin(LCD_E_GPIO_Port,LCD_E_Pin,GPIO_PIN_SET); // enable pulse
	HAL_GPIO_WritePin(LCD_E_GPIO_Port,LCD_E_Pin,GPIO_PIN_RESET);
	HAL_Delay(1); // 37 us
}

void LCD_init() {
	HAL_Delay(15);
	HAL_GPIO_WritePin(LCD_RS_GPIO_Port,LCD_RS_Pin,GPIO_PIN_RESET); // command
	LCD_put(0x30);
	HAL_Delay(5);
	LCD_put(0x30);
	LCD_put(0x30);
	LCD_put(0x38); // 0B00111100 8bit, N=1 (2 lines); F=0 (5x8)
	LCD_put(0x08);
	LCD_put(0x01);
	LCD_put(0x06); // 0B00000110 Increase ID=1, S/C=0 Cursor move
	// End of LCD initialization procedure
	LCD_put(0x0D); // 0B00001011 D = 1, C = 0, B = 1 Blink the cursor
}

#elif defined(LCD_4bit)
void LCD_put4bit(uint8_t ch) {
	HAL_GPIO_WritePin(LCD_RW_GPIO_Port,LCD_RW_Pin,GPIO_PIN_RESET); // write to LCD
	HAL_GPIO_WritePin(LCD_D7_GPIO_Port,LCD_D7_Pin,ch>>7&1);
	HAL_GPIO_WritePin(LCD_D6_GPIO_Port,LCD_D6_Pin,ch>>6&1);
	HAL_GPIO_WritePin(LCD_D5_GPIO_Port,LCD_D5_Pin,ch>>5&1);
	HAL_GPIO_WritePin(LCD_D4_GPIO_Port,LCD_D4_Pin,ch>>4&1);
	HAL_GPIO_WritePin(LCD_E_GPIO_Port,LCD_E_Pin,GPIO_PIN_SET); // enable pulse
	HAL_GPIO_WritePin(LCD_E_GPIO_Port,LCD_E_Pin,GPIO_PIN_RESET);
}

void LCD_put(uint8_t ch) {
	LCD_put4bit(ch);
	LCD_put4bit(ch<<4);
	HAL_Delay(1);
}
void LCD_init() {
	HAL_Delay(15);
	HAL_GPIO_WritePin(LCD_RS_GPIO_Port,LCD_RS_Pin,GPIO_PIN_RESET); // command
	LCD_put4bit(0x30);
	HAL_Delay(5);
	LCD_put4bit(0x30);
	HAL_Delay(1);
	LCD_put4bit(0x30);
	HAL_Delay(1);
	LCD_put4bit(0x20); 
	LCD_put(0x28); // 0B00101000 8bit, N=1 (2 lines); F=0 (5x8)
	LCD_put(0x08);
	LCD_put(0x01);
	LCD_put(0x06); // 0B00000110 Increase ID=1, S/C=0 Cursor move
	// End of LCD initialization procedure
	LCD_put(0x0D); // 0B00001011 D = 1, C = 0, B = 1 Blink the cursor
}

#endif

void LCD_gotoXY(uint8_t X, uint8_t Y) {
	HAL_GPIO_WritePin(LCD_RS_GPIO_Port,LCD_RS_Pin,GPIO_PIN_RESET);
	LCD_put(0x80+0x40*Y + X);
}

void LCD_printf(const uint8_t *p) { // *p address
	HAL_GPIO_WritePin(LCD_RS_GPIO_Port,LCD_RS_Pin,GPIO_PIN_SET); // data
	uint8_t i = 0;
	while ( *(p+i) != 0) {
		LCD_put( *(p+i));
		i++;
	}
}

void LCD_setCGRAM(uint8_t *PatternPointer, uint8_t PatternPosition) {
	for (uint8_t row = 0; row<8; row++) {
		HAL_GPIO_WritePin(LCD_RS_GPIO_Port,LCD_RS_Pin,GPIO_PIN_RESET); // command
		LCD_put(0x40 + (PatternPosition<<3) + row); // address
		HAL_GPIO_WritePin(LCD_RS_GPIO_Port,LCD_RS_Pin,GPIO_PIN_SET); // data
		LCD_put(*(PatternPointer + row));
	}
}


