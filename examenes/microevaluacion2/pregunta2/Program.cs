using System;

namespace Pregunta2
{
    class Program
    {
        static void Main()
        {
            Cola cola = new Cola();
            string[] valoresIniciales = { "P", "K", "A", "D", "D", "A" };
            cola.CargarInicial(valoresIniciales);

            int opcion;
            do
            {
                Console.WriteLine("\n--- Menú de opciones ---");
                Console.WriteLine("1. Mostrar lista");
                Console.WriteLine("2. Eliminar alrededor de un valor");
                Console.WriteLine("3. Ingresar letra");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine() ?? "0");

                switch (opcion)
                {
                    case 1:
                        cola.Mostrar();
                        break;

                    case 2:
                        Console.Write("Ingrese el valor alrededor del cual desea eliminar: ");
                        string valor = Console.ReadLine() ?? "";
                        cola.EliminarAlrededor(valor);
                        break;

                    case 3:
                        Console.Write("Ingrese la letra a agregar: ");
                        string letra = Console.ReadLine() ?? "";
                        if (!string.IsNullOrWhiteSpace(letra))
                        {
                            cola.InsertarAlFinal(letra);
                            Console.WriteLine($"'{letra}' agregado a la lista.");
                        }
                        else
                        {
                            Console.WriteLine("No se ingresó una letra válida.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
