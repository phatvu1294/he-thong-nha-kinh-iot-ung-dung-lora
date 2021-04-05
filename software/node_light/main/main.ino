/*******************************************************************************
  Bao gồm
*******************************************************************************/

// Thư viện LCD
#include <LiquidCrystal.h>

// Thư viện BH1750
#include <Wire.h>
#include <BH1750.h>

// Thư viện Lora
#include <RHDatagram.h>
#include <RH_RF95.h>
#include <SPI.h>

/*******************************************************************************
  Định nghĩa
*******************************************************************************/

// Địa chỉ Lora
#define GATEWAY_ADDRESS     0
#define NODELIGHT_ADDRESS   3

// Ký tự tự tạo
byte sendChar[] = {0x01, 0x03, 0x05, 0x01, 0x01, 0x01, 0x01, 0x00};
byte receiveChar[] = {0x10, 0x10, 0x10, 0x10, 0x14, 0x18, 0x10, 0x00};

/*******************************************************************************
  Biến
*******************************************************************************/

// LCD
LiquidCrystal lcd(9, 8, 7, 6, 5, 4);

// BH1750
BH1750 lightMeter1(0x23);
BH1750 lightMeter2(0x5c);

// Lora
RH_RF95 driver;
RHDatagram manager(driver, NODELIGHT_ADDRESS);
bool loraSendOK = false, loraReceiveOK = false;
unsigned long loraSendMillis = 0, loraReceiveMillis = 0, loraInterval = 2000;

// Mảng cường độ sáng
char lightArr[13];

// Định thời
unsigned long previousMillis = 0;
unsigned long interval = 1000;

/*******************************************************************************
  Hàm khởi tạo
*******************************************************************************/

void setup() {
  // Khởi tạo LCD
  lcd.begin(16, 2);
  lcd.createChar(0, sendChar);
  lcd.createChar(1, receiveChar);

  // Hiển thị bản quyền và tác giả
  lcd.setCursor(0, 0);
  lcd.print("NODE LIGHT  v1.0");
  lcd.setCursor(0, 1);
  lcd.print("(c) 2018 PHAT VU");

  // Khởi tạo BH1750
  Wire.begin();
  lightMeter1.begin();
  lightMeter2.begin();

  // Khởi tạo Lora
  manager.init();

  // Lora chế độ PA Boost 20dBm (Chậm + Khoảng cách xa)
  //driver.setModemConfig(RH_RF95::Bw31_25Cr48Sf512);
  //driver.setTxPower(20);

  delay(3000);

  // Xoá màn hình
  lcd.clear();
}

/*******************************************************************************
  Hàm lặp vô hạn
*******************************************************************************/

void loop() {
  // Nếu Lora gửi thành công thì hiện biểu tượng gửi thành công và ngược lại
  if (loraSendOK) {
    lcd.setCursor(14, 0);
    lcd.write((uint8_t)0);
  } else {
    lcd.setCursor(14, 0);
    lcd.print(" ");
  }

  // Nếu Lora nhận thành công thì hiện biểu tượng nhận thành công và ngược lại
  if (loraReceiveOK) {
    lcd.setCursor(15, 0);
    lcd.write((uint8_t)1);
  } else {
    lcd.setCursor(15, 0);
    lcd.print(" ");
  }

  // Biến thời điểm hiện tại
  unsigned long currentMillis1 = millis();

  // Chạy định thời với thời gian đặt trước
  if (currentMillis1 - previousMillis >= interval || previousMillis == 0) {
    previousMillis = currentMillis1;

    // Biến hiển thị dữ liệu
    char data[17];

    // Đọc cường độ sáng từ các cảm biến
    uint8_t lux1 = lightMeter1.readLightLevel();
    uint8_t lux2 = lightMeter2.readLightLevel();

    // Hiển thị cường độ sáng trước và sau khi qua lưới
    sprintf(data, "TR: %d lx     ", lux1);
    lcd.setCursor(0, 0);
    lcd.print(data);
    sprintf(data, "SA: %d lx     ", lux2);
    lcd.setCursor(0, 1);
    lcd.print(data);

    // Tính độ xuyên sáng
    int level = 0;
    if (lux1 != 0) level = round(lux2 * 100.0 / lux1);

    // Hiển thị độ xuyên sáng
    sprintf(data, "%4d%%   ", level);
    lcd.setCursor(11, 1);
    lcd.print(data);

    // In ra mảng cường độ sáng có định dạng trước
    sprintf(lightArr, "%d,%d", lux1, lux2);
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
        if (manager.sendto((uint8_t *)lightArr, (uint8_t)sizeof(lightArr), GATEWAY_ADDRESS)) {
          // Lora gửi thành công
          loraSendOK = true;
          loraSendMillis = millis();
        }
      }
    }
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
