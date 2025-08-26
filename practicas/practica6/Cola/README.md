# 🧠 Cola Circular en C# (`MyQueue`)

Este proyecto contiene una implementación personalizada de una **cola circular** usando un arreglo (`char[]`).  
Permite realizar 9 operaciones básicas: insertar, eliminar, ver el frente, mostrar todos los elementos, verificar si está vacía o llena, contar elementos, ver tamaño máximo y buscar un valor.

---

## 📄 MyQueue.cs

```csharp
using System;

/// <summary>
/// Clase que implementa una cola circular de tipo char.
/// Permite insertar, eliminar, ver el frente, buscar y otras operaciones básicas.
/// </summary>
public class MyQueue
{
    private char[] Elements; // Arreglo que almacena los elementos de la cola
    private int Size;        // Tamaño máximo de la cola
    private int Front;       // Índice del frente de la cola
    private int Rear;        // Índice del final de la cola
    private int Count;       // Cantidad actual de elementos

    /// <summary>
    /// Constructor que inicializa la cola con un tamaño fijo.
    /// </summary>
    public MyQueue(int N)
    {
        this.Elements = new char[N];
        this.Size = N;
        this.Front = 0;
        this.Rear = -1;
        this.Count = 0;
    }

    /// <summary>
    /// Inserta un nuevo elemento al final de la cola.
    /// </summary>
    public void Enqueue(char valor)
    {
        if (IsFull())
        {
            Console.WriteLine("La cola está llena.");
            return;
        }

        Rear = (Rear + 1) % Size; // Movimiento circular
        Elements[Rear] = valor;
        Count++;
        Console.WriteLine($"Se insertó: {valor}");
    }

    /// <summary>
    /// Elimina el elemento del frente de la cola.
    /// </summary>
    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        char valor = Elements[Front];
        Front = (Front + 1) % Size; // Movimiento circular
        Count--;
        Console.WriteLine($"Se eliminó: {valor}");
    }

    /// <summary>
    /// Devuelve el elemento al frente sin eliminarlo.
    /// </summary>
    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return '\0'; // Carácter nulo como indicador de error
        }

        return Elements[Front];
    }

    /// <summary>
    /// Verifica si la cola está vacía.
    /// </summary>
    public bool IsEmpty()
    {
        return Count == 0;
    }

    /// <summary>
    /// Verifica si la cola está llena.
    /// </summary>
    public bool IsFull()
    {
        return Count == Size;
    }

    /// <summary>
    /// Retorna la cantidad de elementos actualmente en la cola.
    /// </summary>
    public int GetCount()
    {
        return Count;
    }

    /// <summary>
    /// Retorna el tamaño máximo de la cola.
    /// </summary>
    public int GetSize()
    {
        return Size;
    }

    /// <summary>
    /// Busca un valor específico en la cola.
    /// </summary>
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

    /// <summary>
    /// Muestra los elementos actuales de la cola en orden.
    /// </summary>
    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
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


## 🧪 Program.cs

```csharp

using System;

/// Clase principal con menú interactivo para manipular una cola tipo char
/// implementada con una clase personalizada (MyQueue). 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el tamaño máximo de la cola: ");
        if (!int.TryParse(Console.ReadLine(), out int tamano) || tamano <= 0)
        {
            Console.WriteLine("Tamaño inválido.");
            return;
        }

        MyQueue cola = new MyQueue(tamano);
        int opcion;

        // Menú de operaciones sobre la cola
        do
        {
            Console.WriteLine("\n===== MENÚ COLA (MyQueue) =====");
            Console.WriteLine("1. Mostrar cola");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Ver número de elementos (Count)");
            Console.WriteLine("7. Ver tamaño de la cola (Size)");
            Console.WriteLine("8. Buscar elemento (Contains)");
            Console.WriteLine("9. Verificar si está llena (IsFull)");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    cola.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese el carácter a insertar: ");
                    string entrada = Console.ReadLine();
                    if (!string.IsNullOrEmpty(entrada) && entrada.Length == 1)
                    {
                        cola.Enqueue(entrada[0]);
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Ingrese solo un carácter.");
                    }
                    break;
                case 3:
                    cola.Dequeue();
                    break;
                case 4:
                    char frente = cola.Peek();
                    if (frente != '\0')
                        Console.WriteLine($"Elemento en el frente: {frente}");
                    break;
                case 5:
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola NO está vacía.");
                    break;
                case 6:
                    Console.WriteLine($"Cantidad de elementos: {cola.GetCount()}");
                    break;
                case 7:
                    Console.WriteLine($"Tamaño máximo de la cola: {cola.GetSize()}");
                    break;
                case 8:
                    Console.Write("Ingrese el carácter a buscar: ");
                    string buscar = Console.ReadLine();
                    if (!string.IsNullOrEmpty(buscar) && buscar.Length == 1)
                    {
                        Console.WriteLine(cola.Contains(buscar[0]) ? "El valor está en la cola." : "El valor NO está en la cola.");
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                    break;
                case 9:
                    Console.WriteLine(cola.IsFull() ? "La cola está llena." : "La cola NO está llena.");
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}

