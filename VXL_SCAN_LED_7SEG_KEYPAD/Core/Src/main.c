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
const uint8_t LED[] = {0x3F,0x06,0x5B,0x4F,0x66,0x6D,0x7D,0x07,0x7F,0x6F,0x00};
GPIO_TypeDef* GPIO_PORTS[] = {LEDA_GPIO_Port, LEDB_GPIO_Port, LEDC_GPIO_Port, LEDD_GPIO_Port, LEDE_GPIO_Port, LEDF_GPIO_Port, LEDG_GPIO_Port,LEDH_GPIO_Port};
uint16_t GPIO_PINS[] = {LEDA_Pin, LEDB_Pin, LEDC_Pin, LEDD_Pin, LEDE_Pin, LEDF_Pin, LEDG_Pin, LEDH_Pin};
uint32_t num = 0; 
/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */
uint32_t read_Keypad(void) { // tra ve so 32 bit
	HAL_GPIO_WritePin(C1_GPIO_Port,C1_Pin,0);
	HAL_GPIO_WritePin(C2_GPIO_Port,C2_Pin,1);
	HAL_GPIO_WritePin(C3_GPIO_Port,C3_Pin,1);
	
	if (!HAL_GPIO_ReadPin(A_GPIO_Port,A_Pin))
	{
		while (!HAL_GPIO_ReadPin(A_GPIO_Port,A_Pin)); //while(1) = dung tai day
		num = num*10+1;
	}
	if (!HAL_GPIO_ReadPin(B_GPIO_Port,B_Pin))
	{
		while (!HAL_GPIO_ReadPin(B_GPIO_Port,B_Pin));
		num = num*10+4;
	}
	if (!HAL_GPIO_ReadPin(C_GPIO_Port,C_Pin))
	{
		while (!HAL_GPIO_ReadPin(C_GPIO_Port,C_Pin));
		num = num*10+7;
	}
	if (!HAL_GPIO_ReadPin(D_GPIO_Port,D_Pin))
	{
		while (!HAL_GPIO_ReadPin(D_GPIO_Port,D_Pin));
		num = 0;
	}
	
	HAL_GPIO_WritePin(C1_GPIO_Port,C1_Pin,1);
	HAL_GPIO_WritePin(C2_GPIO_Port,C2_Pin,0);
	HAL_GPIO_WritePin(C3_GPIO_Port,C3_Pin,1);
	
	if (!HAL_GPIO_ReadPin(A_GPIO_Port,A_Pin))
	{
		while (!HAL_GPIO_ReadPin(A_GPIO_Port,A_Pin));
		num = num*10+2;
	}
	if (!HAL_GPIO_ReadPin(B_GPIO_Port,B_Pin))
	{
		while (!HAL_GPIO_ReadPin(B_GPIO_Port,B_Pin));
		num = num*10+5;
	}
	if (!HAL_GPIO_ReadPin(C_GPIO_Port,C_Pin))
	{
		while (!HAL_GPIO_ReadPin(C_GPIO_Port,C_Pin));
		num = num*10+8;
	}
	if (!HAL_GPIO_ReadPin(D_GPIO_Port,D_Pin))
	{
		while (!HAL_GPIO_ReadPin(D_GPIO_Port,D_Pin));
		num = num*10+0;
	}
	
	HAL_GPIO_WritePin(C1_GPIO_Port,C1_Pin,1);
	HAL_GPIO_WritePin(C2_GPIO_Port,C2_Pin,1);
	HAL_GPIO_WritePin(C3_GPIO_Port,C3_Pin,0);
	
	if (!HAL_GPIO_ReadPin(A_GPIO_Port,A_Pin))
	{
		while (!HAL_GPIO_ReadPin(A_GPIO_Port,A_Pin));
		num = num*10+3;
	}
	if (!HAL_GPIO_ReadPin(B_GPIO_Port,B_Pin))
	{
		while (!HAL_GPIO_ReadPin(B_GPIO_Port,B_Pin));
		num = num*10+6;
	}
	if (!HAL_GPIO_ReadPin(C_GPIO_Port,C_Pin))
	{
		while (!HAL_GPIO_ReadPin(C_GPIO_Port,C_Pin));
		num = num*10+9;
	}
	if (!HAL_GPIO_ReadPin(D_GPIO_Port,D_Pin))
	{
		while (!HAL_GPIO_ReadPin(D_GPIO_Port,D_Pin));
		num = num/10;
	}
	
	if (num >9999) return num = num/10;
	else return num;
}
/* uint8_t pos_NUM() // neu void th? khong the return
{
	
	HAL_GPIO_WritePin(C1_GPIO_Port,C1_Pin,0);
	NUM_IN[1] = HAL_GPIO_ReadPin(A_GPIO_Port,A_Pin);
	NUM_IN[4] = HAL_GPIO_ReadPin(B_GPIO_Port,B_Pin);
	NUM_IN[7] = HAL_GPIO_ReadPin(C_GPIO_Port,C_Pin);
	HAL_GPIO_WritePin(C1_GPIO_Port,C1_Pin,1);
	
	HAL_GPIO_WritePin(C2_GPIO_Port,C2_Pin,0);
	NUM_IN[0] = HAL_GPIO_ReadPin(D_GPIO_Port,D_Pin);
	NUM_IN[2] = HAL_GPIO_ReadPin(A_GPIO_Port,A_Pin);
	NUM_IN[5] = HAL_GPIO_ReadPin(B_GPIO_Port,B_Pin);
	NUM_IN[8] = HAL_GPIO_ReadPin(C_GPIO_Port,C_Pin);
	HAL_GPIO_WritePin(C2_GPIO_Port,C2_Pin,1);
		
	HAL_GPIO_WritePin(C3_GPIO_Port,C3_Pin,0);
	NUM_IN[3] = HAL_GPIO_ReadPin(A_GPIO_Port,A_Pin);
	NUM_IN[6] = HAL_GPIO_ReadPin(B_GPIO_Port,B_Pin);
	NUM_IN[9] = HAL_GPIO_ReadPin(C_GPIO_Port,C_Pin);
	HAL_GPIO_WritePin(C3_GPIO_Port,C3_Pin,1);
	
	
	for(uint8_t i = 0 ;i<10 ; i++)
		{
			if (NUM_IN[i] == 0) num = i; 
		}	
	//HAL_Delay(100);
return num;
}
*/
void LED_display(uint8_t n,uint8_t pos){

	for(uint8_t i = 0; i<8; i++){
		HAL_GPIO_WritePin(GPIO_PORTS[i],GPIO_PINS[i],LED[n]>>i&1u);
	}
	HAL_GPIO_WritePin(L1_GPIO_Port,L1_Pin,pos%2);
	HAL_GPIO_WritePin(L2_GPIO_Port,L2_Pin,pos%3);
	HAL_GPIO_WritePin(L3_GPIO_Port,L3_Pin,pos%5);
	HAL_GPIO_WritePin(L4_GPIO_Port,L4_Pin,pos%7);
	
	HAL_Delay(1);
	
	GPIOB->ODR=0xffff;// khong kich 4 led // (giua 2 lan hien thi se co trang thai tat: khong kich all led hoac kich 1 led nhung cho hien thi blank

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
	HAL_GPIO_WritePin(L1_GPIO_Port,L1_Pin,1);
	HAL_GPIO_WritePin(L2_GPIO_Port,L2_Pin,1);
	HAL_GPIO_WritePin(L3_GPIO_Port,L3_Pin,1);
	HAL_GPIO_WritePin(L4_GPIO_Port,L4_Pin,1);
	
	HAL_GPIO_WritePin(C3_GPIO_Port,C3_Pin,1);
	HAL_GPIO_WritePin(C1_GPIO_Port,C1_Pin,1);
	HAL_GPIO_WritePin(C2_GPIO_Port,C2_Pin,1);
	// Input pull up
	
  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */
		//LED_display(5,2);
		//LED_display(2,3);
		//LED_display(3,5);
		//LED_display(5,7);


		if (read_Keypad() ==0) LED_display(10 ,7); // tat
		else LED_display(read_Keypad()%10 ,7);
		
		if (read_Keypad()/10 ==0) LED_display(10 ,5);
		else LED_display((read_Keypad()/10)%10 ,5);
		
		if (read_Keypad()/100 ==0) LED_display(10 ,3);
		else LED_display((read_Keypad()/100)%10,3);
		
		if (read_Keypad()/1000 ==0) LED_display(10 ,2);
		else LED_display((read_Keypad()/1000)%10,2);

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
/* USER CODE BEGIN MX_GPIO_Init_1 */
/* USER CODE END MX_GPIO_Init_1 */

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOC_CLK_ENABLE();
  __HAL_RCC_GPIOD_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOB_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOA, L11_Pin|L22_Pin|L33_Pin|L44_Pin
                          |C1_Pin|C2_Pin|C3_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOB, LEDA_Pin|LEDB_Pin|LEDC_Pin|L3_Pin
                          |L4_Pin|LEDD_Pin|LEDE_Pin|LEDF_Pin
                          |LEDG_Pin|LEDH_Pin|L1_Pin|L2_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pins : PC13 PC14 PC15 */
  GPIO_InitStruct.Pin = GPIO_PIN_13|GPIO_PIN_14|GPIO_PIN_15;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOC, &GPIO_InitStruct);

  /*Configure GPIO pins : PD0 PD1 */
  GPIO_InitStruct.Pin = GPIO_PIN_0|GPIO_PIN_1;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOD, &GPIO_InitStruct);

  /*Configure GPIO pins : L11_Pin L22_Pin L33_Pin L44_Pin
                           C1_Pin C2_Pin C3_Pin */
  GPIO_InitStruct.Pin = L11_Pin|L22_Pin|L33_Pin|L44_Pin
                          |C1_Pin|C2_Pin|C3_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pins : A_Pin B_Pin C_Pin D_Pin */
  GPIO_InitStruct.Pin = A_Pin|B_Pin|C_Pin|D_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
  GPIO_InitStruct.Pull = GPIO_PULLUP;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pins : LEDA_Pin LEDB_Pin LEDC_Pin L3_Pin
                           L4_Pin LEDD_Pin LEDE_Pin LEDF_Pin
                           LEDG_Pin LEDH_Pin L1_Pin L2_Pin */
  GPIO_InitStruct.Pin = LEDA_Pin|LEDB_Pin|LEDC_Pin|L3_Pin
                          |L4_Pin|LEDD_Pin|LEDE_Pin|LEDF_Pin
                          |LEDG_Pin|LEDH_Pin|L1_Pin|L2_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /*Configure GPIO pins : PB12 PB13 PB14 PB15 */
  GPIO_InitStruct.Pin = GPIO_PIN_12|GPIO_PIN_13|GPIO_PIN_14|GPIO_PIN_15;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /*Configure GPIO pins : PA11 PA12 PA15 */
  GPIO_InitStruct.Pin = GPIO_PIN_11|GPIO_PIN_12|GPIO_PIN_15;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure peripheral I/O remapping */
  __HAL_AFIO_REMAP_PD01_ENABLE();

/* USER CODE BEGIN MX_GPIO_Init_2 */
/* USER CODE END MX_GPIO_Init_2 */
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
