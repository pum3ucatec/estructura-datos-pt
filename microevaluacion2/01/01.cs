using System;
using System.Collections.Generic;

public class Nodo<T>
{
    public T Dato { get; set; }
    public Nodo<T> Siguiente { get; set; }

    public Nodo(T dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

public class ListaSimple<T>
{
    private Nodo<T> primero;

    public void Agregar(T dato)
    {
        Nodo<T> nuevo = new Nodo<T>(dato);
        if (primero == null)
        {
            primero = nuevo;
        }
        else
        {
            Nodo<T> actual = primero;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    public void Mostrar()
    {
        Nodo<T> actual = primero;
        while (actual != null)
        {
            Console.WriteLine(actual.Dato);
            actual = actual.Siguiente;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        ListaSimple<string> lista = new ListaSimple<string>();
        lista.Agregar("Anthony");
        lista.Agregar("Patrick");
        lista.Agregar("Kevin");
        lista.Agregar("Dianna");

        lista.Mostrar();
    }
}