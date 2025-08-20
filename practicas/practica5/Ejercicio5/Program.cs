using System;

namespace InterseccionArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer arreglo (números separados por comas): ");
            string[] entrada1 = Console.ReadLine().Split(',');
            int[] arr1 = Array.ConvertAll(entrada1, int.Parse);

            Console.WriteLine("Ingrese el segundo arreglo (números separados por comas): ");
            string[] entrada2 = Console.ReadLine().Split(',');
            int[] arr2 = Array.ConvertAll(entrada2, int.Parse);

            bool[] usado = new bool[arr2.Length]; 
            Console.Write("Intersección: [");

            bool primero = true;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j] && !usado[j])
                    {
                        if (!primero)
                            Console.Write(", ");
                        Console.Write(arr1[i]);
                        usado[j] = true;
                        primero = false;
                        break;
                    }
                }
            }

            Console.WriteLine("]");
        }
    }
}
