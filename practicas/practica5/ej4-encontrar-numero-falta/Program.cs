using System;

Console.WriteLine("Ejercicio 4! Encontrar el número que falta");


Random rnd = new Random();
int n = rnd.Next(5, 10);
int[] arreglo = new int[n];


for (int i = 0; i < n; i++)
    arreglo[i] = i + 1;


int faltante = rnd.Next(1, n + 1);
arreglo = Array.FindAll(arreglo, x => x != faltante);


Console.WriteLine("Arreglo: " + string.Join(", ", arreglo));


int sumaEsperada = n * (n + 1) / 2;
int sumaActual = 0;

foreach (int num in arreglo)
    sumaActual += num;

int numeroFaltante = sumaEsperada - sumaActual;

Console.WriteLine($"El número faltante es: {numeroFaltante}");
