using System;

// Clase Nodo
class Nodo
{
    public string Valor { get; set; }
    public Nodo? Siguiente { get; set; }   // Puede ser null

    public Nodo(string valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

// Clase Cola con nodos
class Cola
{
    private Nodo? frente;   // Puede ser null
    private Nodo? final;    // Puede ser null

    public Cola()
    {
        frente = null;
        final = null;
    }

    // Insertar (Enqueue)
    public void Enqueue(string valor)
    {
        Nodo nuevo = new Nodo(valor);

        if (IsEmpty())
        {
            frente = nuevo;
            final = nuevo;
        }
        else
        {
            final!.Siguiente = nuevo; // final no es null aquí
            final = nuevo;
        }
    }

    // Eliminar (Dequeue)
    public string Dequeue()
    {
        if (IsEmpty())
            return "La cola está vacía.";

        string valor = frente!.Valor;  // frente no es null aquí
        frente = frente.Siguiente;

        if (frente == null) // Si la cola quedó vacía
            final = null;

        return valor;
    }

    // Ver frente (Peek)
    public string Peek()
    {
        if (IsEmpty())
            return "La cola está vacía.";

        return frente!.Valor;  // frente no es null aquí
    }

    // Verificar si está vacía
    public bool IsEmpty()
    {
        return frente == null;
    }

    // Mostrar todos los elementos
    public void View()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Nodo? actual = frente;
        Console.WriteLine("Elementos en la cola:");
        while (actual != null)
        {
            Console.WriteLine(" - " + actual.Valor);
            actual = actual.Siguiente;
        }
    }

    // Contar elementos
    public int Count()
    {
        int contador = 0;
        Nodo? actual = frente;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    // Vaciar cola
    public void Clear()
    {
        frente = null;
        final = null;
    }

    // Buscar un elemento
    public bool Search(string valor)
    {
        Nodo? actual = frente;
        while (actual != null)
        {
            if (actual.Valor.Equals(valor, StringComparison.OrdinalIgnoreCase))
                return true;
            actual = actual.Siguiente;
        }
        return false;
    }

    // Eliminar en cualquier posición (0 = frente)
    public bool RemoveAt(int posicion)
    {
        if (IsEmpty() || posicion < 0)
            return false;

        if (posicion == 0)
        {
            Dequeue();
            return true;
        }

        Nodo? actual = frente;
        Nodo? anterior = null;
        int index = 0;

        while (actual != null && index < posicion)
        {
            anterior = actual;
            actual = actual.Siguiente;
            index++;
        }

        if (actual == null) // No se encontró la posición
            return false;

        anterior!.Siguiente = actual.Siguiente;

        if (actual == final)
            final = anterior;

        return true;
    }
}

// Clase Principal con el menú
class Principal
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA con NODOS =====");
            Console.WriteLine("1. Mostrar Cola");
            Console.WriteLine("2. Insertar un valor a la cola");
            Console.WriteLine("3. Eliminar un valor de la cola");
            Console.WriteLine("4. Ver frente de la cola");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Contar elementos");
            Console.WriteLine("7. Vaciar cola");
            Console.WriteLine("8. Buscar elemento");
            Console.WriteLine("9. Eliminar en una posición específica");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    cola.View();
                    break;

                case 2:
                    Console.Write("Ingrese el nombre a insertar: ");
                    string valor = Console.ReadLine()!;
                    if (!string.IsNullOrEmpty(valor))
                    {
                        cola.Enqueue(valor);
                        Console.WriteLine($"Elemento '{valor}' insertado.");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;

                case 3:
                    if (!cola.IsEmpty())
                        Console.WriteLine("Elemento eliminado: " + cola.Dequeue());
                    else
                        Console.WriteLine("La cola está vacía, no se puede eliminar.");
                    break;

                case 4:
                    Console.WriteLine("Frente de la cola: " + cola.Peek());
                    break;

                case 5:
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola no está vacía.");
                    break;

                case 6:
                    Console.WriteLine("Cantidad de elementos en la cola: " + cola.Count());
                    break;

                case 7:
                    cola.Clear();
                    Console.WriteLine("Cola vaciada correctamente.");
                    break;

                case 8:
                    Console.Write("Ingrese el valor a buscar: ");
                    string buscar = Console.ReadLine()!;
                    if (cola.Search(buscar))
                        Console.WriteLine($"El elemento '{buscar}' SÍ está en la cola.");
                    else
                        Console.WriteLine($"El elemento '{buscar}' NO se encuentra en la cola.");
                    break;

                case 9:
                    Console.Write("Ingrese la posición a eliminar (0 = frente): ");
                    if (int.TryParse(Console.ReadLine(), out int pos))
                    {
                        if (cola.RemoveAt(pos))
                            Console.WriteLine($"Elemento en la posición {pos} eliminado correctamente.");
                        else
                            Console.WriteLine("No se pudo eliminar: posición inválida.");
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar un número válido.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida, intente nuevamente.");
                    break;
            }

        } while (opcion != 0);
    }
}
