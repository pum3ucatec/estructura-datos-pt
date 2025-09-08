using System;

class SumaCincoNumeros
{
    static void Main()
    {
        int total = 0;

        // Se piden 5 números al usuario
        for (int contador = 1; contador <= 5; contador++)
        {
            Console.Write($"Ingrese el número {contador}: ");
            string entrada = Console.ReadLine();
            
            if (int.TryParse(entrada, out int numero))
            {
                total += numero; // se acumula el valor ingresado
            }
            else
            {
                Console.WriteLine("Entrada inválida, se tomará como 0.");
            }
        }

        Console.WriteLine($"La suma total de los 5 números es: {total}");
    }
}
