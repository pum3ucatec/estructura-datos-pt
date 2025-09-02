using System;
class Ejercicio6
{
    static void Main()
    {
        int[] arreglo = { 5, 8, 12, 17, 20, 25, 30, 35, 40, 45 };
        Console.Write("Ingrese un número: ");
        int buscado = int.Parse(Console.ReadLine());
        bool encontrado = false;

        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == buscado)
            {
                Console.WriteLine("El número " + buscado + " se encuentra en la posición " + i);
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
            Console.WriteLine("Número no encontrado");

    }
}