/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  * @attention
  *
  * Copyright (c) 2023 STMicroelectronics.
  * All rights reserved.
  *
  * This software is licensed under terms that can be found in the LICENSE file
  * in the root directory of this software component.
  * If no LICENSE file comes with this software, it is provided AS-IS.
  *
  ******************************************************************************
  */
/* USER CODE END Header */
/* Includes ------------------------------------------------------------------*/
#include "main.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
#include <stdio.h>

FILE __stdout;
//void LCD_putchar(uint8_t ch);
int fputc(int ch, FILE *f) 
{
//  LCD_putchar((uint8_t)ch);
  return ch;
}


/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/

/* USER CODE BEGIN PV */

/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */

/* LCD initilize sequence ------------------ */ 
#define LCD_8bit 				 // Select LCD_8bit or LCD_4bit
// #define LCD_useBF				 // 
// ============================================
#define CMD					0  		 // PutType
#define CMD4bit			0xFF	 // Put only nible
#define DAT					1  		 // PutType
#define BF_TIMEOUT 	200000uL    // Maximum busy flag waiting time loop count
/* ----------- End of LCD initilize sequence */ 

/* LCD constants define begin -------------- */
#define 	LCD_CLEARDISPLAY						0x01
#define 	LCD_RETURNHOME							0x02
#define 	LCD_ENTRY_INCREASE					0x06
#define 	LCD_ENTRY_DECREASE					0x04
#define 	LCD_ENTRY_SHIFTRIGHT				0x05
#define 	LCD_ENTRY_SHIFTLEFT				0x07
#define 	LCD_DISPLAY_ALL						0x0F
#define 	LCD_DISPLAY_OFF						0x08
#define 	LCD_CURSOR_OFF							0x0C
#define 	LCD_BLINK_OFF							0x0E
#define 	LCD_SHIFT_CURSOR_LEFT			0x10
#define 	LCD_SHIFT_CURSOR_RIGHT			0x14
#define 	LCD_SHIFT_DISP_LEFT				0x18
#define 	LCD_SHIFT_DISP_RIGHT				0x1C
#define 	LCD_SETCGRAM_ADDR					0x40
//        (LCD_SETCGRAM_ADDR | addr_value)
#define 	LCD_SETDDRAM_ADDR					0x80
//        (LCD_SETDDRAM_ADDR | addr_value)
/* --------------End of LCD constants define */ 


#if defined(LCD_useBF)				 // 
// Wait for LCD ready using Busy Flag check
// Return Wait until BF=0 or reach BF_TimeoutCnt == BF_TIMEOUT
uint8_t LCD_BF_checkAndWait() {
		uint32_t BF_TimeoutCnt = 0;

		// change BF into Digital input for reading busy state
		GPIO_InitTypeDef GPIO_InitStruct = {0};
		GPIO_InitStruct.Pin =  D4_Pin|D5_Pin|D6_Pin|D7_Pin|
												   D0_Pin|D1_Pin|D2_Pin|D3_Pin;
		GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
		GPIO_InitStruct.Pull = GPIO_NOPULL;
		HAL_GPIO_Init(D7_GPIO_Port, &GPIO_InitStruct);

		HAL_GPIO_WritePin(RW_GPIO_Port,RW_Pin,1);
		HAL_GPIO_WritePin(RS_GPIO_Port,RS_Pin,0);
		
//				Wait until BF = 0 (LCD not busy) or BF_TimeOutCnt reach BF_TIMEOUT
		while(HAL_GPIO_ReadPin(D7_GPIO_Port,D7_Pin)&&(BF_TimeoutCnt<BF_TIMEOUT)) { //&&(BF_TimeoutCnt<BF_TIMEOUT)
			BF_TimeoutCnt = BF_TimeoutCnt + 1;
		}

		// Change back BF into Digital OUTPUT PUSH PULL
		GPIO_InitStruct.Pin =  D4_Pin|D5_Pin|D6_Pin|D7_Pin|
												  D0_Pin|D1_Pin|D2_Pin|D3_Pin;		GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
		GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
		GPIO_InitStruct.Pull = GPIO_NOPULL;
		GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
		HAL_GPIO_Init(D7_GPIO_Port, &GPIO_InitStruct);
		
		HAL_GPIO_WritePin(RW_GPIO_Port,RW_Pin,0);    // Change back to Write mode
		return 0;
}
#endif

// LCD put
void LCD_put(uint8_t PutType, uint8_t	ch) {
	#if defined(LCD_useBF)
		LCD_BF_checkAndWait();
	#else
		HAL_Delay(1);
	#endif
#if defined(LCD_8bit)
	HAL_GPIO_WritePin(RS_GPIO_Port,RS_Pin,PutType); // IR
	HAL_GPIO_WritePin(EN_GPIO_Port,EN_Pin,0); // EN=0
	HAL_GPIO_WritePin(D7_GPIO_Port,D7_Pin,(ch>>7)&1u); 
	HAL_GPIO_WritePin(D6_GPIO_Port,D6_Pin,(ch>>6)&1u);
	HAL_GPIO_WritePin(D5_GPIO_Port,D5_Pin,(ch>>5)&1u);
	HAL_GPIO_WritePin(D4_GPIO_Port,D4_Pin,(ch>>4)&1u);
	HAL_GPIO_WritePin(D3_GPIO_Port,D3_Pin,(ch>>3)&1u);
	HAL_GPIO_WritePin(D2_GPIO_Port,D2_Pin,(ch>>2)&1u);
	HAL_GPIO_WritePin(D1_GPIO_Port,D1_Pin,(ch>>1)&1u);
	HAL_GPIO_WritePin(D0_GPIO_Port,D0_Pin,(ch>>0)&1u);
	HAL_GPIO_WritePin(EN_GPIO_Port,EN_Pin,1); // EN=1
	HAL_GPIO_WritePin(EN_GPIO_Port,EN_Pin,0); // EN=1
}

#elif defined(LCD_4bit)
	HAL_GPIO_WritePin(RS_GPIO_Port,RS_Pin,((PutType==CMD4bit)?CMD:PutType)); // IR
	HAL_GPIO_WritePin(EN_GPIO_Port,EN_Pin,0); // EN=0
	HAL_GPIO_WritePin(D7_GPIO_Port,D7_Pin,(ch>>7)&1u); 
	HAL_GPIO_WritePin(D6_GPIO_Port,D6_Pin,(ch>>6)&1u);
	HAL_GPIO_WritePin(D5_GPIO_Port,D5_Pin,(ch>>5)&1u);
	HAL_GPIO_WritePin(D4_GPIO_Port,D4_Pin,(ch>>4)&1u);
	HAL_GPIO_WritePin(EN_GPIO_Port,EN_Pin,1); // EN=1
	HAL_GPIO_WritePin(EN_GPIO_Port,EN_Pin,0); // EN=1

	if (PutType != CMD4bit) {
    #if defined(LCD_useBF)
			LCD_BF_checkAndWait();
		#else
			HAL_Delay(1);
		#endif
		HAL_GPIO_WritePin(RS_GPIO_Port,RS_Pin,((PutType==CMD4bit)?CMD:PutType)); // IR
		HAL_GPIO_WritePin(D3_GPIO_Port,D7_Pin,(ch>>3)&1u);
		HAL_GPIO_WritePin(D2_GPIO_Port,D6_Pin,(ch>>2)&1u);
		HAL_GPIO_WritePin(D1_GPIO_Port,D5_Pin,(ch>>1)&1u);
		HAL_GPIO_WritePin(D0_GPIO_Port,D4_Pin,(ch>>0)&1u);
		HAL_GPIO_WritePin(EN_GPIO_Port,EN_Pin,1); // EN=1
		HAL_GPIO_WritePin(EN_GPIO_Port,EN_Pin,0); // EN=1
	}
}

#endif
const uint8_t char2[]={0,14,17,31,16,14,0,4};   // e.
const uint8_t char1[]={0,2,7,2,14,18,18,15};   // dd
const uint8_t char0[]={2,4,0,4,4,4,4,14};  // e^'
const uint8_t char3[]={0,10,31,31,14,4,0,0};  // LOVE

void LCD_SetCustomChar(uint8_t pos,uint8_t *pTable) {
	pos = pos<<3;
	uint8_t i=0;
	for (i=0;i<8;i++) {
			LCD_put(CMD,LCD_SETCGRAM_ADDR|(pos|i));      			// set CRRAM address
			LCD_put(DAT,*(pTable+i));      		// set CRRAM data
	}
}

// LCD init
void LCD_Init() {
	HAL_Delay(15);
	#if defined(LCD_4bit) 
		LCD_put(CMD4bit, 0x30);
		HAL_Delay(5);
		LCD_put(CMD4bit, 0x30);
		HAL_Delay(1);
		LCD_put(CMD4bit, 0x30);
		LCD_put(CMD4bit, 0x20); // 4bit
		LCD_put(CMD, 0x2C);     // 4bit N=1 (2 lines); F=1 (5x10)
		LCD_put(CMD, 0x0F);     // 0B00001111 Display ON, cursor ON, Blink ON 
		LCD_put(CMD, 0x06);     // 0B00000110 Increase ID=1; S/C=0 Cursor move
		LCD_put(CMD, 0x01);     // Clear LCD
	#elif defined(LCD_8bit)
		LCD_put(CMD, 0x30);
		HAL_Delay(5);
		LCD_put(CMD, 0x30);
		HAL_Delay(1);
		LCD_put(CMD, 0x30);
		LCD_put(CMD, 0x3C);  // 0B00111100 8bit, N=1 (2 lines); F=1 (5x10)
		LCD_put(CMD, 0x0F);  // 0B00001111 Display ON, cursor ON, Blink ON 
		LCD_put(CMD, 0x06);  // 0B00000110 Increase ID=1; S/C=0 Cursor move
		LCD_put(CMD, 0x01);  // Clear LCD
	#endif
		HAL_Delay(2);							
}

/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
{
  /* USER CODE BEGIN 1 */

  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  /* USER CODE BEGIN 2 */
LCD_Init();

LCD_SetCustomChar(0,(uint8_t *)char0);
LCD_SetCustomChar(1,(uint8_t *)char1);
LCD_SetCustomChar(2,(uint8_t *)char2);
LCD_SetCustomChar(3,(uint8_t *)char3);
LCD_put(CMD,LCD_SETDDRAM_ADDR |0x00);
LCD_put(DAT,'C');
LCD_put(DAT,'h');
LCD_put(DAT,0);  // i/
LCD_put(DAT,' ');
LCD_put(DAT,1); // D
LCD_put(DAT,2); // e.
LCD_put(DAT,'p');
LCD_put(DAT,' ');
LCD_put(DAT,'t');
LCD_put(DAT,'r');
LCD_put(DAT,'a');
LCD_put(DAT,'i');
LCD_put(DAT,' ');
LCD_put(DAT,3);  
LCD_put(DAT,3);  
LCD_put(DAT,3);  

  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
  }
  /* USER CODE END 3 */
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};

  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSI;
  RCC_OscInitStruct.HSIState = RCC_HSI_ON;
  RCC_OscInitStruct.HSICalibrationValue = RCC_HSICALIBRATION_DEFAULT;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_NONE;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }

  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_HSI;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV1;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV1;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_0) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief GPIO Initialization Function
  * @param None
  * @retval None
  */
static void MX_GPIO_Init(void)
{
  GPIO_InitTypeDef GPIO_InitStruct = {0};

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOC_CLK_ENABLE();
  __HAL_RCC_GPIOD_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOB_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOA, GPIO_PIN_1, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOB, RW_Pin|D2_Pin|D3_Pin|D4_Pin
                          |D5_Pin|D6_Pin|D7_Pin|RS_Pin
                          |EN_Pin|D0_Pin|D1_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pins : PC13 PC14 PC15 */
  GPIO_InitStruct.Pin = GPIO_PIN_13|GPIO_PIN_14|GPIO_PIN_15;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOC, &GPIO_InitStruct);

  /*Configure GPIO pins : PD0 PD1 */
  GPIO_InitStruct.Pin = GPIO_PIN_0|GPIO_PIN_1;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOD, &GPIO_InitStruct);

  /*Configure GPIO pins : PA0 PA2 PA4 PA5
                           PA6 PA7 PA8 PA9
                           PA10 PA11 PA12 PA15 */
  GPIO_InitStruct.Pin = GPIO_PIN_0|GPIO_PIN_2|GPIO_PIN_4|GPIO_PIN_5
                          |GPIO_PIN_6|GPIO_PIN_7|GPIO_PIN_8|GPIO_PIN_9
                          |GPIO_PIN_10|GPIO_PIN_11|GPIO_PIN_12|GPIO_PIN_15;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pin : PA1 */
  GPIO_InitStruct.Pin = GPIO_PIN_1;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pin : PA3 */
  GPIO_InitStruct.Pin = GPIO_PIN_3;
  GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
  GPIO_InitStruct.Pull = GPIO_PULLUP;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pin : PB0 */
  GPIO_InitStruct.Pin = GPIO_PIN_0;
  GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /*Configure GPIO pins : PB1 PB3 PB4 PB5 */
  GPIO_InitStruct.Pin = GPIO_PIN_1|GPIO_PIN_3|GPIO_PIN_4|GPIO_PIN_5;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /*Configure GPIO pins : RW_Pin D2_Pin D3_Pin D4_Pin
                           D5_Pin D6_Pin D7_Pin RS_Pin
                           EN_Pin D0_Pin D1_Pin */
  GPIO_InitStruct.Pin = RW_Pin|D2_Pin|D3_Pin|D4_Pin
                          |D5_Pin|D6_Pin|D7_Pin|RS_Pin
                          |EN_Pin|D0_Pin|D1_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /*Configure peripheral I/O remapping */
  __HAL_AFIO_REMAP_PD01_ENABLE();

}

/* USER CODE BEGIN 4 */

/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  __disable_irq();
  while (1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */
