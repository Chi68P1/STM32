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
#define SI_Pin GPIO_PIN_0
#define SI_GPIO_Port GPIOA
#define LOAD_Pin GPIO_PIN_1
#define LOAD_GPIO_Port GPIOA
#define CLK_Pin GPIO_PIN_2
#define CLK_GPIO_Port GPIOA
#define D3_Pin GPIO_PIN_10
#define D3_GPIO_Port GPIOB
#define D4_Pin GPIO_PIN_11
#define D4_GPIO_Port GPIOB
#define D5_Pin GPIO_PIN_12
#define D5_GPIO_Port GPIOB
#define D6_Pin GPIO_PIN_13
#define D6_GPIO_Port GPIOB
#define D7_Pin GPIO_PIN_14
#define D7_GPIO_Port GPIOB
#define D8_Pin GPIO_PIN_15
#define D8_GPIO_Port GPIOB
#define D1_Pin GPIO_PIN_8
#define D1_GPIO_Port GPIOB
#define D2_Pin GPIO_PIN_9
#define D2_GPIO_Port GPIOB

/* USER CODE BEGIN Private defines */

/* USER CODE END Private defines */

#ifdef __cplusplus
}
#endif

#endif /* __MAIN_H */