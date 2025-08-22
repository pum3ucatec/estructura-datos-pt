using System;
using System.Collections.Generic;

class ejersicio1
{
    static void Main(string[] args)
    {
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        List<int> resultado = RecorrerEspiral(matriz);

        Console.WriteLine("Recorrido en espiral:");
        Console.WriteLine(string.Join(", ", resultado));
    }

    static List<int> RecorrerEspiral(int[,] matriz)
    {
        List<int> resultado = new List<int>();

        int arriba = 0, 
            abajo = matriz.GetLength(0) - 1;
        int izquierda = 0, 
            derecha = matriz.GetLength(1) - 1;

        while (arriba <= abajo && izquierda <= derecha)
        {
           
            for (int i = izquierda; i <= derecha; i++)
                resultado.Add(matriz[arriba, i]);
            arriba++;

        
            for (int i = arriba; i <= abajo; i++)
                resultado.Add(matriz[i, derecha]);
            derecha--;

            if (arriba <= abajo)
            {
            
                for (int i = derecha; i >= izquierda; i--)
                    resultado.Add(matriz[abajo, i]);
                abajo--;
            }

            if (izquierda <= derecha)
            {
               
                for (int i = abajo; i >= arriba; i--)
                    resultado.Add(matriz[i, izquierda]);
                izquierda++;
            }
        }

        return resultado;
    }
}

