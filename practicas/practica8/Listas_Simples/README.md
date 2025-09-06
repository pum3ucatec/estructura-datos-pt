# Lista Simple en C#

Este proyecto implementa una **lista simple enlazada** en el lenguaje de programación **C#**, mostrando las operaciones básicas de inserción, recorrido, búsqueda y eliminación de nodos.

---

## 📌 Descripción

Una **lista simple enlazada** es una estructura de datos lineal en la que cada elemento (llamado **nodo**) contiene un valor y una referencia al siguiente nodo en la secuencia.  
A diferencia de los **arrays**, las listas enlazadas no requieren un tamaño fijo, lo que permite un manejo dinámico de memoria.

Este programa contiene:

- **Clase `Nodo`**: Representa un nodo de la lista.
- **Clase `Lista`**: Implementa los métodos principales para manipular la lista.
- **Clase `Program`**: Contiene el método `Main` que ejecuta un ejemplo de uso de la lista.

---

## 🏗️ Estructura del Código

### Clase `Nodo`
```csharp
class Nodo
{
    public int dato;
    public Nodo siguiente;
}
```