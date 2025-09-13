using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arreglo = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        var (maxSuma, inicio, fin) = SubarregloSumaMaxima(arreglo);

        Console.WriteLine($"Suma máxima: {maxSuma}");
        Console.WriteLine($"Subarreglo: [{string.Join(", ", arreglo[inicio..(fin + 1)])}]");
    }

    static (int maxSuma, int inicio, int fin) SubarregloSumaMaxima(int[] arreglo)
    {
        int maxSuma = arreglo[0];
        int sumaActual = arreglo[0];
        int inicio = 0;
        int fin = 0;
        int tempInicio = 0;

        for (int i = 1; i < arreglo.Length; i++)
        {
            if (sumaActual < 0)
            {
                sumaActual = arreglo[i];
                tempInicio = i;
            }
            else
            {
                sumaActual += arreglo[i];
            }

            if (sumaActual > maxSuma)
            {
                maxSuma = sumaActual;
                inicio = tempInicio;
                fin = i;
            }
        }

        return (maxSuma, inicio, fin);
    }
}