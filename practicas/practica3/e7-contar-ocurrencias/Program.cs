int[] arreglo = { 2, 5, 2, 8, 2, 9 };

Console.Write("Ingrese el número a buscar: ");
int buscado = int.Parse(Console.ReadLine());
int contador = 0;

for (int i = 0; i < arreglo.Length; i++)
{
    if (arreglo[i] == buscado)
    {
        contador++;
    }
}

Console.WriteLine($"El número {buscado} aparece {contador} veces");
