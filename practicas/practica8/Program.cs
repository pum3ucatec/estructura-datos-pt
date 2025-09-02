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
            Console.WriteLine("\nMENÚ LISTA SIMPLE");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un número: ");
                    int numero = int.Parse(Console.ReadLine());
                    lista.Insertar(numero);
                    break;

                case 2:
                    lista.Mostrar();
                    break;

                case 3:
                    Console.Write("Ingrese el número a eliminar: ");
                    int eliminar = int.Parse(Console.ReadLine());
                    lista.Eliminar(eliminar);
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }
}
