# 📘 Práctica 5 - Ejercicios con Arreglos y Matrices en C#

Este proyecto contiene *10 ejercicios de programación en C#* sobre arreglos y matrices.  
Cada ejercicio está implementado como un método en la clase ArrayExercises y probado en Main().

---

## 🔹 Ejercicio 1 - Rotar Arreglo a la Derecha
*Descripción:*  
Rota un arreglo k posiciones hacia la derecha usando inversión de segmentos.

*Ejemplo:*
Original: 1, 2, 3, 4, 5
Rotado por 2: 4, 5, 1, 2, 3

*Conceptos aplicados:*
- Arreglos.
- Manipulación con índices.
- Algoritmo de inversión.

---

## 🔹 Ejercicio 2 - Subarreglo con Suma Máxima
*Descripción:*  
Encuentra la suma más grande de un subarreglo contiguo usando el algoritmo de *Kadane*.

*Ejemplo:*
Array: -2, 1, -3, 4, -1, 2, 1, -5, 4
Suma máxima: 6 (subarreglo [4, -1, 2, 1])

*Conceptos aplicados:*
- Programación dinámica.
- Manejo de acumuladores.

---

## 🔹 Ejercicio 3 - Eliminar Duplicados en Arreglo Ordenado
*Descripción:*  
Elimina duplicados en un arreglo ordenado, retornando la cantidad de elementos únicos.

*Ejemplo:*
Original: 1, 1, 2, 2, 3, 4, 4
Resultado: 1, 2, 3, 4

*Conceptos aplicados:*
- Arreglos ordenados.
- Punteros e índices.

---

## 🔹 Ejercicio 4 - Encontrar Número que Falta
*Descripción:*  
Dado un arreglo con números del 1 al n, encuentra el que falta.

*Ejemplo:*
Array: 1, 2, 4, 5, 6
Número que falta: 3

*Conceptos aplicados:*
- Fórmula de Gauss n*(n+1)/2.
- Diferencia entre suma esperada y real.

---

## 🔹 Ejercicio 5 - Intersección de Dos Arreglos
*Descripción:*  
Encuentra los elementos comunes entre dos arreglos sin usar LINQ.

*Ejemplo:*
a = {1, 2, 2, 1}
b = {2, 2}
Intersección: 2, 2

*Conceptos aplicados:*
- Comparación con doble bucle.
- Listas dinámicas.

---

## 🔹 Ejercicio 6 - Matriz Transpuesta
*Descripción:*  
Transforma una matriz m x n en su transpuesta n x m.

*Ejemplo:*
Matriz original:
1 2 3
4 5 6

Matriz transpuesta:
1 4
2 5
3 6

*Conceptos aplicados:*
- Matrices bidimensionales.
- Intercambio de filas y columnas.

---

## 🔹 Ejercicio 7 - Producto Excepto el Índice
*Descripción:*  
Crea un arreglo donde cada posición contiene el producto de todos los elementos *excepto el propio índice*.

*Ejemplo:*
Array: 1, 2, 3, 4
Resultado: 24, 12, 8, 6

*Conceptos aplicados:*
- Arreglos auxiliares.
- Complejidad O(n).

---

## 🔹 Ejercicio 8 - Búsqueda en Arreglo Rotado
*Descripción:*  
Realiza una búsqueda binaria en un arreglo que fue rotado.

*Ejemplo:*
Array: 4, 5, 6, 7, 0, 1, 2
Buscar: 0
Encontrado en índice: 4

*Conceptos aplicados:*
- Búsqueda binaria modificada.
- Detección de subarreglos ordenados.

---

## 🔹 Ejercicio 9 - Recorrido en Espiral de Matriz
*Descripción:*  
Recorre una matriz en forma de *espiral*.

*Ejemplo:*
Matriz:
1 2 3
4 5 6
7 8 9

Espiral: 1, 2, 3, 6, 9, 8, 7, 4, 5

*Conceptos aplicados:*
- Control de límites (top, bottom, left, right).
- Recorridos condicionales.

---

## 🔹 Ejercicio 10 - Suma de Subconjuntos con Backtracking
*Descripción:*  
Encuentra todos los subconjuntos de un arreglo que sumen un valor objetivo.

*Ejemplo:*
Array: {2, 3, 6, 7}
Target: 7
Subconjuntos:
[7]
[2, 2, 3]

*Conceptos aplicados:*
- Recursividad y backtracking.
- Listas dinámicas.

---

## 🛠️ Ejecución
1. Guarda el código en un archivo .cs.
2. Compila con:
```bash
dotnet run
3. Se mostrarán los resultados de cada ejercicio en la consola.