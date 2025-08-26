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
                    int.TryParse(Console.ReadLine(), out int valor);
                    cola.Enqueue(valor);
                    break;
                case 3:
                    Console.Write("Ingrese el número a eliminar: ");
                    int.TryParse(Console.ReadLine(), out int valor);
                    cola.Dequeue(valor);
                    break;
               case 4:
                    char frente = cola.Peek();
                    if (frente != '\0')
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