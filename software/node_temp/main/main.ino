/*******************************************************************************
  Bao gồm
*******************************************************************************/

// Thư viện LCD
#include <LiquidCrystal.h>

// Thư viện DS18B20
#include <OneWire.h>
#include <DallasTemperature.h>

// Thư viện Lora
#include <RHDatagram.h>
#include <RH_RF95.h>
#include <SPI.h>

/*******************************************************************************
  Định nghĩa
*******************************************************************************/

// Địa chỉ Lora
#define GATEWAY_ADDRESS     0
#define NODETEMP_ADDRESS    2
#define SENSOR_COUNT        3

// Ký tự tự tạo
byte sendChar[] = {0x01, 0x03, 0x05, 0x01, 0x01, 0x01, 0x01, 0x00};
byte receiveChar[] = {0x10, 0x10, 0x10, 0x10, 0x14, 0x18, 0x10, 0x00};

/*******************************************************************************
  Biến
*******************************************************************************/

// LCD
LiquidCrystal lcd(9, 8, 7, 6, 5, 4);

// DS18B20
OneWire oneWire(3);
DallasTemperature sensors(&oneWire);
DeviceAddress temp1Addr, temp2Addr, temp3Addr;

// Lora
RH_RF95 driver;
RHDatagram manager(driver, NODETEMP_ADDRESS);
bool loraSendOK = false, loraReceiveOK = false;
unsigned long loraSendMillis = 0, loraReceiveMillis = 0, loraInterval = 2000;

// Mảng giá trị nhiệt độ
char tempArr[12];

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
  lcd.print("NODE TEMP   v1.0");
  lcd.setCursor(0, 1);
  lcd.print("(c) 2018 PHAT VU");

  // Khởi tạo DS18B20
  sensors.begin();
  oneWire.reset_search();
  oneWire.search(temp1Addr);
  oneWire.search(temp2Addr);
  oneWire.search(temp3Addr);
  sensors.setResolution(temp1Addr, 9);
  sensors.setResolution(temp2Addr, 9);
  sensors.setResolution(temp3Addr, 9);

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

  // Chạy định thời với sau khoảng thời gian đặt trước
  if (currentMillis1 - previousMillis >= interval || previousMillis == 0) {
    previousMillis = currentMillis1;

    // Yêu cầu đọc nhiệt độ
    sensors.requestTemperatures();

    // Đọc nhiệt độ từ các cảm biến DS18B20
    int temp1 = round(sensors.getTempC(temp1Addr));
    int temp2 = round(sensors.getTempC(temp2Addr));
    int temp3 = round(sensors.getTempC(temp3Addr));

    // Biến hiển thị dữ liệu
    char data[17];

    // Hiển thị tiêu đề và nhiệt độ
    sprintf(data, "CB1 CB2 CB3");
    lcd.setCursor(0, 0);
    lcd.print(data);
    sprintf(data, "%-3d %-3d %-3d", temp1, temp2, temp3);
    lcd.setCursor(0, 1);
    lcd.print(data);
    lcd.setCursor(14, 1);
    lcd.write(0xDF);
    lcd.print("C");

    // In ra mảng nhiệt độ có định dạng trước
    sprintf(tempArr, "%d,%d,%d", temp1, temp2, temp3);
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
        if (manager.sendto((uint8_t *)tempArr, (uint8_t)sizeof(tempArr), GATEWAY_ADDRESS)) {
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
