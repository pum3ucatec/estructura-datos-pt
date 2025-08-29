class Program
{
    static void Main()
    {
        ListasSimples lista = new ListasSimples();
        char opcion;
        do
        {
            Console.WriteLine("1. Insertar al principio");
            Console.WriteLine("2. Mostrar lista");
            Console.WriteLine("3. Eliminar alrededor de la posicion");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            opcion = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (opcion)
            {
                case '1':
                    Console.Write("Ingrese un nombre: ");
                    string nombre = Console.ReadLine()!;
                    lista.InsertarAlPrincipio(nombre);
                    break;
                case '2':
                    lista.Mostrar();
                    break;

                case '3':
                    lista.Mostrar();
                    break;

                case '0':
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            
            }
        } while (opcion != '0');
    }
}