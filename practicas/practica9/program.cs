using System;

class listas_dobles
{
    static void Main(string[] args)
    {
        lista_doble lista = new lista_doble();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENU LISTA DOBLE =====");
            Console.WriteLine("1. Mostrar lista hacia adelante");
            Console.WriteLine("2. Mostrar lista hacia atrás");
            Console.WriteLine("3. Insertar al inicio");
            Console.WriteLine("4. Insertar al final");
            Console.WriteLine("5. Eliminar elemento");
            Console.WriteLine("6. Buscar elemento");
            Console.WriteLine("7. Cantidad de elementos");
            Console.WriteLine("8. Verificar si esta vacia");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un numero valido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    lista.mostrar_adelante();
                    break;

                case 2:
                    lista.mostrar_atras();
                    break;

                case 3:
                    Console.Write("Ingrese el valor a insertar al inicio: ");
                    string inicio = Console.ReadLine();
                    if (!string.IsNullOrEmpty(inicio))
                        lista.insertar_inicio(inicio);
                    break;

                case 4:
                    Console.Write("Ingrese el valor a insertar al final: ");
                    string final = Console.ReadLine();
                    if (!string.IsNullOrEmpty(final))
                        lista.insertar_final(final);
                    break;

                case 5:
                    Console.Write("Ingrese el valor a eliminar: ");
                    string eliminar = Console.ReadLine();
                    if (!string.IsNullOrEmpty(eliminar))
                        lista.eliminar(eliminar);
                    break;

                case 6:
                    Console.Write("Ingrese el valor a buscar: ");
                    string buscar = Console.ReadLine();
                    if (!string.IsNullOrEmpty(buscar))
                        Console.WriteLine(lista.contiene(buscar) ? $"El elemento '{buscar}' esta en la lista." : $"El elemento '{buscar}' no esta en la lista.");
                    break;

                case 7:
                    Console.WriteLine($"La lista tiene {lista.contar()} elemento(s).");
                    break;

                case 8:
                    Console.WriteLine(lista.esta_vacia() ? "La lista esta vacia." : "La lista NO esta vacia.");
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Error, opcion no valida.");
                    break;
            }

        } while (opcion != 0);
    }
}
