using System;

// Clase Nodo
class Nodo
{
    public string Valor { get; set; }
    public Nodo? Siguiente { get; set; }   // Puede Ser Null

    public Nodo(string Valor)
    {
        this.Valor = Valor;
        Siguiente = null;
    }
}

// Clase Cola con nodos
class Cola
{
    private Nodo? Frente;   // Puede Ser Null
    private Nodo? Final;    // Puede Ser Null

    public Cola()
    {
        Frente = null;
        Final = null;
    }

    // Insertar (Enqueue)
    public void Enqueue(string Valor)
    {
        Nodo Nuevo = new Nodo(Valor);

        if (IsEmpty())
        {
            Frente = Nuevo;
            Final = Nuevo;
        }
        else
        {
            Final!.Siguiente = Nuevo; // Final No Es Null Aqui
            Final = Nuevo;
        }
    }

    // Eliminar (Dequeue)
    public string Dequeue()
    {
        if (IsEmpty())
            return "La Cola Esta Vacia.";

        string Valor = Frente!.Valor;  // Frente No Es Null Aqui
        Frente = Frente.Siguiente;

        if (Frente == null) // Si La Cola Quedo Vacia
            Final = null;

        return Valor;
    }

    // Ver Frente (Peek)
    public string Peek()
    {
        if (IsEmpty())
            return "La Cola Esta Vacia.";

        return Frente!.Valor;  // Frente No Es Null Aqui
    }

    // Verificar Si Esta Vacia
    public bool IsEmpty()
    {
        return Frente == null;
    }

    // Mostrar Todos Los Elementos
    public void View()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La Cola Esta Vacia.");
            return;
        }

        Nodo? Actual = Frente;
        Console.WriteLine("Elementos En La Cola:");
        while (Actual != null)
        {
            Console.WriteLine(" - " + Actual.Valor);
            Actual = Actual.Siguiente;
        }
    }

    // Contar Elementos
    public int Count()
    {
        int Contador = 0;
        Nodo? Actual = Frente;
        while (Actual != null)
        {
            Contador++;
            Actual = Actual.Siguiente;
        }
        return Contador;
    }

    // Vaciar Cola
    public void Clear()
    {
        Frente = null;
        Final = null;
    }

    // Buscar Un Elemento
    public bool Search(string Valor)
    {
        Nodo? Actual = Frente;
        while (Actual != null)
        {
            if (Actual.Valor.Equals(Valor, StringComparison.OrdinalIgnoreCase))
                return true;
            Actual = Actual.Siguiente;
        }
        return false;
    }

    // Eliminar En Cualquier Posicion (0 = Frente)
    public bool RemoveAt(int Posicion)
    {
        if (IsEmpty() || Posicion < 0)
            return false;

        if (Posicion == 0)
        {
            Dequeue();
            return true;
        }

        Nodo? Actual = Frente;
        Nodo? Anterior = null;
        int Index = 0;

        while (Actual != null && Index < Posicion)
        {
            Anterior = Actual;
            Actual = Actual.Siguiente;
            Index++;
        }

        if (Actual == null) // No Se Encontro La Posicion
            return false;

        Anterior!.Siguiente = Actual.Siguiente;

        if (Actual == Final)
            Final = Anterior;

        return true;
    }
}

// Clase Principal Con El Menu
class Principal
{
    static void Main(string[] Args)
    {
        Cola Cola = new Cola();
        int Opcion;

        do
        {
            Console.WriteLine("\n===== Menu Cola Con Nodos =====");
            Console.WriteLine("1. Mostrar Cola");
            Console.WriteLine("2. Insertar Un Valor A La Cola");
            Console.WriteLine("3. Eliminar Un Valor De La Cola");
            Console.WriteLine("4. Ver Frente De La Cola");
            Console.WriteLine("5. Verificar Si Esta Vacia");
            Console.WriteLine("6. Contar Elementos");
            Console.WriteLine("7. Vaciar Cola");
            Console.WriteLine("8. Buscar Elemento");
            Console.WriteLine("9. Eliminar En Una Posicion Especifica");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione Una Opcion: ");

            if (!int.TryParse(Console.ReadLine(), out Opcion))
            {
                Console.WriteLine("Ingrese Un Numero Valido.");
                continue;
            }

            switch (Opcion)
            {
                case 1:
                    Cola.View();
                    break;

                case 2:
                    Console.Write("Ingrese El Nombre A Insertar: ");
                    string Valor = Console.ReadLine()!;
                    if (!string.IsNullOrEmpty(Valor))
                    {
                        Cola.Enqueue(Valor);
                        Console.WriteLine($"Elemento '{Valor}' Insertado.");
                    }
                    else
                    {
                        Console.WriteLine("Valor Invalido.");
                    }
                    break;

                case 3:
                    if (!Cola.IsEmpty())
                        Console.WriteLine("Elemento Eliminado: " + Cola.Dequeue());
                    else
                        Console.WriteLine("La Cola Esta Vacia, No Se Puede Eliminar.");
                    break;

                case 4:
                    Console.WriteLine("Frente De La Cola: " + Cola.Peek());
                    break;

                case 5:
                    Console.WriteLine(Cola.IsEmpty() ? "La Cola Esta Vacia." : "La Cola No Esta Vacia.");
                    break;

                case 6:
                    Console.WriteLine("Cantidad De Elementos En La Cola: " + Cola.Count());
                    break;

                case 7:
                    Cola.Clear();
                    Console.WriteLine("Cola Vaciada Correctamente.");
                    break;

                case 8:
                    Console.Write("Ingrese El Valor A Buscar: ");
                    string Buscar = Console.ReadLine()!;
                    if (Cola.Search(Buscar))
                        Console.WriteLine($"El Elemento '{Buscar}' Si Esta En La Cola.");
                    else
                        Console.WriteLine($"El Elemento '{Buscar}' No Se Encuentra En La Cola.");
                    break;

                case 9:
                    Console.Write("Ingrese La Posicion A Eliminar (0 = Frente): ");
                    if (int.TryParse(Console.ReadLine(), out int Pos))
                    {
                        if (Cola.RemoveAt(Pos))
                            Console.WriteLine($"Elemento En La Posicion {Pos} Eliminado Correctamente.");
                        else
                            Console.WriteLine("No Se Pudo Eliminar: Posicion Invalida.");
                    }
                    else
                    {
                        Console.WriteLine("Debe Ingresar Un Numero Valido.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo Del Programa...");
                    break;

                default:
                    Console.WriteLine("Opcion Invalida, Intente Nuevamente.");
                    break;
            }

        } while (Opcion != 0);
    }
}
