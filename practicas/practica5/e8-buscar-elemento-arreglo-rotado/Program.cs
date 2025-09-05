using System;

class BusquedaRotado
{
    public static int BuscarEnRotado(int[] arr, int target)
    {
        int izquierda = 0;
        int derecha = arr.Length - 1;
        
        while (izquierda <= derecha)
        {
            int medio = izquierda + (derecha - izquierda) / 2;
            
            if (arr[medio] == target) return medio;
            
            if (arr[izquierda] <= arr[medio])
            {
                if (target >= arr[izquierda] && target < arr[medio])
                    derecha = medio - 1;
                else
                    izquierda = medio + 1;
            }
            else
            {
                if (target > arr[medio] && target <= arr[derecha])
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }
        }
        
        return -1;
    }

    public static void Main()
    {
        int[] arr = {4, 5, 6, 7, 0, 1, 2};
        int target = 4;
        
        Console.WriteLine("Arreglo rotado: " + string.Join(", ", arr));
        Console.WriteLine("Buscando: " + target);
        
        int posicion = BuscarEnRotado(arr, target);
        Console.WriteLine("Posición encontrada: " + posicion);
    }
}