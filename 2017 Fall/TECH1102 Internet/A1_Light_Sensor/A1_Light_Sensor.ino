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
 
  
  
  (data)>=600,digitalWrite(BluePin,HIGH); //When the value is greater than 600 Blue LED goes on 
  (data)<600,data>=300,digitalWrite(RedPin,HIGH); //When the value is less than 600 but greater than 300 Red LED goes on
  (data)<300,digitalWrite(BluePin,HIGH,RedPin,HIGH); //When the value is less than 300 Red and Blue LED goes on
  
  
  data = analogRead(lightPin); //Read the value from the light sensor and store it in the lightData variable.
  Serial.print("Light value =");
  Serial.println(data);  //Print the data to the serial port.
  delay(1000);           //Wait 1 second (1000mS) before running again.


}

