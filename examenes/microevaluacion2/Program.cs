using System;

class Microevaluacion2
{
    static void Main(string[] args)
    {
        SimpleList list = new SimpleList();
        int op;

        do
        {
            Console.WriteLine("===== Lista =====");
            Console.WriteLine("1. Mostrar Lista");
            Console.WriteLine("2. Insertar al principio");
            Console.WriteLine("3. Eliminar alrededor");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Seleccione una opcion:");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    list.Mostrar();
                    break;
                case 2:
                    Console.WriteLine("Ingrese el nombre:");
                    string? name = Console.ReadLine();
                    list.AddFirst(name);
                    break;
                case 3:
                    Console.WriteLine("Ingrese el nombre para eliminar su alrededor:");
                    string? nameCentral = Console.ReadLine();
                    list.RemoveAround(nameCentral);
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Error, opcion no valida.");
                    break;
            }
        } while (op != 0);
    }
}