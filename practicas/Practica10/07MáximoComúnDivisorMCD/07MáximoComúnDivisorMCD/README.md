# 📘 Máximo Común Divisor (MCD) Recursivo en C#

Este proyecto implementa una función **recursiva** en C# para calcular el **Máximo Común Divisor (MCD)** de dos números enteros, utilizando el algoritmo de Euclides. Es una solución eficiente y elegante que permite comprender cómo se puede aplicar la recursividad en problemas matemáticos clásicos.

---

## 🔢 ¿Qué es el MCD?

El **Máximo Común Divisor (MCD)** de dos números enteros es el número más grande que divide a ambos sin dejar residuo.

**Ejemplo:**

- MCD(48, 18) = 6


---

## 🧠 ¿Por qué usar recursividad?

El algoritmo de Euclides se basa en la siguiente propiedad:

- MCD(a, b) = MCD(b, a % b)

Con un **caso base**:

- MCD(a, 0) = |a|
## 🧪 Ejemplos de ejecución
- Ingresa el primer número: 48
- Ingresa el segundo número: 18
- El MCD de 48 y 18 es: 6