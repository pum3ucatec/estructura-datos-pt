//Ingresa 5 calificaciones en un arreglo y calcula el promedio.  

using System;

class Program
{
    static void Main()
    {

        double[] calificaciones = new double[5];
        double suma = 0;

        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.Write($"Ingresa la calificación #{i + 1}: ");
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out double nota))
            {
                calificaciones[i] = nota;
                suma += nota;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingresa un número válido.");
                i--; 
            }
        }

        double promedio = suma / calificaciones.Length;

        Console.WriteLine($"\nEl promedio de las calificaciones es: {promedio:F2}");
    }
}
