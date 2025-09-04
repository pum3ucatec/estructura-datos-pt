using System;

public class ListaSimple
{
    private Nodo cabeza;
    private int cantidad;

    public ListaSimple()
    {
        cabeza = null;
        cantidad = 0;
    }

    public void InsertarInicio(string dato)
    {
        Nodo nuevo = new Nodo(dato, cabeza);
        cabeza = nuevo;
        cantidad++;
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
            while (actual.Siguiente != null)
                actual = actual.Siguiente;
            actual.Siguiente = nuevo;
        }
        cantidad++;
    }

    public void Eliminar(string dato)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (cabeza.Valor == dato)
        {
            cabeza = cabeza.Siguiente;
            cantidad--;
            Console.WriteLine($"Se eliminó '{dato}'.");
            return;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != null && actual.Siguiente.Valor != dato)
            actual = actual.Siguiente;

        if (actual.Siguiente != null)
        {
            actual.Siguiente = actual.Siguiente.Siguiente;
            cantidad--;
            Console.WriteLine($"Se eliminó '{dato}'.");
        }
        else
        {
            Console.WriteLine($"El elemento '{dato}' no está en la lista.");
        }
    }

    public void Mostrar()
    {
        if (cabeza == null)
        {
            Console.WriteLine("Lista vacía.");
            return;
        }

        Console.Write("Lista: ");
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write($"{actual.Valor} -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    public bool Contiene(string dato)
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            if (actual.Valor == dato)
                return true;
            actual = actual.Siguiente;
        }
        return false;
    }

    public int Contar() => cantidad;

    public bool EstaVacia() => cabeza == null;
}
