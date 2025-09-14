using System;

public class ListaDoble
{
    private NodoDoble cabeza;
    private NodoDoble cola;
    private int CountElements;

    public ListaDoble()
    {
        cabeza = null;
        cola = null;
        CountElements = 0;
    }

    // Insertar al final
    public void Insertar(string name)
    {
        NodoDoble nodo = new NodoDoble(name);
        if (cabeza == null)
        {
            cabeza = nodo;
            cola = nodo;
        }
        else
        {
            cola.Next = nodo;
            nodo.Prev = cola;
            cola = nodo;
        }
        CountElements++;
    }

    // Eliminar primero
    public string EliminarPrimero()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return null;
        }

        string valor = cabeza.Name;
        cabeza = cabeza.Next;

        if (cabeza != null)
            cabeza.Prev = null;
        else
            cola = null; // si se borró el último nodo

        CountElements--;
        return valor;
    }

    // Eliminar por posición
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

        if (posicion == 1) return EliminarPrimero();
        if (posicion == CountElements) return EliminarUltimo();

        NodoDoble current = cabeza;
        int index = 1;
        while (index < posicion)
        {
            current = current.Next;
            index++;
        }

        string valor = current.Name;
        current.Prev.Next = current.Next;
        current.Next.Prev = current.Prev;

        CountElements--;
        return valor;
    }

    // Eliminar último
    public string EliminarUltimo()
    {
        if (cola == null)
        {
            Console.WriteLine("La lista está vacía.");
            return null;
        }

        string valor = cola.Name;
        cola = cola.Prev;

        if (cola != null)
            cola.Next = null;
        else
            cabeza = null;

        CountElements--;
        return valor;
    }

    // Ver primer elemento
    public string VerPrimero()
    {
        return cabeza != null ? cabeza.Name : null;
    }

    // Ver último elemento
    public string VerUltimo()
    {
        return cola != null ? cola.Name : null;
    }

    // Buscar
    public int Buscar(string name)
    {
        NodoDoble current = cabeza;
        int pos = 1;
        while (current != null)
        {
            if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                return pos;
            current = current.Next;
            pos++;
        }
        return -1;
    }

    // Verificar existencia
    public bool Contiene(string name)
    {
        return Buscar(name) != -1;
    }

    // Vaciar lista
    public void Vaciar()
    {
        cabeza = null;
        cola = null;
        CountElements = 0;
    }

    // Mostrar de inicio a fin
    public void MostrarAdelante()
    {
        NodoDoble current = cabeza;
        if (current == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Console.WriteLine("Lista de inicio a fin:");
        while (current != null)
        {
            Console.Write($"| {current.Name} ");
            current = current.Next;
        }
        Console.WriteLine("|");
    }

    // Mostrar de fin a inicio
    public void MostrarAtras()
    {
        NodoDoble current = cola;
        if (current == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Console.WriteLine("Lista de fin a inicio:");
        while (current != null)
        {
            Console.Write($"| {current.Name} ");
            current = current.Prev;
        }
        Console.WriteLine("|");
    }

    // Cantidad
    public int Count()
    {
        return CountElements;
    }

    public bool EstaVacia()
    {
        return cabeza == null;
    }
}
