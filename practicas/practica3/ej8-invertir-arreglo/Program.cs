// See https://aka.ms/new-console-template for more information
Console.WriteLine("ejercicio 8!");



int[] arreglo = { 30, 31, 32, 33, 34, 35 };


int[] invertido = new int[arreglo.Length];


for (int i = 0; i < arreglo.Length; i++)
{
    invertido[i] = arreglo[arreglo.Length - 1 - i];
}


Console.WriteLine("Arreglo original: [" + string.Join(", ", arreglo) + "]");
Console.WriteLine("Arreglo invertido: [" + string.Join(", ", invertido) + "]");