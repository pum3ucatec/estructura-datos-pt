using System;

namespace ValidacionConDoWhile
{
    class Program
    {
        static void Main()
        {
            int numero;

            // Bucle que se repite mientras el número sea negativo o cero
            do
            {
                Console.Write("Ingresa un número entero positivo: ");
                bool esValido = int.TryParse(Console.ReadLine(), out numero);

                if (!esValido)
                {
                    Console.WriteLine("❌ Entrada inválida. Debes ingresar un número entero.");
                    numero = -1; // Fuerza que el bucle se repita
                }
                else if (numero <= 0)
                {
                    Console.WriteLine("⚠️ El número debe ser mayor que cero.");
                }

            } while (numero <= 0);

            Console.WriteLine($"✅ ¡Perfecto! Has ingresado el número: {numero}");
        }
    }
}

