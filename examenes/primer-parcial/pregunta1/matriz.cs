using System;
using System.Collections.Generic;

namespace Pregunta1
{
    class EspiralMatriz
    {
        public static List<int> RecorrerEnEspiral(int[,] matriz)
        {
            List<int> resultado = new List<int>();

            int filaInicio = 0, filaFin = matriz.GetLength(0) - 1;
            int colInicio = 0, colFin = matriz.GetLength(1) - 1;

            while (filaInicio <= filaFin && colInicio <= colFin)
            {
                for (int i = colInicio; i <= colFin; i++)
                    resultado.Add(matriz[filaInicio, i]);
                filaInicio++;

                for (int i = filaInicio; i <= filaFin; i++)
                    resultado.Add(matriz[i, colFin]);
                colFin--;

                if (filaInicio <= filaFin)
                {
                    for (int i = colFin; i >= colInicio; i--)
                        resultado.Add(matriz[filaFin, i]);
                    filaFin--;
                }

                if (colInicio <= colFin)
                {
                    for (int i = filaFin; i >= filaInicio; i--)
                        resultado.Add(matriz[i, colInicio]);
                    colInicio++;
                }
            }

            return resultado;
        }
    }
}
