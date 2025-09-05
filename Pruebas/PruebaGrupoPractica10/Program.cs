using System;

public class Program
{
    public static void Main()
    {
        int[] arreglo = {4, 2, 7, 1, 9};
        int numeroBuscado = 7;
        
        // Llamar al método recursivo
        bool resultado = BuscarElementoRecursivo(arreglo, numeroBuscado);
        
        // Mostrar el resultado
        Console.WriteLine("¿El número " + numeroBuscado + " está en el arreglo?");
        Console.WriteLine("Respuesta: " + resultado);
        
        // Probar con otro número que no existe
        Console.WriteLine("\n¿El número 5 está en el arreglo?");
        Console.WriteLine("Respuesta: " + BuscarElementoRecursivo(arreglo, 5));
    }
    
    public static bool BuscarElementoRecursivo(int[] arr, int valor, int indice = 0)
    {
        if (indice >= arr.Length) return false;
        if (arr[indice] == valor) return true;
        return BuscarElementoRecursivo(arr, valor, indice + 1);
    }
}