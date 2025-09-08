/* 7. Contar ocurrencias
Dado un arreglo de enteros, pide un número y cuenta cuántas veces aparece en el arreglo. */

using System;

class ejercicio_7
{
    static void Main()
    {
        int[] datos = { 2, 5, 2, 8, 2, 9 };
        int buscado = LeerEntero("Número a contar: ");

        int conteo = 0;
        for (int i = 0; i < datos.Length; i++)
            if (datos[i] == buscado) conteo++;

        Console.WriteLine($"Arreglo: [{string.Join(", ", datos)}]");
        Console.WriteLine($"Número buscado: {buscado}");
        Console.WriteLine($"El número aparece {conteo} {(conteo == 1 ? "vez" : "veces")}.");
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

