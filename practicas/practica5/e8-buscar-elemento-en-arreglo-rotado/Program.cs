// Dado un arreglo **rotado y ordenado** (ej. `[4,5,6,7,0,1,2]`), 
// implementa búsqueda binaria modificada para encontrar un número dado.
using System;

class Ejercicio8 {
    static int Buscar(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;

        while (left <= right) {
            int mid = (left + right) / 2;

            if (nums[mid] == target) return mid;

            // esto es para verificar si la parte isquierda esta ordenada
            if (nums[left] <= nums[mid]) {
                if (nums[left] <= target && target < nums[mid]) {
                    right = mid - 1; 
                } else {
                    left = mid + 1; 
                }
            }
            // Si no, la parte derecha está ordenada
            else {
                if (nums[mid] < target && target <= nums[right]) {
                    left = mid + 1; 
                } else {
                    right = mid - 1; 
                }
            }
        }
        return -1; 
    }

    static void Main() {
        int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
        int target = 3;

        int resultado = Buscar(nums, target);
        Console.WriteLine(resultado >= 3 
            ? $"Elemento encontrado en índice {resultado}" 
            : "Elemento no encontrado");
    }
}
