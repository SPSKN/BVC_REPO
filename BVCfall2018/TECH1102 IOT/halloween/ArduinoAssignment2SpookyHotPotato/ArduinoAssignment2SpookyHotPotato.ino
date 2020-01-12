
#include <Adafruit_LiquidCrystal.h>

Adafruit_LiquidCrystal lcd(12, 11, 5, 4, 3, 2);


int buttonState = 0;
int lastButtonState = 0;
int buttonPushCounter = 0;
int randomNumber;
int bluePin = 5;
int button = 2;
int buzzerPin = 13;

#define N_D4 294
#define N_D5 587
#define N_A4 440
#define N_GS4 415
#define N_G4 392
#define N_F4 349
#define N_C4 262

int const TEMPO = 1300;  

int melody[] = {
N_D4, N_D4, N_D5, N_A4, 0, N_GS4, N_G4, N_F4, N_D4, N_F4, N_G4, N_C4, N_C4, N_D5, N_A4, 0, N_GS4, N_G4, N_F4, N_D4, N_F4, N_G4  
}; 

 int noteDurations[] = {
  16, 16, 8, 6, 32, 8, 8, 8, 16, 16, 16, 16, 16, 8, 6, 32, 8, 8, 8, 16, 16, 16 
};

void setup()
{
  pinMode(button, INPUT);
  pinMode(bluePin, OUTPUT);
  randomSeed(analogRead(0));
  lcd.begin(16, 2);
  Serial.begin(9600);
}

void loop()
{
  randomNumber = random(10, 20);
  buttonState = digitalRead(button);
  // compare the buttonState to its previous state
  if (buttonState != lastButtonState) {
    // if the state has changed, increment the counter
    if (buttonState == HIGH) {
      tone(buzzerPin, 587.33, 100);
      delay(100);
      tone(buzzerPin, 698.46, 100);
      buttonPushCounter += 1;

      Serial.print("number of button pushes: ");
      Serial.println(buttonPushCounter);
    }
    

    
    if (buttonPushCounter == randomNumber) {
      digitalWrite(bluePin, HIGH);
        for (int blinkAmount = 0; blinkAmount <= 5; blinkAmount++)
        {
          lcd.setCursor(4, 2);
          lcd.print("         ");
          delay(100);
          lcd.setCursor(4, 0);
          lcd.print("         ");
          delay(200);
          lcd.setCursor(4, 2);
          lcd.print("YOU LOSE");
          delay(100);
          lcd.setCursor(4, 0);
          lcd.print("YOU LOSE");
          delay(200);
        }
      int melody_len = sizeof(melody)/sizeof(melody[0]);

      for (int thisNote = 0; thisNote < melody_len; thisNote++) {
        int noteDuration = TEMPO / noteDurations[thisNote];
        tone(13, melody[thisNote], noteDuration);
        int pauseBetweenNotes = noteDuration * 1.45;
        delay(pauseBetweenNotes);
        noTone(13);
  }
      
    }
  }
  lastButtonState = buttonState;
}
