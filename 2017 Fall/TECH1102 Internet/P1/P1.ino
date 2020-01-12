/*
        Title: A1 - Light Sensor
        Description: This program will read the data from the light sensor and display the result to the serial monitor.
        Revision Date: 2017/08/04
        Licence: http://321maker.mit-license.org/
        Requirements:  Arduino with 321Maker Shield
        Instructions: Click Tools, Serial Montior (Ctrl + Shift + M) to view the output.
*/
int lightPin = A1; //The light sensor is plugged into pin A1 of the Arduino.
int data = 0;      //This will store the data from the sensor.
int RedPin = 12;
int BluePin = 13;



void setup() { //The Setup function runs once.
  Serial.begin(9600);
  pinMode(RedPin, OUTPUT);
  pinMode(BluePin,OUTPUT);
}

void loop() { //The loop function runs forever.
 
  
  
  (if data>=600,BluePin,HIGH);
  (if data<600,data>=300,RedPin,HIGH);
  (if data<300,BluePin,HIGH,RedPin,HIGH);
  
  
  data = analogRead(lightPin); //Read the value from the light sensor and store it in the lightData variable.
  Serial.print("Light value =");
  Serial.println(data);  //Print the data to the serial port.
  delay(1000);           //Wait 1 second (1000mS) before running again.


}

