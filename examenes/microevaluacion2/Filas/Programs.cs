using System;

class Principal
{
    static void Main(string[] args)
    {
        Fila fila = new Fila();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ Lista/Fila con NODOS =====");
            Console.WriteLine("1. Mostrar lista");
            Console.WriteLine("2. Insertar al principio");
            Console.WriteLine("3. Eliminar los datos de la derecha y la izquierda de una posición");
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
                    fila.View();
                    break;

                case 2:
                    Console.Write("Ingrese el nombre a insertar (al principio): ");
                    {
                        string valor = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(valor))
                            fila.InsertFirst(valor);
                        else
                            Console.WriteLine("Valor inválido.");
                    }
                    break;

                case 3:
                    Console.Write("Ingrese la posición (1-based) para eliminar a sus lados: ");
                    if (int.TryParse(Console.ReadLine(), out int pos))
                    {
                        fila.DeleteAround(pos);
                    }
                    else
                    {
                        Console.WriteLine("Posición inválida.");
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
