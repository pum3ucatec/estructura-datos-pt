# 📘 Contar Dígitos Recursivamente en C#

Este proyecto implementa una función **recursiva** en C# para contar cuántos dígitos tiene un número entero positivo. Es una solución elegante que descompone el número dividiéndolo por 10 en cada paso, hasta llegar al caso base.

---

## 🔢 ¿Qué significa contar dígitos?

Contar los dígitos de un número consiste en determinar cuántos caracteres numéricos lo componen.

**Ejemplo:**

- Número: 4567 
- Cantidad de dígitos: 4


---

## 🧠 ¿Por qué usar recursividad?

La recursividad permite expresar el conteo de dígitos como:

- Contar(n) = 1 + Contar(n / 10)

Con un **caso base**: Contar(n) = 1 cuando n < 10
## 🧪 Ejemplos de ejecución
- Ingresa un número entero positivo: 4567
- El número 4567 tiene 4 dígito(s).
