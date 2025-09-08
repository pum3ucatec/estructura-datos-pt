// See https://aka.ms/new-console-template for more information
int[] arreglo = { 2, 5, 2, 8, 2, 9 };

Console.Write("Número buscado: ");
int numBuscado = int.Parse(Console.ReadLine());

int contador = 0;
for (int i = 0; i < arreglo.Length; i++)
{
    if (arreglo[i] == numBuscado)
        contador++;
}

Console.WriteLine($"El número aparece {contador} veces");
