using System;

class Ejercicio2
{
    static void Main()
    {
        Console.Write("Ingrese un número N: ");
        int N = int.Parse(Console.ReadLine());
        
        int suma = 0;
        int contador = 1;
        
        while (contador <= N)
        {
            suma += contador;
            contador++;
        }
        
        Console.WriteLine($"La suma de los números del 1 al {N} es: {suma}");
    }
}
