# Recorrido en Espiral de una Matriz en C#

Este programa en C# imprime los elementos de una matriz en orden espiral, comenzando desde la esquina superior izquierda.  

## Descripción

El usuario ingresa una matriz de tamaño arbitrario y el programa recorre sus elementos en forma de espiral, avanzando hacia la derecha, luego hacia abajo, hacia la izquierda y hacia arriba, repitiendo el patrón hasta recorrer toda la matriz.  

## Funcionamiento

1. Se leen las dimensiones de la matriz (filas y columnas) y los elementos fila por fila.  
2. Se inicializan los límites de la matriz: `top`, `bottom`, `left` y `right`.  
3. Se recorre la matriz en espiral ajustando los límites después de cada pasada:  
   - De izquierda a derecha.  
   - De arriba hacia abajo.  
   - De derecha a izquierda.  
   - De abajo hacia arriba.  
4. Se imprimen los elementos en orden espiral, separados por comas.  

## Ejemplo de ejecución

**Entrada:**  
Matriz:  
1 2 3  
4 5 6  
7 8 9  

**Proceso:**  
- Se recorre primero la fila superior: 1, 2, 3  
- Luego la columna derecha: 6, 9  
- La fila inferior de derecha a izquierda: 8, 7  
- La columna izquierda de abajo hacia arriba: 4  
- Finalmente, el centro: 5  

**Salida:**  
Espiral: [1, 2, 3, 6, 9, 8, 7, 4, 5]  

## Conclusión

Este programa muestra cómo recorrer una matriz en espiral, utilizando límites variables para controlar el recorrido.  
Es una técnica útil para visualización de datos y problemas que requieren ordenamiento especial de matrices.
