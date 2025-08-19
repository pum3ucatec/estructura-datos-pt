int[] notas = { 80, 70, 90, 60, 100 };
int sumaNotas = 0;

for (int i = 0; i < notas.Length; i++)
{
    sumaNotas += notas[i];
}

double promedio = (double)sumaNotas / notas.Length;

Console.WriteLine("Promedio: " + promedio);
