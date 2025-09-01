using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 2, 7, 8, 9, 2 };
            Console.WriteLine("Busque un numero dentro del array");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    c++;
                }

            }
            Console.WriteLine($"El array es: {string.Join(", ", numeros)}");
            Console.WriteLine($"El numero es: {numeroBuscado}");
            Console.WriteLine($"Se repite: {c} veces");
        }
    }