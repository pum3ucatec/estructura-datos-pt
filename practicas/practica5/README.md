# 📘 Ejercicios 5 Avanzados con Arreglos en C#

Este proyecto implementa una serie de **ejercicios avanzados con arreglos y matrices en C#**, utilizando **Programación Orientada a Objetos** y diversos algoritmos.

---

## 🎯 Objetivos
- Practicar la manipulación de arreglos y matrices en C#.
- Implementar algoritmos clásicos de búsqueda, rotación y combinación.
- Desarrollar soluciones eficientes a problemas comunes de programación.
- Aplicar estructuras como listas y técnicas como **backtracking**.

---

## 🔹 Estructura del Proyecto

- **ArrayExercises.cs**  
  Contiene la clase estática `ArrayExercises` con los 10 métodos implementados.

- **Program.cs**  
  Clase principal que ejecuta ejemplos de cada ejercicio en consola.

---

## 🛠️ Ejercicios Implementados

1. **Giro del arreglo a la derecha**  
   Rota un arreglo `k` posiciones hacia la derecha.

2. **Subarreglo con suma máxima**  
   Implementación de **Kadane’s Algorithm** para encontrar la suma máxima en un subarreglo.

3. **Eliminación de duplicados en arreglo ordenado**  
   Reemplaza duplicados en un arreglo y devuelve la cantidad de elementos únicos.

4. **Encontrar número que falta**  
   Encuentra el número faltante en un arreglo de `1..n`.

5. **Intersección de dos arreglos** (sin LINQ)  
   Devuelve los elementos comunes entre dos arreglos.

6. **Matriz transpuesta**  
   Intercambia filas por columnas.

7. **Producto excepto el índice**  
   Devuelve un arreglo donde cada elemento es el producto de todos los demás excepto el índice actual.

8. **Búsqueda en arreglo rotado ordenado**  
   Implementación de **Binary Search** para encontrar un valor en un arreglo rotado.

9. **Recorrido en espiral de matriz**  
   Devuelve los elementos de la matriz en forma de espiral.

10. **Suma de subconjuntos con backtracking**  
    Encuentra subconjuntos de un arreglo que sumen un valor objetivo.

---

## 📌 Ejemplo de Ejecución



Original: 1, 2, 3, 4, 5
Rotado por 2: 4, 5, 1, 2, 3

Suma máxima de subarreglo: 6

Sin duplicados: 1, 2, 3, 4

Número que falta: 3

Intersección: 2, 2

Matriz transpuesta:
1 4
2 5
3 6

Producto excepto índice: 24, 12, 8, 6

Elemento 0 encontrado en índice: 4

Recorrido en espiral: 1, 2, 3, 6, 9, 8, 7, 4, 5

Subconjuntos que suman 7:
[2, 2, 3]
[7]