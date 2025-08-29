using System;

class Nodo
{
    public string Dato;
    public Nodo next;

    public Nodo(string dato)
    {
        Dato = dato;
        next = null;
    }
}

class ListaSimple
{
    private Nodo head;

    public ListaSimple()
    {
        head = null;
    }

    public void InsertarAlPrincipio(string dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.next = head;
        head = nuevo;
    }

    public void Mostrar()
    {
        Nodo actual = head;
        while (actual != null)
        {
            Console.WriteLine("Dato actual -> " + actual.Dato);
            actual = actual.next;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();
        string opcion;

        do
        {
            Console.WriteLine("\n==Menu de Lista Simple==");
            Console.WriteLine("1. Insertar al principio");
            Console.WriteLine("2. Mostrar la lista");
            Console.WriteLine("3. Salir");
            Console.Write("Por favor Ing. Gaston, elige una opcion: ");
            
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese un dato (nombre o numero): ");
                    string dato = Console.ReadLine();
                    lista.InsertarAlPrincipio(dato);
                    Console.WriteLine("Se ha insertado al principio de manera correcta");
                    break;

                case "2":
                    Console.WriteLine("Lista actual:");
                    lista.Mostrar();
                    break;

                case "3":
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

        } while (opcion != "3");
    }
}
