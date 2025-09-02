using System;

class EliminarDuplicados
{
    public static int EliminarDuplicados1(int[] arr)
    {
        if (arr == null || arr.Length == 0) return 0;
        
        int indiceUnico = 0;
        
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[indiceUnico])
            {
                indiceUnico++;
                arr[indiceUnico] = arr[i];
            }
        }
        
        return indiceUnico + 1;
    }

    public static void Main()
    {
        int[] arr = {1, 1, 2, 2, 3, 4, 4};
        Console.WriteLine("Arreglo original: " + string.Join(", ", arr));
        
        int nuevaLongitud = EliminarDuplicados1(arr);
        Console.WriteLine("Sin duplicados: " + string.Join(", ", arr[0..nuevaLongitud]));
        Console.WriteLine("Nueva longitud: " + nuevaLongitud);
    }
}