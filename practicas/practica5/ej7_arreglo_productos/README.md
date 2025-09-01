# Producto de Elementos Excepto el Actual en C#

Este programa en C# calcula un arreglo donde cada posición contiene el producto de todos los elementos del arreglo original excepto el elemento en esa posición.  

## Descripción

El programa recibe un arreglo de enteros y genera un nuevo arreglo donde cada elemento se obtiene multiplicando todos los demás elementos del arreglo original, sin incluir el valor en la posición actual.  
Se utiliza un enfoque eficiente sin divisiones, utilizando arreglos auxiliares para almacenar productos acumulados desde la izquierda y desde la derecha.  

## Funcionamiento

1. Se leen los elementos del arreglo ingresado por el usuario.  
2. Se construyen dos arreglos auxiliares:  
   - `izquierda`: producto de todos los elementos a la izquierda de cada posición.  
   - `derecha`: producto de todos los elementos a la derecha de cada posición.  
3. El producto final en cada posición se calcula multiplicando el valor correspondiente de `izquierda` y `derecha`.  
4. Se imprime el arreglo original y el arreglo resultante.  

## Ejemplo de ejecución

**Entrada:**  
[1, 2, 3, 4]  

**Proceso:**  
- Producto de elementos excepto el actual para cada posición:  
  - 1 → 2*3*4 = 24  
  - 2 → 1*3*4 = 12  
  - 3 → 1*2*4 = 8  
  - 4 → 1*2*3 = 6  

**Salida:**  
Arreglo: [1, 2, 3, 4]  
Resultado: [24, 12, 8, 6]  

## Conclusión

Este programa ilustra cómo calcular productos acumulativos de un arreglo sin utilizar divisiones, empleando arreglos auxiliares para eficiencia.  
El enfoque garantiza complejidad **O(n)** y es útil para manipulación de datos en problemas matemáticos y de algoritmos.
