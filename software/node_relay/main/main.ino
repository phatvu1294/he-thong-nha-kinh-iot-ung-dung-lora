/*******************************************************************************
  Bao gồm
*******************************************************************************/

// Thư viện Lora
#include <RHDatagram.h>
#include <RH_RF95.h>
#include <SPI.h>

// Thư viện tự tạo
extern "C" {
#include "lib.h"
}

/*******************************************************************************
  Định nghĩa
*******************************************************************************/

// Địa chỉ Lora
#define GATEWAY_ADDRESS     0
#define NODERELAY_ADDRESS   4

// Trạng thái bật tắt
#define OFF_STATE           "0"
#define ON_STATE            "1"

// Lệnh bật tắt
#define ONOFF1_NAME         "onoff1"
#define ONOFF2_NAME         "onoff2"
#define ONOFF3_NAME         "onoff3"
#define ONOFF4_NAME         "onoff4"
#define ONOFF5_NAME         "onoff5"

/*******************************************************************************
  Biến
*******************************************************************************/

// Lora
RH_RF95 driver;
RHDatagram manager(driver, NODERELAY_ADDRESS);

/*******************************************************************************
  Hàm khởi tạo
*******************************************************************************/

void setup() {
  // Điều hướng
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(7, OUTPUT);
  pinMode(8, OUTPUT);
  pinMode(9, OUTPUT);

  // Khởi tạo Lora
  manager.init();

  // Lora chế độ PA Boost 20dBm (Chậm + Khoảng cách xa)
  //driver.setModemConfig(RH_RF95::Bw31_25Cr48Sf512);
  //driver.setTxPower(20);
}

/*******************************************************************************
  Hàm lặp vô hạn
*******************************************************************************/

void loop() {
  // Nếu Lora sẵn sàng
  if (manager.available()) {
    // Biến bộ đệm
    uint8_t buf[RH_RF95_MAX_MESSAGE_LEN];

    // Biến độ rộng bộ đệm
    uint8_t len = sizeof(buf);

    // Biến địa chỉ Lora
    uint8_t from;

    // Nếu nhận được dữ liệu Lora
    if (manager.recvfrom(buf, &len, &from)) {

      // Nếu từ Gateway
      if (from == GATEWAY_ADDRESS) {

        // Khởi tạo lệnh
        String commandStr = "";

        // Đọc toàn bộ byte của dữ liệu nhận về
        for (unsigned int i = 0; i < len; i++) commandStr += (char)buf[i];

        // Khởi tạo tên và giá trị điều khiển
        String controlName = "", controlValue = "", value = "";

        // Nếu lệnh khác rỗng
        if (commandStr != "") {
          // Mảng lệnh
          char commandArr[128];

          // Chuyển lệnh sang mảng lệnh
          commandStr.toCharArray(commandArr, sizeof(commandArr));

          // Tách chuỗi bỏ vào con trỏ mảng lệnh
          char ** ptrCommandArr = splitStr(commandArr, ',');

          // Nếu con trỏ lệnh khác rỗng
          if (ptrCommandArr) {
            // Đọc tên và giá trị điều khiển
            if (* (ptrCommandArr + 0)) {
              controlName = String(* (ptrCommandArr + 0));
              free(* (ptrCommandArr + 0));
            }

            if (* (ptrCommandArr + 1)) {
              controlValue = String(* (ptrCommandArr + 1));
              free(* (ptrCommandArr + 1));
            }

            if (* (ptrCommandArr + 2)) {
              value = String(* (ptrCommandArr + 2));
              free(* (ptrCommandArr + 2));
            }

            free(ptrCommandArr);
          }

          // Nếu tên điều khiển là onoff1
          if (controlName == ONOFF1_NAME) {
            // Nếu giá trị điều khiển là trạng thái bật
            if (controlValue == ON_STATE)
              // Bật 1
              digitalWrite(5, HIGH);

            // Nếu giá trị điều khiển là trạng thái tắt
            else if (controlValue == OFF_STATE)
              // Tắt 1
              digitalWrite(5, LOW);

            // Nếu tên điều khiển là onoff2
          } else if (controlName == ONOFF2_NAME) {
            // Nếu giá trị điều khiển là trạng thái bật
            if (controlValue == ON_STATE)
              // Bật 2
              digitalWrite(6, HIGH);

            // Nếu giá trị điều khiển là trạng thái tắt
            else if (controlValue == OFF_STATE)
              // Tắt 2
              digitalWrite(6, LOW);

            // Nếu tên điều khiển là onoff3
          } else if (controlName == ONOFF3_NAME) {
            // Nếu giá trị điều khiển là trạng thái bật
            if (controlValue == ON_STATE)
              // Bật 3
              digitalWrite(7, HIGH);

            // Nếu giá trị điều khiển là trạng thái tắt
            else if (controlValue == OFF_STATE)
              // Tắt 3
              digitalWrite(7, LOW);

            // Nếu tên điều khiển là onoff4
          } else if (controlName == ONOFF4_NAME) {
            // Nếu giá trị điều khiển là trạng thái bật
            if (controlValue == ON_STATE)
              // Bật 4
              digitalWrite(8, HIGH);

            // Nếu giá trị điều khiển là trạng thái tắt
            else if (controlValue == OFF_STATE)
              // Tắt 4
              digitalWrite(8, LOW);

            // Nếu tên điều khiển là onoff5
          } else if (controlName == ONOFF5_NAME) {
            // Nếu giá trị điều khiển là trạng thái bật
            if (controlValue == ON_STATE)
              // Bật 4
              digitalWrite(9, HIGH);

            // Nếu giá trị điều khiển là trạng thái tắt
            else if (controlValue == OFF_STATE)
              // Tắt 4
              digitalWrite(9, LOW);
          }
        }
      }
    }
  }
}
