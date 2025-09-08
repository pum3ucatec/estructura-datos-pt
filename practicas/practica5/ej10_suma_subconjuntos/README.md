# Subconjuntos con Suma Igual a un Target en C#

Este programa en C# encuentra todos los subconjuntos de un arreglo que suman un valor objetivo (target) especificado por el usuario.  

## Descripción

El programa utiliza **backtracking** para generar combinaciones de elementos del arreglo que sumen exactamente el valor target.  
Se evita repetir subconjuntos idénticos mediante un conjunto de control (`HashSet`).  

## Funcionamiento

1. Se leen los elementos del arreglo y el valor target ingresados por el usuario.  
2. Se utiliza una función recursiva (`Backtrack`) para explorar todas las combinaciones posibles de elementos.  
3. Cada vez que la suma de un subconjunto alcanza el target, se imprime y se marca como visto.  
4. Se asegura que no se repitan subconjuntos idénticos utilizando una representación única de cada combinación.  
5. Se imprimen todos los subconjuntos válidos.  

## Ejemplo de ejecución

**Entrada:**  
Arreglo: [2, 3, 6, 7]  
Target: 7  

**Proceso:**  
- Se generan combinaciones: [7] y [2, 3, 2] (si existieran repeticiones en el arreglo).  
- Solo se imprimen combinaciones que sumen exactamente 7 y no se repitan.  

**Salida:**  
  [7]

## Conclusión

Este programa demuestra cómo utilizar backtracking para encontrar subconjuntos con una suma específica, evitando duplicados mediante un conjunto de control.  
Es un ejemplo práctico de búsqueda exhaustiva eficiente, aplicable a problemas de combinatoria y optimización.
