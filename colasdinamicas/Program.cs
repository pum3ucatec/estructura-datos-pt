using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Cola<string> cola = new Cola<string>();
        int opcion;

        do
        {
            Console.WriteLine("\n***** MENU COLA CON NODO *****");
            Console.WriteLine("1. Enqueue (Agregar)");
            Console.WriteLine("2. Dequeue (Eliminar primero)");
            Console.WriteLine("3. Dequeue por posición");
            Console.WriteLine("4. Peek (Ver primero)");
            Console.WriteLine("5. Count (Cantidad)");
            Console.WriteLine("6. View (Ver cola)");
            Console.WriteLine("7. IsEmpty (¿Está vacía?)");
            Console.WriteLine("8. Clear (Vaciar cola)");
            Console.WriteLine("9. Contains (Buscar por dato)");
            Console.WriteLine("10. Buscar por posición");
            Console.WriteLine("11. Buscar posición de elemento");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
                opcion = -1;

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un elemento: ");
                    string elem = Console.ReadLine();
                    cola.Enqueue(elem);
                    Console.WriteLine($"'{elem}' agregado.");
                    break;

                case 2:
                    var eliminado = cola.Dequeue();
                    if (!EqualityComparer<string>.Default.Equals(eliminado, default(string)))
                        Console.WriteLine($"'{eliminado}' eliminado.");
                    break;

                case 3:
                    Console.Write("Ingrese la posición a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int posEliminar))
                    {
                        var eliminadoPos = cola.DequeueAtPosition(posEliminar);
                        if (!EqualityComparer<string>.Default.Equals(eliminadoPos, default(string)))
                            Console.WriteLine($"Elemento '{eliminadoPos}' en posición {posEliminar} eliminado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Posición inválida.");
                    }
                    break;

                case 4:
                    var primero = cola.Peek();
                    if (!EqualityComparer<string>.Default.Equals(primero, default(string)))
                        Console.WriteLine($"El primero es: {primero}");
                    break;

                case 5:
                    Console.WriteLine($"Cantidad de elementos: {cola.Count()}");
                    break;

                case 6:
                    Console.WriteLine("Elementos en la cola:");
                    cola.View();
                    break;

                case 7:
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola NO está vacía.");
                    break;

                case 8:
                    cola.Clear();
                    Console.WriteLine("Cola vaciada.");
                    break;

                case 9:
                    Console.Write("Elemento a buscar: ");
                    string buscar = Console.ReadLine();
                    Console.WriteLine(cola.Contains(buscar)
                        ? $"'{buscar}' SÍ está en la cola."
                        : $"'{buscar}' NO se encuentra en la cola.");
                    break;

                case 10:
                    Console.Write("Ingrese la posición a buscar: ");
                    if (int.TryParse(Console.ReadLine(), out int posBuscar))
                    {
                        var elemento = cola.GetElementAtPosition(posBuscar);
                        if (!EqualityComparer<string>.Default.Equals(elemento, default(string)))
                            Console.WriteLine($"Elemento encontrado en posición {posBuscar}: {elemento}");
                    }
                    else
                    {
                        Console.WriteLine("Posición inválida.");
                    }
                    break;

                case 11:
                    Console.Write("Elemento para buscar su posición: ");
                    string buscarPos = Console.ReadLine();
                    int posicion = cola.FindPosition(buscarPos);
                    if (posicion != -1)
                    {
                        Console.WriteLine($"'{buscarPos}' encontrado en la posición {posicion}.");
                    }
                    else
                    {
                        Console.WriteLine($"'{buscarPos}' no se encuentra en la cola. Revise el dato ingresado.");
                    }
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
