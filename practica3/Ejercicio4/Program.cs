using System;

int[] notas = { 80, 70, 90, 60, 100 };
int suma = 0;

for (int i = 0; i < notas.Length; i++)
{
    suma += notas[i];
}

double promedio = (double)suma / notas.Length;
Console.WriteLine("Promedio: " + promedio);