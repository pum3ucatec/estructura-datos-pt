# 🟢 Práctica 6 – Implementación de Cola Circular en C#

## 📌 Descripción
Este proyecto implementa una **cola circular (queue)** en C# con un tamaño máximo definido y un menú interactivo para probar todas sus operaciones.  

La cola permite manejar datos de manera organizada, agregando elementos al final y eliminando elementos del frente (FIFO – First In First Out).  

**Operaciones disponibles:**
- **Enqueue (Insertar)** ➡️ Agrega un elemento al final de la cola.  
- **Dequeue (Eliminar)** ⬅️ Elimina el elemento que está al frente de la cola.  
- **Peek (Ver frente)** 👀 Muestra el elemento al frente sin eliminarlo.  
- **IsEmpty (Vacía)** ❌ Verifica si la cola está vacía.  
- **IsFull (Llena)** ✅ Verifica si la cola está llena.  
- **Contains (Contiene)** 🔍 Verifica si un elemento específico existe en la cola.  
- **CurrentCount (Tamaño actual)** 📊 Devuelve la cantidad de elementos presentes en la cola.  

El menú interactivo permite al usuario elegir las operaciones de manera repetida hasta seleccionar **0 - Salir**.

---

## 📂 Archivos del proyecto

- `MyQueue.cs`  
  Contiene la clase `MyQueue` que implementa:
  - La estructura interna de la cola (arreglo circular)
  - Métodos `Enqueue`, `Dequeue`, `Peek`, `IsEmpty`, `IsFull`, `Contains`, `CurrentCount`
  - Método `Mostrar()` para imprimir los elementos de la cola  

- `Programa.cs`  
  Contiene el método `Main` y un **menú interactivo** que permite al usuario:
  - Seleccionar opciones mediante números  
  - Ingresar elementos para insertar  
  - Mostrar mensajes claros según la acción realizada  

- `Cola.csproj`  
  Archivo de proyecto de C# necesario para compilar y ejecutar.

---

## 🚀 Cómo ejecutar

1. Abre una terminal en la carpeta del proyecto:

```bash
cd practicas/practica6
