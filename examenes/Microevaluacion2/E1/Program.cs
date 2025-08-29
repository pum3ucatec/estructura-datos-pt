using System;

class Principal
{
    static void Main(string[] args)
    {
        Lista lista = new Lista();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ LISTA SIMPPLE=====");
            Console.WriteLine("1. Mostrar Lista");
            Console.WriteLine("2. Insertar al principio");
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
                    lista.View();
                    break;

                case 2:
                    Console.Write("Ingrese el nombre a insertar: ");
                    string valor = Console.ReadLine();
                    if (!string.IsNullOrEmpty(valor))
                    {
                        cola.Enqueue(valor);
                        Console.WriteLine($"'{valor}' fue insertado en la cola.");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}