using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arreglo = { 4, 5, 6, 7, 0, 1, 2 };
        int objetivo = 0;

        int indice = BuscarEnArregloRotado(arreglo, objetivo);

        if (indice != -1)
            Console.WriteLine($"El elemento {objetivo} está en la posición {indice}.");
        else
            Console.WriteLine($"El elemento {objetivo} no está en el arreglo.");
    }

    static int BuscarEnArregloRotado(int[] nums, int target)
    {
        int izquierda = 0, derecha = nums.Length - 1;

        while (izquierda <= derecha)
        {
            int medio = (izquierda + derecha) / 2;
            if (nums[medio] == target)
                return medio;

            // Lado izquierdo ordenado
            if (nums[izquierda] <= nums[medio])
            {
                if (nums[izquierda] <= target && target < nums[medio])
                    derecha = medio - 1;
                else
                    izquierda = medio + 1;
            }
            // Lado derecho ordenado
            else
            {
                if (nums[medio] < target && target <= nums[derecha])
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }
        }
        return -1;
    }
}