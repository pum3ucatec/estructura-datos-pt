using System;
using System.Collections.Generic;

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
        
        for (int i = 0; i < N; i++)
        {
            Elements[i] = ' ';
        }
    }

    public void Enqueue(char elemento)
    {
        if (IsFull())
        {
            Console.WriteLine("Error: La cola está llena. No se puede insertar.");
            return;
        }

        Rear = (Rear + 1) % Size;
        Elements[Rear] = elemento;
        Count++;
        Console.WriteLine($"Elemento '{elemento}' insertado correctamente.");
    }

    public char Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Error: La cola está vacía. No se puede eliminar.");
            return ' ';
        }

        char elementoEliminado = Elements[Front];
        Elements[Front] = ' ';
        Front = (Front + 1) % Size;
        Count--;
        
        Console.WriteLine($"Elemento '{elementoEliminado}' eliminado correctamente.");
        return elementoEliminado;
    }

    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Error: La cola está vacía.");
            return ' ';
        }
        
        return Elements[Front];
    }

    public char GetRear()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Error: La cola está vacía.");
            return ' ';
        }
        
        return Elements[Rear];
    }

    public bool IsEmpty()
    {
        return Count == 0;
    }

    public bool IsFull()
    {
        return Count == Size;
    }

    public int Contains(char elemento)
    {
        for (int i = 0; i < Count; i++)
        {
            int index = (Front + i) % Size;
            if (Elements[index] == elemento)
            {
                return index; // Devuelve la posición donde se encontró
            }
        }
        return -1; // Devuelve -1 si no se encontró
    }

    public int GetSize()
    {
        return Size;
    }

    public int GetCount()
    {
        return Count;
    }

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