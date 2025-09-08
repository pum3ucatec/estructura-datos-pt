# Práctica 7: Colas Dinámicas en C#

**Autor:** Edwin Escross  
**Carrera:** Ingeniería de Sistemas  

---

## Descripción

Este proyecto implementa una **cola dinámica** en C# utilizando nodos enlazados. Permite agregar, eliminar y buscar nombres de manera interactiva, mostrando la posición de cada elemento, así como el primero y el último de la fila. La cola es ilimitada y su visualización ayuda a entender cómo se organiza internamente.

---

## Estructura del proyecto

- **Nodo.cs:** Representa cada nodo de la cola con un dato (nombre) y un puntero al siguiente nodo.  
- **Cola.cs:** Implementa la cola dinámica con todas las operaciones principales.  
- **Program.cs:** Contiene el menú interactivo que permite manipular la cola desde la consola.  
- **README.md:** Documentación del proyecto.

---

## Funcionalidades Principales

- **Enqueue:** Agrega un nombre al final de la cola.  
- **Dequeue:** Elimina el primer elemento de la cola.  
- **Remove:** Elimina un nombre específico de la cola.  
- **Peek:** Muestra el primer elemento sin eliminarlo.  
- **Last:** Muestra el último elemento de la cola.  
- **Contains:** Verifica si un nombre existe en la cola.  
- **IndexOf:** Retorna la posición de un nombre en la cola.  
- **Count:** Muestra la cantidad de elementos.  
- **Clear:** Vacía toda la cola.  
- **View:** Muestra todos los elementos con su posición.  
- **IsEmpty:** Verifica si la cola está vacía.

---

## Ejemplo de Uso

1. Agregar nombres a la cola.  
2. Eliminar un nombre específico.  
3. Consultar el primer elemento (Peek).  
4. Ver todos los elementos con posición.  
5. Contar elementos en la cola.  
6. Vaciar la cola completamente (Clear).  
7. Buscar uno o varios nombres mostrando su posición.  
8. Consultar el último elemento de la cola.  

La búsqueda permite ingresar varios nombres separados por comas. Las posiciones comienzan desde 1 (frente de la cola).  

---

## Características

- Cola dinámica sin límite de elementos.  
- Permite agregar, eliminar y buscar nombres fácilmente.  
- Visualización de posición/fila de cada elemento.  
- Búsqueda de múltiples nombres al mismo tiempo.  
- Visualización del primer y último elemento.  
- Menú interactivo y fácil de usar.  
- Código modular y organizado en `Nodo.cs`, `Cola.cs` y `Program.cs`.

---

## Notas sobre C# y referencias nulas

En el código se utilizan nodos y propiedades *nullable*, como `Nodo?`, para permitir referencias a `null`. Esto es útil para:

- Inicializar la cola vacía (`frente = null`).  
- Marcar el final de la cola (`Siguiente = null`).  
- Evitar warnings del compilador y errores en tiempo de ejecución.
