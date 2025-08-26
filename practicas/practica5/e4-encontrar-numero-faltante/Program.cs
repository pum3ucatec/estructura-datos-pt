using System;

namespace FinderApp
{
    class NumberFinder
    {
        // Método que localiza el número perdido dentro de una secuencia
        public static int FindMissing(int[] sequence, int size)
        {
            int sumExpected = (size * (size + 1)) / 2;
            int sumReal = 0;

            foreach (int value in sequence)
            {
                sumReal += value;
            }

            return sumExpected - sumReal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 4, 5, 6 };

            int missing = NumberFinder.FindMissing(data, 6);

            Console.WriteLine("El número que falta en la serie es: {0}", missing);
        }
    }
}
