# Búsqueda en un Arreglo Rotado en C#

Este programa en C# busca un elemento en un arreglo que ha sido rotado, devolviendo la posición del elemento si se encuentra.  

## Descripción

El programa permite al usuario ingresar un arreglo de enteros que ha sido rotado (es decir, un arreglo previamente ordenado que se ha desplazado) y un número a buscar.  
Utiliza una versión modificada de la búsqueda binaria adaptada para arreglos rotados, logrando eficiencia en tiempo de ejecución.  

## Funcionamiento

1. Se inicializan los índices `izquierda` y `derecha` al inicio y al final del arreglo.  
2. Se calcula el índice medio y se compara con el elemento objetivo.  
3. Dependiendo de la relación entre los elementos de los extremos y el medio, se ajustan los índices de búsqueda para enfocarse en la sección correcta del arreglo.  
4. Si se encuentra el elemento, se devuelve su índice; de lo contrario, se retorna `-1`.  
5. El programa imprime la posición encontrada (sumando 1 para hacerlo más legible).  

## Ejemplo de ejecución

**Entrada:**  
Arreglo: [4, 5, 6, 7, 0, 1, 2]  
Número a buscar: 0   

**Proceso:**  
- Se identifica la parte rotada del arreglo.  
- Se aplica búsqueda binaria adaptada hasta encontrar el número.  

**Salida:**  
Posición: 5  

## Conclusión

Este programa demuestra cómo aplicar la búsqueda binaria en un arreglo rotado, optimizando la búsqueda con complejidad **O(log n)**.  
Es una técnica eficiente para trabajar con datos parcialmente ordenados y rotados.
