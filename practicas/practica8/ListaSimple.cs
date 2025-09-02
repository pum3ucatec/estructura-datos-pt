using System;

public class ListaSimple
{
    private Nodo cabeza;
    private int CountElements;

    public ListaSimple()
    {
        cabeza = null;
        CountElements = 0;
    }

    public void Insertar(string name)
    {
        Nodo nodo = new Nodo(name);
        if (cabeza == null)
        {
            cabeza = nodo;
        }
        else
        {
            Nodo current = cabeza;
            while (current.Next != null)
                current = current.Next;
            current.Next = nodo;
        }
        CountElements++;
    }

    public string EliminarPrimero()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return null;
        }
        string valor = cabeza.Name;
        cabeza = cabeza.Next;
        CountElements--;
        return valor;
    }

    public string EliminarEn(int posicion)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return null;
        }

        if (posicion < 1 || posicion > CountElements)
        {
            Console.WriteLine("Posición inválida.");
            return null;
        }

        Nodo current = cabeza;
        string valor;

        if (posicion == 1)
        {
            return EliminarPrimero();
        }

        Nodo prev = null;
        int index = 1;
        while (index < posicion)
        {
            prev = current;
            current = current.Next;
            index++;
        }

        valor = current.Name;
        prev.Next = current.Next;
        CountElements--;
        return valor;
    }

    public string VerPrimero()
    {
        return cabeza != null ? cabeza.Name : null;
    }

    public int Buscar(string name)
    {
        Nodo current = cabeza;
        int posicion = 1;
        while (current != null)
        {
            if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                return posicion;
            current = current.Next;
            posicion++;
        }
        return -1;
    }

    public bool Contiene(string name)
    {
        return Buscar(name) != -1;
    }

    public void Vaciar()
    {
        cabeza = null;
        CountElements = 0;
    }

    public void Mostrar()
    {
        Nodo current = cabeza;
        if (current == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Console.WriteLine("Nombres en la lista:");
        while (current != null)
        {
            Console.Write($"| {current.Name} ");
            current = current.Next;
        }
        Console.WriteLine("|");
    }

    public int Count()
    {
        return CountElements;
    }

    public bool EstaVacia()
    {
        return cabeza == null;
    }
}