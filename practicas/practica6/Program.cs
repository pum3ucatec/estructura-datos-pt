using System;

namespace Practica6
{
    class QueueExample
    {
        static void Main(string[] args)
        {
            int queueSize;
            Console.WriteLine("===== CONFIGURACIÓN DE LA COLA =====");
            Console.Write("Ingrese el tamaño máximo de la cola: ");

            while (!int.TryParse(Console.ReadLine(), out queueSize) || queueSize <= 0)
            {
                Console.WriteLine("Por favor ingrese un número entero positivo.");
                Console.Write("Ingrese el tamaño máximo de la cola: ");
            }

            MyQueue queue = new MyQueue(queueSize);
            int option;

            do
            {
                Console.WriteLine("\n===== MENÚ DE LA COLA =====");
                Console.WriteLine("1. Mostrar Cola");
                Console.WriteLine("2. Agregar ");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Ver primer elemento ");
                Console.WriteLine("5. Cantidad de elementos ");
                Console.WriteLine("6. Capacidad de la cola ");
                Console.WriteLine("7. Buscar un elemento ");
                Console.WriteLine("8. Verificar si está vacía ");
                Console.WriteLine("9. Verificar si está llena ");
                Console.WriteLine("0. Salir");
                Console.Write("Elija una opción: ");

                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Ingrese un número válido.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        queue.Show();
                        break;
                    case 2:
                        Console.Write("Ingrese un carácter a agregar: ");
                        if (char.TryParse(Console.ReadLine(), out char value))
                            queue.Enqueue(value);
                        else
                            Console.WriteLine("Debe ingresar un solo carácter.");
                        break;
                    case 3:
                        queue.Dequeue();
                        break;
                    case 4:
                        char front = queue.Peek();
                        if (front != '\0')
                            Console.WriteLine($"Frente de la cola: {front}");
                        break;
                    case 5:
                        Console.WriteLine($"La cola contiene {queue.Count()} elementos.");
                        break;
                    case 6:
                        Console.WriteLine($"La capacidad máxima de la cola es {queue.Length()}.");
                        break;
                    case 7:
                        Console.Write("Ingrese un carácter a buscar: ");
                        if (char.TryParse(Console.ReadLine(), out char search))
                            Console.WriteLine(queue.Contains(search)
                                ? $"El elemento '{search}' está en la cola."
                                : $"El elemento '{search}' NO está en la cola.");
                        else
                            Console.WriteLine("Debe ingresar un solo carácter.");
                        break;
                    case 8:
                        Console.WriteLine(queue.IsEmpty() ? "La cola está vacía." : "La cola NO está vacía.");
                        break;
                    case 9:
                        Console.WriteLine(queue.IsFull() ? "La cola está llena." : "La cola NO está llena.");
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (option != 0);
        }
    }
}