using System;

class Program
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();
        int opcion;

        do
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("       MENÚ DE LISTA SIMPLE");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Mostrar lista");
            Console.WriteLine("2. Insertar nombre");
            Console.WriteLine("3. Eliminar primero");
            Console.WriteLine("4. Eliminar por posición");
            Console.WriteLine("5. Ver primer elemento");
            Console.WriteLine("6. Ver cantidad");
            Console.WriteLine("7. Buscar nombre y posición");
            Console.WriteLine("8. Verificar existencia");
            Console.WriteLine("9. Vaciar lista");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    lista.Mostrar();
                    break;

                case 2:
                    Console.Write("Ingrese un nombre: ");
                    string nombre = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nombre))
                        lista.Insertar(nombre);
                    else
                        Console.WriteLine("Nombre inválido.");
                    break;

                case 3:
                    string eliminado = lista.EliminarPrimero();
                    if (eliminado != null)
                        Console.WriteLine($"Se eliminó: {eliminado}");
                    break;

                case 4:
                    Console.Write("Ingrese la posición a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int pos))
                    {
                        string eliminadoPos = lista.EliminarEn(pos);
                        if (eliminadoPos != null)
                            Console.WriteLine($"Se eliminó: {eliminadoPos}");
                    }
                    else
                        Console.WriteLine("Posición inválida.");
                    break;

                case 5:
                    string primero = lista.VerPrimero();
                    Console.WriteLine(primero != null ? $"Primero: {primero}" : "La lista está vacía.");
                    break;

                case 6:
                    Console.WriteLine($"La lista tiene {lista.Count()} elementos.");
                    break;

                case 7:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    int posBuscada = lista.Buscar(buscar);
                    Console.WriteLine(posBuscada != -1
                        ? $"'{buscar}' está en la posición {posBuscada}"
                        : "No se encontró el nombre.");
                    break;

                case 8:
                    Console.Write("Ingrese el nombre a verificar: ");
                    string existe = Console.ReadLine();
                    Console.WriteLine(lista.Contiene(existe)
                        ? $"'{existe}' está en la lista."
                        : $"'{existe}' no está en la lista.");
                    break;

                case 9:
                    lista.Vaciar();
                    Console.WriteLine("La lista fue vaciada.");
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}
