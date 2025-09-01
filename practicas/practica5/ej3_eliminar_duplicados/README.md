# Eliminación de Duplicados en un Arreglo Ordenado en C#

Este programa en C# elimina los elementos duplicados de un arreglo ordenado, manteniendo solo una copia de cada valor.  

## Descripción

El usuario ingresa un arreglo ordenado de números enteros.  
El programa recorre los elementos y utiliza un puntero para sobrescribir las posiciones de los duplicados, de modo que solo se conserven los valores únicos.  

## Funcionamiento

1. El usuario ingresa los números separados por espacios.  
2. Se verifica si el arreglo está vacío.  
3. Se inicializa un índice `j` para marcar la posición donde se colocará el siguiente valor único.  
4. Se recorre el arreglo comparando cada elemento con el último valor único encontrado.  
5. Al finalizar, se imprimen los elementos sin duplicados.  

## Ejemplo de ejecución

**Entrada:**  
1 1 2 2 3 4 4  

**Proceso:**  
- Se comparan los elementos y se sobrescriben las posiciones repetidas.  

**Salida:**  
Sin duplicados: 1 2 3 4  

## Conclusión

Este programa muestra cómo eliminar duplicados en un arreglo ordenado de manera eficiente, utilizando un enfoque de doble puntero.  
El método permite reducir el uso de memoria extra y mantiene la complejidad en **O(n)**, siendo una solución óptima para este tipo de problemas.
