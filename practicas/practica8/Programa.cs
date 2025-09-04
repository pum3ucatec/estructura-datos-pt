using System;
using ListaSimpleApp;

class Program
{
    static void Main()
    {
        ListaSimple lista = new ListaSimple();
        int opcion;

        do
        {
            Console.WriteLine("\n=== MENÚ LISTA ENLAZADA ===");
            Console.WriteLine("1. Agregar elemento");
            Console.WriteLine("2. Mostrar lista");
            Console.WriteLine("3. Eliminar elemento");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida, intente nuevamente.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el valor a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                    {
                        lista.Agregar(numero);
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida.");
                    }
                    break;

                case 2:
                    lista.Imprimir();
                    break;

                case 3:
                    Console.Write("Ingrese el valor a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int eliminar))
                    {
                        lista.Quitar(eliminar);
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida.");
                    }
                    break;

                case 0:
                    Console.WriteLine(" Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción fuera de rango.");
                    break;
            }

        } while (opcion != 0);
    }
}
