using System;

class Ejercicio7
{
    static void Main()
    {
        int[] arreglo = { 2, 5, 2, 8, 2, 9 };

        Console.Write("Número buscado: ");
        int numeroBuscado = int.Parse(Console.ReadLine());

        int contador = 0;
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == numeroBuscado)
                contador++;
        }

        Console.WriteLine($"El número aparece {contador} veces");
    }
}
