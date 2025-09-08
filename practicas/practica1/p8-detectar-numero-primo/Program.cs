using System;
class Ejercicio8
{
    static void Main()
    {
        Console.Write("Ingresa un número para ver si es primo o no: ");
        int num = int.Parse(Console.ReadLine());

        bool es_primo = true;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                es_primo = false;
                break;
            }
        }

        if (es_primo && num > 1)
            Console.WriteLine(num + " SI es primo");
        else
            Console.WriteLine(num + " NO es primo");
    }
}