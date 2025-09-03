using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== EJERCICIOS AVANZADOS CON ARREGLOS EN C# ===");
        
        // Ejercicio 1: Rotación de Arreglo
        Console.WriteLine("\n1. Rotación de Arreglo:");
        int[] arr1 = {1, 2, 3, 4, 5};
        RotateArray(arr1, 2);
        Console.WriteLine($"Resultado: [{string.Join(", ", arr1)}]");

        // Ejercicio 2: Subarreglo con Suma Máxima
        Console.WriteLine("\n2. Subarreglo con Suma Máxima:");
        int[] arr2 = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        var result2 = MaxSubarraySum(arr2);
        Console.WriteLine($"Suma máxima: {result2.sum}, Subarreglo: [{string.Join(", ", result2.subarray)}]");

        // Ejercicio 3: Eliminar Duplicados
        Console.WriteLine("\n3. Eliminar Duplicados:");
        int[] arr3 = {1, 1, 2, 2, 3, 4, 4};
        int newLength = RemoveDuplicates(arr3);
        Console.WriteLine($"Arreglo sin duplicados: [{string.Join(", ", arr3[0..newLength])}]");

        // Ejercicio 4: Número que Falta
        Console.WriteLine("\n4. Número que Falta:");
        int[] arr4 = {1, 2, 4, 5, 6};
        Console.WriteLine($"Falta el número: {FindMissingNumber(arr4)}");

        // Ejercicio 5: Intersección de Arreglos
        Console.WriteLine("\n5. Intersección de Arreglos:");
        int[] arr5a = {1, 2, 2, 1};
        int[] arr5b = {2, 2};
        int[] intersection = IntersectArrays(arr5a, arr5b);
        Console.WriteLine($"Intersección: [{string.Join(", ", intersection)}]");

        // Ejercicio 6: Matriz Transpuesta
        Console.WriteLine("\n6. Matriz Transpuesta:");
        int[,] matrix6 = {{1, 2, 3}, {4, 5, 6}};
        int[,] transposed = TransposeMatrix(matrix6);
        PrintMatrix(transposed);

        // Ejercicio 7: Producto Excepto Índice
        Console.WriteLine("\n7. Producto Excepto Índice:");
        int[] arr7 = {1, 2, 3, 4};
        int[] products = ProductExceptSelf(arr7);
        Console.WriteLine($"Resultado: [{string.Join(", ", products)}]");

        // Ejercicio 8: Búsqueda en Arreglo Rotado
        Console.WriteLine("\n8. Búsqueda en Arreglo Rotado:");
        int[] arr8 = {4, 5, 6, 7, 0, 1, 2};
        int target = 0;
        Console.WriteLine($"Posición de {target}: {SearchInRotatedArray(arr8, target)}");

        // Ejercicio 9: Espiral en Matriz
        Console.WriteLine("\n9. Recorrido en Espiral:");
        int[,] matrix9 = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        List<int> spiral = SpiralOrder(matrix9);
        Console.WriteLine($"Espiral: [{string.Join(", ", spiral)}]");

        // Ejercicio 10: Suma de Subconjuntos
        Console.WriteLine("\n10. Suma de Subconjuntos:");
        int[] arr10 = {2, 3, 6, 7};
        int targetSum = 7;
        var subsets = CombinationSum(arr10, targetSum);
        Console.WriteLine($"Subconjuntos que suman {targetSum}:");
        foreach (var subset in subsets)
        {
            Console.WriteLine($"[{string.Join(", ", subset)}]");
        }
    }

    /// <summary>Rota un arreglo k posiciones hacia la derecha usando reversión triple</summary>
    static void RotateArray(int[] nums, int k)
    {
        k %= nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }

    /// <summary>Invierte una porción del arreglo entre start y end</summary>
    static void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }

    /// <summary>Implementa el algoritmo de Kadane para encontrar el subarreglo con suma máxima</summary>
    /// <returns>Tupla con la suma máxima y el subarreglo correspondiente</returns>
    static (int sum, int[] subarray) MaxSubarraySum(int[] nums)
    {
        int maxSum = nums[0];
        int currentSum = nums[0];
        int start = 0, end = 0;
        int tempStart = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = nums[i];
                tempStart = i;
            }
            else
            {
                currentSum += nums[i];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                start = tempStart;
                end = i;
            }
        }

        int[] subarray = new int[end - start + 1];
        Array.Copy(nums, start, subarray, 0, subarray.Length);
        return (maxSum, subarray);
    }

    /// <summary>Elimina duplicados de un arreglo ordenado in-place</summary>
    /// <returns>Nueva longitud del arreglo sin duplicados</returns>
    static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;
        
        int i = 0; // Puntero lento
        for (int j = 1; j < nums.Length; j++) // Puntero rápido
        {
            if (nums[j] != nums[i])
            {
                i++;
                nums[i] = nums[j];
            }
        }
        return i + 1;
    }

    /// <summary>Encuentra el número faltante en una secuencia 1..n usando suma de Gauss</summary>
    static int FindMissingNumber(int[] nums)
    {
        int n = nums.Length + 1;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;
        
        foreach (int num in nums)
            actualSum += num;
            
        return expectedSum - actualSum;
    }

    /// <summary>Encuentra la intersección de dos arreglos usando ordenamiento y dos punteros</summary>
    static int[] IntersectArrays(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        
        List<int> result = new List<int>();
        int i = 0, j = 0;
        
        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] == nums2[j])
            {
                result.Add(nums1[i]);
                i++;
                j++;
            }
            else if (nums1[i] < nums2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }
        
        return result.ToArray();
    }

    /// <summary>Calcula la matriz transpuesta intercambiando filas por columnas</summary>
    static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] result = new int[cols, rows];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }
        
        return result;
    }

    /// <summary>Imprime una matriz bidimensional</summary>
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            Console.Write("[");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j]);
                if (j < cols - 1) Console.Write(", ");
            }
            Console.WriteLine("]");
        }
    }

    /// <summary>Calcula el producto de todos los elementos excepto el actual sin usar división</summary>
    /// <remarks>Usa productos acumulativos izquierdo y derecho</remarks>
    static int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        
        // Producto acumulativo de izquierda a derecha
        result[0] = 1;
        for (int i = 1; i < n; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }
        
        // Producto acumulativo de derecha a izquierda
        int rightProduct = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            result[i] *= rightProduct;
            rightProduct *= nums[i];
        }
        
        return result;
    }

    /// <summary>Búsqueda binaria modificada para arreglos rotados y ordenados</summary>
    static int SearchInRotatedArray(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if (nums[mid] == target) return mid;
            
            // Determina qué mitad está ordenada
            if (nums[left] <= nums[mid])
            {
                // Mitad izquierda ordenada
                if (target >= nums[left] && target < nums[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            else
            {
                // Mitad derecha ordenada
                if (target > nums[mid] && target <= nums[right])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }
        
        return -1;
    }

    /// <summary>Recorre una matriz en forma de espiral (sentido horario)</summary>
    static List<int> SpiralOrder(int[,] matrix)
    {
        List<int> result = new List<int>();
        int top = 0, bottom = matrix.GetLength(0) - 1;
        int left = 0, right = matrix.GetLength(1) - 1;
        
        while (top <= bottom && left <= right)
        {
            // Derecha →
            for (int i = left; i <= right; i++)
                result.Add(matrix[top, i]);
            top++;
            
            // Abajo ↓
            for (int i = top; i <= bottom; i++)
                result.Add(matrix[i, right]);
            right--;
            
            if (top <= bottom)
            {
                // Izquierda ←
                for (int i = right; i >= left; i--)
                    result.Add(matrix[bottom, i]);
                bottom--;
            }
            
            if (left <= right)
            {
                // Arriba ↑
                for (int i = bottom; i >= top; i--)
                    result.Add(matrix[i, left]);
                left++;
            }
        }
        
        return result;
    }

    /// <summary>Encuentra todas las combinaciones que suman el target usando backtracking</summary>
    static List<List<int>> CombinationSum(int[] candidates, int target)
    {
        List<List<int>> result = new List<List<int>>();
        Array.Sort(candidates);
        Backtrack(result, new List<int>(), candidates, target, 0);
        return result;
    }

    /// <summary>Función auxiliar recursiva para backtracking</summary>
    static void Backtrack(List<List<int>> result, List<int> temp, int[] candidates, int remain, int start)
    {
        if (remain < 0) return;
        if (remain == 0)
        {
            result.Add(new List<int>(temp));
            return;
        }
        
        for (int i = start; i < candidates.Length; i++)
        {
            if (candidates[i] > remain) break;
            
            temp.Add(candidates[i]);
            Backtrack(result, temp, candidates, remain - candidates[i], i);
            temp.RemoveAt(temp.Count - 1);
        }
    }
}
