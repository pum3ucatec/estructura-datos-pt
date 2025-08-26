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

    // Insertar elemento al final de la cola
    public void Enqueue(char valor)
    {
        if (Count == Size)
        {
            Console.WriteLine("La cola está llena.");
            return;
        }
        Rear = (Rear + 1) % Size;  // Cola circular
        Elements[Rear] = valor;
        Count++;
        Console.WriteLine($"Se insertó: {valor}");
    }

    // Eliminar elemento del frente de la cola
    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }
        char valor = Elements[Front];
        Front = (Front + 1) % Size;  // Cola circular
        Count--;
        Console.WriteLine($"Se eliminó: {valor}");
    }

    // Ver el elemento en el frente sin eliminarlo
    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return '\0';
        }
        return Elements[Front];
    }

    // Verificar si la cola está vacía
    public bool IsEmpty()
    {
        return Count == 0;
    }

    // Mostrar todos los elementos en orden
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

