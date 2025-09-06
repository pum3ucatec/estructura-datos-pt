class Principal
{
    static void Main(string[] args)
    {
        ListaDoble lista = new ListaDoble();
        int opcion = -1;

        do
        {
            Console.WriteLine("\n===== MENÚ LISTA DOBLE =====");
            Console.WriteLine("1. Insertar al inicio");
            Console.WriteLine("2. Insertar al final");
            Console.WriteLine("3. Eliminar del inicio");
            Console.WriteLine("4. Eliminar del final");
            Console.WriteLine("5. Mostrar adelante");
            Console.WriteLine("6. Mostrar atrás");
            Console.WriteLine("7. Buscar");
            Console.WriteLine("0. Salir");
            Console.Write("Elija una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Dato a insertar: ");
                    string d1 = Console.ReadLine();
                    lista.InsertarInicio(d1);
                    break;

                case 2:
                    Console.Write("Dato a insertar: ");
                    string d2 = Console.ReadLine();
                    lista.InsertarFinal(d2);
                    break;

                case 3:
                    string eliminado1 = lista.EliminarInicio();
                    if (eliminado1 != null)
                        Console.WriteLine("Se eliminó: " + eliminado1);
                    else
                        Console.WriteLine("La lista está vacía.");
                    break;

                case 4:
                    string eliminado2 = lista.EliminarFinal();
                    if (eliminado2 != null)
                        Console.WriteLine("Se eliminó: " + eliminado2);
                    else
                        Console.WriteLine("La lista está vacía.");
                    break;

                case 5:
                    lista.MostrarAdelante();
                    break;

                case 6:
                    lista.MostrarAtras();
                    break;

                case 7:
                    Console.Write("Dato a buscar: ");
                    string b = Console.ReadLine();
                    if (lista.Buscar(b))
                        Console.WriteLine("El dato está en la lista.");
                    else
                        Console.WriteLine("El dato NO está en la lista.");
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
