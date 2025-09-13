class Program
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
            Console.WriteLine("5. Contar elementos(Count)");
            Console.WriteLine("6. Longitud (Length - Size)");
            Console.WriteLine("7. Buscar un elemento (Contains)");
            Console.WriteLine("8. Ver si esta vacio(IsEmpty)");
            Console.WriteLine("9. Ver si esta lleno(IsFull)");
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
                    Console.Write("Ingrese el elemento a insertar: ");
                    char.TryParse(Console.ReadLine(), out char valor);
                    cola.Enqueue(valor);
                    break;
                case 3:
                    cola.Dequeue();
                    break;
               case 4:
                    char frente = cola.Peek();
                    if (frente != '\0')
                        Console.WriteLine($"Elemento en el frente: {frente}");
                    break;

                case 5:
                    int elementos = cola.CountElements();
                    Console.WriteLine($"Elementos en la cola: {elementos}");
                    break;
                case 6:
                    Console.WriteLine($"Longitud de la cola: {cola.Length()}");
                    break;

                case 7:
                    Console.WriteLine("Ingrese un elemento a buscar:");
                    char elemento = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine(cola.Contains(elemento) ? "El elemento sí está en la cola." : "El elemento no está en la cola.");
                    break;
                case 8:
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola NO está vacía.");
                    break;
                case 9:
                    Console.WriteLine(cola.IsFull() ? "La cola está llena." : "La cola NO está llena.");
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