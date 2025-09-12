class Program
{
    static void Main(string[] args)
    {
        ListasDobles lista = new ListasDobles();
        int opcion;

        do
        {
            Console.WriteLine("\n=== MENÚ LISTA DOBLE ===");
            Console.WriteLine("1. Mostrar lista hacia adelante");
            Console.WriteLine("2. Mostrar lista hacia atrás");
            Console.WriteLine("3. Insertar al inicio");
            Console.WriteLine("4. Insertar al final");
            Console.WriteLine("5. Eliminar al inicio");
            Console.WriteLine("6. Eliminar al final");
            Console.WriteLine("7. Eliminar en una posición específica");
            Console.WriteLine("8. Buscar un elemento");
            Console.WriteLine("9. Contar elementos");
            Console.WriteLine("10. Verificar si está vacía");
            Console.WriteLine("11. Vaciar lista");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    lista.MostrarHaciaAdelante();
                    break;
                case 2:
                    lista.MostrarHaciaAtras();
                    break;
                case 3:
                    Console.Write("Ingrese el dato: ");
                    int datoInicio = int.Parse(Console.ReadLine());
                    lista.InsertarAlInicio(datoInicio);
                    break;
                case 4:
                    Console.Write("Ingrese el dato: ");
                    int datoFinal = int.Parse(Console.ReadLine());
                    lista.InsertarAlFinal(datoFinal);
                    break;
                case 5:
                    lista.EliminarAlInicio();
                    break;
                case 6:
                    lista.EliminarAlFinal();
                    break;
                case 7:
                    Console.Write("Ingrese la posición a eliminar: ");
                    int pos = int.Parse(Console.ReadLine());
                    lista.EliminarEnPosicion(pos);
                    break;
                case 8:
                    Console.Write("Ingrese el elemento a buscar: ");
                    int buscar = int.Parse(Console.ReadLine());
                    lista.Buscar(buscar);
                    break;
                case 9:
                    Console.WriteLine("La lista tiene " + lista.Contar() + " elementos.");
                    break;
                case 10:
                    Console.WriteLine(lista.EstaVacia() ? "La lista está vacía." : "La lista tiene elementos.");
                    break;
                case 11:
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
