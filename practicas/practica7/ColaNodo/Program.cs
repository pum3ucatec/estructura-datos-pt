using System;
using ColaNodo;

namespace ColaNodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola cola = new Cola();
            int opcion;

            do
            {
                Console.WriteLine("\n===== MENÚ COLA con NODOS =====");
                Console.WriteLine("1. Mostrar Cola");
                Console.WriteLine("2. Insertar (Enqueue)");
                Console.WriteLine("3. Eliminar (Dequeue)");
                Console.WriteLine("4. Ver frente (Peek)");
                Console.WriteLine("5. Verificar si está vacía");
                Console.WriteLine("6. Limpiar Cola");
                Console.WriteLine("7. Tamaño de la Cola");
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
                        cola.Dequeue();
                        break;
                    case 4:
                        cola.Peek();
                        break;
                    case 5:
                        Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola tiene elementos.");
                        break;
                    case 6:
                        cola.Clear();
                        break;
                    case 7:
                        cola.Size();
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
}