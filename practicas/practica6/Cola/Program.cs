using System;
using System.Collections.Generic;

class Cola
{
    private Queue<int> cola;

    public Cola()
    {
        cola = new Queue<int>();
    }

    public void Enqueue(int valor)
    {
        cola.Enqueue(valor);
        Console.WriteLine($"Se insertó: {valor}");
    }

    public void Dequeue()
    {
        if (cola.Count > 0)
        {
            int valor = cola.Dequeue();
            Console.WriteLine($"Se eliminó: {valor}");
        }
        else
        {
            Console.WriteLine("La cola está vacía.");
        }
    }

    public int Peek()
    {
        if (cola.Count > 0)
        {
            return cola.Peek();
        }
        else
        {
            Console.WriteLine("La cola está vacía.");
            return -1;
        }
    }

    public void Mostrar()
    {
        if (cola.Count == 0)
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Console.WriteLine("Elementos de la cola:");
        foreach (int item in cola)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public bool IsEmpty()
    {
        return cola.Count == 0;
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
            Console.WriteLine("\n===== MENÚ COLA =====");
            Console.WriteLine("1. Mostrar cola");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
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
                    cola.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese el número a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
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
                    int frente = cola.Peek();
                    if (frente != -1)
                        Console.WriteLine($"Elemento en el frente: {frente}");
                    break;
                case 5:
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola NO está vacía.");
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}
