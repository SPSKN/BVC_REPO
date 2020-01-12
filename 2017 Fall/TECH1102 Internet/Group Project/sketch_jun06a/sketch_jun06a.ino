/*
#Course code : TECH1102
#Term/Year : fall2017
#Assignment code : GP_1
#Author : Scott Patterson
#BVC Username : s.patterson528@mybvc.ca
#Date created : 2017-11-22
#Description : IOT group project
*/

#include <Wire.h>
#include <LCD.h>
#include <LiquidCrystal_I2C.h>



//Declaring Variables
#define I2C_ADDR  0x3f  
#define BACKLIGHT_PIN  3
int tempSenor = A2;
float data = 0.0;
float tempRead = 0.0;
LiquidCrystal_I2C lcd(I2C_ADDR, 2,1,0,4,5,6,7); 
float tempC = 0.0;

void setup() { 
  Serial.begin(9600);
  lcd.begin (16,2);        // Initalize the LCD.
  lcd.setBacklightPin(3, POSITIVE); // Setup the backlight.
  lcd.setBacklight(HIGH);  //Switch on the backlight.
  lcd.clear();
  lcd.setCursor(0,0);      // Position cursor at first line (0,0)
  lcd.print("Temperature is:"); // Print at curren cursor location
  lcd.setCursor(0,1);      // Position cursor at first column and second line 
  lcd.print(data);    // Print at current cursor location 
  delay(500);


} 
void loop() { 
 //turn Data into Celsius
  lcd.clear();
  data = analogRead(tempSenor); 
  tempRead = 5.0 * data * 100 / 1024; //turning the data into Celsius
  tempC = tempRead;
  lcd.setCursor(0,0);      
  lcd.print("Temperature is:"); 
  lcd.setCursor(0,1);       
  lcd.print(tempRead);
  lcd.setCursor(5,1);
  lcd.print(" *C");     
  delay(3500);  
  //Celsius to Fahrenheit
  lcd.clear();
  data = analogRead(tempSenor);
  tempC = 5.0 * data * 100 / 1024; 
  tempRead = tempC * 9.0 / 5.0 + 32.0; //celsius to Fahrenheit
  lcd.setCursor(0,0);      
  lcd.print("Temperature is:"); 
  lcd.setCursor(0,1);       
  lcd.print(tempRead);
  lcd.setCursor(5,1);
  lcd.print(" *F");     
  delay(3500);  
  //Celsius to Kelvin tempC + 273.15
  lcd.clear();
  data = analogRead(tempSenor);
  tempC = 5.0 * data * 100 / 1024; 
  tempRead = tempC + 273.15; //celsius to Kelvin
  lcd.setCursor(0,0);      
  lcd.print("Temperature is:"); 
  lcd.setCursor(0,1);       
  lcd.print(tempRead);
  lcd.setCursor(5,1);
  lcd.print(" *K");     
  delay(3500);
  
}


