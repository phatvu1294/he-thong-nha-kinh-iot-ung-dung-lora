/*******************************************************************************
  Bao gồm
*******************************************************************************/

// Thư viện OLED
#include "ssd1306.h"
#include "images.h"

// Thư viện COZIR
#include <SoftwareSerial.h>
#include "cozir.h"

// Thư viện Lora
#include <SPI.h>
#include <RHDatagram.h>
#include <RH_RF95.h>

/*******************************************************************************
  Định nghĩa
*******************************************************************************/

// Địa chỉ Lora
#define GATEWAY_ADDRESS     0
#define NODECO2_ADDRESS     1

/*******************************************************************************
  Biến
*******************************************************************************/

// Lora
RH_RF95 driver;
RHDatagram manager(driver, NODECO2_ADDRESS);
bool loraSendOK = false, loraReceiveOK = false;
unsigned long loraSendMillis = 0, loraReceiveMillis = 0, loraInterval = 2000;

// COZIR
SoftwareSerial nss(5, 6);
COZIR czr(nss);

// Mảng giá trị CO2
char co2Arr[6];

// Định thời
unsigned long previousMillis = 0;
unsigned long interval = 1000;

/*******************************************************************************
  Hàm khởi tạo
*******************************************************************************/

void setup() {
  // Khỏi tạo OLED
  ssd1306_128x64_i2c_init();

  // Đầy màn hình
  ssd1306_fillScreen(0x00);

  // Đặt phông chữ
  ssd1306_setFixedFont(ssd1306xled_font6x8);

  // Hiển thị bản quyền tác giả và hình sản phẩm
  ssd1306_printFixed(14,  0, "(c) 2018 PHAT VU", STYLE_NORMAL);
  ssd1306_drawBitmap(0, 18, Product_bg_width, Product_bg_height, Product_bg_bits);

  // COZIR chế độ 2
  czr.SetOperatingMode(CZR_POLLING);

  // COZIR hiệu chỉnh không khí
  czr.CalibrateFreshAir();

  delay(3000);

  // Xóa màn hình
  ssd1306_clearScreen();

  // Hiển thị tên sản phẩm
  ssd1306_printFixed(66, 0, "NODE", STYLE_NORMAL);
  ssd1306_printFixed(66, 8, "v1.0", STYLE_NORMAL);
  ssd1306_printFixedN(92, 0, "CO2", STYLE_NORMAL, FONT_SIZE_2X);

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
  // Hiển thị biểu tượng lora
  ssd1306_drawBitmap(0, 0, Lora_icon_width, Lora_icon_height, Lora_icon_bits);

  // Nếu Lora gửi thành công thì hiện biểu tượng gửi thành công và ngược lại
  if (loraSendOK) {
    ssd1306_drawBitmap(16, 0, Send_icon_width, Send_icon_height, Send_icon_bits);
  } else {
    ssd1306_drawBitmap(16, 0, Default_icon_width, Default_icon_height, Default_icon_bits);
  }

  // Nếu Lora nhận thành công thì hiện biểu tượng nhận thành công và ngược lại
  if (loraReceiveOK) {
    ssd1306_drawBitmap(16, 9, Receive_icon_width, Receive_icon_height, Receive_icon_bits);
  } else {
    ssd1306_drawBitmap(16, 9, Default_icon_width, Default_icon_height, Default_icon_bits);
  }

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
        // Lora nhận thành công
        loraReceiveOK = true;
        loraReceiveMillis = millis();

        delay(500);

        // Nếu gửi giá trị CO2 đến Gateway thành công
        if (manager.sendto((uint8_t *)co2Arr, (uint8_t)sizeof(co2Arr), GATEWAY_ADDRESS)) {
          // Lora gửi thành công
          loraSendOK = true;
          loraSendMillis = millis();
        }
      }
    }
  }

  // Biến thời điểm hiện tại
  unsigned long currentMillis1 = millis();

  // Chạy định thời với sau khoảng thời gian đặt trước
  if (currentMillis1 - previousMillis >= interval || previousMillis == 0) {
    previousMillis = currentMillis1;

    // Biến giá trị CO2
    int co2 = (int)czr.CO2();

    // Chuỗi giá trị CO2
    String co2Str = String(co2);

    // Chuyển chuỗi giá trị CO2 sang mảng giá trị CO2
    co2Str.toCharArray(co2Arr, sizeof(co2Arr));

    // Hiển thị hình CO2
    ssd1306_drawBitmap(0, 18, CO2_bg_width, CO2_bg_height, CO2_bg_bits);

    // Hiển thị tiêu đề CO2
    ssd1306_printFixed(50, 27, "Nong do (ppm)", STYLE_NORMAL);

    // Xóa giá trị CO2 hiện hành
    ssd1306_clearBlock(50, 45, 78, 16);

    // Hiển thị giá trị CO2
    ssd1306_printFixedN(64, 45, co2Str.c_str(), STYLE_NORMAL, FONT_SIZE_2X);
  }

  // Biến thời điểm hiện tại
  unsigned long currentMillis2 = millis();

  // Ẩn biểu tượng Lora gửi thành công sau thời gian định trước
  if ((currentMillis2 - loraSendMillis >= loraInterval) && loraSendOK) {
    loraSendOK = false;
  }

  // Ẩn biểu tượng Lora nhận thành công sau thời gian định trước
  if ((currentMillis2 - loraReceiveMillis >= loraInterval) && loraReceiveOK) {
    loraReceiveOK = false;
  }
}
