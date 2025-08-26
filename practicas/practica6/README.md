# Práctica 6 – Cola Circular en C#

Este proyecto implementa una **cola circular (Queue)** en C# con un **menú interactivo** en consola.  
Permite insertar, eliminar, buscar y mostrar elementos dentro de la cola, además de consultar su capacidad y estado.

---

## Archivos del proyecto

- `MyQueue.cs` → Clase que implementa la **cola circular**.
- `Program.cs` → Programa principal con un **menú interactivo**.
- `practica6.csproj` → Archivo de configuración del proyecto .NET.

---

##  Funcionalidades

### Métodos principales en `MyQueue`
- `Enqueue(char value)` → Agregar un elemento a la cola.  
- `Dequeue()` → Eliminar y devolver el primer elemento.  
- `Peek()` → Consultar el primer elemento sin eliminarlo.  
- `Count()` → Número de elementos almacenados.  
- `Length()` → Capacidad máxima de la cola.  
- `Contains(char value)` → Verificar si existe un elemento.  
- `IsEmpty()` → Indica si la cola está vacía.  
- `IsFull()` → Indica si la cola está llena.  
- `Show()` → Muestra los elementos actuales de la cola.

---

##  Menú del programa (`Program.cs`)

Al ejecutar, se muestra un menú como este:

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

0. Salir

---

## Cómo ejecutar

1. Entrar a la carpeta del proyecto:
   ```bash
   cd practicas/practica6
2. Ejecutar con .NET:
dotnet run
## Ejemplo de uso

===== CONFIGURACIÓN DE LA COLA =====
Ingrese el tamaño máximo de la cola: 3

===== MENÚ DE LA COLA =====
1. Mostrar Cola
2. Agregar (Enqueue)
3. Eliminar (Dequeue)
...
Elija una opción: 2
Ingrese un carácter a agregar: A
'A' agregado a la cola.

Elija una opción: 2
Ingrese un carácter a agregar: B
'B' agregado a la cola.

Elija una opción: 1
Cola: A B
