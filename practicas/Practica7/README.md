# 📘 Descripción del Código – Cola con Nodos en C#

Este proyecto implementa una **cola (Queue) dinámica** utilizando **nodos enlazados** en C#.  

## Interfaz y ejecucion
- **Nodo.cs** → Define la clase `Nodo`, que almacena un dato (`Data`) y una referencia al siguiente nodo (`Next`).  
- **Cola.cs** → Implementa la clase `Cola`, que gestiona los nodos con las operaciones típicas:
    - `Enqueue()` → Inserta un elemento al final.  
    - `Dequeue()` → Elimina y devuelve el primer elemento.  
    - `Peek()` → Muestra el primer elemento sin eliminarlo.  
    - `IsEmpty()` → Verifica si la cola está vacía.  
    - `View()` → Muestra todos los elementos de la cola.  
    - `Contains()` → Busca un valor específico en la cola.  
    - `Clear()` → Vacía toda la cola.  
    - `Count()` → Devuelve la cantidad de elementos.  
- **Program.cs** → Contiene un **menú interactivo** para probar todas las operaciones de la cola.  

## Conclusión
El código permite trabajar con una **cola dinámica** que no depende de un tamaño fijo, usando el principio **FIFO (First In, First Out)** y ofreciendo operaciones adicionales de búsqueda y conteo.
