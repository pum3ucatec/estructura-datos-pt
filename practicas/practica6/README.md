# Cola Circular de Caracteres en C#

## Descripción del Proyecto
Este programa en C# es una **cola circular de caracteres**.  
La idea es que el usuario pueda meter y sacar elementos (caracteres) de una cola, y que el sistema lo haga de forma circular (cuando llega al final del arreglo vuelve al inicio).  

Se hizo con un menú para que se pueda interactuar y probar las funciones básicas de una cola.

---

## Funciones que tiene
La clase `MyQueue` trae varios métodos que se pueden usar:

- **Enqueue(char valor):** agrega un elemento al final de la cola. Si ya está llena no deja.
- **Dequeue():** quita el elemento que está primero en la cola. Si está vacía, muestra mensaje.
- **Peek():** solo mira cuál es el primero sin sacarlo.
- **IsEmpty():** revisa si la cola está vacía (true/false).
- **IsFull():** revisa si la cola ya está llena (true/false).
- **GetCount():** cuántos elementos tiene ahora.
- **GetCapacity():** el tamaño máximo que se le dio a la cola.
- **Contains(char valor):** busca si un carácter está dentro de la cola.
- **Mostrar():** enseña en pantalla todos los elementos en orden.

---

## Cómo está hecho
El proyecto tiene dos partes principales:

1. **`MyQueue`** → aquí está toda la lógica de la cola circular, con sus métodos.
2. **`Program`** → es donde está el menú que el usuario ve para poder:
   - agregar y quitar elementos
   - ver el primero
   - ver la cola completa
   - revisar si está llena o vacía
   - buscar un elemento
   - salir del programa

---
