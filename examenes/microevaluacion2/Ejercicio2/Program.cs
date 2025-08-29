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
                Console.WriteLine("\n===== MENÚ Lista con NODOS =====");
                Console.WriteLine("1. Mostrar Lista");
                Console.WriteLine("2. Insertar (Agregar al final)");
                Console.WriteLine("3. Eliminar (Quitar del principio)");
                Console.WriteLine("4. Ver primer elemento");
                Console.WriteLine("5. Verificar si está vacía");
                Console.WriteLine("6. Insertar al principio de la lista");
                Console.WriteLine("7. Verificar la cantidad de elementos");
                Console.WriteLine("8. Buscar elemento");
                Console.WriteLine("9. Eliminar en una posición específica");
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
                        Console.Write("Ingrese el valor a insertar: ");
                        string valor = Console.ReadLine();
                        cola.Enqueue(valor);
                        break;
                    case 3:
                        cola.Dequeue();
                        break;
                    case 4:
                        cola.Peek();
                        break;
                    case 5:
                        Console.WriteLine(cola.IsEmpty() ? "La lista está vacía." : "La lista tiene elementos.");
                        break;
                    case 6:
                        Console.Write("Ingrese el valor a insertar al principio: ");
                        string nombre = Console.ReadLine();
                        cola.InsertarAlPrincipio(nombre);
                        break;
                    case 7:
                        cola.Count();
                        break;
                    case 8:
                        Console.Write("Ingrese el elemento a buscar: ");
                        string elemento = Console.ReadLine();
                        cola.Buscar(elemento);
                        break;
                    case 9:
                        Console.Write("Ingrese la posición a eliminar (empezando en 0): ");
                        if (int.TryParse(Console.ReadLine(), out int pos))
                        {
                            cola.EliminarEnPosicion(pos);
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar un número válido.");
                        }
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