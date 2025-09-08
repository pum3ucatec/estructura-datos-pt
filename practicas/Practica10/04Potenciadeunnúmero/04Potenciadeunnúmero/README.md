# 📘 Potencia Recursiva en C#

Este proyecto implementa una función **recursiva** en C# para calcular la potencia de un número:  
`base^exponente`, donde la base es un número entero y el exponente es un entero no negativo.

---

## 🧮 ¿Qué es una potencia?

La potencia de un número se define como el producto repetido de la base consigo misma:

- base^exp = base × base × ... × base (exp veces)


Por ejemplo:
- 2^4 = 2 × 2 × 2 × 2 = 16

---

## 🧠 ¿Por qué usar recursividad?

La recursividad permite expresar la potencia como:

- base^exp = base × base^(exp - 1)


Con un **caso base**: base^0 = 1

## Ejemplo de ejecucion
- Ingresa la base: 3
- Ingresa el exponente (no negativo): 4
- 3^4 = 81
