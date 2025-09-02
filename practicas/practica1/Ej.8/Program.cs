using System;

class Program
{
    // Devuelve true si n es primo; false en caso contrario
    static bool EsPrimo(int n)
    {
        if (n <= 1) return false;     // 0, 1 y negativos no son primos
        if (n <= 3) return true;      // 2 y 3 sí son primos
        if (n % 2 == 0) return false; // todos los pares > 2 no son primos

        int limite = (int)Math.Sqrt(n); // basta con probar hasta la raíz cuadrada
        for (int i = 3; i <= limite; i += 2) // solo impares
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