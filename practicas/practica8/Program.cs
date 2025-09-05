
class Principal
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();
        int opcion = -1;

        do
        {
            Console.WriteLine("\n===== MENÚ LISTA SIMPLE =====");
            Console.WriteLine("1. Mostrar Lista (Ver)");
            Console.WriteLine("2. Insertar al inicio");
            Console.WriteLine("3. Insertar al final");
            Console.WriteLine("4. Eliminar (por valor)");
            Console.WriteLine("5. Buscar (Contiene)");
            Console.WriteLine("6. ¿Está vacía?");
            Console.WriteLine("7. Contar elementos");
            Console.WriteLine("8. Vaciar lista");
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
                    lista.Ver();
                    break;

                case 2:
                    Console.Write("Valor a insertar al inicio: ");
                    string vInicio = Console.ReadLine();
                    if (!string.IsNullOrEmpty(vInicio)) lista.InsertarAlInicio(vInicio);
                    else Console.WriteLine("Valor inválido.");
                    break;

                case 3:
                    Console.Write("Valor a insertar al final: ");
                    string vFinal = Console.ReadLine();
                    if (!string.IsNullOrEmpty(vFinal)) lista.InsertarAlFinal(vFinal);
                    else Console.WriteLine("Valor inválido.");
                    break;

                case 4:
                    Console.Write("Valor a eliminar: ");
                    string aEliminar = Console.ReadLine();
                    string eliminado = lista.Eliminar(aEliminar);
                    if (eliminado != null) Console.WriteLine($"Se eliminó: {eliminado}");
                    else Console.WriteLine("No se encontró el valor.");
                    break;

                case 5:
                    Console.Write("Valor a buscar: ");
                    string buscar = Console.ReadLine();
                    Console.WriteLine(lista.Contiene(buscar) ? "El elemento está en la lista." : "No se encontró el elemento.");
                    break;

                case 6:
                    Console.WriteLine(lista.EstaVacia() ? "La lista está vacía." : "La lista tiene elementos.");
                    break;

                case 7:
                    Console.WriteLine("Cantidad de elementos: " + lista.Count());
                    break;

                case 8:
                    lista.Vaciar();
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }
}
