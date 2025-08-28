using System;

class Principal
{
    static void Main(string[] args)
    {
        Cola<string> cola = new Cola<string>();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA CON NODOS =====");
            Console.WriteLine("1. Mostrar Cola");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Contar elementos");
            Console.WriteLine("7. Vaciar cola (Clear)");
            Console.WriteLine("8. Verificar si contiene un valor");
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
                    Console.Write("Ingrese el valor a insertar: ");
                    string valor = Console.ReadLine()!;
                    if (!string.IsNullOrEmpty(valor))
                        cola.Enqueue(valor);
                        
                    else
                        Console.WriteLine("Valor inválido.");
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Elemento eliminado: " + cola.Dequeue());
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Frente de la cola: " + cola.Peek());
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 5:
                    Console.WriteLine(cola.EstaVacia() ? "La cola está vacía." : "La cola tiene elementos.");
                    break;
                case 6:
                    Console.WriteLine("Cantidad de elementos en la cola: " + cola.Count());
                    break;
                case 7:
                    cola.Clear();
                    Console.WriteLine("La cola ha sido vaciada.");
                    break;
                case 8:
                    Console.Write("Ingrese el valor a buscar: ");
                    string buscar = Console.ReadLine()!;
                    Console.WriteLine(cola.Contains(buscar) ? "El valor se encuentra en la cola." : "El valor NO se encuentra en la cola.");
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }
}
