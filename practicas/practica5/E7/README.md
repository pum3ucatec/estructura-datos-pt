# Producto de todos los elementos excepto el índice en C#

Este programa calcula un nuevo arreglo donde cada posición contiene el **producto de todos los elementos del arreglo original, excepto el de su propio índice**.

## Funcionamiento

1. Se construye un arreglo auxiliar `izquierda` que guarda el producto acumulado de todos los elementos a la izquierda de cada índice.
2. Se construye otro arreglo auxiliar `derecha` que guarda el producto acumulado de todos los elementos a la derecha de cada índice.
3. El resultado final se obtiene multiplicando `izquierda[i] * derecha[i]` para cada índice.

## Ejemplo

Dado el arreglo:

[1, 2, 3, 4]


El resultado es:

[24, 12, 8, 6]


## Explicación del ejemplo

- Para índice 0 → `2 * 3 * 4 = 24`
- Para índice 1 → `1 * 3 * 4 = 12`
- Para índice 2 → `1 * 2 * 4 = 8`
- Para índice 3 → `1 * 2 * 3 = 6`

## Salida esperada

Arreglo original:
1 2 3 4

Arreglo resultado:
24 12 8 6