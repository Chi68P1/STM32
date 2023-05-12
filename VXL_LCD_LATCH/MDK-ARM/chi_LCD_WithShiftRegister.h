#include <stdint.h>

void CLK(uint32_t n);
void LATCH();
void LCD_put4bit_RS0(uint8_t ch); 
void LCD_put_RS0(uint8_t ch);
void LCD_put4bit_RS1(uint8_t ch); 
void LCD_put_RS1(uint8_t ch);
void LCD_init();
void LCD_printf(const uint8_t *p);
void LCD_gotoXY(uint8_t X, uint8_t Y);
