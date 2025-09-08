# 📘 Práctica 6 - Implementación de Cola en C#

Este proyecto implementa una **cola (Queue)** en C# con un **menú interactivo en consola**.  
Se utiliza la clase `Queue<T>` de la librería estándar y se encapsula en la clase `MyQueue` para añadir más operaciones.

---

## 🎯 Objetivos
- Comprender la estructura de datos **cola (FIFO)**.
- Implementar operaciones básicas y extendidas sobre la cola.
- Aplicar programación orientada a objetos en C#.
- Interactuar con el usuario mediante un **menú en consola**.

---

## 🔹 Estructura del Proyecto

### `Program.cs`
Contiene el menú principal donde el usuario puede seleccionar operaciones a realizar sobre la cola.

Operaciones disponibles:
1. **Mostrar COLA**
2. **Insertar (Enqueue)**
3. **Eliminar (Dequeue)**
4. **Ver frente (Peek)**
5. **Verificar si está vacía**
6. **Verificar si está llena**
7. **Tamaño de la COLA**
8. **Vaciar COLA**
9. **Buscar elemento**
0. **Salir**

---

### `MyQueue.cs`
Clase que encapsula la funcionalidad de la cola y agrega control de **capacidad máxima**.

**Métodos implementados:**
- `Insertar(int elemento)` → Inserta un elemento si no está llena.
- `Eliminar()` → Elimina y retorna el primer elemento.
- `VerFrente()` → Retorna el elemento del frente sin eliminarlo.
- `Tamaño()` → Devuelve la cantidad de elementos.
- `EstaVacia()` → Indica si la cola está vacía.
- `EstaLlena()` → Indica si la cola alcanzó su capacidad.
- `Vaciar()` → Elimina todos los elementos.
- `Buscar(int elemento)` → Verifica si un elemento existe en la cola.
- `Mostrar()` → Muestra los elementos actuales.

---

## 📌 Ejemplo de Ejecución
Ingrese la capacidad de la cola: 3

===== MENÚ COLA =====

Mostrar COLA

Insertar (Enqueue)

Eliminar (Dequeue)

Ver frente (Peek)

Verificar si está vacía

Verificar si está llena

Tamaño de la COLA

Vaciar COLA

Buscar elemento

Salir
Seleccione una opción: 2
Ingrese número: 10
Se insertó 10 en la cola.

Seleccione una opción: 1
Elementos en la cola:
10

---

## 🛠️ Ejecución en VS Code

1. Crea una carpeta `Practica6`.
2. Dentro de ella guarda:
   - `Program.cs`
   - `MyQueue.cs`
