using System;

public class MyQueue
{
    private char[] Elements;  // arreglo para almacenar
    private int Size;         // capacidad máxima
    private int Front;        // índice del frente
    private int Rear;         // índice del final
    private int Count;        // número actual de elementos

    public MyQueue(int tamaño)
    {
        Elements = new char[tamaño];
        Size = tamaño;
        Front = 0;
        Rear = -1;
        Count = 0;
    }

    // Insertar elemento
    public void Enqueue(char c)
    {
        if (IsFull())
        {
            Console.WriteLine("La cola está llena. No se puede insertar.");
            return;
        }

        Rear = (Rear + 1) % Size;
        Elements[Rear] = c;
        Count++;
    }

    // Eliminar elemento
    public char Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía. No se puede eliminar.");
            return '\0'; // retorno especial
        }

        char value = Elements[Front];
        Front = (Front + 1) % Size;
        Count--;
        return value;
    }

    // Ver primer elemento sin eliminar
    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return '\0';
        }
        return Elements[Front];
    }

    // Mostrar todos los elementos
    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Console.Write("Cola: ");
        for (int i = 0; i < Count; i++)
        {
            int index = (Front + i) % Size;
            Console.Write(Elements[index] + " ");
        }
        Console.WriteLine();
    }

    // Contar elementos actuales
    public int GetCount()
    {
        return Count;
    }

    // Devolver capacidad máxima
    public int GetSize()
    {
        return Size;
    }

    // Verificar si contiene un elemento
    public bool Contains(char c)
    {
        for (int i = 0; i < Count; i++)
        {
            int index = (Front + i) % Size;
            if (Elements[index] == c)
                return true;
        }
        return false;
    }

    // Verificar si está vacía
    public bool IsEmpty()
    {
        return Count == 0;
    }

    // Verificar si está llena
    public bool IsFull()
    {
        return Count == Size;
    }
}
