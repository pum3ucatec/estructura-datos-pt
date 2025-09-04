using System;

public class Cola
{
    private Nodo Front;
    private Nodo Rear;

    public Cola()
    {
        Front = null;
        Rear = null;
    }

    // Insertar (Enqueue)
    public void Enqueue(string value)
    {
        Nodo nuevo = new Nodo(value);
        if (Rear == null)
        {
            Front = Rear = nuevo;
        }
        else
        {
            Rear.Next = nuevo;
            Rear = nuevo;
        }
    }

    // Eliminar (Dequeue)
    public string Dequeue()
    {
        if (IsEmpty()) return null;

        string value = Front.Value;
        Front = Front.Next;

        if (Front == null) Rear = null;

        return value;
    }

    // Ver frente (Peek)
    public string Peek()
    {
        return IsEmpty() ? null : Front.Value;
    }

    // ¿Vacía?
    public bool IsEmpty()
    {
        return Front == null;
    }

    // Contar
    public int Count()
    {
        int count = 0;
        Nodo actual = Front;
        while (actual != null)
        {
            count++;
            actual = actual.Next;
        }
        return count;
    }

    // Buscar un elemento
    public bool Contains(string value)
    {
        Nodo actual = Front;
        while (actual != null)
        {
            if (actual.Value == value) return true;
            actual = actual.Next;
        }
        return false;
    }

    // Limpiar
    public void Clear()
    {
        Front = Rear = null;
    }

    // Mostrar cola
    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Console.Write("Cola: ");
        Nodo actual = Front;
        while (actual != null)
        {
            Console.Write($"{actual.Value} ");
            actual = actual.Next;
        }
        Console.WriteLine();
    }
}
