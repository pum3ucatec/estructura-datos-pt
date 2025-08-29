using System;

class Program
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();
        ListaSimple lista = new ListaSimple();
        int opcion;

        do
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("        MENÚ PRINCIPAL");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Mostrar lista");
            Console.WriteLine("2. Insertar al principio en Lista Simple");
            Console.WriteLine("3. Eliminar alrededor de un valor en Lista Simple");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione la opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine(" Opción inválida.");
                continue;
            }

            switch (opcion)
            {
                case 1: cola.Mostrar(); break;

                case 2:
                    Console.Write("Ingrese un número para insertar al principio: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                        lista.InsertarAlPrincipio(valor);
                    else
                        Console.WriteLine(" Valor inválido.");
                    break;

                case 3:
                    Console.Write("Ingrese el valor para eliminar alrededor: ");
                    if (int.TryParse(Console.ReadLine(), out int v))
                        lista.EliminarAlrededor(v);
                    else
                        Console.WriteLine(" Valor inválido.");
                    break;

                case 0:
                    Console.WriteLine(" Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine(" Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}