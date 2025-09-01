# Intersección de Dos Arreglos en C#

Este programa en C# encuentra los elementos comunes entre dos arreglos de enteros, considerando las repeticiones que aparecen en ambos.  

## Descripción

El programa compara los elementos de dos arreglos ingresados por el usuario.  
Cuando un número existe en ambos arreglos, se agrega al resultado de la intersección.  
Cada elemento se usa solo una vez en la comparación, lo que permite manejar correctamente los valores repetidos.  

## Funcionamiento

1. Se reciben dos arreglos de enteros como entrada.  
2. Se inicializa un arreglo de control (`usado`) para marcar los elementos ya emparejados en el segundo arreglo.  
3. Se recorren los elementos del primer arreglo y se buscan coincidencias en el segundo.  
4. Cuando se encuentra una coincidencia, se agrega al resultado y se marca como usado.  
5. Se muestra en pantalla la intersección final de los arreglos.  

## Ejemplo de ejecución

**Entrada:**  
Arreglo1 = [1, 2, 2, 1]  
Arreglo2 = [2, 2]  

**Proceso:**  
- El número `2` aparece dos veces en ambos arreglos.  
- Se toman solo esas dos coincidencias.  

**Salida:**  
Intersección: [2, 2]    

## Conclusión

Este programa demuestra cómo calcular la intersección de dos arreglos teniendo en cuenta las repeticiones.  
La estrategia de marcar elementos como usados evita contar duplicados de manera incorrecta, garantizando que el resultado refleje fielmente los valores comunes entre ambos arreglos.
