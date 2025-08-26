public class Program
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
            Console.WriteLine("1. Enqueue (Agregar)");
            Console.WriteLine("2. Dequeue (Eliminar)");
            Console.WriteLine("3. Peek (Ver frente)");
            Console.WriteLine("4. Mostrar cola");
            Console.WriteLine("5. Ver Count");
            Console.WriteLine("6. Ver Size");
            Console.WriteLine("7. Buscar elemento (Contains)");
            Console.WriteLine("8. ¿Está vacía?");
            Console.WriteLine("9. ¿Está llena?");
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
                    Console.WriteLine("Tamaño máximo (Size): " + cola.GetSize());
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
