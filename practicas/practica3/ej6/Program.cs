using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 3, 7, 12, 17, 25, 30, 41, 50, 60, 75 };

        Console.Write("Ingrese un número: ");
        int buscado = int.Parse(Console.ReadLine());

        int posicion = -1;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscado)
            {
                posicion = i;
                break;
            }
        }

        if (posicion != -1)
            Console.WriteLine($"El número {buscado} se encuentra en la posición {posicion}");
        else
            Console.WriteLine("Número no encontrado");
    }
}
