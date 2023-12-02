#include <DHT.h>
#define DHTTYPE DHT22
#include <Servo.h>
 
const int DHTPin = 6;

float valorPotenciometro;
const int pinPotenciometro = A0;

const int pinLEDTem = 8; 

float maxVoltaje=5.0;
 
DHT dht(DHTPin, DHTTYPE);
Servo servoMotor;
 
void setup() 
{
   Serial.begin(9600);
   Serial.println("Probando DHT22!");
  pinMode(pinLEDTem, OUTPUT);
   dht.begin();
    servoMotor.attach(11);
}
 
void loop() 
{
   delay(2000);
 
   float t = dht.readTemperature();
 
   if (isnan(t)) 
   {
      Serial.println("No se pudo leer el sensor DHT!");
      return;
   }
 valorPotenciometro = analogRead(pinPotenciometro);

   float temperatura= convertidorVoltajeACentigrados(valorPotenciometro,t);
 
      Serial.print("~/");
   Serial.print(temperatura);
   Serial.print('/');
   Serial.print(1);
   Serial.print('/');
   Serial.print(t);
     Serial.print('/');
     Serial.println("-");
}


float convertidorVoltajeACentigrados(float valorAnalogico,float tempDHT11){
    //Primero convertimos el valor a analógico a voltaje del valor del potenciometro
    float voltaje=(valorPotenciometro*maxVoltaje)/1023;
    //temperatura maxima de un invernadero es de 30 grados.
    //40 => 5V
    float temperaturaCelsius =(voltaje*50)/maxVoltaje;
    if(tempDHT11>=temperaturaCelsius){
     digitalWrite(pinLEDTem,HIGH);
      delay(500);
        servoMotor.write(0);
    // Esperamos .5 segundo
        delay(500);
    
    // Desplazamos a la posición 90º
      servoMotor.write(90);
    // Esperamos 1 segundo
      delay(500);
    
    // Desplazamos a la posición 180º
      servoMotor.write(180);
    // Esperamos 1 segundo
      delay(500);

    }else{
      digitalWrite(pinLEDTem,LOW);
      delay(500);
    }

    return temperaturaCelsius;
}
