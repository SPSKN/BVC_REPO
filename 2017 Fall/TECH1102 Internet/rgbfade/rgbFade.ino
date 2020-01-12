/*
        Title: RGB fade
        Description: This program will fade the Red, Green, Blue (RGB) LED on 
                     the 321Maker shield.
        Revision Date: January 15, 2016
        Licence: http://321maker.mit-license.org/
        Requirements: Arduino with 321Maker Shield
*/

// Global constants
int RGBRedPin = 9;    
int RGBGreenPin = 10; 
int RGBBluePin = 11;  
int SW1Pin = 2;
int SW2Pin = 3;
int POTPin = A0;
int DEFAULTRGBPin = 0;

// Variables
int currentRGBPin = 0;
int previousSW1State = 0;
int previousSW2State = 0;

// The Setup function runs once.
void setup() { 
  // Initialize output
  pinMode(RGBRedPin, OUTPUT);    
  pinMode(RGBGreenPin, OUTPUT);  
  pinMode(RGBBluePin, OUTPUT);   
  
  // Initialize input
  pinMode(SW1Pin, INPUT);
  pinMode(SW2Pin, INPUT);
  pinMode(POTPin, INPUT);

  // Initialize defaults
  DEFAULTRGBPin = RGBRedPin;

  // Initialize variables
  currentRGBPin = RGBRedPin;
  previousSW1State = HIGH;
  previousSW2State = HIGH;
}

// The loop function runs forever.
void loop() { 
   if (resetPressed()) {
      changeBrightness(currentRGBPin, 0);
      resetChannel();
   } else if (changePressed()) {
      changeBrightness(currentRGBPin, 0);
      changeChannel(); 
   } else {
      int brightness = getBrightness();
      changeBrightness(currentRGBPin, brightness);
   }
}

bool resetPressed()
{
  int currentState = digitalRead(SW2Pin);
  if (currentState == LOW && previousSW2State == HIGH) {
    previousSW2State = LOW;
    return true;
  } else if (currentState == HIGH) {
    previousSW2State = HIGH;
  }
  return false;
}

void resetChannel() {
  currentRGBPin = DEFAULTRGBPin;
}

bool changePressed()
{
  int currentState = digitalRead(SW1Pin);
  if (currentState == LOW && previousSW1State == HIGH) {
    previousSW1State = LOW;
    return true;
  } else if (currentState == HIGH) {
    previousSW1State = HIGH;
  }
  return false;
}

void changeChannel() {
  if (currentRGBPin == RGBRedPin) {
    currentRGBPin = RGBGreenPin;
  } else if (currentRGBPin == RGBGreenPin) {
   currentRGBPin = RGBBluePin;
  } else {
   currentRGBPin = RGBRedPin;
  }
}

void changeBrightness(int pinToChange, int value) {
  analogWrite(pinToChange, value);
}

int getBrightness() {
  int value = analogRead(POTPin); // Read pot
  return map(value, 0, 1023, 0, 255);
}



