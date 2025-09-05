using System;
using System.Collections.Generic;

class Ejercicio10
{
    static void Main()
    {
        int[] arr = {2,3,6,7};
        int target = 7;
        List<int> temp = new List<int>();
        Subsets(arr, target, 0, temp, 0);
    }

    static void Subsets(int[] arr, int target, int suma, List<int> temp, int start)
    {
        if (suma == target)
        {
            Console.Write("[");
            for(int i=0;i<temp.Count;i++)
            {
                Console.Write(temp[i]);
                if(i < temp.Count-1) Console.Write(", ");
            }
            Console.WriteLine("]");
            return;
        }
        if (suma > target) return;

        for(int i=start;i<arr.Length;i++)
        {
            temp.Add(arr[i]);
            Subsets(arr, target, suma+arr[i], temp, i); // permitir repetir
            temp.RemoveAt(temp.Count-1);
        }
    }
}
