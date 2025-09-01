// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 3!");


int[] lista = { 5, 14, 8, 8 };


int suma = 0;


foreach (int numero in lista)
{
    suma += numero;
}


Console.WriteLine("Arreglo: [" + string.Join(", ", lista) + "]");
Console.WriteLine("Suma: " + suma);
