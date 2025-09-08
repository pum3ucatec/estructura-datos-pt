using System;

public class Cola
{
    private Nodo? frente;
    private Nodo? final;
    private int cantidad;

    public Cola()
    {
        frente = null;
        final = null;
        cantidad = 0;
    }

    // Propiedad para acceder al frente desde Program.cs
    public Nodo? Front => frente;

    public void Enqueue(string dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (final == null)
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

    public string? Dequeue()
    {
        if (frente == null) return null;

        string valor = frente.Dato;
        frente = frente.Siguiente;

        if (frente == null) final = null;

        cantidad--;
        return valor;
    }

    public string? Peek() => frente?.Dato;

    public string? Last() => final?.Dato;

    public bool Contains(string dato)
    {
        Nodo? actual = frente;
        while (actual != null)
        {
            if (actual.Dato == dato) return true;
            actual = actual.Siguiente;
        }
        return false;
    }

    public int Count() => cantidad;

    public void Clear()
    {
        frente = null;
        final = null;
        cantidad = 0;
    }

    public void View()
    {
        if (frente == null)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(La cola está vacía)");
            Console.ResetColor();
            return;
        }

        Nodo? actual = frente;
        while (actual != null)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("- " + actual.Dato);
            Console.ResetColor();
            actual = actual.Siguiente;
        }
    }

    public bool IsEmpty() => cantidad == 0;

    public int IndexOf(string dato)
    {
        Nodo? actual = frente;
        int posicion = 1;
        while (actual != null)
        {
            if (actual.Dato == dato) return posicion;
            actual = actual.Siguiente;
            posicion++;
        }
        return -1;
    }

    // Eliminar un nombre específico
    public bool Remove(string dato)
    {
        if (frente == null) return false;

        if (frente.Dato == dato)
        {
            Dequeue();
            return true;
        }

        Nodo? actual = frente;
        while (actual.Siguiente != null)
        {
            if (actual.Siguiente.Dato == dato)
            {
                if (actual.Siguiente == final)
                    final = actual;
                actual.Siguiente = actual.Siguiente.Siguiente;
                cantidad--;
                return true;
            }
            actual = actual.Siguiente;
        }
        return false;
    }
}
