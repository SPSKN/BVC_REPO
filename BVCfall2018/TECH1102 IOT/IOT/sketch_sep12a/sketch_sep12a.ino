void setup() {
  // put your setup code here, to run once:
  pinMode(11,OUTPUT);
  pinMode(10,OUTPUT);
  pinMode(9,OUTPUT);
  

}

void loop() {
  // put your main code here, to run repeatedly:
  
  digitalWrite(9,HIGH); //RED
  delay(1000);
  digitalWrite(9, LOW); 
  delay(1000);
  digitalWrite(10,HIGH);//GREEN
  delay(1000);
  digitalWrite(10, LOW);
  delay(1000);
  digitalWrite(11,HIGH);//BLUE
  delay(1000);
  digitalWrite(11,LOW);
  delay(1000);
  digitalWrite(9,HIGH);
  digitalWrite(10,HIGH);
  delay(1000);
  digitalWrite(9, LOW);
  digitalWrite(10,LOW);
  delay(1000);
  digitalWrite(9,HIGH);
  digitalWrite(11,HIGH);
  delay(1000);
  digitalWrite(9,LOW);
  digitalWrite(11,LOW);
  delay(1000);
  digitalWrite(10,HIGH);
  digitalWrite(11,HIGH);
  delay(1000);
  digitalWrite(10,LOW);
  digitalWrite(11,LOW);
  delay(1000);
  //WHITE 9,10,11
  digitalWrite(9,HIGH);
  digitalWrite(10,HIGH);
  digitalWrite(11,HIGH);
  delay(1000);
  digitalWrite(9,LOW);
  digitalWrite(10,LOW);
  digitalWrite(11,LOW);
  delay(1000);
  

}
