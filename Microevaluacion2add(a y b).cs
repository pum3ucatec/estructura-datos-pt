using System;

class Nodo
{
    public int dato;
    public Nodo siguiente;

    public Nodo(int valor)
    {
        this.dato = valor;
        this.siguiente = null;
    }
}

class ListaEnlazada
{
    private Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

   
    public void InsertarAlPrincipio(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        nuevoNodo.siguiente = cabeza;
        cabeza = nuevoNodo;
    }

   
    public void EliminarAlrededor(int valor)
    {
        if (cabeza == null || cabeza.siguiente == null)
        {
            
            return;
        }

        Nodo antesDelAnterior = null;
        Nodo anterior = null;
        Nodo actual = cabeza;

      
        while (actual != null && actual.dato != valor)
        {
            antesDelAnterior = anterior;
            anterior = actual;
            actual = actual.siguiente;
        }

   
        if (actual == null || actual.siguiente == null)
        {
            return;
        }

      
        actual.siguiente = actual.siguiente.siguiente;

  
        if (anterior != null)
        {
            if (antesDelAnterior == null)
            {
                
                cabeza = actual;
            }
            else
            {
               
                antesDelAnterior.siguiente = actual;
            }
        }
    }

    public void MostrarLista()
    {
        Nodo actual = cabeza;
        Console.Write("Lista: ");
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

        // Insertar elementos al principio
        lista.InsertarAlPrincipio(50);
        lista.InsertarAlPrincipio(40);
        lista.InsertarAlPrincipio(30);
        lista.InsertarAlPrincipio(20);
        lista.InsertarAlPrincipio(10);

        Console.WriteLine("Lista original:");
        lista.MostrarLista();

        // Eliminar los nodos alrededor del valor 30 (eliminará 20 y 40)
        Console.WriteLine("\nEliminando alrededor del nodo con valor 30...");
        lista.EliminarAlrededor(30);

        Console.WriteLine("Lista después de la eliminación:");
        lista.MostrarLista();
    }
}
