
# Explicación del Proyecto de Colas Dinámicas de la Practica 7

Acá describire cómo se realizo este  proyecto implementando una estructura de datos llamada **Cola Dinámica** en C# para resolver la **`Practica 7`** de la cuarta semana del modulo, para la materia de Estructura de datos I. Donde se aplica una lista enlazada para almacenar los elementos de la cola.

## 1. `Nodo.cs` - Definición de Nodo

El archivo **`Nodo.cs`** define la clase **`Nodo`**, que representa un nodo individual en una lista enlazada. Un nodo contiene el valor de un elemento y una referencia al siguiente nodo.

### Código de `Nodo.cs`

```csharp
public class Nodo
{
    public int Valor; // El valor del nodo
    public Nodo Siguiente; // Referencia al siguiente nodo en la cola

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null; // Inicialmente no tiene siguiente nodo
    }
}
```

### Explicación:
- **Clase `Nodo`**: Cada nodo tiene un valor (de tipo `int` en este caso) y una referencia al siguiente nodo en la cola.
- **Constructor `Nodo(int valor)`**: Este constructor se usa para crear un nodo y asignarle un valor. La referencia al siguiente nodo es inicializada como `null`.

## 2. `Cola.cs` - Implementación de la Cola

El archivo **`Cola.cs`** contiene la implementación de la clase **`Cola`**. Esta clase maneja una cola usando nodos enlazados, donde los elementos se agregan al final de la cola y se eliminan desde el principio.

### Código de `Cola.cs`

```csharp
public class Cola
{
    private Nodo Frente; // Nodo que apunta al primer elemento de la cola
    private Nodo Final;  // Nodo que apunta al último elemento de la cola

    public Cola()
    {
        Frente = null;  // La cola comienza vacía
        Final = null;
    }

    // Agregar un valor al final de la cola
    public void Enqueue(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);  // Creamos un nuevo nodo con el valor

        if (Final != null)
        {
            Final.Siguiente = nuevoNodo;  // El nodo anterior apunta al nuevo nodo
        }
        Final = nuevoNodo; // El nuevo nodo es ahora el último
        if (Frente == null)
        {
            Frente = nuevoNodo;  // Si la cola estaba vacía, el nuevo nodo es el primero
        }
    }

    // Eliminar un elemento del frente de la cola
    public int Dequeue()
    {
        if (Frente == null)
        {
            throw new InvalidOperationException("La cola está vacía");
        }
        int valor = Frente.Valor;  // Guardamos el valor del nodo que será eliminado
        Frente = Frente.Siguiente;  // El siguiente nodo se convierte en el primero
        if (Frente == null)
        {
            Final = null;  // Si la cola queda vacía, el último nodo también debe ser null
        }
        return valor;
    }

    // Ver el primer elemento de la cola sin eliminarlo
    public int Peek()
    {
        if (Frente == null)
        {
            throw new InvalidOperationException("La cola está vacía");
        }
        return Frente.Valor;  // Retornamos el valor del primer nodo
    }

    // Verificar si la cola está vacía
    public bool IsEmpty()
    {
        return Frente == null;  // Si el primer nodo es null, la cola está vacía
    }
}
```

### Explicación:
- **Variables `Frente` y `Final`**: Apuntan respectivamente al primer y último nodo de la cola.
- **Método `Enqueue(int valor)`**: Agrega un valor al final de la cola, creando un nuevo nodo y ajustando las referencias.
- **Método `Dequeue()`**: Elimina y devuelve el primer elemento de la cola, moviendo la referencia del `Frente` al siguiente nodo.
- **Método `Peek()`**: Devuelve el valor del primer elemento de la cola sin eliminarlo.
- **Método `IsEmpty()`**: Verifica si la cola está vacía revisando si el `Frente` es `null`.

## 3. `Program.cs` - Punto de Entrada

El archivo **`Program.cs`** es el punto de entrada del programa. En este archivo se crean instancias de la clase **`Cola`** y se realizan algunas operaciones de ejemplo para mostrar cómo funciona la cola.

### Código de `Program.cs`

```csharp
using System;

class Program
{
    static void Main()
    {
        Cola cola = new Cola();  // Creamos una instancia de la cola

        // Agregamos elementos a la cola
        cola.Enqueue(10);
        cola.Enqueue(20);
        cola.Enqueue(30);

        // Mostramos el primer elemento (Peek)
        Console.WriteLine("Primer elemento (Peek): " + cola.Peek());

        // Eliminamos un elemento (Dequeue)
        Console.WriteLine("Elemento eliminado (Dequeue): " + cola.Dequeue());

        // Mostramos el estado de la cola
        Console.WriteLine("Primer elemento después de Dequeue (Peek): " + cola.Peek());

        // Verificamos si la cola está vacía
        Console.WriteLine("¿La cola está vacía? " + cola.IsEmpty());
    }
}
```

### Explicación:
- **Instancia de `Cola`**: Se crea una nueva instancia de la cola.
- **Operación `Enqueue()`**: Se agregan tres elementos a la cola (10, 20, 30).
- **Operación `Peek()`**: Se muestra el primer elemento de la cola sin eliminarlo.
- **Operación `Dequeue()`**: Se elimina el primer elemento de la cola.
- **Operación `IsEmpty()`**: Se verifica si la cola está vacía.

---

