using System;

class Program
{
    static void Main()
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        int maxSuma = arr[0];
        int sumaActual = arr[0];
        int inicio = 0, fin = 0, tempInicio = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > sumaActual + arr[i])
            {
                sumaActual = arr[i];
                tempInicio = i; // posible inicio del subarreglo
            }
            else
            {
                sumaActual += arr[i];
            }

            if (sumaActual > maxSuma)
            {
                maxSuma = sumaActual;
                inicio = tempInicio;
                fin = i;
            }
        }

        Console.WriteLine($"La suma máxima es: {maxSuma}");

        Console.Write("Subarreglo: [");
        for (int i = inicio; i <= fin; i++)
        {
            Console.Write(arr[i]);
            if (i < fin) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}
