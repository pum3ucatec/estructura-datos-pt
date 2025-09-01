# Subarreglo con Suma Máxima en C#

Este programa en C# encuentra el subarreglo contiguo dentro de un arreglo de enteros que tiene la suma máxima posible.  

## Descripción

El algoritmo analiza los elementos de un arreglo y determina qué segmento contiguo genera la mayor suma acumulada.  
Para ello utiliza un enfoque basado en el algoritmo de **Kadane**, que permite resolver el problema de manera eficiente.  

## Funcionamiento

1. Se inicializan variables para guardar la suma actual y la suma máxima encontrada.  
2. Se recorren los elementos del arreglo, actualizando la suma parcial en cada paso.  
3. Si un elemento es mayor que la suma acumulada hasta ese punto, se reinicia el cálculo desde ese elemento.  
4. Cuando se encuentra una nueva suma máxima, se registran los índices de inicio y fin del subarreglo.  
5. Al final, el programa imprime el subarreglo que da la suma máxima y el valor de dicha suma.  

## Ejemplo de ejecución

**Entrada:**  
Arreglo: [-2, 1, -3, 4, -1, 2, 1, -5, 4]  

**Proceso:**  
- Se evalúan diferentes subarreglos.  
- El subarreglo `[4, -1, 2, 1]` produce la suma máxima.  

**Salida:**  
Subarreglo con suma máxima: [4, -1, 2, 1]  
Suma máxima: 6  

## Conclusión

Este programa ilustra cómo aplicar el algoritmo de Kadane para resolver el problema del subarreglo con suma máxima.  
Es una solución eficiente con complejidad **O(n)**, lo que la hace adecuada incluso para arreglos grandes.
