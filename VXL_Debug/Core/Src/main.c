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
#include <stdint.h>
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
UART_HandleTypeDef huart1;

/* USER CODE BEGIN PV */
char i8[100];
char i16[100];
char i32[100];
char i64[100];
char ui8[100];
char ui16[100];
char ui32[100];
char ui64[100];

int8_t valueInt8Min = INT8_MIN;
int16_t valueInt16Min = INT16_MIN;
int32_t valueInt32Min = INT32_MIN;
int64_t valueInt64Min = INT64_MIN;
uint8_t valueUint8Min = 0;
uint16_t valueUint16Min = 0;
uint32_t valueUint32Min = 0;
uint64_t valueUint64Min = 0;

int8_t valueInt8Max = INT8_MAX;
int16_t valueInt16Max = INT16_MAX;
int32_t valueInt32Max = INT32_MAX;
int64_t valueInt64Max = INT64_MAX;
uint8_t valueUint8Max = UINT8_MAX;
uint16_t valueUint16Max = UINT16_MAX;
uint32_t valueUint32Max = UINT32_MAX;
uint64_t valueUint64Max = UINT64_MAX;


/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_USART1_UART_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */

//  Retarget printf
FILE __stdout;
int fputc(int ch, FILE *f)
{
	char tempch = ch;
	
	HAL_UART_Transmit(&huart1, (uint8_t *)&	tempch,1,100);
	return ch;
}
int ferror(FILE *f){
  /* Your implementation of ferror(). */
  return 0;
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
  MX_USART1_UART_Init();
  /* USER CODE BEGIN 2 */
	
	long int a = snprintf(i8, sizeof(i8), "int8_t min, max value %d %d\n", valueInt8Min, valueInt8Max);
	long int b = snprintf(i16, sizeof(i16), "int16_t min, max value %d %d\n", valueInt16Min, valueInt16Max);
	long int c = snprintf(i32, sizeof(i32), "int32_t min, max value %d %d\n", valueInt32Min, valueInt32Max);
	long int d = snprintf(i64, sizeof(i64), "int64_t min, max value %lld %lld\n", valueInt64Min, valueInt64Max); 

	long int e = snprintf(ui8, sizeof(ui8), "uint8_t min, max value %d %d\n", valueUint8Min, valueUint8Max);
	long int f = snprintf(ui16, sizeof(ui16), "uint16_t min, max value %d %d\n", valueUint16Min, valueUint16Max);
	long int g = snprintf(ui32, sizeof(ui32), "uint32_t min, max value %u %u\n", valueUint32Min, valueUint32Max);
	long int h = snprintf(ui64, sizeof(ui64), "uint64_t min, max value %llu %llu\n\n", valueUint64Min, valueUint64Max); 
	
  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */

  while (1)
  {
    /* USER CODE END WHILE */
		printf ("Integers: %i %u \n", -3456, 3456);
		printf ("Characters: %c %c \n", 'z', 80);
		printf ("Decimals: %d %ld\n", 1997, 32000L);
		printf ("Some different radices: %d %x %o %#x %#o \n", 100, 100, 100, 100, 100);
		printf ("floats: %4.2f %+.0e %E \n", 3.14159, 3.14159, 3.14159);
		printf ("Preceding with empty spaces: %10d \n", 1997);
		printf ("Preceding with zeros: %010d \n", 1997);
		printf ("Width: %*d \n", 15, 140);
		printf ("%s \n", " A string ");
		HAL_Delay(1000);
		
		int ch;
		for( ch = 75 ; ch <= 100; ch++ ) {
			printf("ASCII value = %d, Character = %c\n", ch , ch );
		}
		HAL_Delay(100000);
		/*
		HAL_UART_Transmit_IT(&huart1, (uint8_t*) &i8, a);
		HAL_Delay(1000);
		HAL_UART_Transmit_IT(&huart1, (uint8_t*) &i16, b);
		HAL_Delay(1000);
		HAL_UART_Transmit_IT(&huart1, (uint8_t*) &i32, c);
		HAL_Delay(1000);
		HAL_UART_Transmit_IT(&huart1, (uint8_t*) &i64, d);
		HAL_Delay(1000);
		HAL_UART_Transmit_IT(&huart1, (uint8_t*) &ui8, e);
		HAL_Delay(1000);
		HAL_UART_Transmit_IT(&huart1, (uint8_t*) &ui16, f);
		HAL_Delay(1000);
		HAL_UART_Transmit_IT(&huart1, (uint8_t*) &ui32, g);
		HAL_Delay(1000);
		HAL_UART_Transmit_IT(&huart1, (uint8_t*) &ui64, h);
		HAL_Delay(1000);*/

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
  * @brief USART1 Initialization Function
  * @param None
  * @retval None
  */
static void MX_USART1_UART_Init(void)
{

  /* USER CODE BEGIN USART1_Init 0 */

  /* USER CODE END USART1_Init 0 */

  /* USER CODE BEGIN USART1_Init 1 */

  /* USER CODE END USART1_Init 1 */
  huart1.Instance = USART1;
  huart1.Init.BaudRate = 9600;
  huart1.Init.WordLength = UART_WORDLENGTH_8B;
  huart1.Init.StopBits = UART_STOPBITS_1;
  huart1.Init.Parity = UART_PARITY_NONE;
  huart1.Init.Mode = UART_MODE_TX_RX;
  huart1.Init.HwFlowCtl = UART_HWCONTROL_NONE;
  huart1.Init.OverSampling = UART_OVERSAMPLING_16;
  if (HAL_UART_Init(&huart1) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN USART1_Init 2 */

  /* USER CODE END USART1_Init 2 */

}

/**
  * @brief GPIO Initialization Function
  * @param None
  * @retval None
  */
static void MX_GPIO_Init(void)
{

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOA_CLK_ENABLE();

}

/* USER CODE BEGIN 4 */
void HAL_UART_TxCpltCallback(UART_HandleTypeDef *huart) {
    /* X? lý khi vi?c g?i d? li?u hoàn thành */
}
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
