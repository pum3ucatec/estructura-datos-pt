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
// A)Inciso a la insercion del principio de la lista simple
// se añade a su cabeza el elemento nuevo recoriendo uno el espacio <<A>> , <<B>> , <<C>> a=1 b=2 c=3
// seguria esta logica agregadon "+ = W " <<W>>, <<A>> , <<B>> , <<C>> 
// pasando de w=1 a=2 b=3 c=4
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
