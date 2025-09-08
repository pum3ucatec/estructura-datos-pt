using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        Console.Write("Ingrese un número: ");
        int buscado = int.Parse(Console.ReadLine());
        bool encontrado = false;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscado)
            {
                Console.WriteLine($"El número {buscado} se encuentra en la posición {i}");
                encontrado = true;
                break;
            }
        }
        if (!encontrado) Console.WriteLine("Número no encontrado");
    }
}