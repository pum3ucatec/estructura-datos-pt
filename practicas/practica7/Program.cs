using System;

class Principal
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA con NODOS =====");
            Console.WriteLine("1. Mostrar Cola(View)");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía(IsEmpty)");
            Console.WriteLine("6. Cantidad de elementos (Count)");
            Console.WriteLine("7. Buscar elemento (Contains)");
            Console.WriteLine("8. Limpiar Cola (Clear)");
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
                    cola.View();
                    break;
                case 2:
                    Console.Write("Ingrese el nombre a insertar: ");
                    string? valor = Console.ReadLine();
                    if (!string.IsNullOrEmpty(valor))
                    {
                        cola.Enqueue(valor);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 3:
                    cola.Dequeue();
                    break;
                case 4:
                    string? frente = cola.Peek();
                    if (frente != null)
                        Console.WriteLine($"Frente de la cola: {frente}");
                    break;
                case 5:
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola NO está vacía.");
                    break;
                case 6:
                    Console.WriteLine($"La cola tiene {cola.GetCount()} elemento(s).");
                    break;
                case 7:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string? buscar = Console.ReadLine();
                    if (!string.IsNullOrEmpty(buscar))
                        Console.WriteLine(cola.Contains(buscar) ? $"El nombre '{buscar}' SÍ está en la cola." : $"El nombre '{buscar}' NO está en la cola.");
                    else
                        Console.WriteLine("Debe ingresar un nombre válido.");
                    break;
                case 8:
                    cola.Clear();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Error, opción no valida.");
                    break;
            }
        } while (opcion != 0);
    }
}