using System;

public class ListaSimple
{
    public Nodo Head { get; set; }

    public ListaSimple()
    {
        this.Head = null;
    }

    public void InsertarInicio(string name)
    {
        Nodo nuevoNodo = new Nodo(name);
        nuevoNodo.Next = Head;
        Head = nuevoNodo;
    }

    public void EliminarAlrededor(string name)
{
    if (IsEmpty())
    {
        Console.WriteLine("La lista esta vacia");
        return;
    }

    Nodo actual = Head;
    Nodo anterior = null;
    
    while (actual != null && actual.Name != name)
        {
            anterior = actual;
            actual = actual.Next;
        }

    if (actual == null)
    {
        Console.WriteLine($"El elemento '{name}' no se encontró en la lista.");
        return;
    }

    if (anterior != null)
    {
        Nodo AAnterior = null;
        Nodo current = Head;
        while (current != null && current.Next != actual)
        {
            AAnterior = current;
            current = current.Next;
        }
        if (AAnterior == null)
        {
        
            Head = actual;
        }
        else
        {
            AAnterior.Next = actual;
        }
    }

    if (actual.Next != null)
    {
        actual.Next = actual.Next.Next;
    }
    else
    {
        Console.WriteLine($"No hay nodo siguiente a '{name}' para eliminar.");
    }
}
}

       