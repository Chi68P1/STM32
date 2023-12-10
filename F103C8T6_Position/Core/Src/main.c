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
#include "string.h"
#include "stdio.h" 
#include "stdlib.h"
#include "stdbool.h"
/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
#define UPDATE_PERIOD			0.005		/* Chu ki cap nhat: 5ms = ngat timer 4 */
#define PULSES_IN_ROUND		11			/* So xung tren 1 vong cua dong co */
/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/
TIM_HandleTypeDef htim2;
TIM_HandleTypeDef htim3;
TIM_HandleTypeDef htim4;

UART_HandleTypeDef huart1;

/* USER CODE BEGIN PV */
/* Thong so ham PIController : tuy vao loai dong co ma tinh lai cac thong so Kp, Ki, Kb */
//float 		Kp 							= 0.087039474;			/* Ti le */
//float 		Ki 							= 2.192982456;			/* Tich phan */
//float 		Kd 							= 0.0;							/* Vi phan */
//float			Kb 							= 25.19526329;			/* Dung cho Anti-windup */

//int32_t 	UHiLim 					= 100;								/* Gioi han tren pwm */
//int32_t 	ULoLim 					= 0;									/* Gioi han duoi pwm */

/* Thong so dieu khien vi tri 3 cap do : tuy vao loai dong co ma tinh lai cac thong so Kp1 Kp2 Kv2 Kp4 Kvg */
	// For Low Speed
float Kp1 = 28.95;		// Kp2 = wn * cp2 = 120.637 * 0.24
	// For Middle Speed
float Kp2 = 28.95;		// Kp2 = wn * cp2 = 120.637 * 0.24
float Kv2 = 115.81;		// Kv2 = wn * cv2 = 120.637 * 0.96
	// For High Speed
float Kp4 = 28.95;		// Kp4 = wn * cp = 120.637 * 0.24
float Kvg = 0.76;		// Kvg = cv * wn * Jt

///* Thong so ham PDController : tuy vao loai dong co ma tinh lai cac thong so Kp, Kd, alpha */
float 		Kp 							= 0.317763158;			/* Ti le */
float 		Ki 							= 0.0;						/* Tich phan */
float 		Kd 							= 0.009208776;							/* Vi phan */
float			alpha 					= 0.8;			/* Dung cho Low pass filter */
uint8_t 	dir							= 0;				/* Chieu quay */

int32_t 	UHiLim 					= 100;								/* Gioi han tren pwm */
int32_t 	ULoLim 					= 60;									/* Gioi han duoi pwm */


/* Thong so ham HAL_UART_RxCpltCallback */
bool 			run             = false;				/* Dong co stop */
uint16_t	DesiredSpeed  	= 0;						/* Van toc mong muon (RPM) */
float			DesiredVel  		= 0;						/* Van toc mong muon (rad/s) */
int16_t		DesiredRound  	= 0;							/* Vi tri mong muon (Round) */
float 		DesiredPos 			= 0;	 					/* Vi tri mong muon (rad) */
uint8_t 	Rx_indx;	
char 			Rx_Buffer[20];
char 			Rx_data[2];

/* Thong so ham HAL_GPIO_EXTI_Callback */
uint8_t 	PreviousState 	= 0;			/* Trang thai encoder chu ki truoc */					
int16_t 	CountValue  		= 0;			/* Bien dem encoder => tinh vi tri */
int32_t 	PosCnt  				= 0;			/* Bien dem so vong quay => tinh vi tri */
uint16_t 	VelCnt      		= 0;			/* Bien dem encoder => tinh van toc */
uint16_t 	VelTemp      		= 0;			/* Bien dem encoder => tinh van toc */

/* Thong so ham HAL_TIM_PeriodElapsedCallback */
float 		CurrPos 	 			= 0;	 		/* Vi tri hien tai (rad) */
float 		CurrRound 	 		= 0;	 		/* Vi tri hien tai (round) */
float 		CurrVel 				= 0;	 		/* Van toc hien tai (rad/s) */
float 		CurrSpeed 			= 0;	 		/* Van toc hien tai (RPM) */
uint8_t 	tick						= 0;			/* Dung de dem cho timer 5 */
uint8_t 	PWMSet 					= 0;	 		/* PWM dieu khien dong co */
/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_TIM2_Init(void);
static void MX_TIM3_Init(void);
static void MX_TIM4_Init(void);
static void MX_USART1_UART_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */


struct __FILE
{
  int handle;
  /* Whatever you require here. If the only file you are using is */
  /* standard output using printf() for debugging, no file handling */
  /* is required. */
};

FILE __stdout;
int fputc(int ch, FILE *f)
{
	char tempch = ch;
	
	HAL_UART_Transmit(&huart1, (uint8_t *)&	tempch,1,100);
	return ch;
}

/* ================================================= Ket thuc ham printf  =================================================== */
	
/* ====================================== Dieu khien vi tri 3 cap van toc ====================================== */
int32_t SetVelLow(float CurrentPos, float Pos)
{
	/* Set boundary */
	UHiLim = 10, ULoLim=0;
	float posErr = 0;
	float uout;
	/* Calculate error */
	posErr = Pos - CurrentPos;
	if(posErr < 0)
	{
		posErr = -posErr;
		dir = 2;
	}
	else if(posErr > 0)
	{
		dir = 1;
	}
	else
	{
		dir = 0;
	}
	uout = posErr * Kp1;
	/* Rectify output */
	if (uout>UHiLim) uout=UHiLim;
	else if(uout<ULoLim) uout=ULoLim;
	return uout;
}
	/*==== Set Middle Velocity ====*/
int32_t SetVelMid(float CurrentPos, float Pos, float CurrentVel)
{
	/* Set boundary */
	UHiLim = 20, ULoLim=0;
	float posErr = 0;
	float uout;
	/* Calculate error */
	posErr = Pos - CurrentPos;
	if(posErr < 0)
	{
		posErr = -posErr;
		dir = 2;
	}
	else if(posErr > 0)
	{
		dir = 1;
	}
	else
	{
		dir = 0;
	}
	uout = (posErr * Kp2 - CurrentVel) * Kv2;
	/* Rectify output */
	if (uout>UHiLim) uout=UHiLim;
	else if(uout<ULoLim) uout=ULoLim;
	return uout;
}
	/*==== Set High Velocity ====*/
int32_t SetVelHigh(float CurrentPos, float Pos, float CurrentVel)
{
	/* Set boundary */
	UHiLim = 99, ULoLim=0;
	float posErr = 0;
	float uout;
	/* Calculate error */
	posErr = Pos - CurrentPos;
	if(posErr < 0)
	{
		posErr = -posErr;
		dir = 2;
	}
	else if(posErr > 0)
	{
		dir = 1;
	}
	else
	{
		dir = 0;
	}
	uout = (posErr * Kp4 - CurrentVel) * Kvg;
	/* Rectify output */
	if (uout>UHiLim) uout=UHiLim;
	else if(uout<ULoLim) uout=ULoLim;
	return uout;
}
/* ====================================== Ket thuc ham dieu khien vi tri 3 cap van toc ====================================== */

/* ================================================= Ham dieu khien van toc su dung bo PI +(Anti-windup)  =================================================== */
int32_t PIController(float desired_val, float real_val, float gain, float Ki, float Kb, int uHiLim, int uLoLim)
{
		/* Controller values */
		static float err_reset;
		static float uI_p;
		float err, uP, uI;
		int uOut;

		/* Algorithm */
		err = (desired_val - real_val);
			/* Proportional */
		uP = gain * err;
			/* Integral (with Anti-windup) */
		uI = uI_p + (Ki * UPDATE_PERIOD *err) + Kb * UPDATE_PERIOD * err_reset;
			/* Integral part */
		uI_p = uI;
			/* Output control */
		uOut = (int)(uP + uI);
			/* Output saturation */
		if(uOut > uHiLim)
		{
			err_reset = uHiLim - uOut;
			uOut = uHiLim;
		}
		else if(uOut < uLoLim)
		{
			err_reset = uLoLim - uOut;
			uOut = uLoLim;
		}
		return uOut;
}
/* ================================================= Ket thuc ham dieu khien van toc su dung bo PI +(Anti-windup)  =================================================== */

/* ================================================= Ham dieu khien vi tri su dung bo PD + (Low pas filter) =================================================== */
int32_t  PDController(float desired_val, float real_val, float gain, float Kd, float alpha, int uHiLim, int uLoLim) {
	static float err_p = 0;
	static float uD_f_p = 0;
	float err;
	float uP, uD, uD_f;
	int uOut;
	
	err = desired_val - real_val;
	
	if(err < 0)
	{
		err = -err;
		dir = 2;
	}
	else if(err > 0)
	{
		dir = 1;
	}
	else
	{
		dir = 0;
	}
	
 	uP = gain*err; // khau P
	
	uD  = Kd*(err-err_p)/UPDATE_PERIOD; // khau D
	
	uD_f = alpha*uD + (1-alpha)*uD_f_p; // low pass filter cho khau D
	
	err_p = err;
	uD_f_p = uD_f;

	uOut = (int) uP + uD_f; // PWM out

	if (uOut>UHiLim) {
		uOut=UHiLim;
	}
	else if(uOut<ULoLim) { 
		uOut=ULoLim;
	}
	
  return uOut;
}
/* ================================================= Ket thuc ham dieu khien vi tri su dung bo PD +(Low pas filter) =================================================== */

/* ====================================== Ham dieu khien dong co => xet chieu quay va pwm ====================================== */
void motorRot(uint8_t runMode, int32_t pwmSet)
{
	if(runMode == 1)			/* quay chieu CW */
	{	
		HAL_GPIO_WritePin(GPIOA, GPIO_PIN_2, GPIO_PIN_RESET);
		HAL_GPIO_WritePin(GPIOA, GPIO_PIN_3, GPIO_PIN_SET);
		__HAL_TIM_SetCompare(&htim2, TIM_CHANNEL_2, pwmSet);
	}
	else if(runMode == 2)	/* quay chieu CCW */
	{	
		HAL_GPIO_WritePin(GPIOA, GPIO_PIN_2, GPIO_PIN_SET);
		HAL_GPIO_WritePin(GPIOA, GPIO_PIN_3, GPIO_PIN_RESET);
		__HAL_TIM_SetCompare(&htim2, TIM_CHANNEL_2, pwmSet);
	}
	else									/* stop */
	{
		HAL_GPIO_WritePin(GPIOA, GPIO_PIN_2, GPIO_PIN_SET);
		HAL_GPIO_WritePin(GPIOA, GPIO_PIN_3, GPIO_PIN_RESET);
		__HAL_TIM_SetCompare(&htim2, TIM_CHANNEL_2, 0);
	}
}
/* =============================================== Ket thuc ham dieu khien dong co ============================================= */
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
  MX_TIM2_Init();
  MX_TIM3_Init();
  MX_TIM4_Init();
  MX_USART1_UART_Init();
  /* USER CODE BEGIN 2 */
	HAL_TIM_PWM_Start(&htim2, TIM_CHANNEL_2);						/* Enable PWM */
	HAL_TIM_Base_Start_IT(&htim3);											/* Enable interrupt Timer 4 */
	HAL_TIM_Base_Start_IT(&htim4);											/* Enable interrupt Timer 5 */
	HAL_UART_Receive_IT(&huart1,(uint8_t*) Rx_data, 1);	/* Enable receive interrupt UART */
	HAL_GPIO_WritePin(GPIOC,GPIO_PIN_13,GPIO_PIN_RESET);  
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
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSI_DIV2;
  RCC_OscInitStruct.PLL.PLLMUL = RCC_PLL_MUL12;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }

  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV4;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV4;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_1) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief TIM2 Initialization Function
  * @param None
  * @retval None
  */
static void MX_TIM2_Init(void)
{

  /* USER CODE BEGIN TIM2_Init 0 */

  /* USER CODE END TIM2_Init 0 */

  TIM_MasterConfigTypeDef sMasterConfig = {0};
  TIM_OC_InitTypeDef sConfigOC = {0};

  /* USER CODE BEGIN TIM2_Init 1 */

  /* USER CODE END TIM2_Init 1 */
  htim2.Instance = TIM2;
  htim2.Init.Prescaler = 11;
  htim2.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim2.Init.Period = 100;
  htim2.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
  htim2.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_DISABLE;
  if (HAL_TIM_PWM_Init(&htim2) != HAL_OK)
  {
    Error_Handler();
  }
  sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim2, &sMasterConfig) != HAL_OK)
  {
    Error_Handler();
  }
  sConfigOC.OCMode = TIM_OCMODE_PWM1;
  sConfigOC.Pulse = 0;
  sConfigOC.OCPolarity = TIM_OCPOLARITY_HIGH;
  sConfigOC.OCFastMode = TIM_OCFAST_DISABLE;
  if (HAL_TIM_PWM_ConfigChannel(&htim2, &sConfigOC, TIM_CHANNEL_2) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN TIM2_Init 2 */

  /* USER CODE END TIM2_Init 2 */
  HAL_TIM_MspPostInit(&htim2);

}

/**
  * @brief TIM3 Initialization Function
  * @param None
  * @retval None
  */
static void MX_TIM3_Init(void)
{

  /* USER CODE BEGIN TIM3_Init 0 */

  /* USER CODE END TIM3_Init 0 */

  TIM_ClockConfigTypeDef sClockSourceConfig = {0};
  TIM_MasterConfigTypeDef sMasterConfig = {0};

  /* USER CODE BEGIN TIM3_Init 1 */

  /* USER CODE END TIM3_Init 1 */
  htim3.Instance = TIM3;
  htim3.Init.Prescaler = 23999;
  htim3.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim3.Init.Period = 4;
  htim3.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
  htim3.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_DISABLE;
  if (HAL_TIM_Base_Init(&htim3) != HAL_OK)
  {
    Error_Handler();
  }
  sClockSourceConfig.ClockSource = TIM_CLOCKSOURCE_INTERNAL;
  if (HAL_TIM_ConfigClockSource(&htim3, &sClockSourceConfig) != HAL_OK)
  {
    Error_Handler();
  }
  sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim3, &sMasterConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN TIM3_Init 2 */

  /* USER CODE END TIM3_Init 2 */

}

/**
  * @brief TIM4 Initialization Function
  * @param None
  * @retval None
  */
static void MX_TIM4_Init(void)
{

  /* USER CODE BEGIN TIM4_Init 0 */

  /* USER CODE END TIM4_Init 0 */

  TIM_ClockConfigTypeDef sClockSourceConfig = {0};
  TIM_MasterConfigTypeDef sMasterConfig = {0};

  /* USER CODE BEGIN TIM4_Init 1 */

  /* USER CODE END TIM4_Init 1 */
  htim4.Instance = TIM4;
  htim4.Init.Prescaler = 23999;
  htim4.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim4.Init.Period = 9;
  htim4.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
  htim4.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_DISABLE;
  if (HAL_TIM_Base_Init(&htim4) != HAL_OK)
  {
    Error_Handler();
  }
  sClockSourceConfig.ClockSource = TIM_CLOCKSOURCE_INTERNAL;
  if (HAL_TIM_ConfigClockSource(&htim4, &sClockSourceConfig) != HAL_OK)
  {
    Error_Handler();
  }
  sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim4, &sMasterConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN TIM4_Init 2 */

  /* USER CODE END TIM4_Init 2 */

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
  huart1.Init.BaudRate = 115200;
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
  GPIO_InitTypeDef GPIO_InitStruct = {0};
/* USER CODE BEGIN MX_GPIO_Init_1 */
/* USER CODE END MX_GPIO_Init_1 */

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOC_CLK_ENABLE();
  __HAL_RCC_GPIOD_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOB_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOC, GPIO_PIN_13, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOA, GPIO_PIN_2|GPIO_PIN_3, GPIO_PIN_RESET);

  /*Configure GPIO pin : PC13 */
  GPIO_InitStruct.Pin = GPIO_PIN_13;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOC, &GPIO_InitStruct);

  /*Configure GPIO pins : PC14 PC15 */
  GPIO_InitStruct.Pin = GPIO_PIN_14|GPIO_PIN_15;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOC, &GPIO_InitStruct);

  /*Configure GPIO pins : PD0 PD1 */
  GPIO_InitStruct.Pin = GPIO_PIN_0|GPIO_PIN_1;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOD, &GPIO_InitStruct);

  /*Configure GPIO pins : PA0 PA4 PA5 PA6
                           PA7 PA8 PA11 PA12
                           PA15 */
  GPIO_InitStruct.Pin = GPIO_PIN_0|GPIO_PIN_4|GPIO_PIN_5|GPIO_PIN_6
                          |GPIO_PIN_7|GPIO_PIN_8|GPIO_PIN_11|GPIO_PIN_12
                          |GPIO_PIN_15;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pins : PA2 PA3 */
  GPIO_InitStruct.Pin = GPIO_PIN_2|GPIO_PIN_3;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pins : PB0 PB1 PB2 PB10
                           PB11 PB12 PB13 PB14
                           PB15 PB3 PB5 PB7
                           PB8 PB9 */
  GPIO_InitStruct.Pin = GPIO_PIN_0|GPIO_PIN_1|GPIO_PIN_2|GPIO_PIN_10
                          |GPIO_PIN_11|GPIO_PIN_12|GPIO_PIN_13|GPIO_PIN_14
                          |GPIO_PIN_15|GPIO_PIN_3|GPIO_PIN_5|GPIO_PIN_7
                          |GPIO_PIN_8|GPIO_PIN_9;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /*Configure GPIO pins : ENC_CHA_Pin ENC_CHB_Pin */
  GPIO_InitStruct.Pin = ENC_CHA_Pin|ENC_CHB_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_IT_RISING_FALLING;
  GPIO_InitStruct.Pull = GPIO_PULLUP;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /*Configure peripheral I/O remapping */
  __HAL_AFIO_REMAP_PD01_ENABLE();

  /* EXTI interrupt init*/
  HAL_NVIC_SetPriority(EXTI4_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(EXTI4_IRQn);

  HAL_NVIC_SetPriority(EXTI9_5_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(EXTI9_5_IRQn);

/* USER CODE BEGIN MX_GPIO_Init_2 */
/* USER CODE END MX_GPIO_Init_2 */
}

/* USER CODE BEGIN 4 */
/* ================================================= Ham ngat UART => nhan du lieu qua serial =================================================== */
void HAL_UART_RxCpltCallback(UART_HandleTypeDef *huart)
{
	uint8_t i;
	if(huart->Instance == USART1) //uart1
	{
			if(Rx_indx==0) {for (i=0;i<20;i++) Rx_Buffer[i] = 0;}
		
			switch(Rx_data[0]) {
					/* dung dong co */
					case 'e':
							run = false;
							break;
					/* dong co chay */
					case 'r':
							run = true;
							break;
					case 's':		
							DesiredRound = atoi(Rx_Buffer);								/* Vi tri mong muon (round) */
							DesiredPos = DesiredRound*2*3.1415;						/* Vi tri mong muon (rad) */
							memset(Rx_Buffer, 0, sizeof(Rx_Buffer));
							Rx_indx = 0;
							break;    
					case 'v':
							DesiredSpeed = atoi(Rx_Buffer);								/* Van toc mong muon (RPM) */
							DesiredVel = DesiredSpeed*2*3.1415/60;				/* Van toc mong muon (rad/s) */
							memset(Rx_Buffer, 0, sizeof(Rx_Buffer));
							Rx_indx = 0;
							break;    
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
					case '.':
					case '-':																				/* So am */
							Rx_Buffer[Rx_indx++] |= Rx_data[0];
							break; 
					default:
							break;
			}
			HAL_UART_Receive_IT(&huart1,(uint8_t*)Rx_data,1);
	}
}
/* ================================================= Ket thuc ham ngat UART =================================================== */

/* ================================================= Ham ngat external => tinh encoder =================================================== */
void HAL_GPIO_EXTI_Callback(uint16_t GPIO_Pin)
{		
	// Encoder Channel A
	if(GPIO_Pin == ENC_CHA_Pin) /* ENC_CHA label trong CubeMX */
	{
		unsigned char StateA;
		StateA = (StateA<<1) | HAL_GPIO_ReadPin(GPIOB, GPIO_PIN_4);
		StateA = (StateA<<1) | HAL_GPIO_ReadPin(GPIOB, GPIO_PIN_6);
		StateA = StateA&0x03;
		switch (StateA) {
			case 0:
				if(PreviousState==1) CountValue++;
				else CountValue--;
			break;
			case 1:
				if(PreviousState==3) CountValue++;
				else CountValue--;
			break;
			case 2:
				if(PreviousState==0) CountValue++;
				else CountValue--;
			break;
			case 3:
				if(PreviousState==2) CountValue++;
				else CountValue--;
			break;
			}
		PreviousState = StateA;
		VelCnt++;
		if (CountValue>=4*PULSES_IN_ROUND) {
			CountValue = 0;
			PosCnt++;
		}
		else if	(CountValue<=-4*PULSES_IN_ROUND) {
			CountValue = 0;
			PosCnt--;
		}
	}
	// Encoder Channel B
	if(GPIO_Pin == ENC_CHB_Pin) /* ENC_CHB label trong CubeMX */
	{
		unsigned char StateB;
		StateB = (StateB<<1) | HAL_GPIO_ReadPin(GPIOB, GPIO_PIN_4);
		StateB = (StateB<<1) | HAL_GPIO_ReadPin(GPIOB, GPIO_PIN_6);
		StateB = StateB&0x03;
		switch (StateB) {
			case 0:
				if(PreviousState==1) CountValue++;
				else CountValue--;
			break;
			case 1:
				if(PreviousState==3) CountValue++;
				else CountValue--;
			break;
			case 2:
				if(PreviousState==0) CountValue++;
				else CountValue--;
			break;
			case 3:
				if(PreviousState==2) CountValue++;
				else CountValue--;
			break;
			}
		PreviousState = StateB;
		VelCnt++;
		if (CountValue>=4*PULSES_IN_ROUND) {
			CountValue = 0;
			PosCnt++;
		}
		else if	(CountValue<=-4*PULSES_IN_ROUND) {
			CountValue = 0;
			PosCnt--;
		}
	}
}
/* ================================================= Ket thuc ham ngat external =================================================== */

/* ================================================= Ham ngat timer =================================================== */
void HAL_TIM_PeriodElapsedCallback(TIM_HandleTypeDef *htim) {	

	if(htim->Instance==TIM3)																											/* Ngat timer 3: 5ms => tinh PID */
	{
		CurrPos 	= PosCnt*2*3.1415 + CountValue*2*3.1415/(4*PULSES_IN_ROUND);										/* rad */	
		CurrRound = PosCnt + CountValue/(4*PULSES_IN_ROUND);																			/* round */	
		
		VelTemp		 	= VelCnt;																												/* Gan bien dem van toc vao bien tam */		
		VelCnt 			= 0;																														/* Reset bien dem van toc */	
		CurrSpeed 	= 60*VelTemp/(4*PULSES_IN_ROUND*0.005);																			/* RPM */				
		CurrVel 		= 2*3.1415*VelTemp/(4*PULSES_IN_ROUND*0.005);																/* rad/s */	

		//PWMSet = PIController(DesiredSpeed, CurrSpeed, Kp, Ki, Kb, UHiLim, ULoLim);	/* Tinh pwm bang bo dieu khien PI de dieu khien van toc */
		//motorRot(1,PWMSet);																															/* Xet chieu va pwm cho dong co */
		
		PWMSet = PDController(DesiredPos, CurrPos, Kp, Kd, alpha, UHiLim, ULoLim);	/* Tinh pwm bang bo dieu khien PD de dieu khien vi tri */
		motorRot(dir,PWMSet);																															/* Xet chieu va pwm cho dong co */
				
		return;
	}
	
	if (htim->Instance==TIM4)																											/* Ngat timer 4: 10x5ms => gui gia tri bang ham printf */
	{
		tick++;
		if ((run==true)&&(tick==5)){
			tick = 0;

			printf("V%d\r \n",(int) CurrSpeed);
			
			printf("P%f\r \n", CurrRound);
		}
	}
}
/* ================================================= Ket thuc ham ngat timer =================================================== */
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
