# Lista Doble en C#

Este proyecto implementa y ejemplifica el uso de una **lista doblemente enlazada** en **C#**, utilizando la clase genérica `LinkedList<T>` incluida en la librería estándar de .NET.

---

## 📌 Descripción

Una **lista doblemente enlazada** es una estructura de datos lineal donde cada nodo contiene un valor y dos referencias:
- **Anterior** → nodo previo en la lista.
- **Siguiente** → nodo siguiente en la lista.

Esto permite recorrer la lista en **ambos sentidos** y realizar inserciones y eliminaciones de manera eficiente.

En este ejemplo, se utiliza la clase **`LinkedList<int>`** para almacenar enteros, mostrando operaciones como agregar, recorrer, eliminar y acceder a elementos.

---

## 🏗️ Estructura del Código

### Creación de la lista
```csharp
LinkedList<int> listaDoble = new LinkedList<int>();
```