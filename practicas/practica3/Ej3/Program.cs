
// Dado un arreglo de enteros, calcula la suma de todos sus elementos

int[] numeros = { 10, 20, 60, 50, 30 };

int suma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("La suma del todos los elementos es: " + suma);

Console.ResetColor();