# Implementación de las COLAS en C#

El presente programa tiene por objetivo implementar una cola (queue) en C#.

Mediante la creación de 2 clases, y su respectiva herencia, se podrá implementar esta cola interactiva con el usuario. Estas clases son una MyQueue.cs, la cual contiene las operaciones básicas de una cola, y el program.cs con el menú interactivo para estas operaciones.


## 1. Desarrollo del programa


### 1.1. MyQueue.cs

Este define las operaciones de la cola.

``` c sharp
using System;

public class MyQueue
{
    private char[] Elements;
    private int Size;
    private int Front;
    private int Rear;
    private int Count;

    public MyQueue(int N)
    {
        this.Elements = new char[N];
        this.Size = N;
        this.Front = 0;
        this.Rear = -1;
        this.Count = 0;
    }

    public void Enqueue(char valor)
    {
        if (IsFull())
        {
            Console.WriteLine("La cola está LLENA.");
            return;
        }
        Rear = (Rear + 1) % Size;
        Elements[Rear] = valor;
        Count++;
        Console.WriteLine($"Se ha introducido el valor: {valor}");
    }

    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está VACÍA.");
            return;
        }
        char valor = Elements[Front];
        Front = (Front + 1) % Size;
        Count--;
        Console.WriteLine($"Se ha eliminado el valor: {valor}");
    }

    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está VACÍA.");
            return '\0';
        }
        return Elements[Front];
    }

    public bool IsEmpty()
    {
        return Count == 0;
    }

    public bool IsFull()
    {
        return Count == Size;
    }

    public int GetCount()
    {
        return Count;
    }

    public int GetSize()
    {
        return Size;
    }

    public bool Contains(char valor)
    {
        for (int i = 0; i < Count; i++)
        {
            int index = (Front + i) % Size;
            if (Elements[index] == valor)
                return true;
        }
        return false;
    }

    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola actualmente está VACIA.");
            return;
        }
        Console.WriteLine("\nElementos en la cola:");
        for (int i = 0; i < Count; i++)
        {
            int index = (Front + i) % Size;
            Console.Write($"{Elements[index]} ");
        }
        Console.WriteLine();
    }
}
```

- **Atributos usados:**
	- **Elements** : Arreglo donde se guardan los elementos.
	- **Size** : Tamaño maximo de la cola.
	- **Front** : Indice del primer elemento.
	- **Rear** : Indice del ultimo elemento.
	- **Count** : Cantidad de elementos en la cola.

- **Operaciones:**

	- **Enqueue:** : Inserta un elemento al final de la cola.
	- **Dequeue:** : Elimina el elemento en el frente de la cola.
	- **Peek:** : Devuelve el elemento en el frente de la cola sin eliminarlo.
	- **Count:** : Devuelve la cantidad de elementos almacenados actualmente en la cola.
	- **Size:** : Devuelve la capacidad maxima de la cola.
	- **Contains:** : Verifica si un elemento existe dentro de la cola.
	- **IsEmpty:** : Verifica si la cola esta vacia.
	- **IsFull:** : Verifica si la cola esta llena.
	- **Mostrar:** : Muestra todos los elementos de la cola en orden.

### 1.2. Program.cs

Contiene el programa principal, y el menú a mostrar en consola.

- **Flujo del programa:**

Al iniciar, el usuario define el tamaño maximo de la cola.
```text
Ingrese el tamaño máximo de la cola.
```
El menú mostrado será el sgte.

```text
===== MENÚ COLA  =====
1. Mostrar cola
2. Insertar (Enqueue)
3. Eliminar (Dequeue)
4. Ver frente (Peek)
5. Verificar si está vacía (IsEmpty)
6. Ver número de elementos (Count)
7. Ver tamaño de la cola (Size)
8. Buscar elemento en la cola (Contains)
9. Verificar si la coal está llena (IsFull)
0. Salir
```
Cada opción muestra una operación determinada de la cola, definidas en el archivo MyQueue.cs.


	