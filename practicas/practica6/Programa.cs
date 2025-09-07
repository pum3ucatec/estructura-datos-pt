using System;

class Principal
{
    static void Main(string[] args)
    {
        MyQueue cola = new MyQueue(5);
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ DE LA COLA =====");
            Console.WriteLine("1. Mostrar Cola");
            Console.WriteLine("2. Agregar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver primer elemento (Peek)");
            Console.WriteLine("5. Cantidad de elementos (Count)");
            Console.WriteLine("6. Capacidad de la cola (Size)");
            Console.WriteLine("7. Buscar un elemento (Contains)");
            Console.WriteLine("8. Verificar si está vacía (IsEmpty)");
            Console.WriteLine("9. Verificar si está llena (IsFull)");
            Console.WriteLine("0. Salir");
            Console.Write("Elija una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1: // Mostrar Cola
                    cola.Mostrar();
                    break;
                case 2: // Enqueue
                    Console.Write("Ingrese un carácter a agregar: ");
                    if (char.TryParse(Console.ReadLine(), out char valor))
                        cola.Enqueue(valor);
                    else
                        Console.WriteLine("Debe ingresar un solo carácter.");
                    break;
                case 3: // Dequeue
                    cola.Dequeue();
                    break;
                case 4: // Peek
                    char frente = cola.Peek();
                    if (frente != '\0')
                        Console.WriteLine($"Frente de la cola: {frente}");
                    break;
                case 5: // Count
                    Console.WriteLine($"La cola contiene {cola.Count()} elementos.");
                    break;
                case 6: // Size
                    Console.WriteLine($"La capacidad máxima de la cola es {cola.Length()}.");
                    break;
                case 7: // Contains
                    Console.Write("Ingrese un carácter a buscar: ");
                    if (char.TryParse(Console.ReadLine(), out char buscar))
                        Console.WriteLine(cola.Contains(buscar)
                            ? $"El elemento '{buscar}' está en la cola."
                            : $"El elemento '{buscar}' NO está en la cola.");
                    else
                        Console.WriteLine("Debe ingresar un solo carácter.");
                    break;
                case 8: // IsEmpty
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola NO está vacía.");
                    break;
                case 9: // IsFull
                    Console.WriteLine(cola.IsFull() ? "La cola está llena." : "La cola NO está llena.");
                    break;
                case 0: // Salir
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}
