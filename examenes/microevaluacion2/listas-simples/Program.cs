class Program
{
    static void Main(string[] args)
    {
        ListaSimple listaSimple = new ListaSimple();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ LISTA SIMPLE con NODOS =====");
            Console.WriteLine("1. Insertar al inicio");
            Console.WriteLine("2. Eliminar alrededor de un elemento");
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
                    Console.Write("Ingrese el elemento a insertar: ");
                    string valor = Console.ReadLine();
                    listaSimple.InsertarInicio(valor);
                    break;
                    
                case 2:
                    Console.Write("Ingrese el elemento a eliminar alrededor: ");
                    string elemento = Console.ReadLine();
                    listaSimple.EliminarAlrededor(elemento);
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    break;
            }
        }
        while (opcion != 0);
    }
}