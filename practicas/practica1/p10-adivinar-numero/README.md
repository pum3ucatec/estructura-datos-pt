# Ejercicio 10 - Juego "Adivina el número"

## 📌 Descripción
Este programa es un juego donde la computadora **piensa un número entre 1 y 100** y el usuario debe adivinarlo.

## 🚀 Funcionamiento
1. Genera un número aleatorio entre 1 y 100.
2. Pide al usuario intentar adivinarlo.
3. Da pistas:
   - "Muy bajo" si el número ingresado es menor.
   - "Muy alto" si el número ingresado es mayor.
4. Finaliza cuando el usuario acierta.

## 🖥️ Ejemplo de salida
He pensado un número entre 1 y 100. ¡Adivínalo!
Tu intento: 50
Muy bajo. Prueba un número más GRANDE.
Tu intento: 75
Muy alto. Prueba un número más PEQUEÑO.
Tu intento: 63
¡Correcto! El número era 63. Intentos: 3

## 🛠️ Conceptos aplicados
- Generación de números aleatorios (`Random`).
- Ciclo infinito controlado con `break`.
- Condicionales `if-else`.
