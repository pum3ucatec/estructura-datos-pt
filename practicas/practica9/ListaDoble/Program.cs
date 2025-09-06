using System;
class Program
{
    static void Main()
    {
        ListaDoble lista = new ListaDoble();
        int op;

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
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    lista.MostrarAdelante();
                    break;

                case 2:
                    lista.MostrarAtras();
                    break;

                case 3:
                    Console.Write("Ingrese un nombre: ");
                    string nombreInicio = Console.ReadLine();
                    lista.InsertarAlInicio(nombreInicio);
                    break;

                case 4:
                    Console.Write("Ingrese un nombre: ");
                    string nombreFinal = Console.ReadLine();
                    lista.InsertarAlFinal(nombreFinal);
                    break;

                case 5:
                    Console.Write("Ingrese el nombre a eliminar: ");
                    string nombreEliminar = Console.ReadLine();
                    lista.Eliminar(nombreEliminar);
                    break;

                case 6:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string nombreBuscar = Console.ReadLine();
                    lista.Buscar(nombreBuscar);
                    break;

                case 7:
                    Console.WriteLine($"Cantidad de elementos: {lista.Cantidad()}");
                    break;

                case 8:
                    Console.WriteLine(lista.EstaVacia() ? "La lista está vacía." : "La lista NO está vacía.");
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (op != 0);
    }
}
