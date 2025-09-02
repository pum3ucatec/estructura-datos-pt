﻿class Principal
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el tamaño de la cola: ");
        if (!int.TryParse(Console.ReadLine(), out int tamaño) || tamaño <= 0)
        {
            Console.WriteLine("Tamaño inválido. Usando tamaño por defecto de 5.");
            tamaño = 5;
        }

        MyQueue cola = new MyQueue(tamaño);
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA =====");
            Console.WriteLine("1. Mostrar COLA");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Ver final (Rear)");
            Console.WriteLine("6. Verificar si está vacía (IsEmpty)");
            Console.WriteLine("7. Verificar si está llena (IsFull)");
            Console.WriteLine("8. Buscar elemento (Contains)");
            Console.WriteLine("9. Ver cantidad de elementos actuales (Count)");
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
                    Console.Write("Ingrese el carácter a insertar: ");
                    char caracter;
                    if (char.TryParse(Console.ReadLine(), out caracter))
                    {
                        cola.Enqueue(caracter);
                    }
                    else
                    {
                        Console.WriteLine("Carácter inválido.");
                    }
                    break;
                case 3:
                    cola.Dequeue();
                    break;
                case 4:
                    char frente = cola.Peek();
                    if (frente != ' ')
                    {
                        Console.WriteLine($"El elemento en el frente es: '{frente}'");
                    }
                    break;
                case 5:
                    char final = cola.GetRear();
                    if (final != ' ')
                    {
                        Console.WriteLine($"El elemento en el final es: '{final}'");
                    }
                    break;
                case 6:
                    if (cola.IsEmpty())
                    {
                        Console.WriteLine("La cola está vacía.");
                    }
                    else
                    {
                        Console.WriteLine("La cola NO está vacía.");
                    }
                    break;
                case 7:
                    if (cola.IsFull())
                    {
                        Console.WriteLine("La cola está llena.");
                    }
                    else
                    {
                        Console.WriteLine("La cola NO está llena.");
                        Console.WriteLine($"Espacios disponibles: {cola.GetSize() - cola.GetCount()}");
                    }
                    break;
                case 8:
                    Console.Write("Ingrese el carácter a buscar: ");
                    if (char.TryParse(Console.ReadLine(), out char buscar))
                    {
                        int posicion = cola.Contains(buscar);
                        if (posicion != -1)
                        {
                            Console.WriteLine($"El elemento '{buscar}' SÍ está en la cola.");
                            Console.WriteLine($"Posición: {posicion}");
                        }
                        else
                        {
                            Console.WriteLine($"El elemento '{buscar}' NO está en la cola.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Carácter inválido.");
                    }
                    break;
                case 9:
                    Console.WriteLine($"Cantidad de elementos actuales: {cola.GetCount()}");
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