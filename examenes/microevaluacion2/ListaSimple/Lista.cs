using System;

public class ListaSimple
{
    private NodoLista cabeza;

    public ListaSimple()
    {
        cabeza = null;
    }

    // Insertar al principio
    public void InsertarAlPrincipio(int valor)
    {
        NodoLista nuevo = new NodoLista(valor);
        nuevo.Siguiente = cabeza;
        cabeza = nuevo;
    }

    // Eliminar alrededor de un valor
    public void EliminarAlrededor(int valor)
    {
        if (cabeza == null || cabeza.Siguiente == null)
        {
            Console.WriteLine(" La lista no tiene suficientes elementos.");
            return;
        }

        NodoLista actual = cabeza;
        NodoLista anterior = null;

        while (actual != null && actual.Dato != valor)
        {
            anterior = actual;
            actual = actual.Siguiente;
        }

        if (actual == null)
        {
            Console.WriteLine($" El valor {valor} no está en la lista.");
            return;
        }

        // Eliminar anterior
        if (anterior != null)
        {
            Console.WriteLine($" Eliminado el nodo anterior con valor {anterior.Dato}");
            if (anterior == cabeza)
                cabeza = actual;
            else
            {
                NodoLista temp = cabeza;
                while (temp.Siguiente != anterior)
                    temp = temp.Siguiente;
                temp.Siguiente = actual;
            }
        }

        // Eliminar siguiente
        if (actual.Siguiente != null)
        {
            Console.WriteLine($" Eliminado el nodo siguiente con valor {actual.Siguiente.Dato}");
            actual.Siguiente = actual.Siguiente.Siguiente;
        }
    }

    // Mostrar lista
    public void Mostrar()
    {
        if (cabeza == null)
        {
            Console.WriteLine(" La lista está vacía.");
            return;
        }

        NodoLista temp = cabeza;
        while (temp != null)
        {
            Console.Write(temp.Dato + " -> ");
            temp = temp.Siguiente;
        }
        Console.WriteLine("null");
    }
}