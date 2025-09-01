using System;
    class Program
    {
        static void Main(String[] args)
        {
            int[] numeros = { 15, 16, 22, 9, 7, 17, 20, 11 };
            int mayor = numeros[0];
            int menor = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }
            Console.WriteLine($"El numero mayor es: {mayor}");
            Console.WriteLine($"El numero menor es: {menor}");
        }
    }
