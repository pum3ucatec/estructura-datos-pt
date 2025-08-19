int[] arreglo = { 2, 5, 2, 8, 2, 9 };
int buscado = 2;
int contador = 0;

for (int i = 0; i < arreglo.Length; i++)
{
    if (arreglo[i] == buscado)
        contador++;
}

Console.WriteLine("El número aparece " + contador + " veces");
