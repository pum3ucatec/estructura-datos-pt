# ColaNodo (Queue with Nodes)

This repository contains a C# console application that implements a **queue** data structure using **linked nodes**. The application provides a simple menu for users to perform common queue operations.

## Features

The program allows you to manage a queue of strings with the following functionalities:

* **Insert (Enqueue):** Add a new element to the back of the queue.
* **Remove (Dequeue):** Remove the element from the front of the queue.
* **View Front (Peek):** See the element at the front of the queue without removing it.
* **Show All:** Display all elements currently in the queue.
* **Check if Empty:** Verify if the queue contains any elements.
* **Count Elements:** Show the total number of elements in the queue.
* **Clear:** Empty the entire queue.
* **Search:** Find a specific element within the queue.
* **Remove Specific Element:** Delete a specific element by its value, regardless of its position.

## Project Structure

* `Program.cs`: Contains the main entry point of the application and the user interface logic. It presents the menu and handles user input to call the appropriate queue methods.
* `Cola.cs`: Defines the `Cola` class, which is the core implementation of the queue data structure. It manages the `Front` and `Rear` nodes and provides methods for all the queue operations.
* `Nodo.cs`: Defines the `Nodo` (Node) class. This is the basic building block of the linked list that the queue is built on. Each `Nodo` holds a string value (`Name`) and a reference to the next `Nodo` in the sequence.

## How to Run

1.  Make sure you have the .NET SDK installed on your system.
2.  Clone or download this repository.
3.  Open a terminal or command prompt and navigate to the project directory.
4.  Run the application using the following command:

    ```bash
    dotnet run
    ```

5.  The interactive menu will appear, and you can start performing queue operations.

## Example Usage

When you run the program, you will see a menu like this:

```
===== MENÚ COLA =====
1. Mostrar cola
2. Insertar (Enqueue)
3. Eliminar (Dequeue)
4. Ver frente (Peek)
5. Verificar si está vacía
6. Contar elementos
7. Limpiar cola
8. Buscar elemento
9. Eliminar elemento específico
0. Salir
Seleccione una opción: 2
Ingrese el nombre a insertar: Juan
Se insertó Juan en la cola.

===== MENÚ COLA =====
Seleccione una opción: 2
Ingrese el nombre a insertar: María
Se insertó María en la cola.

===== MENÚ COLA =====
Seleccione una opción: 1

Elementos en la cola:
Juan
María

===== MENÚ COLA =====
Seleccione una opción: 4
Elemento en el frente: Juan

===== MENÚ COLA =====
Seleccione una opción: 3
Se eliminó Juan de la cola.

===== MENÚ COLA =====
Seleccione una opción: 5
La cola NO está vacía.

===== MENÚ COLA =====
Seleccione una opción: 0
Saliendo del programa...
```     