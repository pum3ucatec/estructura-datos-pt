using System;

public class Nodo
{
    public string Name { get; set; }
    public Nodo Next { get; set; }

    public Nodo(string name)
    {
        Name = name;
        Next = null;
    }
}


public class LinkedList
{
    public Nodo Front { get; private set; }
    public Nodo Rear { get; private set; }
    private int size;

    public LinkedList()
    {
        Front = null;
        Rear = null;
        size = 0;
    }
    public void Add(string name)
    {
        Nodo nodo = new Nodo(name);
        if (head == null)
        {
            Front = nodo;
            Rear = nodo;
        }
        else
        {
            Rear.Next = nodo;
            Rear = nodo;
        }

        size++;
    }
}    
class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            int opcion;

            do
            {
                Console.WriteLine("\n===== MENÚ =====");
                Console.WriteLine("1. Mostrar lista");
                Console.WriteLine("2. Insertar");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Entrada inválida. Por favor ingrese un número.");
                    continue;
                }

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Numero de elementos");
                        Console.WriteLine(numeros.Count);
                        break;

                    case 2:
                        Console.Write("Ingrese el valor a insertar: ");
                        string valor = Console.ReadLine()?.Trim();
                        if (!string.IsNullOrEmpty(valor))
                        {
                            list.Add(valor);
                            Console.WriteLine($"Bien, '{valor}' fue insertado en la cola.");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido. No se insertó en la cola.");
                        }
                        break;

                    case 3:
                        Console.Write("Ingrese el valor a insertar: ");
                        string valor = Console.ReadLine()?.Trim();
                        if (!string.IsNullOrEmpty(valor))
                        {
                            list.Add(valor);
                            Console.WriteLine($"Bien, '{valor}' fue insertado en la cola.");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido. No se insertó en la cola.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Chau amiguito...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 0);
        }
    }
