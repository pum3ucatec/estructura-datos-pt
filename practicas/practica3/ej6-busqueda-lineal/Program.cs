using System;
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Busque un numero dentro del array");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());
            bool encontrar = false;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    encontrar = true;
                    Console.WriteLine($"El numero {numeroBuscado} se encuentra en la posicion {i}");
                    break;
                }
            }
            if (!encontrar)
            {
                Console.WriteLine($"El numero no esta en el array");
            } 
        }
    }


