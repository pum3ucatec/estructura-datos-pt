// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        double[] Calificaciones = new double[5];
        double Suma = 0;

        for (int I = 0; I < Calificaciones.Length; I++)
        {
            Console.Write("Ingresa La Calificacion #" + (I + 1) + ": ");
            Calificaciones[I] = Convert.ToDouble(Console.ReadLine());
            Suma += Calificaciones[I];
        }
        
        double Promedio = Suma / Calificaciones.Length;

        Console.WriteLine("El Promedio De Las Calificaciones Es: " + Promedio);
    }
}

