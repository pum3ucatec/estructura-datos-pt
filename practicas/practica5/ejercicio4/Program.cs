using System;

class Ejercicio4
{
    static void Main()
    {
        int[] arr = {1, 2, 4, 5, 6};
        int n = arr.Length + 1;
        int sumaTotal = n * (n + 1) / 2;
        int sumaArr = 0;

        for (int i = 0; i < arr.Length; i++) sumaArr += arr[i];

        Console.WriteLine("Número que falta: " + (sumaTotal - sumaArr));
    }
}
