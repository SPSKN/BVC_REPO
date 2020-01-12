
/*
        Title: A1 - Light Sensor
        Description: This program will read the data from the light sensor and display the result to the serial monitor.
        Revision Date: 2017/08/04
        Licence: http://321maker.mit-license.org/
        Requirements:  Arduino with 321Maker Shield
        Instructions: Click Tools, Serial Montior (Ctrl + Shift + M) to view the output.
*/
int lightPin = A1; //The light sensor is plugged into pin A1 of the Arduino.
int data = INPUT;      //This will store the data from the sensor.
int RedPin = 12;
int BluePin = 13;
int WaitTime = 500;
void setup() { //The Setup function runs once.
  Serial.begin(9600);
  pinMode(RedPin, OUTPUT);
  pinMode(BluePin,OUTPUT);
}
void loop() { //The loop function runs forever.
  data = analogRead(lightPin); 
  Serial.print("Light value =");
  Serial.println(data);  
  delay(WaitTime);   
}
  
  
if (data >=600){ 
  digitalWrite (BluePin,HIGH); //When the value is greater than 600 Blue LED goes on 
  delay(WaitTime);
  digitalWrite (BluePin,LOW);
  delay(WaitTime);
}
  else
  
if (data <100){ 
    digitalWrite (BluePin,HIGH); //When the value is greater than 600 Blue LED goes on 
    digitalWrite (RedPin,HIGH);
    delay(WaitTime);
    digitalWrite (RedPin,LOW);
    digitalWrite (BluePin,LOW);
    delay(WaitTime);
  }  