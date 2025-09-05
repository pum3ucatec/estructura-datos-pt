// Detectar si un número es primo
// Usar un bucle for para detectar si un número ingresado por el usuario es primo o no. 
// Camilaa

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número que desea para verificar si es primo: ");
        int numero = int.Parse(Console.ReadLine());
        bool esPrimo = true;
        
        if (numero <= 1)
        {
            esPrimo = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }
        
        Console.WriteLine(esPrimo ? $"{numero} es un número primo." : $"{numero} no es un número primo.");
    }
}
