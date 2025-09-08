using System;

namespace Utils
{
    class DuplicateHandler
    {
        // Método para eliminar elementos repetidos en un arreglo ordenado
        public static int[] CleanArray(int[] input)
        {
            if (input.Length == 0)
                return input;

            int pos = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[pos])
                {
                    pos++;
                    input[pos] = input[i];
                }
            }

            int[] filtered = new int[pos + 1];
            Array.Copy(input, filtered, pos + 1);

            return filtered;
        }
    }

    class App
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 2, 2, 3, 4, 4 };

            int[] cleaned = DuplicateHandler.CleanArray(numbers);

            Console.WriteLine("Arreglo depurado:");
            foreach (int val in cleaned)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}
