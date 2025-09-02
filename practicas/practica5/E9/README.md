# Recorrido en espiral de una matriz en C#

Este programa recorre una matriz en **forma de espiral** (de izquierda a derecha, luego hacia abajo, después a la izquierda y finalmente hacia arriba, repitiendo hasta recorrer todos los elementos).

## Ejemplo de uso

Matriz de prueba:

1 2 3
4 5 6
7 8 9


### Salida esperada

Recorrido en espiral:
1 2 3 6 9 8 7 4 5

## Funcionamiento

1. Se definen cuatro límites: **arriba, abajo, izquierda y derecha**.  
2. Se recorre la matriz siguiendo este orden:
   - Izquierda → Derecha  
   - Arriba → Abajo  
   - Derecha → Izquierda  
   - Abajo → Arriba  
3. Se van ajustando los límites en cada iteración hasta recorrer toda la matriz.

