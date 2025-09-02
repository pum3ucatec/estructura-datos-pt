// Dado dos arreglos de enteros, encuentra los elementos comunes sin usar LINQ.  
//Ejemplo: `[1,2,2,1]` y `[2,2]` → `[2,2]`.
using System;

class Ejercicio5
{
    static void Main()
    {
        int[] arreglo1 = { 1, 2, 2, 1, 3, 3 };
        int[] arreglo2 = { 1, 1, 3, 3 };

        Console.WriteLine("Arreglos originales:");
        Console.WriteLine(string.Join(", ", arreglo1)); 
        Console.WriteLine(string.Join(", ", arreglo2)); 
        Console.WriteLine("Numeros iguales:");

        for (int i = 0; i < arreglo1.Length; i++)
        {
            for (int j = 0; j < arreglo2.Length; j++)
            {
                if (arreglo1[i] == arreglo2[j])
                {
                    Console.Write(arreglo1[i] + " ");
                    arreglo2[j] = int.MinValue;
                    break;
                }
            }
        }
    }
}
