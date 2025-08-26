using System;

public class Cola
{
    private int[] elementos;
    private int frente;
    private int fin;
    private int count;
    private int capacidad;

    public Cola(int size)
    {
        capacidad = size;
        elementos = new int[capacidad];
        frente = 0;
        fin = -1;
        count = 0;
    }

    public void Enqueue(int valor)
    {
        if (IsFull())
        {
            Console.WriteLine("❌ La cola está llena. No se puede insertar.");
            return;
        }
        fin = (fin + 1) % capacidad;
        elementos[fin] = valor;
        count++;
        Console.WriteLine($"✔ Se insertó: {valor}");
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("❌ La cola está vacía. No se puede eliminar.");
            return -1;
        }
        int valor = elementos[frente];
        frente = (frente + 1) % capacidad;
        count--;
        Console.WriteLine($"✔ Se eliminó: {valor}");
        return valor;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("❌ La cola está vacía.");
            return -1;
        }
        return elementos[frente];
    }

    public int Count() => count;

    public int Size() => capacidad;

    public bool Contains(int valor)
    {
        for (int i = 0; i < count; i++)
        {
            int index = (frente + i) % capacidad;
            if (elementos[index] == valor) return true;
        }
        return false;
    }

    public bool IsEmpty() => count == 0;

    public bool IsFull() => count == capacidad;

    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("❌ La cola está vacía.");
            return;
        }
        Console.Write("Cola: ");
        for (int i = 0; i < count; i++)
        {
            int index = (frente + i) % capacidad;
            Console.Write(elementos[index] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        int size = LeerEntero("Ingrese la capacidad de la cola (entero positivo): ", 1);
        Cola cola = new Cola(size);

        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ DE OPERACIONES ---");
            Console.WriteLine("1. Enqueue (Insertar)");
            Console.WriteLine("2. Dequeue (Eliminar)");
            Console.WriteLine("3. Peek (Mostrar Frente)");
            Console.WriteLine("4. Mostrar Cola");
            Console.WriteLine("5. Count (Cantidad)");
            Console.WriteLine("6. Size (Capacidad)");
            Console.WriteLine("7. Contains (Buscar)");
            Console.WriteLine("8. ¿Está Vacía?");
            Console.WriteLine("9. ¿Está Llena?");
            Console.WriteLine("0. Salir");

            opcion = LeerEntero("Seleccione una opción: ", 0, 9);

            switch (opcion)
            {
                case 1:
                    int valor = LeerEntero("Ingrese un valor: ");
                    cola.Enqueue(valor);
                    break;

                case 2:
                    cola.Dequeue();
                    break;

                case 3:
                    Console.WriteLine($"Frente: {cola.Peek()}");
                    break;

                case 4:
                    cola.Display();
                    break;

                case 5:
                    Console.WriteLine($"Elementos en la cola: {cola.Count()}");
                    break;

                case 6:
                    Console.WriteLine($"Capacidad total: {cola.Size()}");
                    break;

                case 7:
                    int buscar = LeerEntero("Ingrese un valor a buscar: ");
                    Console.WriteLine(cola.Contains(buscar) ? "✔ Existe en la cola" : "❌ No existe en la cola");
                    break;

                case 8:
                    Console.WriteLine(cola.IsEmpty() ? "✔ La cola está vacía" : "❌ La cola no está vacía");
                    break;

                case 9:
                    Console.WriteLine(cola.IsFull() ? "✔ La cola está llena" : "❌ La cola no está llena");
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
            }

        } while (opcion != 0);
    }

    // Método seguro para leer enteros
    static int LeerEntero(string mensaje, int minimo = int.MinValue, int maximo = int.MaxValue)
    {
        int numero;
        while (true)
        {
            Console.Write(mensaje);
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero) && numero >= minimo && numero <= maximo)
                return numero;

            Console.WriteLine("❌ Entrada inválida. Intente de nuevo.");
        }
    }
}

