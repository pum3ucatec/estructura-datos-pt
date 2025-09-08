using System;

namespace ArrayMath
{
    class Calculator
    {
        // Calcula el producto de todos los elementos excepto el del índice actual
        public static int[] BuildProductArray(int[] numbers)
        {
            int length = numbers.Length;
            int[] prefix = new int[length];
            int[] suffix = new int[length];
            int[] output = new int[length];

            // Construir productos de izquierda
            prefix[0] = 1;
            for (int i = 1; i < length; i++)
            {
                prefix[i] = prefix[i - 1] * numbers[i - 1];
            }

            // Construir productos de derecha
            suffix[length - 1] = 1;
            for (int i = length - 2; i >= 0; i--)
            {
                suffix[i] = suffix[i + 1] * numbers[i + 1];
            }

            // Multiplicar ambos resultados
            for (int i = 0; i < length; i++)
            {
                output[i] = prefix[i] * suffix[i];
            }

            return output;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 4 };

            int[] result = Calculator.BuildProductArray(data);

            Console.WriteLine("Arreglo resultante:");
            foreach (int val in result)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}
