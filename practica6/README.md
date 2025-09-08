
# **Guía del programa trabajado**

Acá describire cómo se implementaron los archivos **`MyQueue.cs`** y **`Program.cs`** en C# para resolver la **`Practica 6`** de la cuarta semana del modulo en la materia de Estructura de datos I. Estos archivos contienen la implementación de la estructura de datos **Queue** y el punto de entrada principal del programa.

---

## **1. Descripción General de la Practica 6**

En esta practica se implementa una cola (queue) personalizada en **C#**. La cola es una estructura de datos tipo FIFO (First In, First Out), que significa que el primer elemento en entrar es el primero en salir.

- **`MyQueue.cs`**: Contiene la implementación de la clase `MyQueue`, que es una cola personalizada.
- **`Program.cs`**: Es el archivo que contiene el método `Main`, que es el punto de entrada del programa y donde se interactúa con la clase `MyQueue`.

---

## **2. `MyQueue.cs` - Implementación de la Cola**

El archivo **`MyQueue.cs`** implementa la clase `MyQueue`, que simula el comportamiento de una cola con operaciones como **Enqueue** (agregar un elemento), **Dequeue** (eliminar un elemento) y **Peek** (ver el primer elemento).

### **2.1. Definición de la Clase `MyQueue`**

La clase **`MyQueue`** tiene las siguientes características:

- **`private List<int> queue`**: Una lista interna que se usa para almacenar los elementos de la cola.
- **Métodos**:
  - **`Enqueue(int value)`**: Añade un valor al final de la cola.
  - **`Dequeue()`**: Elimina el primer elemento de la cola.
  - **`Peek()`**: Devuelve el primer elemento de la cola sin eliminarlo.
  - **`IsEmpty()`**: Verifica si la cola está vacía.

#### **Código de `MyQueue.cs`**

```csharp
using System;
using System.Collections.Generic;

public class MyQueue
{
    private List<int> queue;

    public MyQueue()
    {
        queue = new List<int>();
    }

    // Agregar un elemento al final de la cola
    public void Enqueue(int value)
    {
        queue.Add(value);
    }

    // Eliminar el primer elemento de la cola
    public int Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("La cola está vacía.");
        }

        int value = queue[0];
        queue.RemoveAt(0);
        return value;
    }

    // Ver el primer elemento de la cola sin eliminarlo
    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("La cola está vacía.");
        }

        return queue[0];
    }

    // Verificar si la cola está vacía
    public bool IsEmpty()
    {
        return queue.Count == 0;
    }
}
```

### **2.2. Explicación del Código**

- **Constructor `MyQueue()`**: Inicializa la lista vacía que será utilizada para almacenar los elementos de la cola.
  
- **Método `Enqueue(int value)`**: Añade un elemento al final de la cola usando el método `Add()` de la lista.

- **Método `Dequeue()`**: Elimina y retorna el primer elemento de la cola. Si la cola está vacía, lanza una excepción (`InvalidOperationException`).

- **Método `Peek()`**: Retorna el primer elemento de la cola sin eliminarlo. También lanza una excepción si la cola está vacía.

- **Método `IsEmpty()`**: Retorna `true` si la cola está vacía, de lo contrario, retorna `false`.

---

## **3. `Program.cs` - Punto de Entrada del Programa**

El archivo **`Program.cs`** contiene el punto de entrada del programa, que es el método **`Main()`**. Aquí se crean instancias de la clase **`MyQueue`** y se realizan algunas operaciones para demostrar su funcionamiento.

### **3.1. Definición del Método `Main()`**

El método `Main()` hace lo siguiente:

1. Crea una instancia de la clase **`MyQueue`**.
2. Agrega elementos a la cola usando **`Enqueue()`**.
3. Muestra el primer elemento de la cola usando **`Peek()`**.
4. Elimina el primer elemento de la cola usando **`Dequeue()`**.
5. Muestra el estado de la cola tras cada operación.

#### **Código de `Program.cs`**

```csharp
using System;

class Program
{
    static void Main()
    {
        MyQueue queue = new MyQueue();

        // Agregar elementos a la cola
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        // Ver el primer elemento de la cola
        Console.WriteLine("Primer elemento (Peek): " + queue.Peek());

        // Eliminar el primer elemento de la cola
        Console.WriteLine("Elemento eliminado (Dequeue): " + queue.Dequeue());

        // Ver el estado de la cola
        Console.WriteLine("Primer elemento después de Dequeue (Peek): " + queue.Peek());

        // Verificar si la cola está vacía
        Console.WriteLine("¿La cola está vacía? " + queue.IsEmpty());
    }
}
```

### **3.2. Explicación del Código**

1. **Instancia de `MyQueue`**: Se crea un objeto **`queue`** de la clase **`MyQueue`**.
   
2. **Operación `Enqueue()`**: Se agregan tres elementos a la cola (`10`, `20`, `30`).
   
3. **Operación `Peek()`**: Se muestra el primer elemento de la cola sin eliminarlo. En este caso, sería `10`.
   
4. **Operación `Dequeue()`**: Se elimina el primer elemento de la cola. El primer elemento (`10`) se elimina y se muestra en la consola.

5. **Estado después de `Dequeue()`**: Se muestra el nuevo primer elemento de la cola (que es ahora `20` después de que `10` fue eliminado).

6. **Verificación de la cola vacía**: Finalmente, se verifica si la cola está vacía, lo que en este caso no es cierto.

---


