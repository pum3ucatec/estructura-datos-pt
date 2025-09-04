using System;

class Program
{
    static int Buscar(int[] arr, int target)
    {
        int l = 0, r = arr.Length - 1;
        while (l <= r)
        {
            int mid = (l + r) / 2;
            if (arr[mid] == target) return mid;

            if (arr[l] <= arr[mid])
            {
                if (target >= arr[l] && target < arr[mid]) r = mid - 1;
                else l = mid + 1;
            }
            else
            {
                if (target > arr[mid] && target <= arr[r]) l = mid + 1;
                else r = mid - 1;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = {4,5,6,7,0,1,2};
        int target = 0;
        Console.WriteLine("número de rotaciones: " + Buscar(arr, target));
    }
}
