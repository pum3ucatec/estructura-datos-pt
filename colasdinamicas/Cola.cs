using System;

public class Cola<T>
{
    private Nodo<T> frente;
    private Nodo<T> final;
    private int cantidad;

    public Cola()
    {
        frente = null;
        final = null;
        cantidad = 0;
    }

    // Enqueue
    public void Enqueue(T dato)
    {
        Nodo<T> nuevo = new Nodo<T>(dato);
        if (IsEmpty())
        {
            frente = nuevo;
            final = nuevo;
        }
        else
        {
            final.Siguiente = nuevo;
            final = nuevo;
        }
        cantidad++;
    }

    // Dequeue
    public T Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("⚠️ La cola está vacía.");
            return default(T);
        }

        T valor = frente.Dato;
        frente = frente.Siguiente;
        if (frente == null)
            final = null;

        cantidad--;
        return valor;
    }

    // Peek
    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("⚠️ La cola está vacía.");
            return default(T);
        }
        return frente.Dato;
    }

    // Count
    public int Count()
    {
        return cantidad;
    }

    // View
    public void View()
    {
        if (IsEmpty())
        {
            Console.WriteLine("⚠️ La cola está vacía.");
            return;
        }

        Nodo<T> actual = frente;
        int pos = 1;
        while (actual != null)
        {
            Console.WriteLine($"{pos}. {actual.Dato}");
            actual = actual.Siguiente;
            pos++;
        }
    }

    // IsEmpty
    public bool IsEmpty()
    {
        return cantidad == 0;
    }

    // Clear
    public void Clear()
    {
        frente = null;
        final = null;
        cantidad = 0;
    }

    // Contains
    public bool Contains(T dato)
    {
        Nodo<T> actual = frente;
        while (actual != null)
        {
            if (actual.Dato.Equals(dato))
                return true;
            actual = actual.Siguiente;
        }
        return false;
    }
}
