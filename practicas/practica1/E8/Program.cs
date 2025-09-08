using System;

class NumeroPrimo
{
    static void Main()
    {
        Console.Write("Ingrese un número para comprobar si es primo: ");
        string entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int numero))
        {
            Console.WriteLine("❌ Entrada inválida. Debe ingresar un número entero.");
            return;
        }

        bool esPrimo = true;

        if (numero <= 1)
        {
            esPrimo = false;
        }
        else
        {
            // Solo es necesario verificar hasta la raíz cuadrada del número
            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }

        if (esPrimo)
            Console.WriteLine($"✔ {numero} es un número primo.");
        else
            Console.WriteLine($"✘ {numero} no es un número primo.");
    }
}
