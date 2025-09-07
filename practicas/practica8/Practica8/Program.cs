using System;

// Clase Nodo
class Nodo
{
    public int Valor { get; set; }
    public Nodo? Siguiente { get; set; }

    public Nodo(int Valor)
    {
        this.Valor = Valor;
        Siguiente = null;
    }
}

// Clase Lista Simple
class ListaSimple
{
    private Nodo? Cabeza; // Primer nodo de la lista

    public ListaSimple()
    {
        Cabeza = null;
    }

    // Insertar al inicio
    public void InsertarInicio(int Valor)
    {
        Nodo Nuevo = new Nodo(Valor);
        Nuevo.Siguiente = Cabeza;
        Cabeza = Nuevo;
    }

    // Insertar al final
    public void InsertarFinal(int Valor)
    {
        Nodo Nuevo = new Nodo(Valor);
        if (Cabeza == null)
        {
            Cabeza = Nuevo;
        }
        else
        {
            Nodo Actual = Cabeza;
            while (Actual.Siguiente != null)
            {
                Actual = Actual.Siguiente;
            }
            Actual.Siguiente = Nuevo;
        }
    }

    // Eliminar un nodo por valor
    public void Eliminar(int Valor)
    {
        if (Cabeza == null) return;

        if (Cabeza.Valor == Valor)
        {
            Cabeza = Cabeza.Siguiente;
            return;
        }

        Nodo Actual = Cabeza;
        while (Actual.Siguiente != null && Actual.Siguiente.Valor != Valor)
        {
            Actual = Actual.Siguiente;
        }

        if (Actual.Siguiente != null)
        {
            Actual.Siguiente = Actual.Siguiente.Siguiente;
        }
    }

    // Buscar un nodo
    public bool Buscar(int Valor)
    {
        Nodo Actual = Cabeza;
        while (Actual != null)
        {
            if (Actual.Valor == Valor)
                return true;
            Actual = Actual.Siguiente;
        }
        return false;
    }

    // Mostrar la lista
    public void Mostrar()
    {
        Nodo Actual = Cabeza;
        if (Actual == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        while (Actual != null)
        {
            Console.Write(Actual.Valor + " -> ");
            Actual = Actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}

// Programa principal con menú
class Program
{
    static void Main()
    {
        ListaSimple Lista = new ListaSimple();
        bool Salir = false;

        while (!Salir)
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1. Insertar al inicio");
            Console.WriteLine("2. Insertar al final");
            Console.WriteLine("3. Eliminar un valor");
            Console.WriteLine("4. Buscar un valor");
            Console.WriteLine("5. Mostrar la lista");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            string? Opcion = Console.ReadLine();

            switch (Opcion)
            {
                case "1":
                    Console.Write("Ingrese el valor a insertar al inicio: ");
                    int ValorInicio = int.Parse(Console.ReadLine() ?? "0");
                    Lista.InsertarInicio(ValorInicio);
                    break;

                case "2":
                    Console.Write("Ingrese el valor a insertar al final: ");
                    int ValorFinal = int.Parse(Console.ReadLine() ?? "0");
                    Lista.InsertarFinal(ValorFinal);
                    break;

                case "3":
                    Console.Write("Ingrese el valor a eliminar: ");
                    int ValorEliminar = int.Parse(Console.ReadLine() ?? "0");
                    Lista.Eliminar(ValorEliminar);
                    break;

                case "4":
                    Console.Write("Ingrese el valor a buscar: ");
                    int ValorBuscar = int.Parse(Console.ReadLine() ?? "0");
                    bool Encontrado = Lista.Buscar(ValorBuscar);
                    Console.WriteLine(Encontrado ? "Valor encontrado." : "Valor no encontrado.");
                    break;

                case "5":
                    Console.WriteLine("\nContenido de la lista:");
                    Lista.Mostrar();
                    break;

                case "6":
                    Salir = true;
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida, intente nuevamente.");
                    break;
            }
        }
    }
}
