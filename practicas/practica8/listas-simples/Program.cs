class Program
{
    static void Main(string[] args)
    {
        ListasSimples lista = new ListasSimples();
        int opcion;

        do
        {
            Console.WriteLine("\n=== MENÚ LISTA SIMPLE ===");
            Console.WriteLine("1. Mostrar lista");
            Console.WriteLine("2. Insertar al inicio");
            Console.WriteLine("3. Insertar al final");
            Console.WriteLine("4. Eliminar en una posición");
            Console.WriteLine("5. Buscar elemento");
            Console.WriteLine("6. Contar elementos");
            Console.WriteLine("7. Verificar si está vacía");
            Console.WriteLine("8. Vaciar lista");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    lista.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese el dato: ");
                    int datoInicio = int.Parse(Console.ReadLine());
                    lista.InsertarAlInicio(datoInicio);
                    break;
                case 3:
                    Console.Write("Ingrese el dato: ");
                    int datoFinal = int.Parse(Console.ReadLine());
                    lista.InsertarAlFinal(datoFinal);
                    break;
                case 4:
                    Console.Write("Ingrese la posición a eliminar: ");
                    int pos = int.Parse(Console.ReadLine());
                    lista.EliminarDeUnaPosicion(pos);
                    break;
                case 5:
                    Console.Write("Ingrese el elemento a buscar: ");
                    int buscar = int.Parse(Console.ReadLine());
                    lista.Buscar(buscar);
                    break;
                case 6:
                    Console.WriteLine("Número de elementos: " + lista.Contar());
                    break;
                case 7:
                    Console.WriteLine(lista.EstaVacia() ? "La lista está vacía." : "La lista tiene elementos.");
                    break;
                case 8:
                    lista.Vaciar();
                    Console.WriteLine("La lista ha sido vaciada.");
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
