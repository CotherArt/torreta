// Incluimos la librería necesaria para manejar los servo motores
#include <Servo.h> 

// Definimos los servo motores que controlarán el eje X y Y
Servo servoX;
Servo servoY;

// Definimos la variable que contiene la información transmitida por el puerto Serial
String serialData;

// Función que se ejecutará solo una vez al iniciar el Arduino
void setup() {
  // Asignamos cada servo a su respectivo pin digital del Arduino
  servoX.attach(9);
  servoY.attach(8);

  // Abrimos el puerto Serial con un ratio de 9600 bps
  Serial.begin(9600);
  // Asignamos el tiempo maximo de espera para los datos en 10 milisegundos
  Serial.setTimeout(10);
}

// Funcion que se ejecutará en bucle infinitamente
void loop() {
  // Comprobamos si hay información en el puerto Serial
  if (Serial.available() >0){
    // Obtenemos la información del puerto Serial
    serialData = Serial.readString();

    // Traducimos la información recibida, en ángulos del eje X y Y
    int anguloX = parseDataX(serialData);
    int anguloY = parseDataY(serialData);

    // Movemos los servomotores a sus respectivos angulos
    servoX.write(anguloX);
    servoY.write(anguloY);
  }
}

// Función que retorna el numero seguido de la letra X
// Ejemplo: 
// input -> "X120Y90"
// output -> 120
int parseDataX(String data){
  data.remove(data.indexOf("Y"));
  data.remove(data.indexOf("X"), 1);
  return data.toInt();
}

// Función que retorna el numero seguido de la letra Y
// Ejemplo: 
// input -> "X120Y90"
// output -> 90
int parseDataY(String data){
  data.remove(0,data.indexOf("Y") + 1);
  return data.toInt();
}
