#  Ejercicio 8 – Invertir un arreglo

Este programa en C# toma un **arreglo de números** y crea un nuevo arreglo con los elementos en **orden inverso**.

---
## Explicación 

Se define un arreglo numeros con algunos valores.

Se crea un arreglo invertido del mismo tamaño que numeros.

Se recorre el arreglo con un bucle for:

invertido[i] = numeros[numeros.Length - 1 - i] → coloca los elementos desde el final hacia el inicio.

Se imprime el arreglo invertido usando string.Join para separar los elementos por comas.