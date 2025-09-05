using System;

class Practica9
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();
        int opcion;

        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===== MENÚ LISTA SIMPLE =====");
            Console.ResetColor();

            Console.WriteLine("1. Ver lista");
            Console.WriteLine("2. Insertar elemento");
            Console.WriteLine("3. Eliminar elemento");
            Console.WriteLine("4. Buscar elemento");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Contar elementos");
            Console.WriteLine("7. Vaciar lista");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine(" Ingrese un número válido.");
                Console.ReadKey();
                continue;
            }

            switch (opcion)
            {
                case 1:
                    lista.Ver();
                    break;

                case 2:
                    Console.WriteLine("¿Dónde desea insertar?");
                    Console.WriteLine("1. Al inicio");
                    Console.WriteLine("2. Al final");
                    Console.Write("Seleccione: ");
                    string valor = Console.ReadLine();
                    Console.Write("Ingrese el valor: ");
                    string nuevo = Console.ReadLine();

                    if (!string.IsNullOrEmpty(nuevo))
                    {
                        if (valor == "1") lista.InsertarAlInicio(nuevo);
                        else if (valor == "2") lista.InsertarAlFinal(nuevo);
                        else Console.WriteLine(" Opción inválida.");
                    }
                    else
                    {
                        Console.WriteLine(" Valor inválido.");
                    }
                    break;

                case 3:
                    Console.Write("Valor a eliminar: ");
                    string borrar = Console.ReadLine();
                    string eliminado = lista.Eliminar(borrar);
                    Console.WriteLine(eliminado != null ? $" Se eliminó: {eliminado}" : " No se encontró el valor.");
                    break;

                case 4:
                    Console.Write("Valor a buscar: ");
                    string buscar = Console.ReadLine();
                    Console.WriteLine(lista.Contiene(buscar) ? "El elemento está en la lista." : " No se encontró.");
                    break;

                case 5:
                    Console.WriteLine(lista.EstaVacia() ? "La lista está vacía." : "La lista tiene elementos.");
                    break;

                case 6:
                    Console.WriteLine("Cantidad de elementos: " + lista.Count());
                    break;

                case 7:
                    lista.Vaciar();
                    Console.WriteLine(" Lista vaciada correctamente.");
                    break;

                case 0:
                    Console.WriteLine(" Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine(" Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();

        } while (opcion != 0);
    }
}
