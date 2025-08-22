# FUNCIONAMIENTO PREGUNTA 1

## Recorrido en espiral de una matriz

- Importamos la biblioteca .NET y Colections Generic

```c#
using System;
using System.Collections.Generic;
```

## Clase principal

### Metodo principal

- Creamos una matriz 3 x 3, que recorreremos en espiral

```c#
 static void Main(string[] args){
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        List<int> resultado = RecorrerEspiral(matriz);

        Console.WriteLine("Recorrido en espiral:");
        Console.WriteLine(string.Join(", ", resultado));
    }
```

Llamamos al metodo **RecorrerEspiral** y lo guardamos en una lista, y se imprime la lista

---

### Metodo para recorrer el espiral

- Para poder recorrer la matriz y que nos la devuelva en espiral crearemos un metodo **RecorrerEspiral**

```c#
static List<int> RecorrerEspiral(int[,] matriz)
```

Esto se encarga de recibir la matriz y devolvernos una lista con los numeros en orden espiral

- Creamos una lista donde se guardara el recorrido

```c#
List<int> resultado = new List<int>();
if (matriz == null || matriz.Length == 0) return resultado;

int filas = matriz.GetLength(0);
int columnas = matriz.GetLength(1);
```

Si la matriz esta vacia, nos devolvera un valor vacio. Usamos GetLength() para obtener el tamaño, en este caso, de las filas y columnas.

- Despues definimos los limites de la matriz

```c#
int arriba = 0, abajo = filas - 1;
int izquierda = 0, derecha = columnas - 1;

```

- Usamos "while" para que haga el recorrido en espiral hasta que las capas no se terminen

```c#
 while (arriba <= abajo && izquierda <= derecha)
```

- Ahora hacemos el recorrido en espiral

---

1.  Primero el recorrido de la fila de arriba

```c#
for (int j = izquierda; j <= derecha; j++)
                resultado.Add(matriz[arriba, j]);
                arriba++;
```

2.  Despues el recorriodo de la tercera columna

```c#
for (int i = arriba; i <= abajo; i++)
                resultado.Add(matriz[i, derecha]);
                derecha--;
```

3.  Continuamos con el corrido de la tercera fila, esta vez de derecha a izquierda

```c#
     if (arriba <= abajo)
    {
        for (int j = derecha; j >= izquierda; j--)
        resultado.Add(matriz[abajo, j]);
        abajo--;
            }

```

4. Por ultimo subimos por la primera columna

```c#
    if (izquierda <= derecha)
    {
        for (int i = abajo; i >= arriba; i--)
        resultado.Add(matriz[i, izquierda]);
        izquierda++;
            }
```

- Salimos del ciclo y nos devuelve el resultado

```c#
return resultado;
```
