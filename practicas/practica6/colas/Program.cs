using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el tamaño máximo de la cola: ");
        if (!int.TryParse(Console.ReadLine(), out int tam) || tam <= 0)
        {
            Console.WriteLine("El tamaño ingresado no es VÁLIDO.");
            return;
        }

        MyQueue cola = new MyQueue(tam);
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA  =====");
            Console.WriteLine("1. Mostrar cola");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía (IsEmpty)");
            Console.WriteLine("6. Ver número de elementos (Count)");
            Console.WriteLine("7. Ver tamaño de la cola (Size)");
            Console.WriteLine("8. Buscar elemento en la cola (Contains)");
            Console.WriteLine("9. Verificar si la coal está llena (IsFull)");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número. ");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    cola.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese el valor: ");
                    string entrada = Console.ReadLine();
                    if (!string.IsNullOrEmpty(entrada) && entrada.Length == 1)
                    {
                        cola.Enqueue(entrada[0]);
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Ingrese solo un valor.");
                    }
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
                    Console.WriteLine(cola.IsEmpty() ? "La cola está VACIA." : "La cola NO está vacía.");
                    break;
                case 6:
                    Console.WriteLine($"Cantidad de elementos en la cola: {cola.GetCount()}");
                    break;
                case 7:
                    Console.WriteLine($"Tamaño máximo de la cola: {cola.GetSize()}");
                    break;
                case 8:
                    Console.Write("Ingrese el valor a buscar: ");
                    string buscar = Console.ReadLine();
                    if (!string.IsNullOrEmpty(buscar) && buscar.Length == 1)
                    {
                        Console.WriteLine(cola.Contains(buscar[0]) ? "El valor está en la cola." : "El valor NO está en la cola.");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. ERROR.");
                    }
                    break;
                case 9:
                    Console.WriteLine(cola.IsFull() ? "La cola está llena." : "La cola NO está llena.");
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}