//Imports necessary librarys to use the stepper motor and the servo motor
#include <Stepper.h>
#include <Servo.h>
#define STEPS 100//Idk what this dose but it makes it work. You may need to change it depending on your stepper motor
//Creates a stepper and servo object
Stepper stepper(STEPS, 8, 9, 10, 11);
Servo arm;
//Creates necessary varibles
int armpos = 0;
int readln = 0;
void setup() {
    Serial.begin(9600); //Sets the baud rate
    stepper.setSpeed(100); //Sets the speed at which the stepper moves
    arm.attach(5); //Sets the control pin for the servo
}

void loop() {
  readln = Serial.read(); //Gets commands from the program on your computer
  //The rest does stuff based on the commands the program on your computer
  if (readln = 1){
    arm.write(armpos - 10);
  }

  if (readln = 2){
    arm.write(armpos - 1);
  }

  if (readln = 3){
    arm.write(armpos + 1);
  }

  if (readln = 4){
    arm.write(armpos + 10);
  }

  if (readln = 5){
    stepper.step(-10);
  }

  if (readln = 6){
    stepper.step(-1);
  }

  if (readln = 7){
    stepper.step(+1);
  }

  if (readln = 8){
    stepper.step(+10);
  }
}
