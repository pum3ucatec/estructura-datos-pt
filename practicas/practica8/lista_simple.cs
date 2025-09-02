using System;

public class ListaSimple
{
    private Nodo cabeza;
    private int count;

    public ListaSimple()
    {
        cabeza = null;
        count = 0;
    }

    public void InsertarInicio(string dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.Next = cabeza;
        cabeza = nuevo;
        count++;
    }

    public void InsertarFinal(string dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Next != null)
                actual = actual.Next;
            actual.Next = nuevo;
        }
        count++;
    }

    public void Eliminar(string dato)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (cabeza.Name == dato)
        {
            cabeza = cabeza.Next;
            count--;
            Console.WriteLine($"Elemento '{dato}' eliminado.");
            return;
        }

        Nodo actual = cabeza;
        while (actual.Next != null && actual.Next.Name != dato)
            actual = actual.Next;

        if (actual.Next != null)
        {
            actual.Next = actual.Next.Next;
            count--;
            Console.WriteLine($"Elemento '{dato}' eliminado.");
        }
        else
        {
            Console.WriteLine($"El elemento '{dato}' no se encontró.");
        }
    }

    public void Mostrar()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo actual = cabeza;
        Console.Write("Lista: ");
        while (actual != null)
        {
            Console.Write($"{actual.Name} -> ");
            actual = actual.Next;
        }
        Console.WriteLine("null");
    }

    public bool Contiene(string dato)
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            if (actual.Name == dato) return true;
            actual = actual.Next;
        }
        return false;
    }

    public int Contar() => count;

    public bool EstaVacia() => cabeza == null;
}
