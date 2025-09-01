# Encontrar Número Faltante en un Arreglo en C#

Este programa en C# identifica si falta algún número dentro de un rango en un arreglo dado de enteros.  

## Descripción

El programa recibe un arreglo de números enteros y determina si falta algún valor en la secuencia entre el número mínimo y el máximo del arreglo.  
Para ello, compara la suma esperada de todos los números del rango con la suma real de los elementos presentes.  

## Funcionamiento

1. Se ordena el arreglo de entrada.  
2. Se calcula la suma esperada de todos los enteros desde el mínimo hasta el máximo usando fórmulas matemáticas.  
3. Se obtiene la suma real de los elementos del arreglo.  
4. La diferencia entre la suma esperada y la real indica el número faltante.  
5. Si la diferencia es cero, significa que no falta ningún número en el rango.  

## Ejemplo de ejecución

**Entrada:**  
[1, 2, 4, 5, 6]  

**Proceso:**  
- El rango esperado es de 1 a 6.  
- La suma esperada es 21.  
- La suma real es 18.  
- Diferencia = 3.  

**Salida:**  
Número faltante: 3  

## Conclusión

Este programa muestra una forma eficiente de identificar un número faltante en un arreglo.  
El uso de sumas esperadas evita la necesidad de recorrer todo el rango, haciendo que el algoritmo sea simple y rápido, con complejidad **O(n)**.
