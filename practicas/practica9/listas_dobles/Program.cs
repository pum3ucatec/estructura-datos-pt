// Lista Doble
using System;
using System.Collections.Generic;
using System.Linq;

namespace listas_dobles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista doblemente enlazada
            LinkedList<int> listaDoble = new LinkedList<int>();

            // Agregar elementos a la lista
            listaDoble.AddLast(10);
            listaDoble.AddLast(20);
            listaDoble.AddLast(30);
            listaDoble.AddFirst(5); // Agregar al inicio

            // Mostrar los elementos de la lista
            Console.WriteLine("Elementos en la lista doble:");
            foreach (var item in listaDoble)
            {
                Console.WriteLine(item);
            }

            // Eliminar un elemento
            listaDoble.Remove(20);

            // Mostrar los elementos después de la eliminación
            Console.WriteLine("\nElementos después de eliminar 20:");
            foreach (var item in listaDoble)
            {
                Console.WriteLine(item);
            }

            // Acceder al primer y último elemento
            Console.WriteLine($"\nPrimer elemento: {listaDoble.First.Value}");
            Console.WriteLine($"Último elemento: {listaDoble.Last.Value}");
        }
    }
}