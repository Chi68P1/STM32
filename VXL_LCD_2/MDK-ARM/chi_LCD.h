#include <stdint.h>

void LCD_put4bit(uint8_t ch); 
void LCD_put(uint8_t ch);
void LCD_init();
void LCD_printf(const uint8_t *p);
void LCD_gotoXY(uint8_t X, uint8_t Y);
void LCD_setCGRAM(uint8_t *PatternPointer, uint8_t PatternPosition);