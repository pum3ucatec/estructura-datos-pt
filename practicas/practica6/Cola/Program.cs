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
            Console.WriteLine("1. Mostrar cola");
            Console.WriteLine("2. Agregar elemento a la cola");
            Console.WriteLine("3. Eliminar elemento de la cola");
            Console.WriteLine("4. Ver frente de la cola");
            Console.WriteLine("5. Ver cantidad de elementos en la cola");
            Console.WriteLine("6. Ver tamaño de la cola");
            Console.WriteLine("7. Buscar elemento en la cola");
            Console.WriteLine("8. Ver si está vacía");
            Console.WriteLine("9. Ver si está llena");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    cola.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese un carácter para agregar: ");
                    char c = Console.ReadLine()[0];
                    cola.Enqueue(c);
                    break;
                case 3:
                    char eliminado = cola.Dequeue();
                    if (eliminado != '\0')
                        Console.WriteLine("Elemento eliminado: " + eliminado);
                    break;
                case 4:
                    char frente = cola.Peek();
                    if (frente != '\0')
                        Console.WriteLine("Elemento al frente: " + frente);
                    break;
                case 5:
                    Console.WriteLine("Número de elementos (Count): " + cola.GetCount());
                    break;
                case 6:
                    Console.WriteLine("Tamaño máximo (Size): " + cola.GetSize());
                    break;
                case 7:
                    Console.Write("Ingrese un carácter a buscar: ");
                    char buscar = Console.ReadLine()[0];
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
