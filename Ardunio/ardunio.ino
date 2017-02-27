#include <dht.h>

dht DHT;


#define DHT11_PIN 3
#define s0 4
#define s1 5
#define s2 6
#define s3 7
#define sensorOut 8

int frequency=0;

void setup(){
  pinMode(s0,OUTPUT);
  pinMode(s1,OUTPUT);
  pinMode(s2,OUTPUT);
  pinMode(s3,OUTPUT);
  pinMode(sensorOut,INPUT);

  digitalWrite(s0,HIGH);
  digitalWrite(s1,LOW);

  Serial.begin(9600);
  
}

void loop(){
  digitalWrite(s2,LOW);
  digitalWrite(s3,LOW);

  frequency = pulseIn(sensorOut,LOW);

  
  Serial.print(frequency);
  Serial.print("--");
 

  digitalWrite(s2,HIGH);
  digitalWrite(s3,HIGH);

  frequency =pulseIn(sensorOut,LOW);

  Serial.print(frequency);
  Serial.print("--");
 

digitalWrite(s2,LOW);
  digitalWrite(s3,HIGH);

  frequency =pulseIn(sensorOut,LOW);

  Serial.print(frequency);

   

   int chk = DHT.read11(DHT11_PIN);
  int sensorValue=analogRead(A1);
  Serial.print("--");
   Serial.print(sensorValue);
  Serial.print("--");
   Serial.print(DHT.humidity);
    Serial.print("--");
    Serial.print(DHT.temperature);
    Serial.println();
  delay(1000);
  
}




