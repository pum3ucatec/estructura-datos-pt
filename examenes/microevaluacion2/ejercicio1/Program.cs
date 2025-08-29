using System;

class Program
{
    // Clase para cada elemento de la lista
    class Nodo
    {
        public string nombre;
        public Nodo siguiente;
    }

    static Nodo inicio = null; // Donde empieza la lista

    static void Main()
    {
        int opcion;
        
        do
        {
            Console.WriteLine("\n--- LISTA DE NOMBRES ---");
            Console.WriteLine("1. Agregar nombre al inicio");
            Console.WriteLine("2. Ver todos los nombres");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            
            opcion = Convert.ToInt32(Console.ReadLine());
            
            switch(opcion)
            {
                case 1:
                    AgregarNombre();
                    break;
                case 2:
                    VerNombres();
                    break;
                case 3:
                    Console.WriteLine("¡Adiós!");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
            
        } while (opcion != 3);
    }

    // Función para agregar nombre al inicio
    static void AgregarNombre()
    {
        Console.Write("Ingresa un nombre: ");
        string nom = Console.ReadLine();
        
        Nodo nuevo = new Nodo();
        nuevo.nombre = nom;
        nuevo.siguiente = inicio;
        
        inicio = nuevo;
        
        Console.WriteLine("¡Nombre agregado al inicio!");
    }

    // Función para ver todos los nombres
    static void VerNombres()
    {
        if (inicio == null)
        {
            Console.WriteLine("La lista está vacía");
            return;
        }
        
        Console.WriteLine("\nNombres en la lista:");
        Nodo actual = inicio;
        int contador = 1;
        
        while (actual != null)
        {
            Console.WriteLine($"{contador}. {actual.nombre}");
            actual = actual.siguiente;
            contador++;
        }
    }
}