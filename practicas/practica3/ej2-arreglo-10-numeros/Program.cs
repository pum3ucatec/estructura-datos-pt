// 2. Recorrido con `for`  
// Crea un arreglo de 10 números enteros y muéstralos en consola utilizando un ciclo `for`.
// Camii  

using System;

class Program
{
    static void Main()
    {
        // Se crea el arreglo de 10 números enteros
        int[] arreglo10 = { 1,2,3,4,5,6,7,8,9,10 };
        Console.WriteLine("Ejercicio 2 de Cami:");
        // Se recorre el arreglo con un ciclo for
        for (int i = 0; i < arreglo10.Length; i++)
            Console.WriteLine(arreglo10[i]);
    }
}

