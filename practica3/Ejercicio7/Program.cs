using System;

int[] arreglo = { 2, 5, 2, 8, 2, 9 };
Console.WriteLine("Número buscado: ");
int buscado = int.Parse(Console.ReadLine());
int contador = 0;

for (int i = 0; i < arreglo.Length; i++)
{
    if (arreglo[i] == buscado)
    {
        contador++;
    }
}

Console.WriteLine($"El número aparece {contador} veces");