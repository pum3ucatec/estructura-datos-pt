#  Cálculo del Máximo Común Divisor (MCD) con Recursividad en C#

##  Descripción
Este programa implementa el **algoritmo de Euclides** de manera recursiva para calcular el **Máximo Común Divisor (MCD)** de dos números enteros ingresados por el usuario.  

El **MCD** es el número entero más grande que divide exactamente a ambos números.

---

##  Funcionamiento del programa
1. El usuario ingresa dos números enteros desde consola.
2. El programa aplica el **algoritmo de Euclides**:
   - Caso base: si `b == 0`, el MCD es `a`.
   - Paso recursivo: llamar nuevamente a la función con los valores `(b, a % b)`.
3. Muestra el resultado en pantalla.

---

##  Ejemplo de ejecución  
  
Ingrese el primer número: 48  
Ingrese el segundo número: 18  
El MCD de 48 y 18 es: 6  
 
---

##  Estructura del código
- **MCDRecursivo(int a, int b):** Función recursiva que calcula el MCD.
- **Main():** Punto de entrada, donde se piden los números y se muestra el resultado.

---

## Notas

El programa asume que el usuario siempre ingresa números enteros válidos.  

Si se ingresan números negativos, el algoritmo sigue funcionando porque el MCD siempre será un número positivo.  

---

## Integrantes 
1. Ramos Hidalgo Patrick Rodrigo
2. Quisbert Huayta Antony Quisbert