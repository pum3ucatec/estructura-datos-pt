using System;

namespace Pregunta1
{
    class Principal
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            int opcion;

            do
            {
                Console.WriteLine("\n--- Menú de opciones ---");
                Console.WriteLine("1. Mostrar lista");
                Console.WriteLine("2. Insertar al inicio");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        lista.Mostrar();
                        break;

                    case 2:
                        Console.Write("Ingrese el valor a insertar: ");
                        string valor = Console.ReadLine();
                        if (!string.IsNullOrEmpty(valor))
                        {
                            lista.InsertarInicio(valor);
                            Console.WriteLine($"'{valor}' insertado al inicio.");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 3);
        }
    }
}
