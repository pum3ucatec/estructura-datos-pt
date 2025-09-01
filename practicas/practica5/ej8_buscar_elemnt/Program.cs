using System;

class Ejercicio8
{
    static void Main()
    {
        Console.WriteLine("Ejemplo buscando 0 en [4,5,6,7,0,1,2]");
        int[] ejemplo = { 4, 5, 6, 7, 0, 1, 2 };
        int indiceEjemplo = BuscarEnRotado(ejemplo, 0);
        Console.WriteLine("Posición: " + (indiceEjemplo >= 0 ? indiceEjemplo + 1 : -1));

        Console.WriteLine("\nAhora ingresa tu arreglo (separado por espacios):");
        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] arr = Array.ConvertAll(input, int.Parse);

        Console.WriteLine("Número a buscar:");
        int target = int.Parse(Console.ReadLine());

        int indice = BuscarEnRotado(arr, target);
        Console.WriteLine("Posición: " + (indice >= 0 ? indice + 1 : -1));
    }

    static int BuscarEnRotado(int[] arr, int target)
    {
        int izquierda = 0, derecha = arr.Length - 1;

        while (izquierda <= derecha)
        {
            int mid = (izquierda + derecha) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[izquierda] <= arr[mid])
            {
                if (target >= arr[izquierda] && target < arr[mid])
                    derecha = mid - 1;
                else
                    izquierda = mid + 1;
            }
            else
            {
                if (target > arr[mid] && target <= arr[derecha])
                    izquierda = mid + 1;
                else
                    derecha = mid - 1;
            }
        }
        return -1;
    }
}
