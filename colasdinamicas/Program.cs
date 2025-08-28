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
            Console.WriteLine("2. Dequeue (Eliminar)");
            Console.WriteLine("3. Peek (Ver primero)");
            Console.WriteLine("4. Count (Cantidad)");
            Console.WriteLine("5. View (Ver cola)");
            Console.WriteLine("6. IsEmpty (¿Está vacía?)");
            Console.WriteLine("7. Clear (Vaciar cola)");
            Console.WriteLine("8. Contains (Buscar)");
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
                    var primero = cola.Peek();
                    if (!EqualityComparer<string>.Default.Equals(primero, default(string)))
                        Console.WriteLine($"El primero es: {primero}");
                    break;

                case 4:
                    Console.WriteLine($"Cantidad de elementos: {cola.Count()}");
                    break;

                case 5:
                    Console.WriteLine("Elementos en la cola:");
                    cola.View();
                    break;

                case 6:
                    Console.WriteLine(cola.IsEmpty() ? " La cola está vacía." : "La cola NO está vacía.");
                    break;

                case 7:
                    cola.Clear();
                    Console.WriteLine("Cola vaciada.");
                    break;

                case 8:
                    Console.Write("Elemento a buscar: ");
                    string buscar = Console.ReadLine();
                    Console.WriteLine(cola.Contains(buscar)
                        ? $" '{buscar}' SÍ está en la cola."
                        : $" '{buscar}' NO se encuentra en la cola.");
                    break;

                case 0:
                    Console.WriteLine(" Saliendo...");
                    break;

                default:
                    Console.WriteLine(" Opción inválida.");
                    break;
            }
        } while (opcion != 0);
    }
}
