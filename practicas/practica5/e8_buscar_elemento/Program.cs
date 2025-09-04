using System;

class ejercicio_8 {
    static int Buscar(int[] arr, int target) {
        int inicio = 0, fin = arr.Length - 1;
        while (inicio <= fin) {
            int mid = (inicio + fin) / 2;
            if (arr[mid] == target) return mid;

            if (arr[inicio] <= arr[mid]) {
                if (target >= arr[inicio] && target < arr[mid]) fin = mid - 1;
                else inicio = mid + 1;
            } else {
                if (target > arr[mid] && target <= arr[fin]) inicio = mid + 1;
                else fin = mid - 1;
            }
        }
        return -1;
    }

    static void Main() {
        Console.WriteLine("Ingrese tamaño del arreglo:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Ingrese elementos del arreglo rotado:");
        for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el número a buscar:");
        int target = int.Parse(Console.ReadLine());

        int pos = Buscar(arr, target);
        Console.WriteLine(pos == -1 ? "No encontrado" : $"Encontrado en índice {pos}");
    }
}
