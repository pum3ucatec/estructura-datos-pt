using System;

class Program
{
    static void Main()
    {
        int[] arr1 = {1,2,2,1};
        int[] arr2 = {1,1};
        Console.WriteLine("Arreglos originales:");
        Console.WriteLine(string.Join(", ", arr1)); 
        Console.WriteLine(string.Join(", ", arr2)); 
        Console.WriteLine("Numeros iguales:");
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                if (arr1[i] == arr2[j])
                {
                    Console.Write(arr1[i] + " ");
                    arr2[j] = int.MinValue;
                    break;
                }
            }
        }
    }
}
