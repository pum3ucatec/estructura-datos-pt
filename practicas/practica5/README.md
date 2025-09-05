# Práctica 5 - Ejercicios de Arreglos y Matrices en C#

Este directorio contiene una colección de ejercicios prácticos sobre arreglos y matrices en C#. Cada ejercicio está en su propia carpeta con su respectivo archivo `Program.cs`.

---

## Índice

- [Práctica 5 - Ejercicios de Arreglos y Matrices en C#](#práctica-5---ejercicios-de-arreglos-y-matrices-en-c)
  - [Índice](#índice)
  - [1. Rotación de Arreglo](#1-rotación-de-arreglo)
  - [2. Subarreglo con Suma Máxima](#2-subarreglo-con-suma-máxima)
  - [3. Eliminar Duplicados de un Arreglo](#3-eliminar-duplicados-de-un-arreglo)
  - [4. Encontrar Número Faltante](#4-encontrar-número-faltante)
  - [5. Intersección y Diferencia de Dos Arreglos](#5-intersección-y-diferencia-de-dos-arreglos)
  - [6. Matriz Transpuesta](#6-matriz-transpuesta)
  - [7. Arreglo de Productos Excepto el Índice](#7-arreglo-de-productos-excepto-el-índice)
  - [8. Buscar Elemento en Arreglo Rotado](#8-buscar-elemento-en-arreglo-rotado)
  - [9. Recorrido en Espiral de una Matriz](#9-recorrido-en-espiral-de-una-matriz)
  - [10. Suma de Subconjuntos (Backtracking)](#10-suma-de-subconjuntos-backtracking)

---

## 1. Rotación de Arreglo

**Archivo:** `ej1-rotacion-arreglo/Program.cs`

Rota un arreglo de enteros a la derecha un número dado de posiciones.  
**Cómo funciona:**  
Utiliza inversión de segmentos para rotar el arreglo eficientemente.

---

## 2. Subarreglo con Suma Máxima

**Archivo:** `ej2-subarreglo-suma-max/Program.cs`

Encuentra el subarreglo contiguo con la suma máxima (algoritmo de Kadane).  
**Cómo funciona:**  
Recorre el arreglo acumulando sumas y reinicia cuando la suma es negativa, guardando el mejor resultado.

---

## 3. Eliminar Duplicados de un Arreglo

**Archivo:** `ej3-eliminar-duplicados/Program.cs`

Elimina los elementos duplicados de un arreglo ordenado.  
**Cómo funciona:**  
Recorre el arreglo y mueve los elementos únicos al inicio, luego imprime solo los únicos.

---

## 4. Encontrar Número Faltante

**Archivo:** `ej4-encontrar-numero-faltante/Program.cs`

Dado un arreglo con números del 1 al n (falta uno), encuentra el número faltante.  
**Cómo funciona:**  
Calcula la suma esperada y la resta de la suma real para hallar el faltante.

---

## 5. Intersección y Diferencia de Dos Arreglos

**Archivo:** `ej5-interaccion-dos-arreglos/Program.cs`

Genera dos arreglos aleatorios y muestra:
- Los números que están en ambos (intersección).
- Los números que están solo en el primero (diferencia).

**Cómo funciona:**  
Usa ciclos anidados y listas auxiliares para comparar y almacenar los resultados.

---

## 6. Matriz Transpuesta

**Archivo:** `ej6-matriz-traspuesta/Program.cs`

Dada una matriz (arreglo bidimensional), encuentra su transpuesta.  
**Cómo funciona:**  
Crea una nueva matriz donde las filas son columnas y viceversa.

---

## 7. Arreglo de Productos Excepto el Índice

**Archivo:** `ej7-arreglo-productos/Program.cs`

Construye un nuevo arreglo donde cada posición contiene el producto de todos los elementos excepto el de esa posición (sin usar división).  
**Cómo funciona:**  
Calcula productos acumulados a la izquierda y derecha de cada índice y los multiplica.

---

## 8. Buscar Elemento en Arreglo Rotado

**Archivo:** `ej8-buscar-elementos/Program.cs`

Implementa búsqueda binaria modificada para encontrar un número en un arreglo rotado y ordenado.  
**Cómo funciona:**  
Determina qué mitad está ordenada y ajusta los límites de búsqueda según el valor objetivo.

---

## 9. Recorrido en Espiral de una Matriz

**Archivo:** `ej9-espiral-matriz/Program.cs`

Recorre e imprime los elementos de una matriz en forma de espiral.  
**Cómo funciona:**  
Usa límites variables para recorrer la matriz por capas desde afuera hacia adentro.

---

## 10. Suma de Subconjuntos (Backtracking)

**Archivo:** `ej10-suma-subconjuntos/Program.cs`

Encuentra todos los subconjuntos de un arreglo cuya suma sea igual a un número objetivo (target), usando backtracking.  
**Cómo funciona:**  
Explora todas las combinaciones posibles sumando elementos y retrocediendo cuando la suma excede el objetivo.

