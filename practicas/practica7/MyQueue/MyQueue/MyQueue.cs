using System;

class MyQueue(int tamaño)
{
    private char[] elementos = new char[tamaño];  
    private int frente = 0;       
    private int final = -1;       
    private int count = 0;        
    private int size = tamaño;

    public void Enqueue(char item)
    {
        if (IsFull())
        {
            Console.WriteLine("❌ Error: La cola está llena.");
            return;
        }
        final = (final + 1) % size;
        elementos[final] = item;
        count++;
        Console.WriteLine($"✅ Se insertó '{item}' en la cola.");
    }


    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("❌ Error: La cola está vacía.");
            return;
        }
        Console.WriteLine($"✅ Se eliminó '{elementos[frente]}' de la cola.");
        frente = (frente + 1) % size;
        count--;
    }

    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("❌ La cola está vacía.");
            return ' ';
        }
        return elementos[frente];
    }

    public char GetRear()
    {
        if (IsEmpty())
        {
            Console.WriteLine("❌ La cola está vacía.");
            return ' ';
        }
        return elementos[final];
    }

    public bool IsEmpty()
    {
        return count == 0;
    }


    public bool IsFull()
    {
        return count == size;
    }


    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("❌ La cola está vacía.");
            return;
        }

        Console.Write("📌 Elementos en la cola: ");
        for (int i = 0; i < count; i++)
        {
            int index = (frente + i) % size;
            Console.Write(elementos[index] + " ");
        }
        Console.WriteLine();
    }

    public int Contains(char item)
    {
        for (int i = 0; i < count; i++)
        {
            int index = (frente + i) % size;
            if (elementos[index] == item)
                return i; // posición dentro de la cola
        }
        return -1;
    }

    public int GetCount()
    {
        return count;
    }

    public int GetSize()
    {
        return size;
    }
}
