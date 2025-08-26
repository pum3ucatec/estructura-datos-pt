using System;

class Principal
{
    static void Main(string[] args)
    {
        int tamaño;

        Console.WriteLine("===== CONFIGURACION DE LA COLA =====");
        Console.Write("Ingrese el tamaño máximo de la cola: ");
        
        while (!int.TryParse(Console.ReadLine(), out tamaño) || tamaño <= 0)
        {
            Console.WriteLine("Debe ingresar un número entero positivo.");
            Console.Write("Ingrese el tamaño máximo de la cola: ");
        }

        MyQueue cola = new MyQueue(tamaño);
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENU COLA =====");
            Console.WriteLine("1. Mostrar COLA");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacia (IsEmpty)");
            Console.WriteLine("6. Insertar varios elementos");
            Console.WriteLine("7. Cantidad de elementos (Count)");
            Console.WriteLine("8. Tamaño de la cola (Size)");
            Console.WriteLine("9. Buscar elemento (Contains)");
            Console.WriteLine("10. Verificar si está llena (IsFull)");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un numero valido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    cola.Mostrar();
                    break;

                case 2:
                    Console.Write("Ingrese el caracter a insertar: ");
                    char valor;
                    if (char.TryParse(Console.ReadLine(), out valor))
                        cola.Enqueue(valor);
                    else
                        Console.WriteLine("Debe ingresar un solo caracter.");
                    break;

                case 3:
                    cola.Dequeue();
                    break;

                case 4:
                    char frente = cola.Peek();
                    if (frente != '\0')
                        Console.WriteLine($"Frente de la cola: {frente}");
                    break;

                case 5:
                    Console.WriteLine(cola.IsEmpty() ? "La cola esta vacia." : "La cola NO esta vacia.");
                    break;

                case 6:
                    Console.Write("Ingrese varios caracteres separados por espacio: ");
                    string entrada = Console.ReadLine();
                    string[] elementos = entrada.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (var e in elementos)
                    {
                        if (e.Length == 1)
                            cola.Enqueue(e[0]);
                        else
                            Console.WriteLine($"'{e}' no es un caracter válido.");
                    }
                    break;

                case 7:
                    Console.WriteLine($"La cola tiene {cola.GetCount()} elemento(s).");
                    break;

                case 8:
                    Console.WriteLine($"El tamaño maximo de la cola es {cola.GetSize()}.");
                    break;

                case 9:
                    Console.Write("Ingrese el caracter a buscar: ");
                    char buscar;
                    if (char.TryParse(Console.ReadLine(), out buscar))
                        Console.WriteLine(cola.Contains(buscar) ? $"El elemento '{buscar}' SI esta en la cola." : $"El elemento '{buscar}' NO esta en la cola.");
                    else
                        Console.WriteLine("Debe ingresar un solo caracter.");
                    break;

                case 10:
                    Console.WriteLine(cola.IsFull() ? "La cola esta llena." : "La cola NO esta llena.");
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }

        } while (opcion != 0);
    }
}
