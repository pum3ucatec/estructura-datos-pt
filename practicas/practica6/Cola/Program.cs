using System;

class Principal
{
    static void Main(string[] args)
    {
        MyQueue cola = new MyQueue(5);
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA =====");
            Console.WriteLine("1. Mostrar COLA");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Verificar si está llena");
            Console.WriteLine("7. Verificar si un elemento existe (Contains)"); // Nueva opción
            Console.WriteLine("8. Ver el tamaño de la cola (Size)"); // Nueva opción
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
                    if (int.TryParse(Console.ReadLine(), out int numeroAInsertar))
                    {
                        cola.Enqueue(numeroAInsertar);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Ingrese un número entero.");
                    }
                    break;
                case 3:
                    int itemEliminado = cola.Dequeue();
                    if (itemEliminado != -1)
                    {
                        Console.WriteLine($"Se eliminó el elemento: {itemEliminado}");
                    }
                    break;
                case 4:
                    int frente = cola.Peek();
                    if (frente != -1)
                    {
                        Console.WriteLine($"El elemento en el frente de la cola es: {frente}");
                    }
                    break;
                case 5:
                    if (cola.IsEmpty())
                    {
                        Console.WriteLine("La cola está vacía.");
                    }
                    else
                    {
                        Console.WriteLine("La cola NO está vacía.");
                    }
                    break;
                case 6:
                    if (cola.IsFull())
                    {
                        Console.WriteLine("La cola está llena.");
                    }
                    else
                    {
                        Console.WriteLine("La cola NO está llena.");
                    }
                    break;
                case 7: // Caso para la nueva función Contains
                    Console.Write("Ingrese el elemento a buscar: ");
                    if (int.TryParse(Console.ReadLine(), out int elementoABuscar))
                    {
                        if (cola.Contains(elementoABuscar))
                        {
                            Console.WriteLine($"El elemento {elementoABuscar} SÍ se encuentra en la cola.");
                        }
                        else
                        {
                            Console.WriteLine($"El elemento {elementoABuscar} NO se encuentra en la cola.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Ingrese un número entero.");
                    }
                    break;
               case 8: // Caso para la nueva función de conteo
                   Console.WriteLine($"El tamaño de la cola es: {cola.CurrentCount}");
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