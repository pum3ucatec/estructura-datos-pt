using System;

class ProductoExceptoIndice
{
    public static int[] ProductoExceptoIndice1(int[] arr)
    {
        int n = arr.Length;
        int[] resultado = new int[n];
        
        int productoIzquierda = 1;
        for (int i = 0; i < n; i++)
        {
            resultado[i] = productoIzquierda;
            productoIzquierda *= arr[i];
        }
        
        int productoDerecha = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            resultado[i] *= productoDerecha;
            productoDerecha *= arr[i];
        }
        
        return resultado;
    }

    public static void Main()
    {
        int[] arr = {1, 2, 3, 4};
        Console.WriteLine("Arreglo: " + string.Join(", ", arr));
        
        int[] resultado = ProductoExceptoIndice1(arr);
        Console.WriteLine("Producto excepto índice: " + string.Join(", ", resultado));
    }
}