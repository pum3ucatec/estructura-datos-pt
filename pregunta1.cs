using System;
using System.Linq;

namespace ExamenParcial
{
    public class NumeroFaltante
    {
        /// <summary>
        /// Encuentra el número faltante en un arreglo de números del 1 al n
        /// </summary>
        /// <param name="arr">Arreglo de números con un número faltante</param>
        /// <returns>El número que falta en la secuencia</returns>
        public static int EncontrarNumeroFaltante(int[] arr)
        {
            int n = arr.Length + 1;
            int sumaTotal = n * (n + 1) / 2;
            int sumaActual = arr.Sum();
            return sumaTotal - sumaActual;
        }

        // Método principal para pruebas
        public static void Main(string[] args)
        {
            Console.WriteLine("=== PRUEBA NUMERO FALTANTE ===");

            // Caso de prueba 1
            int[] test1 = { 1, 2, 4, 5, 6 };
            Console.WriteLine($"Input: [{string.Join(", ", test1)}]");
            Console.WriteLine($"Output: {EncontrarNumeroFaltante(test1)}");
            Console.WriteLine($"Esperado: 3");
            Console.WriteLine();

            // Caso de prueba 2
            int[] test2 = { 1, 3, 4, 5 };
            Console.WriteLine($"Input: [{string.Join(", ", test2)}]");
            Console.WriteLine($"Output: {EncontrarNumeroFaltante(test2)}");
            Console.WriteLine($"Esperado: 2");
            Console.WriteLine();

            // Caso de prueba 3
            int[] test3 = { 2, 3, 4, 5, 6 };
            Console.WriteLine($"Input: [{string.Join(", ", test3)}]");
            Console.WriteLine($"Output: {EncontrarNumeroFaltante(test3)}");
            Console.WriteLine($"Esperado: 1");
        }
    }
}
