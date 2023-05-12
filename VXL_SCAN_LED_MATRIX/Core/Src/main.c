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
const uint8_t NUMDATA[10][5] = {0x41,0x3a,0x36,0x2e,0x41,  //0      const nam trong ROM
																0x7f,0x5e,0x00,0x7e,0x7f,	 //1
																0x5e,0x3c,0x3a,0x36,0x4e,  //2
																0x3d,0x3e,0x2e,0x16,0x39,  //3
																0x73,0x6b,0x5b,0x00,0x7b,  //4
																0x0d,0x2e,0x2e,0x2e,0x31,  //5
																0x61,0x56,0x36,0x36,0x79,  //6
																0x3f,0x38,0x37,0x2f,0x1f,  //7
																0x49,0x36,0x36,0x36,0x49,  //8
																0x4f,0x36,0x36,0x35,0x43}; //9
/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */
void delay(unsigned int t)
{
	unsigned int x, y;
	for (x=0;x<t;x++)
	{
		for (y=0;y<123; y++);
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

  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */
		for (uint8_t m = 0;m<10;m++)
		{
			for (uint8_t k = 0;k<20;k++) // tao do tre = delay
			{
				for (uint8_t n = 0;n<5;n++)
				{
					HAL_GPIO_WritePin(C1_GPIO_Port,C1_Pin,GPIO_PIN_RESET);
					HAL_GPIO_WritePin(C2_GPIO_Port,C2_Pin,GPIO_PIN_RESET);
					HAL_GPIO_WritePin(C3_GPIO_Port,C3_Pin,GPIO_PIN_RESET);
					HAL_GPIO_WritePin(C4_GPIO_Port,C4_Pin,GPIO_PIN_RESET);
					HAL_GPIO_WritePin(C5_GPIO_Port,C5_Pin,GPIO_PIN_RESET);
				
					// Chuan bi du lieu
					HAL_GPIO_WritePin(LED1_GPIO_Port,LED1_Pin,NUMDATA[m][n]&1);
					HAL_GPIO_WritePin(LED2_GPIO_Port,LED2_Pin,NUMDATA[m][n]&1<<1);
					HAL_GPIO_WritePin(LED3_GPIO_Port,LED3_Pin,NUMDATA[m][n]&1<<2);
					HAL_GPIO_WritePin(LED4_GPIO_Port,LED4_Pin,NUMDATA[m][n]&1<<3);
					HAL_GPIO_WritePin(LED5_GPIO_Port,LED5_Pin,NUMDATA[m][n]&1<<4);
					HAL_GPIO_WritePin(LED6_GPIO_Port,LED6_Pin,NUMDATA[m][n]&1<<5);
					HAL_GPIO_WritePin(LED7_GPIO_Port,LED7_Pin,NUMDATA[m][n]&1<<6);
				
					uint8_t col = 1<<n;
					HAL_GPIO_WritePin(C1_GPIO_Port,C1_Pin,col&1); // sang cot 1 khi n = 0 
					HAL_GPIO_WritePin(C2_GPIO_Port,C2_Pin,col&1<<1); // sang cot 2 khi n = 1 
					HAL_GPIO_WritePin(C3_GPIO_Port,C3_Pin,col&1<<2);
					HAL_GPIO_WritePin(C4_GPIO_Port,C4_Pin,col&1<<3);
					HAL_GPIO_WritePin(C5_GPIO_Port,C5_Pin,col&1<<4);
					HAL_Delay(1); // < 8.4ms
				}
			}
		}
		HAL_Delay(1);
		
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
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOB_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOA, C1_Pin|C2_Pin|C3_Pin|C4_Pin
                          |C5_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOB, LED1_Pin|LED2_Pin|LED3_Pin|LED4_Pin
                          |LED5_Pin|LED6_Pin|LED7_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pins : C1_Pin C2_Pin C3_Pin C4_Pin
                           C5_Pin */
  GPIO_InitStruct.Pin = C1_Pin|C2_Pin|C3_Pin|C4_Pin
                          |C5_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pins : LED1_Pin LED2_Pin LED3_Pin LED4_Pin
                           LED5_Pin LED6_Pin LED7_Pin */
  GPIO_InitStruct.Pin = LED1_Pin|LED2_Pin|LED3_Pin|LED4_Pin
                          |LED5_Pin|LED6_Pin|LED7_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

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
