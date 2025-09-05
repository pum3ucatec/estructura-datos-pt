using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese el tamaño de los arreglos
        Console.Write("Ingrese el tamaño de los arreglos: ");
        int n = int.Parse(Console.ReadLine());

        // Crear dos arreglos de tamaño n
        int[] arreglo1 = new int[n];
        int[] arreglo2 = new int[n];

        // Llenar el primer arreglo con números aleatorios entre 1 y 100
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            arreglo1[i] = rand.Next(1, 101);
        }

        // Llenar el segundo arreglo con números aleatorios entre 1 y 100
        for (int i = 0; i < n; i++)
        {
            arreglo2[i] = rand.Next(1, 101);
        }

        // Mostrar los dos arreglos
        Console.WriteLine("Arreglo 1: " + string.Join(", ", arreglo1));
        Console.WriteLine("Arreglo 2: " + string.Join(", ", arreglo2));


        // Encontrar y mostrar los números que están en ambos arreglos (intersección)
        List<int> interseccion = new List<int>();
        for (int i = 0; i < arreglo1.Length; i++)
        {
            for (int j = 0; j < arreglo2.Length; j++)
            {
                if (arreglo1[i] == arreglo2[j] && !interseccion.Contains(arreglo1[i]))
                {
                    interseccion.Add(arreglo1[i]);
                    break;
                }
            }
        }
        Console.WriteLine("Números en ambos arreglos: " + string.Join(", ", interseccion));

        // Encontrar y mostrar los números que están en el primer arreglo pero no en el segundo (diferencia)
        List<int> diferencia = new List<int>();
        for (int i = 0; i < arreglo1.Length; i++)
        {
            bool encontrado = false;
            for (int j = 0; j < arreglo2.Length; j++)
            {
                if (arreglo1[i] == arreglo2[j])
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado && !diferencia.Contains(arreglo1[i]))
            {
                diferencia.Add(arreglo1[i]);
            }
        }
        Console.WriteLine("Números en el primer arreglo pero no en el segundo: " + string.Join(", ", diferencia));

    }
}