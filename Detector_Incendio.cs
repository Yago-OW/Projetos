const int sensor=A1;
float valor=0;
float temp=0;

void setup(){
  
  pinMode(sensor, INPUT);
  Serial.println("Lendo Temperatura...");
  pinMode(A0, INPUT);
  pinMode(A1, INPUT);
  pinMode(7, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(3, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  
  valor=analogRead(sensor);
  temp =(valor * 500)/1023;
  Serial.print("Temperatura");
  Serial.print(temp);
  Serial.println(" C");
  delay(500);
  
  if (temp<=15) {
    digitalWrite(3, HIGH);
    digitalWrite(7, LOW);
  }
  
  if(analogRead(A0)>21) {
    digitalWrite(3, LOW);
  }
  
  if (temp>=16) {
    digitalWrite(7, HIGH);
    digitalWrite(3, LOW);
  }
  
  if (analogRead(A0) > 21) {
    digitalWrite(7, HIGH);
    digitalWrite(6, HIGH);
    digitalWrite(5, LOW);
    digitalWrite(4, LOW);
   
   
    
    delay(500);
    
    digitalWrite(7, LOW);
    digitalWrite(6, LOW);
    digitalWrite(5, LOW);
    digitalWrite(4, LOW);
    delay(500);
    
    } 
  
   if(analogRead(A0) <= 10) {
    digitalWrite(5, HIGH);
     digitalWrite(4, LOW);
    
    
  }
  
   if (analogRead(A0) > 11 && analogRead(A0) <= 20){
    digitalWrite(4, HIGH);
    digitalWrite(5, LOW);
  }

} 