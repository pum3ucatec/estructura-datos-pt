# 📌 Ejercicio 9: Recorrido en Espiral de una Matriz

## 📖 Enunciado
Escribe un programa que recorra e imprima los elementos de una matriz en forma de **espiral**.

---

## ✨ Ejemplo
### Entrada:
[ [1, 2, 3],
[4, 5, 6],
[7, 8, 9] ]

shell
Copiar código

### Salida:
[1, 2, 3, 6, 9, 8, 7, 4, 5]

pgsql
Copiar código

---

## 📌 Código en C#
```csharp
static void RecorridoEspiral(int[,] matriz)
{
    int filaInicio = 0, filaFin = matriz.GetLength(0) - 1;
    int colInicio = 0, colFin = matriz.GetLength(1) - 1;

    while (filaInicio <= filaFin && colInicio <= colFin)
    {
        for (int i = colInicio; i <= colFin; i++)
            Console.Write(matriz[filaInicio, i] + " ");
        filaInicio++;

        for (int i = filaInicio; i <= filaFin; i++)
            Console.Write(matriz[i, colFin] + " ");
        colFin--;

        if (filaInicio <= filaFin)
        {
            for (int i = colFin; i >= colInicio; i--)
                Console.Write(matriz[filaFin, i] + " ");
            filaFin--;
        }

        if (colInicio <= colFin)
        {
            for (int i = filaFin; i >= filaInicio; i--)
                Console.Write(matriz[i, colInicio] + " ");
            colInicio++;
        }
    }
}
🛠️ Explicación
Usamos cuatro límites para controlar el recorrido:

filaInicio, filaFin

colInicio, colFin

Recorremos:

Izquierda → Derecha

Arriba → Abajo

Derecha → Izquierda

Abajo → Arriba

Reducimos los límites después de cada recorrido para "encogernos" hacia el centro de la matriz.

✅ Ejemplo de ejecución
yaml
Copiar código
Matriz original:
1 2 3 
4 5 6 
7 8 9 

Recorrido en espiral:
1 2 3 6 9 8 7 4 5