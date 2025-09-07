# Búsqueda en un arreglo rotado en C#

Este programa implementa una **búsqueda binaria modificada** para encontrar un elemento dentro de un arreglo **rotado y ordenado**.

## Funcionamiento

Un arreglo ordenado puede estar "rotado" en algún punto.  
Ejemplo: `[0, 1, 2, 4, 5, 6, 7]` puede rotarse y convertirse en `[4, 5, 6, 7, 0, 1, 2]`.

El algoritmo identifica cuál de las dos mitades está ordenada en cada paso y descarta la otra, logrando una búsqueda eficiente en **O(log n)**.

## Ejemplo de uso

Arreglo de prueba:

[4, 5, 6, 7, 0, 1, 2]


Elemento a buscar:
0


### Salida esperada

Arreglo:
4 5 6 7 0 1 2

El número 0 se encontró en la posición: 4

