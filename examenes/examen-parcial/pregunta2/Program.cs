using System;

class pregunta2 {
    static void Main()
    {
        Console.Write("Ingrese el tamaño del arreglo: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Ingrese los números del arreglo (del 1 al "+ n +", faltando uno):");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // La suma de 1 a n (fórmula: n*(n+1)/2)
        int total = (n + 1) * (n + 2) / 2;
        int sumaArr = 0;

        foreach (int num in arr)
        {
            sumaArr += num;
        }

        Console.WriteLine("El número faltante es: " + (total - sumaArr));
    }
}
