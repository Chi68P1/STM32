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
#include <math.h>
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
const uint8_t LED[] = {0x02,0x9E,0x24,0x0C,0x98,0x48,0x40,0x1E,0x00,0x08,0xFF};
//const uint8_t LED[] = {0B00000010,0B10011110,0B00100100,
												//0B00001100,0B10011000,0B01001000,
												//0B01000000,0B00011110,0B00000000,
												//0B00001000};
/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */

// xung clock
void LED_CLK(uint32_t n){
	while(n>0){
		HAL_GPIO_WritePin(CLK_GPIO_Port,CLK_Pin,1);
		HAL_GPIO_WritePin(CLK_GPIO_Port,CLK_Pin,0);
		n = n-1;
	}
}

// day tung so len led, day 8 lan
void LED_push(uint8_t n){
	for(uint8_t i = 0; i<8; i++){
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,LED[n]&(1<<i));
		LED_CLK(1);
	}
}

// truy cap gia tri tai tung vi trí cua so n, bat dau tu hang don vi. Sau do dung ham LED_push day so len led lan luot. Co kiem tra so 0 dung dau
void LED_print(uint32_t n){

int i = 0;
int divisor = 1;
while (i < 8) {
    int digit = (n / divisor);
    LED_push((digit == 0) ? 10 : digit%10); // dung thi = 10, sai thi = digit%10
    i++;
    divisor *= 10;
}
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

	//for (uint32_t i = 0; i <99999999; i++) {
		//LED_print(i);
		//HAL_GPIO_WritePin(LAT_GPIO_Port,LAT_Pin,1);
		//HAL_GPIO_WritePin(LAT_GPIO_Port,LAT_Pin,0);
		//HAL_Delay(100);
	//}
		
		LED_push(10);
		
		
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		
		LED_push(10);
		
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,0);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		HAL_GPIO_WritePin(DAT_GPIO_Port,DAT_Pin,1);
		LED_CLK(1);
		
		HAL_GPIO_WritePin(LAT_GPIO_Port,LAT_Pin,1);
		HAL_GPIO_WritePin(LAT_GPIO_Port,LAT_Pin,0);
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
  HAL_GPIO_WritePin(GPIOB, CLK_Pin|LAT_Pin|DAT_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pins : PC13 PC14 PC15 */
  GPIO_InitStruct.Pin = GPIO_PIN_13|GPIO_PIN_14|GPIO_PIN_15;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOC, &GPIO_InitStruct);

  /*Configure GPIO pins : PD0 PD1 */
  GPIO_InitStruct.Pin = GPIO_PIN_0|GPIO_PIN_1;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOD, &GPIO_InitStruct);

  /*Configure GPIO pins : PA0 PA1 PA2 PA3
                           PA4 PA5 PA6 PA7
                           PA8 PA9 PA10 PA11
                           PA12 PA15 */
  GPIO_InitStruct.Pin = GPIO_PIN_0|GPIO_PIN_1|GPIO_PIN_2|GPIO_PIN_3
                          |GPIO_PIN_4|GPIO_PIN_5|GPIO_PIN_6|GPIO_PIN_7
                          |GPIO_PIN_8|GPIO_PIN_9|GPIO_PIN_10|GPIO_PIN_11
                          |GPIO_PIN_12|GPIO_PIN_15;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pins : PB0 PB1 PB2 PB10
                           PB11 PB12 PB13 PB14
                           PB15 PB6 PB7 PB8
                           PB9 */
  GPIO_InitStruct.Pin = GPIO_PIN_0|GPIO_PIN_1|GPIO_PIN_2|GPIO_PIN_10
                          |GPIO_PIN_11|GPIO_PIN_12|GPIO_PIN_13|GPIO_PIN_14
                          |GPIO_PIN_15|GPIO_PIN_6|GPIO_PIN_7|GPIO_PIN_8
                          |GPIO_PIN_9;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /*Configure GPIO pins : CLK_Pin LAT_Pin DAT_Pin */
  GPIO_InitStruct.Pin = CLK_Pin|LAT_Pin|DAT_Pin;
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
