// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 5!");


int[] numeros = { 5, 11, 45, 7, 19, 8, 4, 65 };

int mayor = numeros[0];
int menor = numeros[0];

foreach (int num in numeros)
{
    if (num > mayor)
    {
        mayor = num;
    }
    if (num < menor)
    {
        menor = num;
    }
}

Console.WriteLine("Los números son: " + string.Join(", ", numeros));
Console.WriteLine($"El número mayor es: {mayor}");
Console.WriteLine($"El número menor es: {menor}");