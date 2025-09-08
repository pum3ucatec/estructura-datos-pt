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
            Console.WriteLine("\nLISTA DOBLEMENTE ENLAZADA");
            Console.WriteLine("1. Agregar nombre al final");
            Console.WriteLine("2. Ver nombres de inicio a fin");
            Console.WriteLine("3. Ver nombres de fin a inicio");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarAlFinal();
                    break;
                case 2:
                    MostrarInicioAFin();
                    break;
                case 3:
                    MostrarFinAInicio();
                    break;
                case 4:
                    Console.WriteLine("Programa terminado");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        } while (opcion != 4);
    }

    static void AgregarAlFinal()
    {
        Console.Write("Ingresa un nombre: ");
        string nom = Console.ReadLine();

        Nodo nuevo = new Nodo();
        nuevo.nombre = nom;

        if (inicio == null)
        {
            inicio = nuevo;
            fin = nuevo;
        }
        else
        {
            fin.siguiente = nuevo;
            nuevo.anterior = fin;
            fin = nuevo;
        }

        Console.WriteLine("Nombre agregado al final");
    }

    static void MostrarInicioAFin()
    {
        if (inicio == null)
        {
            Console.WriteLine("La lista está vacía");
            return;
        }

        Console.WriteLine("\nNombres de inicio a fin:");
        Nodo actual = inicio;
        int contador = 1;
        while (actual != null)
        {
            Console.WriteLine($"{contador}. {actual.nombre}");
            actual = actual.siguiente;
            contador++;
        }
    }

    static void MostrarFinAInicio()
    {
        if (fin == null)
        {
            Console.WriteLine("La lista está vacía");
            return;
        }

        Console.WriteLine("\nNombres de fin a inicio:");
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
