// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {

        double[] calificaciones = new double[5];
        double suma = 0;

        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.Write("Ingresa la calificación #" + (i + 1) + ": ");
            calificaciones[i] = Convert.ToDouble(Console.ReadLine());
            suma += calificaciones[i];
        }
        
        double promedio = suma / calificaciones.Length;

        Console.WriteLine("El promedio de las calificaciones es: " + promedio);
    }
}

