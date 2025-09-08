# 📘 Búsqueda Recursiva de Elemento en un Arreglo en C#

Este proyecto implementa una función **recursiva** en C# para determinar si un número existe dentro de un arreglo de enteros. El usuario ingresa los elementos del arreglo y el valor a buscar, lo que permite reforzar el aprendizaje interactivo y el manejo de entrada en consola.

---

## 🔍 ¿Qué significa buscar un elemento?

Buscar un elemento en un arreglo consiste en verificar si un valor específico está presente entre sus elementos.

**Ejemplo:**
- Arreglo: [3, 5, 2, 7, 1] 
- Valor buscado: 7 
- Resultado: El número 7 SÍ está en el arreglo.

---

## 🧠 ¿Por qué usar recursividad?

La recursividad permite expresar la búsqueda como:
- Buscar(arr, valor, index) = 
- true si arr[index] == valor 
- false si index >= arr.Length 
- Buscar(arr, valor, index + 1) en otro caso
## 🧪 Ejemplos de ejecución
- ¿Cuántos elementos tendrá el arreglo?: 5
- Elemento 1: 3
- Elemento 2: 5
- Elemento 3: 2
- Elemento 4: 7
- Elemento 5: 1
- Ingresa el número que deseas buscar: 7
- El número 7 SÍ está en el arreglo.
- Ingresa el número que deseas buscar: 9
- El número 9 NO está en el arreglo.


