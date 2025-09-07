using System;

public class Cola
{
    private int[] Elementos;
    private int Frente;
    private int Fin;
    private int CountInterno;
    private int Capacidad;

    public Cola(int Size)
    {
        Capacidad = Size;
        Elementos = new int[Capacidad];
        Frente = 0;
        Fin = -1;
        CountInterno = 0;
    }

    public void Enqueue(int Valor)
    {
        if (IsFull())
        {
            Console.WriteLine("❌ La Cola Esta Llena. No Se Puede Insertar.");
            return;
        }
        Fin = (Fin + 1) % Capacidad;
        Elementos[Fin] = Valor;
        CountInterno++;
        Console.WriteLine($"✔ Se Inserto: {Valor}");
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("❌ La Cola Esta Vacia. No Se Puede Eliminar.");
            return -1;
        }
        int Valor = Elementos[Frente];
        Frente = (Frente + 1) % Capacidad;
        CountInterno--;
        Console.WriteLine($"✔ Se Elimino: {Valor}");
        return Valor;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("❌ La Cola Esta Vacia.");
            return -1;
        }
        return Elementos[Frente];
    }

    public int Count() => CountInterno;

    public int Size() => Capacidad;

    public bool Contains(int Valor)
    {
        for (int I = 0; I < CountInterno; I++)
        {
            int Index = (Frente + I) % Capacidad;
            if (Elementos[Index] == Valor) return true;
        }
        return false;
    }

    public bool IsEmpty() => CountInterno == 0;

    public bool IsFull() => CountInterno == Capacidad;

    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("❌ La Cola Esta Vacia.");
            return;
        }
        Console.Write("Cola: ");
        for (int I = 0; I < CountInterno; I++)
        {
            int Index = (Frente + I) % Capacidad;
            Console.Write(Elementos[Index] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] Args)
    {
        int Size = LeerEntero("Ingrese La Capacidad De La Cola (Entero Positivo): ", 1);
        Cola Cola = new Cola(Size);

        int Opcion;
        do
        {
            Console.WriteLine("\n--- Menu De Operaciones ---");
            Console.WriteLine("1. Enqueue (Insertar)");
            Console.WriteLine("2. Dequeue (Eliminar)");
            Console.WriteLine("3. Peek (Mostrar Frente)");
            Console.WriteLine("4. Mostrar Cola");
            Console.WriteLine("5. Count (Cantidad)");
            Console.WriteLine("6. Size (Capacidad)");
            Console.WriteLine("7. Contains (Buscar)");
            Console.WriteLine("8. Esta Vacia?");
            Console.WriteLine("9. Esta Llena?");
            Console.WriteLine("0. Salir");

            Opcion = LeerEntero("Seleccione Una Opcion: ", 0, 9);

            switch (Opcion)
            {
                case 1:
                    int Valor = LeerEntero("Ingrese Un Valor: ");
                    Cola.Enqueue(Valor);
                    break;

                case 2:
                    Cola.Dequeue();
                    break;

                case 3:
                    Console.WriteLine($"Frente: {Cola.Peek()}");
                    break;

                case 4:
                    Cola.Display();
                    break;

                case 5:
                    Console.WriteLine($"Elementos En La Cola: {Cola.Count()}");
                    break;

                case 6:
                    Console.WriteLine($"Capacidad Total: {Cola.Size()}");
                    break;

                case 7:
                    int Buscar = LeerEntero("Ingrese Un Valor A Buscar: ");
                    Console.WriteLine(Cola.Contains(Buscar) ? "✔ Existe En La Cola" : "❌ No Existe En La Cola");
                    break;

                case 8:
                    Console.WriteLine(Cola.IsEmpty() ? "✔ La Cola Esta Vacia" : "❌ La Cola No Esta Vacia");
                    break;

                case 9:
                    Console.WriteLine(Cola.IsFull() ? "✔ La Cola Esta Llena" : "❌ La Cola No Esta Llena");
                    break;

                case 0:
                    Console.WriteLine("Saliendo Del Programa...");
                    break;
            }

        } while (Opcion != 0);
    }

    // Metodo Seguro Para Leer Enteros
    static int LeerEntero(string Mensaje, int Minimo = int.MinValue, int Maximo = int.MaxValue)
    {
        int Numero;
        while (true)
        {
            Console.Write(Mensaje);
            string? Entrada = Console.ReadLine();

            if (int.TryParse(Entrada, out Numero) && Numero >= Minimo && Numero <= Maximo)
                return Numero;

            Console.WriteLine("❌ Entrada Invalida. Intente De Nuevo.");
        }
    }
}


