class Program
{
    static void Main(string[] args)
    {
        ListaSimple listaSimple = new ListaSimple();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ LISTA SIMPLE =====");
            Console.WriteLine("1. Mostrar lista simple");
            Console.WriteLine("2. Insertar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Ver cima");
            Console.WriteLine("5. Verificar si está vacía");
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
                    listaSimple.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese el número a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int valorInsertar))
                    {
                        listaSimple.Insertar(valorInsertar);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 3:
                    Console.Write("Ingrese el número a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int valorEliminar))
                    {
                        listaSimple.Eliminar(valorEliminar);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 4:
                    int cima = listaSimple.Peek();
                    if (cima != -1)
                        Console.WriteLine($"Elemento en la cima: {cima}");
                    break;
                case 5:
                    Console.WriteLine(listaSimple.IsEmpty() ? "La lista está vacía." : "La lista NO está vacía.");
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