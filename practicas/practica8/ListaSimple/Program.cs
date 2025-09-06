using System;
class Program
{
    static void Main()
    {
        ListaSimple lista = new ListaSimple();
        int op;

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
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    lista.Mostrar();
                    break;

                case 2:
                    Console.Write("Ingrese un nombre: ");
                    string nombreInicio = Console.ReadLine();
                    lista.InsertarAlInicio(nombreInicio);
                    break;

                case 3:
                    Console.Write("Ingrese un nombre: ");
                    string nombreFinal = Console.ReadLine();
                    lista.InsertarAlFinal(nombreFinal);
                    break;

                case 4:
                    Console.Write("Ingrese el nombre a eliminar: ");
                    string nombreEliminar = Console.ReadLine();
                    lista.Eliminar(nombreEliminar);
                    break;

                case 5:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string nombreBuscar = Console.ReadLine();
                    lista.Buscar(nombreBuscar);
                    break;

                case 6:
                    Console.WriteLine($"Cantidad de elementos: {lista.Cantidad()}");
                    break;

                case 7:
                    Console.WriteLine(lista.EstaVacia() ? "La lista está vacía." : "La lista no está vacía.");
                    break;

                case 0:
                    Console.WriteLine("Bye Bye :p");
                    break;

                default:
                    Console.WriteLine("Opción no válida!!!!!");
                    break;
            }

        } while (op != 0);
    }
}
