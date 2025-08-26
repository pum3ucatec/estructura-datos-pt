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
            Console.WriteLine("7. Ver cantidad (Count)");
            Console.WriteLine("8. Ver capacidad (Length)");
            Console.WriteLine("9. Ver tamaño (Size)");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("⚠️ Ingrese un número válido.");
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
                        cola.Enqueue(valor);
                    else
                        Console.WriteLine(" Número no válido.");
                    break;
                case 3:
                    cola.Dequeue();
                    break;
                case 4:
                    cola.Peek();
                    break;
                case 5:
                    Console.WriteLine(cola.IsEmpty() ? " La cola está vacía." : " La cola NO está vacía.");
                    break;
                case 6:
                    Console.WriteLine(cola.IsFull() ? " La cola está llena." : " La cola NO está llena.");
                    break;
                case 7:
                    Console.WriteLine($"Cantidad de elementos (Count): {cola.Count}");
                    break;
                case 8:
                    Console.WriteLine($"Capacidad máxima (Length): {cola.Length}");
                    break;
                case 9:
                    Console.WriteLine($"Tamaño (Size): {cola.Size}");
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