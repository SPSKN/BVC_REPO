//Analog Pins
 int sensorPin =0; //TMP sensor
 int dialPin =5; //POT sensor

void setup(){
  
  Serial.begin(9600); // for serial printing
  pinMode(13, OUTPUT); //Heater
  pinMode(12, OUTPUT); //AC
  
}

void loop(){
  
  //Variables for the analogRead
  float reading = analogRead(sensorPin);
  int dialRead = analogRead(dialPin);
  int desiredTemp = (dialRead/34);// Setting the max value to 30 Degrees
  int aboveTemp = (desiredTemp +5);
  int belowTemp = (desiredTemp-5);
  
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
    Serial.println("AC ON");
  }
  else {
    digitalWrite(12, LOW);
  }
  
  if(degC <= belowTemp){//Turn on Heater
    digitalWrite(13,HIGH);
    Serial.println("Heater ON");
  }
  else {
    digitalWrite(13,LOW);
  }
  //5 second delay
  delay(5000);
}
