using System;

class Program
{
    static void Main()
    {
        int[] arr = {4,5,6,7,0,1,2};
        int target = 0;

        int index = SearchRotatedArray(arr, target);

        if (index != -1)
            Console.WriteLine("Número encontrado en la posición: " + index);
        else
            Console.WriteLine("Número no encontrado en el arreglo.");
    }

    static int SearchRotatedArray(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
                return mid;

            // La mitad izquierda está ordenada
            if (arr[left] <= arr[mid])
            {
                if (target >= arr[left] && target < arr[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            // La mitad derecha está ordenada
            else
            {
                if (target > arr[mid] && target <= arr[right])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }

        return -1; // No encontrado
    }
}
