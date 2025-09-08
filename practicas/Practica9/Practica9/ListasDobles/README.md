# 🔁 Lista Doblemente Enlazada en C#

Este proyecto es una aplicación de consola que implementa una **lista doblemente enlazada** para almacenar nombres. A diferencia de una lista simple, esta estructura permite recorrer los elementos tanto hacia adelante como hacia atrás.

---

## 🎯 Objetivo del programa

- Agregar nombres al final de la lista.
- Mostrar los nombres desde el inicio hasta el final.
- Mostrar los nombres desde el final hasta el inicio.
- Salir del programa.

---

## 🧠 ¿Qué es una lista doblemente enlazada?

Es una estructura de datos donde cada nodo tiene:
- Un campo de datos (`nombre`).
- Un puntero al siguiente nodo (`siguiente`).
- Un puntero al nodo anterior (`anterior`).

Esto permite recorrer la lista en ambos sentidos, lo que la hace útil para aplicaciones como navegadores, editores de texto, o sistemas de historial.

---

## 🧱 Estructura del código

### Clase `Nodo`
```csharp
class Nodo {
    public string nombre;
    public Nodo siguiente;
    public Nodo anterior;
}
