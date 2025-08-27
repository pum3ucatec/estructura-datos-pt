
using System;

public class MyQueue
{
    private char[] Elements; // Arreglo que guarda los elementos de la cola
    private int Size;        // Tamaño máximo de la cola
    private int Front;       // Índice del frente
    private int Rear;        // Índice del final
    private int Count;       // Cantidad de elementos actuales

    // Constructor: inicializa la cola con tamaño N
    public MyQueue(int N)
    {
        Elements = new char[N];
        Size = N;
        Front = 0;
        Rear = -1;
        Count = 0;

        // Inicializar todos los elementos con espacio vacío
        for (int i = 0; i < N; i++)
            Elements[i] = ' ';
    }

    // Inserta un elemento al final de la cola (Enqueue)
    public void Enqueue(char elemento)
    {
        if (IsFull())
        {
            Console.WriteLine(" Error: La cola está llena. No se puede insertar.");
            return;
        }

        Rear = (Rear + 1) % Size; // Índice circular
        Elements[Rear] = elemento;
        Count++;

        Console.WriteLine($" Elemento '{elemento}' insertado correctamente.");
    }

    // Elimina el elemento del frente de la cola (Dequeue)
    public char Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine(" Error: La cola está vacía. No se puede eliminar.");
            return ' ';
        }

        char elementoEliminado = Elements[Front];
        Elements[Front] = ' '; // Limpia la posición
        Front = (Front + 1) % Size;
        Count--;

        Console.WriteLine($" Elemento '{elementoEliminado}' eliminado correctamente.");
        return elementoEliminado;
    }

    // Devuelve el elemento al frente sin eliminarlo
    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine(" La cola está vacía.");
            return ' ';
        }
        return Elements[Front];
    }

    // Devuelve el elemento al final de la cola
    public char GetRear()
    {
        if (IsEmpty())
        {
            Console.WriteLine(" La cola está vacía.");
            return ' ';
        }
        return Elements[Rear];
    }

    // Verifica si la cola está vacía
    public bool IsEmpty() => Count == 0;

    // Verifica si la cola está llena
    public bool IsFull() => Count == Size;

    // Busca un elemento y devuelve su posición, -1 si no lo encuentra
    public int Contains(char elemento)
    {
        for (int i = 0; i < Count; i++)
        {
            int index = (Front + i) % Size;
            if (Elements[index] == elemento)
                return index;
        }
        return -1;
    }

    // Devuelve el tamaño máximo de la cola
    public int GetSize() => Size;

    // Devuelve la cantidad actual de elementos
    public int GetCount() => Count;

    // Muestra el estado completo de la cola
    public void Mostrar()
    {
        Console.WriteLine("\n=== ESTADO DE LA COLA ===");
        Console.WriteLine($"Tamaño máximo: {Size}");
        Console.WriteLine($"Elementos actuales: {Count}");
        Console.WriteLine($"Espacios libres: {Size - Count}");
        Console.WriteLine($"Frente: {Front}");
        Console.WriteLine($"Final: {Rear}");
        Console.WriteLine($"¿Está vacía? {IsEmpty()}");
        Console.WriteLine($"¿Está llena? {IsFull()}");

        Console.WriteLine("\nElementos en la cola:");
        for (int i = 0; i < Size; i++)
        {
            if (i == Front && i == Rear)
                Console.Write($"[F/R:{Elements[i]}] ");
            else if (i == Front)
                Console.Write($"[F:{Elements[i]}] ");
            else if (i == Rear)
                Console.Write($"[R:{Elements[i]}] ");
            else
                Console.Write($"[{Elements[i]}] ");
        }
        Console.WriteLine();
    }
}
