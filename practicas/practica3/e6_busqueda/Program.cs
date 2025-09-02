/* 6. Búsqueda lineal
Dado un arreglo de 10 números, pide al usuario un número y determina si está dentro del arreglo (imprime la posición si existe).*/

using System;

class ejercicio_6
{
    static void Main()
    {
        int[] datos = { 4, 9, 17, 23, 42, 17, 8, 12, 5, 33 };
        int buscado = LeerEntero("Ingrese un número a buscar: ");

        int indice = -1;
        for (int i = 0; i < datos.Length; i++)
        {
            if (datos[i] == buscado)
            {
                indice = i;
                break; 
            }
        }

        if (indice != -1)
            Console.WriteLine($"El número {buscado} se encuentra en el índice {indice} (posición {indice + 1}).");
        else
            Console.WriteLine($"El número {buscado} no está en el arreglo.");
    }

    static int LeerEntero(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int valor))
                return valor;
            Console.WriteLine("Error, intenta de nuevo.");
        }
    }
}

