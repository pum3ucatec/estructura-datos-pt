using System;
class Nodo
{
    public int dato;
    public Nodo siguiente;
    public Nodo(int valor)
    {
        dato = valor;
        siguiente = null;
    }
}
class ListaEnlazada
{
    private Nodo cabeza;
    public ListaEnlazada()
    {
        cabeza = null;
    }
    public void InsertarAlFinal(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.siguiente != null)
            {
                actual = actual.siguiente;
            }
            actual.siguiente = nuevoNodo;
        }
    }
    public void MostrarLista()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.dato + " -> ");
            actual = actual.siguiente;
        }
        Console.WriteLine("null");
    }
}
class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.InsertarAlFinal(10);
        lista.InsertarAlFinal(20);
        lista.InsertarAlFinal(30);
        lista.MostrarLista(); 
    }
}
