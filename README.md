# 📘 Ejercicios Avanzados con Arreglos en C#

Este programa presenta **10 ejercicios avanzados** con arreglos y matrices en **C#**, resolviendo problemas clásicos de algoritmos como rotaciones, sumas máximas, intersecciones y backtracking.

---

## 🔹 1. Rotación de Arreglo

**Descripción:**  
Rota un arreglo `k` posiciones hacia la derecha usando el método de **reversión triple**.

```csharp
static void RotateArray(int[] nums, int k)
{
    k %= nums.Length;
    Reverse(nums, 0, nums.Length - 1);
    Reverse(nums, 0, k - 1);
    Reverse(nums, k, nums.Length - 1);
}
Ejemplo de entrada y salida:

Entrada: [1, 2, 3, 4, 5], k = 2

Salida: [4, 5, 1, 2, 3]
```
```csharp
🔹 2. Subarreglo con Suma Máxima
Descripción:
Implementa el algoritmo de Kadane para encontrar el subarreglo con la mayor suma posible.

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
Ejemplo de entrada y salida:

Entrada: [-2,1,-3,4,-1,2,1,-5,4]

Salida: Suma = 6, Subarreglo [4, -1, 2, 1]

```

```csharp
🔹 3. Eliminar Duplicados
Descripción:
Elimina duplicados de un arreglo ordenado in-place usando dos punteros.

static int RemoveDuplicates(int[] nums)
{
    if (nums.Length == 0) return 0;
    
    int i = 0; 
    for (int j = 1; j < nums.Length; j++)
    {
        if (nums[j] != nums[i])
        {
            i++;
            nums[i] = nums[j];
        }
    }
    return i + 1;
}
Ejemplo:

Entrada: [1,1,2,2,3,4,4]

Salida: [1,2,3,4]
