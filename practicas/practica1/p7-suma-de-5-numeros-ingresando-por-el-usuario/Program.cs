// Suma de 5 números ingresados por el usuario.
// Pedir al 5 numeros (uno por uno) y sumarlos usando for.
// Camilaa
using System;

class Program
{
    static void Main()
    {
        double suma = 0;
        
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Ingrese el número que desea sumar {i}: ");
            double numero = double.Parse(Console.ReadLine());
            suma += numero;
        }
        
        Console.WriteLine($"La suma de los 5 números es el total de: {suma}");
    }
}