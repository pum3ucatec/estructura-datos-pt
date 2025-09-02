# Ejercicio 10 - Juego de Adivinanza

## Descripción
Este programa genera un número aleatorio entre **1 y 50**, y el usuario debe adivinarlo mediante intentos.

---

## Ejemplo de Ejecución
 Adivina el número entre 1 y 50
 Ingresa tu intento: 30
El número secreto es MENOR.
 Ingresa tu intento: 15
El número secreto es MAYOR.
 Ingresa tu intento: 22
 ¡Felicidades! Adivinaste el número.



---

## Funcionamiento
- Se usa `Random.Next(1, 51)` para generar un número aleatorio entre **1 y 50**.  
- El programa solicita al usuario un número y compara con el secreto.  
  - Si el intento es mayor → muestra "MENOR".  
  - Si el intento es menor → muestra "MAYOR".  
- El ciclo `do-while` continúa hasta que el jugador acierte.  

---