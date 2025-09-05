using System;
class Program
{
    static void Main(string[] args)
    {

        ListaDoble lista = new ListaDoble();
        int opcion;
        do
        {
            Console.WriteLine("\n=== MENÚ LISTA DOBLE ===");
            Console.WriteLine("1. Mostrar lista hacia adelante");
            Console.WriteLine("2. Mostrar lista hacia atrás");
            Console.WriteLine("3. Insertar al inicio");
            Console.WriteLine("4. Insertar al final");
            Console.WriteLine("5. Eliminar elemento");
            Console.WriteLine("6. Buscar un elemento");
            Console.WriteLine("7. Contar elementos");
            Console.WriteLine("8. Verificar si está vacía");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            opcion = int.Parse(Console.ReadLine() ?? "0");

            switch (opcion)
            {
                case 1:
                    lista.MostrarHaciaDelante();
                    lista.LimpiarPantalla();
                    break;

                case 2:
                    lista.MostrarHaciaAtras();
                    lista.LimpiarPantalla();
                    break;

                case 3:
                    Console.Write("Ingrese el dato:");
                    int datoInicio = int.Parse(Console.ReadLine() ?? "0");
                    lista.InsertarAlInicio(datoInicio);
                    lista.LimpiarPantalla();
                    break;

                case 4:
                    Console.Write("Ingrese el dato: ");
                    int datoFinal = int.Parse(Console.ReadLine() ?? "0");
                    lista.InsertarAlFinal(datoFinal);
                    lista.LimpiarPantalla();
                    break;

                case 5:
                    Console.Write("Ingrese el valor a eliminar: ");
                    int valor = int.Parse(Console.ReadLine() ?? "1");
                    lista.EliminarPorValor(valor);
                    lista.LimpiarPantalla();
                    break;

                case 6:
                    Console.Write("Ingrese el elemento a buscar: ");
                    int buscar = int.Parse(Console.ReadLine() ?? "1");
                    lista.Buscar(buscar);
                    lista.LimpiarPantalla();
                    break;

                case 7:
                    Console.WriteLine($"La lista tiene {lista.Contar()} elementos.");
                    lista.LimpiarPantalla();
                    break;

                case 8:
                    Console.WriteLine(lista.Empty() ? "La lista está vacía." : "La lista tiene elementos.");
                    lista.LimpiarPantalla();
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;


            }
        } while (opcion != 0);
    }


}