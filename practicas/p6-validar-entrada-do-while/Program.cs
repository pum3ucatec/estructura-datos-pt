int numero;
do
{
    Console.Write("Ingresa un número positivo: ");
    numero = int.Parse(Console.ReadLine());
} while (numero <= 0);

Console.WriteLine($"Número válido: {numero}");
    