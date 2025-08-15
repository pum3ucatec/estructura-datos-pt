int suma = 0;

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Ingresa el número {i}: ");
    int num = int.Parse(Console.ReadLine());
    suma += num;
}

Console.WriteLine($"La suma de los 5 números es: {suma}");
