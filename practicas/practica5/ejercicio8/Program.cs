using System;

class Ejercicio8
{
    static void Main()
    {
        int[] arr = {4,5,6,7,0,1,2};
        int target = 0;
        int izquierda = 0;
        int derecha = arr.Length - 1;

        while (izquierda <= derecha)
        {
            int medio = (izquierda + derecha) / 2;
            if (arr[medio] == target) { Console.WriteLine("Encontrado en: " + medio); break; }

            if (arr[izquierda] <= arr[medio])
            {
                if (target >= arr[izquierda] && target < arr[medio]) derecha = medio - 1;
                else izquierda = medio + 1;
            }
            else
            {
                if (target > arr[medio] && target <= arr[derecha]) izquierda = medio + 1;
                else derecha = medio - 1;
            }
        }
    }
}
