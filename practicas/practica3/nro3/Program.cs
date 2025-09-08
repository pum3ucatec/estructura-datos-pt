int[] arreglo = { 5, 10, 15, 20 };
int suma = 0;

for (int i = 0; i < arreglo.Length; i++)
{
    suma += arreglo[i];
}

Console.WriteLine("Arreglo: [" + string.Join(", ", arreglo) + "]");
Console.WriteLine("Suma: " + suma);