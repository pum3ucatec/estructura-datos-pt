using System;
using System.Collections.Generic;

public static class ArrayExercises
{
    // 1. Giro del arreglo a la derecha
    public static void RotateArray(int[] arr, int k)
    {
        k = k % arr.Length;
        Reverse(arr, 0, arr.Length - 1);
        Reverse(arr, 0, k - 1);
        Reverse(arr, k, arr.Length - 1);
    }

    private static void Reverse(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }

    // 2. Subarreglo con Suma Máxima
    public static int MaxSubArraySum(int[] arr)
    {
        int maxSum = arr[0];
        int currentSum = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            currentSum = Math.Max(arr[i], currentSum + arr[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }

    // 3. Eliminación de duplicados en arreglo ordenado
    public static int RemoveDuplicates(int[] arr)
    {
        if (arr.Length == 0) return 0;

        int uniqueIndex = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[i - 1])
            {
                arr[uniqueIndex] = arr[i];
                uniqueIndex++;
            }
        }

        return uniqueIndex;
    }

    // 4. Encontrar número que falta
    public static int FindMissingNumber(int[] arr, int n)
    {
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            actualSum += arr[i];
        }

        return expectedSum - actualSum;
    }

    // 5. Intersección de dos arreglos sin LINQ
    public static List<int> IntersectArrays(int[] a, int[] b)
    {
        List<int> result = new List<int>();
        bool[] used = new bool[b.Length];
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                if (!used[j] && a[i] == b[j])
                {
                    result.Add(a[i]);
                    used[j] = true;
                    break;
                }
            }
        }
        return result;
    }

    // 6. Matriz transpuesta
    public static int[,] Transpose(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transposed = new int[cols, rows];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                transposed[j, i] = matrix[i, j];
        return transposed;
    }

    // 7. Producto excepto el índice
    public static int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] output = new int[n];
        int[] leftProducts = new int[n];
        int[] rightProducts = new int[n];

        leftProducts[0] = 1;
        for (int i = 1; i < n; i++)
            leftProducts[i] = leftProducts[i - 1] * nums[i - 1];

        rightProducts[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
            rightProducts[i] = rightProducts[i + 1] * nums[i + 1];

        for (int i = 0; i < n; i++)
            output[i] = leftProducts[i] * rightProducts[i];

        return output;
    }

    // 8. Búsqueda en arreglo rotado ordenado
    public static int SearchInRotatedArray(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[left] <= arr[mid])
            {
                if (target >= arr[left] && target < arr[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            else
            {
                if (target > arr[mid] && target <= arr[right])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }

        return -1;
    }

    // 9. Recorrido en espiral de matriz
    public static List<int> SpiralOrder(int[,] matrix)
    {
        List<int> result = new List<int>();
        int top = 0, bottom = matrix.GetLength(0) - 1;
        int left = 0, right = matrix.GetLength(1) - 1;

        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++)
                result.Add(matrix[top, i]);
            top++;

            for (int i = top; i <= bottom; i++)
                result.Add(matrix[i, right]);
            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                    result.Add(matrix[bottom, i]);
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    result.Add(matrix[i, left]);
                left++;
            }
        }

        return result;
    }

    // 10. Suma de subconjuntos con backtracking
    public static void SubsetSum(int[] nums, int target)
    {
        List<int> current = new List<int>();

        void Backtrack(int start, int sum)
        {
            if (sum == target)
            {
                Console.WriteLine($"[{string.Join(", ", current)}]");
                return;
            }

            if (sum > target)
                return;

            for (int i = start; i < nums.Length; i++)
            {
                current.Add(nums[i]);
                Backtrack(i, sum + nums[i]); // Permite reutilizar elementos
                current.RemoveAt(current.Count - 1);
            }
        }

        Backtrack(0, 0);
    }
}

class Program
{
    static void Main()
    {
        // Ejemplo 1 - Rotar arreglo
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original: " + string.Join(", ", arr));
        ArrayExercises.RotateArray(arr, 2);
        Console.WriteLine("Rotado por 2: " + string.Join(", ", arr));

        // Ejemplo 2 - Subarreglo suma máxima
        int[] arr2 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine("Suma máxima de subarreglo: " + ArrayExercises.MaxSubArraySum(arr2));

        // Ejemplo 3 - Eliminar duplicados
        int[] arr3 = { 1, 1, 2, 2, 3, 4, 4 };
        int uniqueCount = ArrayExercises.RemoveDuplicates(arr3);
        Console.WriteLine("Sin duplicados: " + string.Join(", ", arr3[..uniqueCount]));

        // Ejemplo 4 - Número que falta
        int[] arr4 = { 1, 2, 4, 5, 6 };
        Console.WriteLine("Número que falta: " + ArrayExercises.FindMissingNumber(arr4, 6));

        // Ejemplo 5 - Intersección de arreglos
        int[] a = { 1, 2, 2, 1 };
        int[] b = { 2, 2 };
        var interseccion = ArrayExercises.IntersectArrays(a, b);
        Console.WriteLine("Intersección: " + string.Join(", ", interseccion));

        // Ejemplo 6 - Matriz transpuesta
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] transpuesta = ArrayExercises.Transpose(matrix);
        Console.WriteLine("Matriz transpuesta:");
        for (int i = 0; i < transpuesta.GetLength(0); i++)
        {
            for (int j = 0; j < transpuesta.GetLength(1); j++)
                Console.Write(transpuesta[i, j] + " ");
            Console.WriteLine();
        }

        // Ejemplo 7 - Producto excepto índice
        int[] nums7 = { 1, 2, 3, 4 };
        int[] productos = ArrayExercises.ProductExceptSelf(nums7);
        Console.WriteLine("Producto excepto índice: " + string.Join(", ", productos));

        // Ejemplo 8 - Buscar en arreglo rotado
        int[] arr8 = { 4, 5, 6, 7, 0, 1, 2 };
        int target = 0;
        int pos = ArrayExercises.SearchInRotatedArray(arr8, target);
        Console.WriteLine($"Elemento {target} encontrado en índice: {pos}");

        // Ejemplo 9 - Recorrido en espiral
        int[,] matrix9 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        var spiral = ArrayExercises.SpiralOrder(matrix9);
        Console.WriteLine("Recorrido en espiral: " + string.Join(", ", spiral));

        // Ejemplo 10 - Suma de subconjuntos
        int[] nums10 = { 2, 3, 6, 7 };
        int target10 = 7;
        Console.WriteLine($"Subconjuntos que suman {target10}:");
        ArrayExercises.SubsetSum(nums10, target10);
    }
}
