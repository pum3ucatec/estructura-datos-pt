Console.Write("Ingresa un número: ");
int num = int.Parse(Console.ReadLine());
bool esPrimo = true;

if (num <= 1)
{
    esPrimo = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            esPrimo = false;
            break;
        }
    }
}

if (esPrimo)
    Console.WriteLine($"{num} es primo");
else
    Console.WriteLine($"{num} no es primo");
