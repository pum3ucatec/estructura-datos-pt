using System;

class Ejercicio5
{
    static void Main()
    {
        Console.WriteLine("Ejemplo: Arreglo1=[1,2,2,1], Arreglo2=[2,2]");
        int[] arr1 = { 1, 2, 2, 1 };
        int[] arr2 = { 2, 2 };
        MostrarInterseccion(arr1, arr2);

        Console.WriteLine("\nAhora ingresa el primer arreglo (separado por espacios):");
        string[] input1 = Console.ReadLine().Split(' ');
        int[] userArr1 = Array.ConvertAll(input1, int.Parse);

        Console.WriteLine("Ingresa el segundo arreglo (separado por espacios):");
        string[] input2 = Console.ReadLine().Split(' ');
        int[] userArr2 = Array.ConvertAll(input2, int.Parse);

        MostrarInterseccion(userArr1, userArr2);
    }

    static void MostrarInterseccion(int[] arr1, int[] arr2)
    {
        bool[] usado = new bool[arr2.Length];
        Console.Write("Intersección: [");
        bool primero = true;
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                if (arr1[i] == arr2[j] && !usado[j])
                {
                    if (!primero) Console.Write(", ");
                    Console.Write(arr1[i]);
                    primero = false;
                    usado[j] = true;
                    break;
                }
            }
        }
        Console.WriteLine("]");
    }
}