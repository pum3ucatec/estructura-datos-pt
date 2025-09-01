using System;

namespace ListaSimples 
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaSimple lista = new ListaSimple();
            int opcion, valor;

            do
            {
                Console.WriteLine("\n===== MENÚ LISTA SIMPLE =====");
                Console.WriteLine("1. Insertar al inicio");
                Console.WriteLine("2. Insertar al final");
                Console.WriteLine("3. Eliminar un valor");
                Console.WriteLine("4. Buscar un valor");
                Console.WriteLine("5. Mostrar lista");
                Console.WriteLine("6. Salir");
                Console.Write("Elige una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingresa un valor: ");
                        if (int.TryParse(Console.ReadLine(), out valor))
                            lista.InsertarInicio(valor);
                        else
                            Console.WriteLine("Valor inválido.");
                        break;
                    case 2:
                        Console.Write("Ingresa un valor: ");
                        if (int.TryParse(Console.ReadLine(), out valor))
                            lista.InsertarFinal(valor);
                        else
                            Console.WriteLine("Valor inválido.");
                        break;
                    case 3:
                        Console.Write("Ingresa el valor a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out valor))
                            lista.Eliminar(valor);
                        else
                            Console.WriteLine("Valor inválido.");
                        break;
                    case 4:
                        Console.Write("Ingresa el valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out valor))
                        {
                            bool encontrado = lista.Buscar(valor);
                            Console.WriteLine(encontrado ? "Valor encontrado." : "Valor no encontrado.");
                        }
                        else
                            Console.WriteLine("Valor inválido.");
                        break;
                    case 5:
                        lista.Mostrar();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (opcion != 6);
        }
    }
}
