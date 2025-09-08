using System;
using System.Collections.Generic;

namespace ArrayOperations
{
    class Intersector
    {
        // Devuelve los elementos comunes entre dos arreglos, respetando las repeticiones
        public static List<int> GetCommonElements(int[] first, int[] second)
        {
            List<int> commons = new List<int>();
            bool[] marked = new bool[second.Length];

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (!marked[j] && first[i] == second[j])
                    {
                        commons.Add(first[i]);
                        marked[j] = true;
                        break;
                    }
                }
            }

            return commons;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] setA = { 1, 2, 2, 1 };
            int[] setB = { 2, 2 };

            List<int> intersection = Intersector.GetCommonElements(setA, setB);

            Console.WriteLine("Elementos en común:");
            foreach (int item in intersection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
