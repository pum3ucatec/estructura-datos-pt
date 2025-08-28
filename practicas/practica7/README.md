
# COLAS DINAMICAS

## Descripción
Este proyecto implementa una **estructura de datos tipo Cola** en C# utilizando nodos enlazados.  
Permite almacenar elementos de manera ordenada y procesarlos siguiendo el orden **FIFO** (First In, First Out).

---

## Clases Principales

### 1. `Nodo`
- Representa un nodo dentro de la cola.
- Propiedades:
  - `Name` → valor del nodo (string).
  - `Next` → referencia al siguiente nodo en la cola.
- Constructor: inicializa el nodo con un valor y `Next` en null.

### 2. `Cola`
- Implementa la lógica de la cola enlazada.
- Propiedades:
  - `Front` → nodo al frente de la cola.
  - `Rear` → nodo al final de la cola.
- Métodos principales:
  - `Enqueue(string name)` → inserta un nodo al final de la cola.
  - `Dequeue()` → elimina y devuelve el nodo del frente.
  - `Peek()` → devuelve el nodo del frente sin eliminarlo.
  - `IsEmpty()` → verifica si la cola está vacía.
  - `Count()` → devuelve la cantidad de elementos.
  - `Clear()` → vacía la cola.
  - `Contains(string name)` → verifica si un elemento existe.
  - `View()` → muestra todos los elementos de la cola.

### 3. `Principal` (Clase Main)
- Contiene el método `Main()` para interactuar con la cola.
- Funcionalidades:
  - Crear la cola con un tamaño definido.
  - Menú interactivo con opciones para:
    1. Mostrar la cola
    2. Insertar elemento
    3. Eliminar elemento
    4. Ver el primer elemento
    5. Ver cantidad de elementos
    6. Ver capacidad máxima
    7. Buscar un elemento
    8. Verificar si la cola está vacía
    9. Verificar si la cola está llena
    0. Salir del programa

---

