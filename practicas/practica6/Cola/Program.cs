namespace Cola
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Ingrese el tamaño de la cola: ");
            int n = int.Parse(Console.ReadLine());
            MyQueue cola = new MyQueue(n);

            int opcion;
            do
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Agregar un elemento(Enqueue)");
                Console.WriteLine("2. Eliminar un elemento (Dequeue) ");
                Console.WriteLine("3. Ver frente (Peek)");
                Console.WriteLine("4. Mostrar cola");
                Console.WriteLine("5. Ver cantidad de elementos (Count)");
                Console.WriteLine("6. Ver tamaño de la cola(length)");
                Console.WriteLine("7. Buscar elemento (Contains)");
                Console.WriteLine("8. Ver si esta vacia (IsEmty)"); 
                Console.WriteLine("9.Ver si esta llena (IsFull)");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un carácter para agregar: ");
                        char c = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        cola.Enqueue(c);
                        break;
                    case 2:
                        char eliminado = cola.Dequeue();
                        if (eliminado != '\0')
                            Console.WriteLine("Elemento eliminado: " + eliminado);
                        break;
                    case 3:
                        char frente = cola.Peek();
                        if (frente != '\0')
                            Console.WriteLine("Elemento al frente: " + frente);
                        break;
                    case 4:
                        cola.Mostrar();
                        break;
                    case 5:
                        Console.WriteLine("Número de elementos (Count): " + cola.GetCount());
                        break;
                    case 6:
                        Console.WriteLine("Tamaño máximo (Length): " + cola.GetLength());
                        break;
                    case 7:
                        Console.Write("Ingrese un carácter a buscar: ");
                        char buscar = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        Console.WriteLine(cola.Contains(buscar) ? "El elemento está en la cola." : "El elemento NO está en la cola.");
                        break;
                    case 8:
                        Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola NO está vacía.");
                        break;
                    case 9:
                        Console.WriteLine(cola.IsFull() ? "La cola está llena." : "La cola NO está llena.");
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 0);
        }
    }
}