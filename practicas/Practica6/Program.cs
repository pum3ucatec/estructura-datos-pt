
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== PROGRAMA DE COLAS ===");
        Console.Write("Ingrese el tamaño de la cola: ");
        
        // Validar tamaño ingresado
        if (!int.TryParse(Console.ReadLine(), out int tamaño) || tamaño <= 0)
        {
            Console.WriteLine("Tamaño inválido. Usando tamaño por defecto de 5.");
            tamaño = 5;
        }

        // Crear la cola con el tamaño ingresado
        MyQueue cola = new MyQueue(tamaño);
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ DE OPCIONES =====");
            Console.WriteLine("1. Mostrar estado de la COLA");
            Console.WriteLine("2. Insertar un elemento (Enqueue)");
            Console.WriteLine("3. Eliminar un elemento (Dequeue)");
            Console.WriteLine("4. Ver elemento al frente (Peek)");
            Console.WriteLine("5. Ver elemento al final (Rear)");
            Console.WriteLine("6. ¿Está vacía? (IsEmpty)");
            Console.WriteLine("7. ¿Está llena? (IsFull)");
            Console.WriteLine("8. Buscar elemento (Contains)");
            Console.WriteLine("9. Ver cantidad de elementos actuales (Count)");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine(" Error: Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    cola.Mostrar();
                    break;

                case 2:
                    Console.Write("Ingrese el carácter a insertar: ");
                    if (char.TryParse(Console.ReadLine(), out char caracter))
                    {
                        cola.Enqueue(caracter);
                    }
                    else
                    {
                        Console.WriteLine(" Error: Carácter inválido.");
                    }
                    break;

                case 3:
                    cola.Dequeue();
                    break;

                case 4:
                    char frente = cola.Peek();
                    if (frente != ' ')
                        Console.WriteLine($" El elemento en el frente es: '{frente}'");
                    break;

                case 5:
                    char final = cola.GetRear();
                    if (final != ' ')
                        Console.WriteLine($" El elemento al final es: '{final}'");
                    break;

                case 6:
                    Console.WriteLine(cola.IsEmpty() ? " La cola está vacía." : " La cola NO está vacía.");
                    break;

                case 7:
                    if (cola.IsFull())
                    {
                        Console.WriteLine(" La cola está llena.");
                    }
                    else
                    {
                        Console.WriteLine(" La cola NO está llena.");
                        Console.WriteLine($"Espacios disponibles: {cola.GetSize() - cola.GetCount()}");
                    }
                    break;

                case 8:
                    Console.Write("Ingrese el carácter a buscar: ");
                    if (char.TryParse(Console.ReadLine(), out char buscar))
                    {
                        int posicion = cola.Contains(buscar);
                        if (posicion != -1)
                            Console.WriteLine($" El elemento '{buscar}' está en la cola (posición {posicion}).");
                        else
                            Console.WriteLine($" El elemento '{buscar}' NO está en la cola.");
                    }
                    else
                    {
                        Console.WriteLine(" Error: Carácter inválido.");
                    }
                    break;

                case 9:
                    Console.WriteLine($" Cantidad de elementos actuales: {cola.GetCount()}");
                    break;

                case 0:
                    Console.WriteLine(" Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine(" Opción no válida. Intente nuevamente.");
                    break;
            }

        } while (opcion != 0);
    }
}
