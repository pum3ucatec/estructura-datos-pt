using System;

Console.WriteLine("Ejercicio 9! Recorrer matriz en espiral");


int[,] matriz = {
    { 11, 12, 13, 14 },
    { 21, 22, 23, 24 },
    { 31, 32, 33, 34 }
};

int filas = matriz.GetLength(0);
int columnas = matriz.GetLength(1);

int arriba = 0, abajo = filas - 1;
int izq = 0, der = columnas - 1;

Console.Write("Recorrido en espiral: ");

while (arriba <= abajo && izq <= der)
{

    for (int j = izq; j <= der; j++)
        Console.Write(matriz[arriba, j] + " ");
    arriba++;


    for (int i = arriba; i <= abajo; i++)
        Console.Write(matriz[i, der] + " ");
    der--;

    if (arriba <= abajo)
    {

        for (int j = der; j >= izq; j--)
            Console.Write(matriz[abajo, j] + " ");
        abajo--;
    }

    if (izq <= der)
    {

        for (int i = abajo; i >= arriba; i--)
            Console.Write(matriz[i, izq] + " ");
        izq++;
    }
}

Console.WriteLine();
