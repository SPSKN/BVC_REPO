/*
        Title: Temperature Sensor
        Description: This program will read the data from the temperature sensor. 
                     Convert the data to a temperature and display the temperature 
                     to the serial monitor in both Celsius and Fahrenheit.
        Revision Date: March 15, 2016
        Licence: http://321maker.mit-license.org/
        Requirements: Arduino with 321Maker Shield
        Instructions: Use Serial Monitor to see output.
*/

int tempPin = A2;     // The temperature sensor is plugged into pin A2 of the Arduino.
int data;             // This will store the data from the sensor.
int waitTime = 5000;  // Wait
float TemperatureC = data -27.00;
float TempBoil = 100.00 - temperatureC;


// The Setup function runs once.
void setup(void) {    
  Serial.begin(9600); // This will enable the Arduino to send data to the Serial monitor.
}

//The loop function runs forever.
void loop(void) { 
  
  
  data = analogRead(tempPin);        // Read from the temperature sensor
  Serial.print("Sensor reading = "); // Serial.print displays to the Serial Monitor.
  Serial.println(TemperatureC);
  Serial.println("You are..");
  Serial.print(TempBoil);
  Serial.print("away from boiliing");


  delay(waitTime); // Wait waitTime before running again.
}

