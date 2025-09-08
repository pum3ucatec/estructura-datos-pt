# 📘 Conversión Recursiva de Decimal a Binario en C#

Este proyecto implementa una función **recursiva** en C# para convertir un número entero decimal en su representación binaria. Es una solución elegante que refleja la lógica matemática de la división sucesiva por 2.

---

## 🔢 ¿Qué significa convertir a binario?

La conversión de un número decimal a binario consiste en expresar ese número usando solo los dígitos `0` y `1`, según el sistema de numeración base 2.

**Ejemplo:**

- Decimal: 13 
- Binario: 1101

---

## 🧠 ¿Por qué usar recursividad?

La recursividad permite expresar la conversión como:

- Binario(n) = Binario(n / 2) + (n % 2)

Con un **caso base**:
- Si n == 0 → "0" 
- Si n == 1 → "1"
## 🧪 Ejemplos de ejecución
- Ingresa un número entero no negativo: 13
- El número 13 en binario es: 1101
- Ingresa un número entero no negativo: 0
- El número 0 en binario es: 0
- Ingresa un número entero no negativo: -5
- Entrada inválida. Por favor ingresa un número entero no negativo.
