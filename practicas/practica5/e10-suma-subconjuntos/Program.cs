using System;
using System.Collections.Generic;

namespace CombinationsApp
{
    class SubsetFinder
    {
        // Busca todas las combinaciones de números que sumen al objetivo
        public static void FindSubsets(int[] numbers, int target, int pos, List<int> currentSet, List<List<int>> solutions)
        {
            if (target == 0)
            {
                // Si llegamos al objetivo, guardamos el subconjunto
                solutions.Add(new List<int>(currentSet));
                return;
            }

            if (target < 0 || pos == numbers.Length)
                return;

            // Tomar el número actual
            currentSet.Add(numbers[pos]);
            FindSubsets(numbers, target - numbers[pos], pos + 1, currentSet, solutions);
            currentSet.RemoveAt(currentSet.Count - 1);

            // Omitir el número actual
            FindSubsets(numbers, target, pos + 1, currentSet, solutions);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 2, 3, 6, 7 };
            List<List<int>> results = new List<List<int>>();

            SubsetFinder.FindSubsets(data, 7, 0, new List<int>(), results);

            Console.WriteLine("Combinaciones que alcanzan el objetivo (7):");
            foreach (var set in results)
            {
                Console.WriteLine("{ " + string.Join(" - ", set) + " }");
            }
        }
    }
}
