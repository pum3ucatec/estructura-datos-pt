using System;
using System.Collections;
using System.Diagnostics.Contracts;

class Nodo
{
    public string Dato { get; set; }
    public Nodo siguiente { get; set; }

    public Nodo(string dato)
    {
        Dato = dato;
        siguiente = null;
    }
}

class Cola
{
    private Nodo frente;
    private Nodo final;
    private int cantidad;

    public Cola()
    {
        frente = null;
        final = null;
        cantidad = 0;
    }

    // Insertar
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
            final.siguiente = nuevo;
            final = nuevo;
        }
        cantidad++;
        Console.WriteLine($"{valor} agregado a la cola.");
    }

    public string Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return null;
        }
        string valor = frente.Dato;
        frente = frente.siguiente;
        cantidad--;
        if (IsEmpty())
        {
            final = null;
        }
        Console.WriteLine($"{valor} eliminado de la cola.");
        return valor;
    }

    public void Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
        }
        else
        {
            Console.WriteLine($"El frente de la cola es: {frente.Dato}");
        }
    }

    public bool IsEmpty()
    {
        return frente == null;
    }


    public int Count()
    {
        return cantidad;
    }

    public void Clear()
    {
        frente = null;
        final = null;
        cantidad = 0;
        Console.WriteLine("Cola vaciada.");
    }

    public bool Contains(string valor)
    {
        Nodo actual = frente;
        while (actual != null)
        {
            if (actual.Dato.Equals(valor, StringComparison.OrdinalIgnoreCase))
                return true;
            actual = actual.siguiente;
        }
        return false;
    }

    public void Search(string valor)
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Nodo actual = frente;
        Nodo anterior = null;

        while (actual != null && !actual.Dato.Equals(valor, StringComparison.OrdinalIgnoreCase))
        {
            anterior = actual;
            actual = actual.siguiente;
        }

        if (actual == null)
        {
            Console.WriteLine($"{valor} no encontrado en la cola.");
            return;
        }

        if (anterior == null)
        {

            frente = frente.siguiente;
            if (frente == null)
                final = null; // La cola queda vacía
        }
        else
        {
            anterior.siguiente = actual.siguiente;
            if (actual == final)
                final = anterior;
        }

        cantidad--;
        Console.WriteLine($"{valor} eliminado de la cola.");
    }

    public void View()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Console.WriteLine("Elementos en la cola:");
        Nodo actual = frente;
        while (actual != null)
        {
            Console.Write($"[{actual.Dato}] ");
            actual = actual.siguiente;
        }
        Console.WriteLine();
    }
}

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
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Contar elementos");
            Console.WriteLine("7. Vaciar cola");
            Console.WriteLine("8. Buscar elemento (Contains)");
            Console.WriteLine("9. Eliminar de la cola en cualquier posicion");
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
                    string valor = Console.ReadLine();
                    if (!string.IsNullOrEmpty(valor))
                    {
                        cola.Enqueue(valor);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 3:
                    cola.Dequeue();
                    break;
                case 4:
                    cola.Peek();
                    break;
                case 5:
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola no está vacía.");
                    break;
                case 6:
                    Console.WriteLine($"La cola tiene {cola.Count()} elementos.");
                    break;
                case 7:
                    cola.Clear();
                    break;
                case 8:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    if (cola.Contains(buscar))
                    {
                        Console.WriteLine($"{buscar} está en la cola.");
                    }
                    else
                    {
                        Console.WriteLine($"{buscar} no está en la cola.");
                    }
                    break;
                case 9:
                    Console.Write("Ingrese el nombre a buscar y eliminar: ");
                    string eliminar = Console.ReadLine();
                    if (cola.Contains(eliminar))
                    {
                        cola.Search(eliminar);
                        Console.WriteLine($"{eliminar} ha sido eliminado de la cola.");
                    }
                    else
                    {
                        Console.WriteLine($"{eliminar} no está en la cola.");
                    }
                    break;
                default:

                    break;
            }

        } while (opcion != 0);
    }
}