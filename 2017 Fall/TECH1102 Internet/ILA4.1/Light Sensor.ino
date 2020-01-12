/*
    Title: ILA.1 - Light Sensor
*/
int redPin = 12;    
int bluePin = 13;
int lightPin = A1;
int data = 0;

void setup(){
    Serial.begin(9600);
    pinMode(redPin, OUTPUT);
    pinMode(bluePin, OUTPUT);

}
void loop(){
    analogRead(lightPin, LOW);
    digitalWrite(redPin, HIGH);
    digitalWrite(bluePin, HIGH);



    data = analogRead(lightPin);
    Serial.print("Light value =");
    Serial.println(data);
    delay(1000);



}