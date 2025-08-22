using System;
using System.Collections.Generic;

namespace ExamenParcial
{
    public class EspiralMatriz
    {
        /// <summary>
        /// Recorre una matriz en forma de espiral (sentido horario)
        /// </summary>
        /// <param name="matriz">Matriz 2D de enteros</param>
        /// <returns>Lista de elementos en orden espiral</returns>
        public static List<int> RecorridoEspiral(int[,] matriz)
        {
            List<int> resultado = new List<int>();
            
            if (matriz == null || matriz.Length == 0)
                return resultado;
            
            int filaInicio = 0, filaFin = matriz.GetLength(0) - 1;
            int colInicio = 0, colFin = matriz.GetLength(1) - 1;
            
            while (filaInicio <= filaFin && colInicio <= colFin)
            {
                // Derecha →
                for (int j = colInicio; j <= colFin; j++)
                {
                    resultado.Add(matriz[filaInicio, j]);
                }
                filaInicio++;
                
                // Abajo ↓
                for (int i = filaInicio; i <= filaFin; i++)
                {
                    resultado.Add(matriz[i, colFin]);
                }
                colFin--;
                
                if (filaInicio <= filaFin)
                {
                    // Izquierda ←
                    for (int j = colFin; j >= colInicio; j--)
                    {
                        resultado.Add(matriz[filaFin, j]);
                    }
                    filaFin--;
                }
                
                if (colInicio <= colFin)
                {
                    // Arriba ↑
                    for (int i = filaFin; i >= filaInicio; i--)
                    {
                        resultado.Add(matriz[i, colInicio]);
                    }
                    colInicio++;
                }
            }
            
            return resultado;
        }
        
        // Método auxiliar para imprimir matriz
        public static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Método principal para pruebas
        public static void Main(string[] args)
        {
            Console.WriteLine("=== PRUEBA RECORRIDO ESPIRAL ===");
            
            // Caso de prueba 1 - Matriz 3x3
            int[,] test1 = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            
            Console.WriteLine("Matriz 3x3:");
            ImprimirMatriz(test1);
            var resultado1 = RecorridoEspiral(test1);
            Console.WriteLine($"Recorrido espiral: [{string.Join(", ", resultado1)}]");
            Console.WriteLine($"Esperado: [1, 2, 3, 6, 9, 8, 7, 4, 5]");
            Console.WriteLine();
            
            // Caso de prueba 2 - Matriz 2x3
            int[,] test2 = {
                {1, 2, 3},
                {4, 5, 6}
            };
            
            Console.WriteLine("Matriz 2x3:");
            ImprimirMatriz(test2);
            var resultado2 = RecorridoEspiral(test2);
            Console.WriteLine($"Recorrido espiral: [{string.Join(", ", resultado2)}]");
            Console.WriteLine($"Esperado: [1, 2, 3, 6, 5, 4]");
        }
    }
}
