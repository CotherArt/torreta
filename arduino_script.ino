#include <Servo.h> 

Servo servoX;
Servo servoY;

String laserX;
String laserY;

String serialData;

void setup() {
  servoX.attach(9);
  servoY.attach(8);
  Serial.begin(9600); // opens serial port, sets data rate to 9600 bps
  Serial.setTimeout(10);
}

void loop() {
  if (Serial.available() >0){
    serialData = Serial.readString();  

//    servoX.write(map(parseDataX(serialData),0,180,45,135));
//    servoY.write(map(parseDataY(serialData),1,180,45,135));
    servoX.write(parseDataX(serialData));
    servoY.write(parseDataY(serialData));
  }
}

void serialEvent(){
  
}


int parseDataX(String data){
  data.remove(data.indexOf("Y"));
  data.remove(data.indexOf("X"), 1);
  return data.toInt();
}

int parseDataY(String data){
  data.remove(0,data.indexOf("Y") + 1);
  return data.toInt();
}
