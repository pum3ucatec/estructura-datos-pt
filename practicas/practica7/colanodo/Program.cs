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
            Console.WriteLine("1. Mostrar Cola (View)");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía (IsEmpty)");
            Console.WriteLine("6. Contar elementos (Count)");
            Console.WriteLine("7. Limpiar cola (Clear)");
            Console.WriteLine("8. Buscar elemento (Contains)");
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
                    string valor = Console.ReadLine();
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
                    string eliminado = cola.Dequeue();
                    if (eliminado != null)
                        Console.WriteLine($"Se eliminó: {eliminado}");
                    else
                        Console.WriteLine("La cola está vacía.");
                    break;
                case 4:
                    string frente = cola.Peek();
                    if (frente != null)
                        Console.WriteLine($"El frente es: {frente}");
                    else
                        Console.WriteLine("La cola está vacía.");
                    break;
                case 5:
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola tiene elementos.");
                    break;
                case 6:
                    Console.WriteLine($"Cantidad de elementos: {cola.Count()}");
                    break;
                case 7:
                    cola.Clear();
                    Console.WriteLine("Cola vaciada correctamente.");
                    break;
                case 8:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string buscado = Console.ReadLine();
                    Console.WriteLine(cola.Contains(buscado) ? "El elemento está en la cola." : "No se encontró el elemento.");
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