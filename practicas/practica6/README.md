# Practica 6: Colas en C#

## Descripción

Se utiliza una implementación de una **cola (FIFO - First In, First Out)** en C# utilizando un arreglo de caracteres (`char[]`).

Este código permite insertar, eliminar, mostrar y consultar elementos en la cola, además de verificar si está llena o vacía.

---

## Archivos principales

- **MyQueue.cs** → Contiene la clase `MyQueue` con la lógica de la cola.
- **Program.cs** → Contiene el menú de consola que permite interactuar con la cola.

---

## Funcionalidades principales

- **Enqueue(char value)**: Inserta un elemento al final de la cola.
- **Dequeue()**: Elimina y devuelve el elemento al frente de la cola.
- **Peek()**: Devuelve el elemento del frente **sin eliminarlo**.
- **Mostrar()**: Muestra todos los elementos de la cola en orden.
- **CountElements()**: Devuelve la cantidad de elementos actuales.
- **Length()**: Devuelve la capacidad máxima de la cola.
- **Contains(char value)**: Verifica si un valor existe dentro de la cola.
- **IsEmpty()**: Indica si la cola está vacía.
- **IsFull()**: Indica si la cola está llena.

---

## Menú de consola (Program.cs)

Al ejecutar el programa, se despliega un menú con las siguientes opciones:

```
===== MENÚ COLA =====

1. Mostrar COLA

2. Insertar (Enqueue)

3. Eliminar (Dequeue)

4. Ver frente (Peek)

5. Contar elementos (Count)

6. Longitud (Length - Size)

7. Buscar un elemento (Contains)

8. Ver si está vacío (IsEmpty)

9. Ver si está lleno (IsFull)

0. Salir
```

---

El usuario puede elegir una opción y el programa ejecutará la acción correspondiente sobre la cola.

---

## Ejemplo de ejecución

```bash
===== MENÚ COLA =====

1. Mostrar COLA

2. Insertar (Enqueue)

3. Eliminar (Dequeue)
...
Seleccione una opción: 2
Ingrese el elemento a insertar: A
Se insertó A en la cola.
```

---

## Notas

- La implementación actual solo maneja **caracteres (`char`)**, pero puede adaptarse fácilmente a otros tipos de datos.
- Si se intenta **insertar en una cola llena** o **eliminar de una vacía**, el programa muestra un mensaje en consola.
