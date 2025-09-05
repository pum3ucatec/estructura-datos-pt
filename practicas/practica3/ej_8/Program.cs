// See https://aka.ms/new-console-template for more information
int[] original = { 1, 2, 3, 4, 5 };
int[] invertido = new int[original.Length];

for (int i = 0; i < original.Length; i++)
{
    invertido[i] = original[original.Length - 1 - i];
}

Console.WriteLine("Arreglo original: [" + string.Join(", ", original) + "]");
Console.WriteLine("Arreglo invertido: [" + string.Join(", ", invertido) + "]");
