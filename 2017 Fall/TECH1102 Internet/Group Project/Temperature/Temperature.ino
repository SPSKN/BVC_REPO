/*
 Title: Group Project - Temperature
        Description: THis program takes ambient Temperature Reading and saves it in a .txt file
        Revision Date: 07-Oct-2017
        Licence: http://321maker.mit-license.org/
        Requirements:  Arduino Leonardo with 321Maker Shield
        Instructions: 

*/
//Declaring Variables
int TempRead = A2;
int data = 0;
//Setup
void setup() { 
  Serial.begin(9600);

}
   //The loop 
void loop() { 
  
  data = analogRead(TempRead); 
  Serial.print("The Temperature is ");
  Serial.println(data);  //Print the data to the serial port.
  Serial.println(" C"); //Prints a C for Celsius
  
  delay(1000);           //Wait 1 second (1000mS) before running again.
}
/*
Not reading in Celsius, 
No LCD display
Not saveing a .txt file


*/