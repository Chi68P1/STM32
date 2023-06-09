/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.h
  * @brief          : Header for main.c file.
  *                   This file contains the common defines of the application.
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

/* Define to prevent recursive inclusion -------------------------------------*/
#ifndef __MAIN_H
#define __MAIN_H

#ifdef __cplusplus
extern "C" {
#endif

/* Includes ------------------------------------------------------------------*/
#include "stm32f1xx_hal.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */

/* USER CODE END Includes */

/* Exported types ------------------------------------------------------------*/
/* USER CODE BEGIN ET */

/* USER CODE END ET */

/* Exported constants --------------------------------------------------------*/
/* USER CODE BEGIN EC */

/* USER CODE END EC */

/* Exported macro ------------------------------------------------------------*/
/* USER CODE BEGIN EM */

/* USER CODE END EM */

/* Exported functions prototypes ---------------------------------------------*/
void Error_Handler(void);

/* USER CODE BEGIN EFP */

/* USER CODE END EFP */

/* Private defines -----------------------------------------------------------*/
#define RE_Pin GPIO_PIN_0
#define RE_GPIO_Port GPIOA
#define C74_Pin GPIO_PIN_0
#define C74_GPIO_Port GPIOB
#define B74_Pin GPIO_PIN_1
#define B74_GPIO_Port GPIOB
#define A74_Pin GPIO_PIN_2
#define A74_GPIO_Port GPIOB
#define F_Pin GPIO_PIN_10
#define F_GPIO_Port GPIOB
#define E_Pin GPIO_PIN_11
#define E_GPIO_Port GPIOB
#define D_Pin GPIO_PIN_12
#define D_GPIO_Port GPIOB
#define C_Pin GPIO_PIN_13
#define C_GPIO_Port GPIOB
#define B_Pin GPIO_PIN_14
#define B_GPIO_Port GPIOB
#define A_Pin GPIO_PIN_15
#define A_GPIO_Port GPIOB
#define DP_Pin GPIO_PIN_8
#define DP_GPIO_Port GPIOB
#define G_Pin GPIO_PIN_9
#define G_GPIO_Port GPIOB

/* USER CODE BEGIN Private defines */

/* USER CODE END Private defines */

#ifdef __cplusplus
}
#endif

#endif /* __MAIN_H */
