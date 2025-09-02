// Ingresa 5 calificaciones en un arreglo y calcula el promedio.  

using System;

class Ejercicio4{
    static void Main()
    {
        int[] calificaciones = { 80, 70, 90, 60, 100 };
        int suma = 0;

        for (int i = 0; i < calificaciones.Length; i++)
        {
            suma += calificaciones[i];
        }

        int promedio = (int )suma / calificaciones.Length;

        
        Console.WriteLine("Promedio: " + promedio);
         
     }
}