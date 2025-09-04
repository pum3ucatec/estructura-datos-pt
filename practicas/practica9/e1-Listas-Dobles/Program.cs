using System;

class Program
{
    class Nodo
    {
        public string nombre;
        public Nodo siguiente;
        public Nodo anterior;
    }
    
    static Nodo inicio = null;
    static Nodo fin = null;
    
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n LISTA DOBLE DE NOMBRES ");
            Console.WriteLine("1. Agregar nombre al inicio");
            Console.WriteLine("2. Agregar nombre al final");
            Console.WriteLine("3. Ver nombres desde el inicio");
            Console.WriteLine("4. Ver nombres desde el final");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarAlInicio();
                    break;
                case 2:
                    AgregarAlFinal();
                    break;
                case 3:
                    VerDesdeInicio();
                    break;
                case 4:
                    VerDesdeFinal();
                    break;
                case 5:
                    Console.WriteLine("Programa terminado");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 5);
    }

    static void AgregarAlInicio()
    {
        Console.Write("Ingresa un nombre: ");
        string nom = Console.ReadLine();

        Nodo nuevo = new Nodo();
        nuevo.nombre = nom;
        nuevo.siguiente = inicio;
        nuevo.anterior = null;

        if (inicio != null)
        {
            inicio.anterior = nuevo;
        }
        else
        {
            fin = nuevo; // Si la lista estaba vacía
        }
        
        inicio = nuevo;
        Console.WriteLine("Nombre agregado al inicio");
    }

    static void AgregarAlFinal()
    {
        Console.Write("Ingresa un nombre: ");
        string nom = Console.ReadLine();

        Nodo nuevo = new Nodo();
        nuevo.nombre = nom;
        nuevo.siguiente = null;
        nuevo.anterior = fin;

        if (fin != null)
        {
            fin.siguiente = nuevo;
        }
        else
        {
            inicio = nuevo; // Si la lista estaba vacía
        }
        
        fin = nuevo;
        Console.WriteLine("Nombre agregado al final");
    }

    static void VerDesdeInicio()
    {
        if (inicio == null)
        {
            Console.WriteLine("La lista está vacía");
            return;
        }
        
        Console.WriteLine("\nNombres desde el inicio:");
        Nodo actual = inicio;
        int contador = 1;
        
        while (actual != null)
        {
            Console.WriteLine($"{contador}. {actual.nombre}");
            actual = actual.siguiente;
            contador++;
        }
    }

    static void VerDesdeFinal()
    {
        if (fin == null)
        {
            Console.WriteLine("La lista está vacía");
            return;
        }
        
        Console.WriteLine("\nNombres desde el final:");
        Nodo actual = fin;
        int contador = 1;
        
        while (actual != null)
        {
            Console.WriteLine($"{contador}. {actual.nombre}");
            actual = actual.anterior;
            contador++;
        }
    }
}