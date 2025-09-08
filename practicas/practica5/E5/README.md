# Intersección de Arreglos

Este programa en **C#** encuentra los elementos comunes (intersección) entre dos arreglos de enteros.

## Descripción

Dado dos arreglos de números enteros, se busca la intersección de ambos, es decir, los elementos que aparecen en los dos arreglos.  
Se utiliza un arreglo temporal y una marca de uso para evitar contar dos veces el mismo elemento.

## Ejemplo de Ejecución

### Entrada
arr1 = { 1, 2, 2, 1 }
arr2 = { 2, 2 }

### Salida

Intersección: [2, 2]

## Funcionamiento del Código

1. Se recorre cada elemento del primer arreglo.
2. Se compara con los elementos del segundo arreglo.
3. Si son iguales y el elemento aún no ha sido utilizado, se guarda en un arreglo temporal.
4. Se ajusta el tamaño del arreglo resultado con los elementos encontrados.
5. Finalmente, se muestra la intersección en consola.

