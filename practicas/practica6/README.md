# 📌 Práctica 6 – Implementación de Cola en C#

Este proyecto consiste en la implementación de una **estructura de datos Cola (Queue)** utilizando el lenguaje C#.  
Se desarrolla un programa con menú interactivo y una clase que gestiona la cola mediante un arreglo.

---

## 🔹 Program.cs
Este archivo contiene el **programa principal** que muestra un menú en consola para interactuar con la cola.  
Permite al usuario:

1. **Mostrar Cola** → Visualiza los elementos de la cola.  
2. **Agregar (Enqueue)** → Inserta un carácter al final de la cola.  
3. **Eliminar (Dequeue)** → Elimina el primer elemento de la cola.  
4. **Ver primer elemento (Peek)** → Muestra el primer valor sin eliminarlo.  
5. **Cantidad de elementos (Count)** → Devuelve cuántos elementos hay en la cola.  
6. **Capacidad de la cola (Size)** → Muestra la capacidad máxima definida.  
7. **Buscar un elemento (Contains)** → Verifica si un valor existe en la cola.  
8. **Verificar si está vacía (IsEmpty)** → Comprueba si la cola no tiene elementos.  
9. **Verificar si está llena (IsFull)** → Comprueba si ya no se pueden agregar más elementos.  
0. **Salir** → Finaliza la ejecución del programa.  

El usuario define el tamaño de la cola al inicio y luego puede utilizar todas las opciones del menú.

---

## 🔹 MyQueue.cs
Este archivo implementa la **clase MyQueue**, que define cómo funciona la cola.  
Características principales:

- **Atributos**:  
  - Un arreglo de caracteres para almacenar los elementos.  
  - Variables `front`, `rear` y `count` para manejar la posición de los elementos.  

- **Métodos principales**:  
  - `Enqueue(char)` → Inserta un elemento.  
  - `Dequeue()` → Elimina el primer elemento.  
  - `Peek()` → Muestra el primer elemento sin eliminarlo.  
  - `Count()` → Retorna el número de elementos actuales.  
  - `Length()` → Retorna la capacidad máxima.  
  - `Contains(char)` → Busca un elemento dentro de la cola.  
  - `IsEmpty()` → Indica si la cola está vacía.  
  - `IsFull()` → Indica si la cola está llena.  
  - `Show()` → Muestra gráficamente el contenido de la cola.  

---

## 🔹 Ejemplo de ejecución

Al ejecutar el programa, se pedirá primero el tamaño de la cola y luego se mostrará el menú de opciones.

===== CONFIGURACIÓN DE LA COLA =====
Ingrese el tamaño máximo de la cola: 5
===== MENÚ DE LA COLA =====
1. Mostrar Cola
2. Agregar (Enqueue)
3. Eliminar (Dequeue)
4. Ver primer elemento (Peek)
5. Cantidad de elementos (Count)
6. Capacidad de la cola (Size)
7. Buscar un elemento (Contains)
8. Verificar si está vacía (IsEmpty)
9. Verificar si está llena (IsFull)
0. alir
Elija una opción: 2
Ingrese un carácter a agregar: A
'A' agregado a la cola.

===== MENÚ DE LA COLA =====
Mostrar Cola
Agregar (Enqueue)
Eliminar (Dequeue)
...
Elija una opción: 2
Ingrese un carácter a agregar: B
'B' agregado a la cola.
===== MENÚ DE LA COLA =====
Mostrar Cola
...
Elija una opción: 1
Cola: A B

===== MENÚ DE LA COLA =====
Elija una opción: 4
Frente de la cola: A

===== MENÚ DE LA COLA =====
Elija una opción: 3
'A' eliminado de la cola.

===== MENÚ DE LA COLA =====
Elija una opción: 1
Cola: B

---

## 📌 Conclusión
Este proyecto permite comprender el funcionamiento de una **cola circular implementada con arreglos** en C#.  
El archivo `Program.cs` gestiona la interacción con el usuario mediante un menú, mientras que `MyQueue.cs` contiene toda la lógica de la estructura de datos.

📌 **Autor:** *Ramos Patrick*  
📌 **Materia:** *Estructura de Datos – Práctica 6*
