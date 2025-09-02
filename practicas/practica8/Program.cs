using System;

class Principal
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENU LISTA SIMPLE =====");
            Console.WriteLine("1. Mostrar lista");
            Console.WriteLine("2. Insertar al inicio");
            Console.WriteLine("3. Insertar al final");
            Console.WriteLine("4. Eliminar elemento");
            Console.WriteLine("5. Buscar elemento");
            Console.WriteLine("6. Cantidad de elementos");
            Console.WriteLine("7. Verificar si está vacía");
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
                    lista.Mostrar();
                    break;

                case 2:
                    Console.Write("Ingrese el valor a insertar al inicio: ");
                    string inicio = Console.ReadLine();
                    if (!string.IsNullOrEmpty(inicio))
                        lista.InsertarInicio(inicio);
                    break;

                case 3:
                    Console.Write("Ingrese el valor a insertar al final: ");
                    string final = Console.ReadLine();
                    if (!string.IsNullOrEmpty(final))
                        lista.InsertarFinal(final);
                    break;

                case 4:
                    Console.Write("Ingrese el valor a eliminar: ");
                    string eliminar = Console.ReadLine();
                    if (!string.IsNullOrEmpty(eliminar))
                        lista.Eliminar(eliminar);
                    break;

                case 5:
                    Console.Write("Ingrese el valor a buscar: ");
                    string buscar = Console.ReadLine();
                    if (!string.IsNullOrEmpty(buscar))
                        Console.WriteLine(lista.Contiene(buscar) ? $"El elemento '{buscar}' esta en la lista." : $"El elemento '{buscar}' no esta en la lista.");
                    break;

                case 6:
                    Console.WriteLine($"La lista tiene {lista.Contar()} elemento(s).");
                    break;

                case 7:
                    Console.WriteLine(lista.EstaVacia() ? "La lista está vacia." : "La lista NO está vacia.");
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no valida.");
                    break;
            }

        } while (opcion != 0);
    }
}
