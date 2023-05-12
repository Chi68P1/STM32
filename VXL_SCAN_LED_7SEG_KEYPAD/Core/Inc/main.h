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
#define L11_Pin GPIO_PIN_0
#define L11_GPIO_Port GPIOA
#define L22_Pin GPIO_PIN_1
#define L22_GPIO_Port GPIOA
#define L33_Pin GPIO_PIN_2
#define L33_GPIO_Port GPIOA
#define L44_Pin GPIO_PIN_3
#define L44_GPIO_Port GPIOA
#define C1_Pin GPIO_PIN_4
#define C1_GPIO_Port GPIOA
#define C2_Pin GPIO_PIN_5
#define C2_GPIO_Port GPIOA
#define C3_Pin GPIO_PIN_6
#define C3_GPIO_Port GPIOA
#define A_Pin GPIO_PIN_7
#define A_GPIO_Port GPIOA
#define LEDA_Pin GPIO_PIN_0
#define LEDA_GPIO_Port GPIOB
#define LEDB_Pin GPIO_PIN_1
#define LEDB_GPIO_Port GPIOB
#define LEDC_Pin GPIO_PIN_2
#define LEDC_GPIO_Port GPIOB
#define L3_Pin GPIO_PIN_10
#define L3_GPIO_Port GPIOB
#define L4_Pin GPIO_PIN_11
#define L4_GPIO_Port GPIOB
#define B_Pin GPIO_PIN_8
#define B_GPIO_Port GPIOA
#define C_Pin GPIO_PIN_9
#define C_GPIO_Port GPIOA
#define D_Pin GPIO_PIN_10
#define D_GPIO_Port GPIOA
#define LEDD_Pin GPIO_PIN_3
#define LEDD_GPIO_Port GPIOB
#define LEDE_Pin GPIO_PIN_4
#define LEDE_GPIO_Port GPIOB
#define LEDF_Pin GPIO_PIN_5
#define LEDF_GPIO_Port GPIOB
#define LEDG_Pin GPIO_PIN_6
#define LEDG_GPIO_Port GPIOB
#define LEDH_Pin GPIO_PIN_7
#define LEDH_GPIO_Port GPIOB
#define L1_Pin GPIO_PIN_8
#define L1_GPIO_Port GPIOB
#define L2_Pin GPIO_PIN_9
#define L2_GPIO_Port GPIOB

/* USER CODE BEGIN Private defines */

/* USER CODE END Private defines */

#ifdef __cplusplus
}
#endif

#endif /* __MAIN_H */
