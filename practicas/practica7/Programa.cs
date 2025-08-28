using System;

class Principal
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la capacidad de la cola (0 = ilimitada): ");
        int cap;
        if (!int.TryParse(Console.ReadLine(), out cap) || cap < 0)
            cap = 0;

        Cola cola = (cap == 0) ? new Cola() : new Cola(cap);

        int opcion;
        do
        {
            Console.WriteLine("\n===== MENÚ COLA con NODOS =====");
            Console.WriteLine("1. Mostrar Cola");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Cantidad de elementos (Count)");
            Console.WriteLine("6. Capacidad de la cola");
            Console.WriteLine("7. Buscar un elemento (Contains)");
            Console.WriteLine("8. Verificar si está vacía (IsEmpty)");
            Console.WriteLine("9. Verificar si está llena (IsFull)");
            Console.WriteLine("10. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    cola.View();
                    break;

                case 2:
                    Console.Write("Ingrese el nombre a insertar: ");
                    string valor = Console.ReadLine();
                    if (!string.IsNullOrEmpty(valor))
                    {
                        cola.Enqueue(valor);
                        Console.WriteLine($"'{valor}' agregado a la cola.");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;

                case 3:
                    string eliminado = cola.Dequeue();
                    if (eliminado != null)
                        Console.WriteLine($"Elemento eliminado: {eliminado}");
                    break;

                case 4:
                    string peek = cola.Peek();
                    Console.WriteLine(peek == null ? "La cola está vacía." : $"Primer elemento: {peek}");
                    break;

                case 5:
                    Console.WriteLine($"Cantidad de elementos en la cola: {cola.Count()}");
                    break;

                case 6:
                    Console.WriteLine($"Capacidad de la cola: {cola.Capacity()}");
                    break;

                case 7:
                    Console.Write("Ingrese el valor a buscar: ");
                    string buscar = Console.ReadLine();
                    Console.WriteLine(cola.Contains(buscar) ? "El elemento está en la cola." : "El elemento no está en la cola.");
                    break;

                case 8:
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola no está vacía.");
                    break;

                case 9:
                    Console.WriteLine(cola.IsFull() ? "La cola está llena." : "La cola no está llena.");
                    break;

                case 10:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 10);
    }
}