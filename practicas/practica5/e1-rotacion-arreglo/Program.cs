using System;

namespace ArrayRotationApp
{
    class ArrayTools
    {
        // Método que rota un arreglo a la derecha cierta cantidad de pasos
        public static int[] ShiftRight(int[] numbers, int steps)
        {
            int length = numbers.Length;

            // Ajustar los pasos si son mayores al tamaño del arreglo
            steps = steps % length;

            int[] rotatedArray = new int[length];
            int newIndex;

            for (int index = 0; index < length; index++)
            {
                newIndex = (index + steps) % length;
                rotatedArray[newIndex] = numbers[index];
            }

            return rotatedArray;
        }
    }

    class Launcher
    {
        static void Main(string[] args)
        {
            int[] original = { 1, 2, 3, 4, 5 };

            // Roto el arreglo 2 posiciones hacia la derecha
            int[] moved = ArrayTools.ShiftRight(original, 2);

            Console.WriteLine("Resultado final:");
            foreach (int value in moved)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
