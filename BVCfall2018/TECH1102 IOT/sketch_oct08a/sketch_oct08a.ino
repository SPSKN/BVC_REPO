//Analog Pins
const int sensorPin =0; //TMP sensor
const int dialPin =5; //POT sensor

void setup() {
  // put your setup code here, to run once:
Serial.begin(9600); // For serial printing
  pinMode(13, OUTPUT);// Heater
  pinMode(12, OUTPUT);// AC
}

void loop() {
  // put your main code here, to run repeatedly:
//Variables for the analogRead
  float reading = analogRead(sensorPin); //Reading from TMP SENOR
  int dialRead = analogRead(dialPin); //READING from POT sensor
  int desiredTemp = (dialRead/34);// Setting the max value to 30 Degrees
  int aboveTemp = (desiredTemp+5);//+5 Degrees
  int belowTemp = (desiredTemp-5);//-5 Degrees
  
  //this is how to get the Degrees in Celsius from TMP sensor
  float degC = (5.0 * reading*100.0/1024)-49.7;
  //Prints the Temp. reading
  Serial.print("Temp is: ");
  Serial.println(degC);
  //Prints the Dial Reading
  Serial.print("Desired Room Temp is set at: ");
  Serial.println(desiredTemp);

  
  //dial can set temp from 0 to 30 Degrees Celsius
  if(degC >= aboveTemp){//Turn on AC
    digitalWrite(12,HIGH);
    //Serial.println("AC ON");
  }
  else {
    digitalWrite(12, LOW);//Turn off AC
  }
  
  if(degC <= belowTemp){//Turn on Heater
    digitalWrite(13,HIGH);
    //Serial.println("Heater ON");
  }
  else {
    digitalWrite(13,LOW);//Turn off Heater
  }
  //5 second delay
  delay(5000);
}
