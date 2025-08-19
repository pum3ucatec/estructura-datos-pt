using System;

class Programa6
{
    static void Main(string[] args)
    {
        int[] numeros = { 3, 7, 10, 15, 17, 20, 25, 30, 40, 50 };

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

        if (!encontrado)
        {
            Console.WriteLine("Número no encontrado en el arreglo.");
        }
    }
}
