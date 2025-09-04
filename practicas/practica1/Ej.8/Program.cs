using System;

class Program
{
    
    static bool EsPrimo(int n)
    {
        if (n <= 1) return false;     
        if (n <= 3) return true;      
        if (n % 2 == 0) return false; 

        int limite = (int)Math.Sqrt(n); 
        for (int i = 3; i <= limite; i += 2) 
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Ingresa un entero: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine(EsPrimo(n)
                ? $"{n} es primo."
                : $"{n} NO es primo.");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}