using System;

class Program
{
    static void Main(string[] args)
    {
        ListaDoble lista = new ListaDoble();
        int opcion;

        do
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("     MENÚ DE LISTA DOBLE");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Mostrar lista adelante");
            Console.WriteLine("2. Mostrar lista atrás");
            Console.WriteLine("3. Insertar nombre");
            Console.WriteLine("4. Eliminar primero");
            Console.WriteLine("5. Eliminar último");
            Console.WriteLine("6. Eliminar por posición");
            Console.WriteLine("7. Ver primer elemento");
            Console.WriteLine("8. Ver último elemento");
            Console.WriteLine("9. Ver cantidad");
            Console.WriteLine("10. Buscar nombre");
            Console.WriteLine("11. Verificar existencia");
            Console.WriteLine("12. Vaciar lista");
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
                    lista.MostrarAdelante();
                    break;

                case 2:
                    lista.MostrarAtras();
                    break;

                case 3:
                    Console.Write("Ingrese un nombre: ");
                    string nombre = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nombre))
                        lista.Insertar(nombre);
                    else
                        Console.WriteLine("Nombre inválido.");
                    break;

                case 4:
                    string elimPrimero = lista.EliminarPrimero();
                    if (elimPrimero != null)
                        Console.WriteLine($"Se eliminó: {elimPrimero}");
                    break;

                case 5:
                    string elimUltimo = lista.EliminarUltimo();
                    if (elimUltimo != null)
                        Console.WriteLine($"Se eliminó: {elimUltimo}");
                    break;

                case 6:
                    Console.Write("Ingrese posición: ");
                    if (int.TryParse(Console.ReadLine(), out int pos))
                    {
                        string eliminado = lista.EliminarEn(pos);
                        if (eliminado != null)
                            Console.WriteLine($"Se eliminó: {eliminado}");
                    }
                    else
                        Console.WriteLine("Posición inválida.");
                    break;

                case 7:
                    Console.WriteLine(lista.VerPrimero() != null
                        ? $"Primero: {lista.VerPrimero()}"
                        : "Lista vacía.");
                    break;

                case 8:
                    Console.WriteLine(lista.VerUltimo() != null
                        ? $"Último: {lista.VerUltimo()}"
                        : "Lista vacía.");
                    break;

                case 9:
                    Console.WriteLine($"Cantidad de elementos: {lista.Count()}");
                    break;

                case 10:
                    Console.Write("Ingrese nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    int posEncontrada = lista.Buscar(buscar);
                    Console.WriteLine(posEncontrada != -1
                        ? $"'{buscar}' está en la posición {posEncontrada}"
                        : "No encontrado.");
                    break;

                case 11:
                    Console.Write("Ingrese nombre a verificar: ");
                    string existe = Console.ReadLine();
                    Console.WriteLine(lista.Contiene(existe)
                        ? $"'{existe}' está en la lista."
                        : $"'{existe}' no está en la lista.");
                    break;

                case 12:
                    lista.Vaciar();
                    Console.WriteLine("Lista vaciada.");
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

