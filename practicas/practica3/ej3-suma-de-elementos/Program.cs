
// Ejercicio 3: Calcular la suma de los elementos de un arreglo
// Camii
using System;

class Program
{
    static void Main()
    {
        // Arreglo con números
        int[] arr = { 5, 10, 15, 20 };

        int suma = 0; // Variable acumuladora

        // Recorremos el arreglo y sumamos los valores
        foreach (int n in arr)
        {
            suma += n;
        }

        // Mostramos el resultado
        Console.WriteLine($"La suma de los numeros es = {suma}");
    }
}

