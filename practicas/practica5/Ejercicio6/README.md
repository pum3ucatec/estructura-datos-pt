# 📌 Ejercicio 6: Matriz Transpuesta

## 📖 Enunciado
Dada una **matriz** (arreglo bidimensional), encontrar su **matriz transpuesta**.  

👉 La **transpuesta** de una matriz se obtiene al convertir sus **filas en columnas**.  

### Ejemplo:
Matriz original:
[ [1, 2, 3],
[4, 5, 6] ]

Copiar código
Matriz transpuesta:
[ [1, 4],
[2, 5],
[3, 6] ]

pgsql
Copiar código

---

## 📌 Código en C#
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6}
        };

        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);

        int[,] transpuesta = Transponer(matriz);

        Console.WriteLine("\nMatriz transpuesta:");
        ImprimirMatriz(transpuesta);
    }

    static int[,] Transponer(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int[,] resultado = new int[columnas, filas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[j, i] = matriz[i, j];
            }
        }
        return resultado;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
🛠️ Explicación paso a paso
Definir matriz de ejemplo

csharp
Copiar código
int[,] matriz = {
    {1, 2, 3},
    {4, 5, 6}
};
Es una matriz de 2 filas x 3 columnas.

Transponer

Si la matriz es m x n, su transpuesta es n x m.

Se logra intercambiando los índices:

csharp
Copiar código
resultado[j, i] = matriz[i, j];
Imprimir la matriz
Se usa un método auxiliar que recorre filas y columnas.

✅ Ejemplo de ejecución
Entrada:
yaml
Copiar código
Matriz original:
1 2 3
4 5 6
Salida:
yaml
Copiar código
Matriz transpuesta:
1 4
2 5
3 6 