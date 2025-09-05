// Ingresar 5 elementos a un arreglo y clacular el promedio
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        int suma = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese un número: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            suma += numeros[i];
        }

        double promedio = (double)suma / 5;
        Console.WriteLine("El promedio es: " + promedio);
    }
}
