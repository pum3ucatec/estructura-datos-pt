// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio de Pilas!");

Stack<int> pila = new Stack<int>();
int opcion;

do
{
    Console.WriteLine("\n--- Menú de Pila ---");
    Console.WriteLine("1. Push (insertar elemento)");
    Console.WriteLine("2. Pop (eliminar elemento)");
    Console.WriteLine("3. Peek (ver elemento superior)");
    Console.WriteLine("4. Count (cantidad de elementos)");
    Console.WriteLine("5. Clear (limpiar pila)");
    Console.WriteLine("6. Push 'n' (insertar un número específico)");
    Console.WriteLine("0. Salir");
    Console.Write("Elige una opción: ");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingresa un número a insertar: ");
            int valor = int.Parse(Console.ReadLine());
            pila.Push(valor);
            Console.WriteLine("Elemento insertado.");
            break;

        case 2:
            if (pila.Count > 0)
            {
                int eliminado = pila.Pop();
                Console.WriteLine($"Elemento {eliminado} eliminado.");
            }
            else
            {
                Console.WriteLine("La pila está vacía.");
            }
            break;

        case 3:
            if (pila.Count > 0)
            {
                int superior = pila.Peek();
                Console.WriteLine($"Elemento superior: {superior}");
            }
            else
            {
                Console.WriteLine("La pila está vacía.");
            }
            break;

        case 4:
            Console.WriteLine($"Cantidad de elementos en la pila: {pila.Count}");
            break;

        case 5:
            pila.Clear();
            Console.WriteLine("Pila limpiada.");
            break;

        case 6:
            Console.Write("¿Cuántos elementos deseas insertar? ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingresa el elemento {i}: ");
                int num = int.Parse(Console.ReadLine());
                pila.Push(num);
            }
            Console.WriteLine($"{cantidad} elementos insertados en la pila.");
            break;

        case 0:
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

} while (opcion != 0);