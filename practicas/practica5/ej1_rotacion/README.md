# Rotación de un Arreglo a la Derecha en C#

Este programa en C# implementa una función que rota los elementos de un arreglo hacia la derecha una cantidad determinada de posiciones.

## Descripción

El programa recibe un arreglo de enteros y un valor `k`, que indica cuántas posiciones se deben rotar los elementos hacia la derecha.  
La rotación es circular: los últimos elementos se mueven al inicio del arreglo.

## Funcionamiento

1. Se calcula la longitud del arreglo.
2. Se ajusta `k` para que no sea mayor al tamaño del arreglo (`k % n`).
3. Se copian los últimos `k` elementos al inicio del nuevo arreglo.
4. Se desplazan los elementos restantes hacia la derecha.
5. El programa imprime en consola cómo se van moviendo los elementos y muestra el resultado final.

## Ejemplo de ejecución

**Entrada:**
- Arreglo: `[1, 2, 3, 4, 5]`  
- `k = 2`

**Proceso:**
- Los últimos 2 elementos (`4` y `5`) se mueven al inicio.  
- Los demás elementos se desplazan hacia la derecha.  

**Salida:**
Resultado final: [4, 5, 1, 2, 3]  

## Conclusión

Este programa demuestra cómo realizar una rotación circular de un arreglo de manera eficiente.  
El uso de un nuevo arreglo temporal permite reorganizar los elementos sin necesidad de operaciones complejas, mostrando un ejemplo claro de manipulación de estructuras de datos en C#.

