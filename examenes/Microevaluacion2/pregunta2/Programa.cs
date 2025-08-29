using System;
class Program
{
    class Nodo
    {
        public string nombre;
        public Nodo siguiente;
    }

    static Nodo inicio = null;
    static void Main()
    {
        int opcion;
        
        do
        {
            Console.WriteLine("\n LISTA DE NOMBRES ");
            Console.WriteLine("1. Agregar nombre al inicio");
            Console.WriteLine("2. Ver todos los nombres");
            Console.WriteLine("3. Eliminar antes y después de un nombre");
            Console.WriteLine("4. Salir");
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
                    EliminarAlrededor();
                    break;
                case 4:
                    Console.WriteLine("Adiós");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
            
        } while (opcion != 4);
    }
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
    static void EliminarAlrededor()
    {
        if (inicio == null)
        {
            Console.WriteLine("La lista está vacía");
            return;
        }

        Console.Write("Ingresa el nombre elegido: ");
        string nombreRef = Console.ReadLine();

        Nodo actual = inicio;
        Nodo anterior = null;
        Nodo objetivo = null;

        while (actual != null)
        {
            if (actual.nombre == nombreRef)
            {
                objetivo = actual;
                break;
            }
            anterior = actual;
            actual = actual.siguiente;
        }

        if (objetivo == null)
        {
            Console.WriteLine("Nombre no encontrado en la lista");
            return;
        }
        if (anterior != null)
        {
            Console.WriteLine($"Eliminando nombre antes: {anterior.nombre}");
            if (anterior == inicio)
            {
                inicio = objetivo;
            }
            else
            {
                Nodo temp = inicio;
                Nodo prevTemp = null;
                
                while (temp != anterior)
                {
                    prevTemp = temp;
                    temp = temp.siguiente;
                }
                
                if (prevTemp != null)
                {
                    prevTemp.siguiente = objetivo;
                }
            }
        }
        else
        {
            Console.WriteLine("No hay nombre antes del seleccionado");
        }
        if (objetivo.siguiente != null)
        {
            Console.WriteLine($"Eliminando nombre después: {objetivo.siguiente.nombre}");
            objetivo.siguiente = objetivo.siguiente.siguiente;
        }
        else
        {
            Console.WriteLine("No hay nombre después del seleccionado");
        }

        Console.WriteLine("Eliminación completada");
    }
}