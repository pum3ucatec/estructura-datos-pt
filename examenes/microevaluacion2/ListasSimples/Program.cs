using System;
class Program
{
    static void Main()
    {
        Lista lista = new Lista();
        int opcion;

        do
        {
            Console.WriteLine("\n--- MENU LISTA SIMPLE ---");
            Console.WriteLine("1. Insertar nombre al principio");
            Console.WriteLine("2. Eliminar alrededor de un nombre");
            Console.WriteLine("3. Mostrar lista");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un nombre: ");
                    string nombre = Console.ReadLine();
                    lista.InsertarAlPrincipio(nombre);
                    break;

                case 2:
                    Console.Write("Ingrese el nombre del que quiere eliminar sus alrededores: ");
                    string nombreEliminar = Console.ReadLine();
                    lista.EliminarAlrededor(nombreEliminar);
                    break;

                case 3:
                    lista.View();
                    break;

                case 0:
                    Console.WriteLine("Adios, vuelva prontos...");
                    break;

                default:
                    Console.WriteLine("Error! Opción no valida");
                    break;
            }

        } while (opcion != 0);
    }
}
