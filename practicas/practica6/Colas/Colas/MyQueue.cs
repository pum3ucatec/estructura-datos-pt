class MyQueue
{
    private char[] elementos;
    private int frente;
    private int final;
    private int count;

    public MyQueue(int tamaño)
    {
        elementos = new char[tamaño];
        frente = 0;
        final = -1;
        count = 0;
    }

    public void Enqueue(char item)
    {
        if (IsFull())
        {
            Console.WriteLine("La cola está llena. No se puede insertar.");
            return;
        }
        final = (final + 1) % elementos.Length;
        elementos[final] = item;
        count++;
        Console.WriteLine($"Elemento '{item}' insertado correctamente.");
    }

    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía. No se puede eliminar.");
            return;
        }
        char eliminado = elementos[frente];
        frente = (frente + 1) % elementos.Length;
        count--;
        Console.WriteLine($"Elemento '{eliminado}' eliminado correctamente.");
    }

    public char Peek()
    {
        return IsEmpty() ? ' ' : elementos[frente];
    }

    public char GetRear()
    {
        return IsEmpty() ? ' ' : elementos[final];
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public bool IsFull()
    {
        return count == elementos.Length;
    }

    public int Contains(char item)
    {
        for (int i = 0; i < count; i++)
        {
            int index = (frente + i) % elementos.Length;
            if (elementos[index] == item)
                return index;
        }
        return -1;
    }

    public int GetCount()
    {
        return count;
    }

    public int GetSize()
    {
        return elementos.Length;
    }

    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }
        Console.Write("Cola: ");
        for (int i = 0; i < count; i++)
        {
            int index = (frente + i) % elementos.Length;
            Console.Write(elementos[index] + " ");
        }
        Console.WriteLine();
    }
}

