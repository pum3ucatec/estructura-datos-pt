using System;

class Ejercicio6
{
    static void Main()
    {
        int[] arreglo = { 3, 7, 11, 17, 23, 29, 31, 37, 41, 43 };

        Console.Write("Ingrese un número: ");
        int buscado = int.Parse(Console.ReadLine());

        int posicion = -1;

        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == buscado)
            {
                posicion = i;
                break;
            }
        }

        if (posicion != -1)
            Console.WriteLine($"El número {buscado} se encuentra en la posición {posicion}");
        else
            Console.WriteLine("Número no encontrado.");
    }
}
