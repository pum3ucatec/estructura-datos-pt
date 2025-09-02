
#  Prácticas de Arreglos Avanzados en C#

Este documento contiene 10 ejercicios de arreglos y matrices en C#, mostrando técnicas como rotación, suma máxima, eliminación de duplicados, transposición, recorridos en espiral, combinaciones y más.

---

## Ejercicio 1 – Rotar un arreglo

**Objetivo:** Rotar los elementos de un arreglo `k` posiciones a la derecha.

```
int[] arr = {1, 2, 3, 4, 5};
int k = 2;

for (int i = 0; i < k; i++)
{
    int ultimo = arr[arr.Length - 1];
    for (int j = arr.Length - 1; j > 0; j--) arr[j] = arr[j - 1];
    arr[0] = ultimo;
}

foreach (int n in arr) Console.Write(n + " ");
```
## Explicación :
Se desplazan todos los elementos hacia la derecha `k` veces. El último elemento se mueve al inicio en cada iteración.

---

## Ejercicio 2 – Suma máxima de subarreglo contiguo

**Objetivo:** Encontrar la suma máxima de un subarreglo contiguo.

```
int[] arr = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
int maxSum = arr[0], current = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (current < 0) current = 0;
    current += arr[i];
    if (current > maxSum) maxSum = current;
}

Console.WriteLine("Suma máxima: " + maxSum);
```

## Explicación :
Se recorre el arreglo sumando elementos contiguos y reiniciando la suma cuando se vuelve negativa. Se guarda el valor máximo encontrado.

---

## Ejercicio 3 – Eliminar duplicados de un arreglo

**Objetivo:** Crear un arreglo sin duplicados consecutivos.

```
int[] arr = {1, 1, 2, 2, 3, 4, 4};
int nuevoTamaño = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (i == 0 || arr[i] != arr[i - 1])
    {
        arr[nuevoTamaño] = arr[i];
        nuevoTamaño++;
    }
}

for (int i = 0; i < nuevoTamaño; i++) Console.Write(arr[i] + " ");
```

## Explicación :
Se compara cada elemento con el anterior; si es distinto, se guarda en la nueva posición. Así se eliminan duplicados consecutivos.

---

## Ejercicio 4 – Encontrar número faltante

**Objetivo:** Encontrar el número que falta en un arreglo con números del 1 a n.

```
int[] arr = {1, 2, 4, 5, 6};
int n = arr.Length + 1;
int sumaTotal = n * (n + 1) / 2;
int sumaArr = 0;

for (int i = 0; i < arr.Length; i++) sumaArr += arr[i];

Console.WriteLine("Número que falta: " + (sumaTotal - sumaArr));
```

## Explicación :
Se calcula la suma esperada de 1 a n y se resta la suma real del arreglo. La diferencia es el número faltante.

---

## Ejercicio 5 – Elementos comunes entre arreglos

**Objetivo:** Mostrar elementos comunes entre dos arreglos.

```
int[] a = {1, 2, 2, 1};
int[] b = {2, 2};
bool[] usado = new bool[b.Length];

for (int i = 0; i < a.Length; i++)
{
    for (int j = 0; j < b.Length; j++)
    {
        if (a[i] == b[j] && !usado[j])
        {
            Console.Write(a[i] + " ");
            usado[j] = true;
            break;
        }
    }
}
```

## Explicación :
Se comparan todos los elementos de `a` con `b`. Se marca cada elemento usado para evitar repetir la coincidencia.

---

## Ejercicio 6 – Matriz transpuesta

**Objetivo:** Transponer una matriz.

```
int[,] mat = { {1,2,3}, {4,5,6} };
int filas = mat.GetLength(0), col = mat.GetLength(1);
int[,] trans = new int[col, filas];

for (int i = 0; i < filas; i++)
    for (int j = 0; j < col; j++)
        trans[j,i] = mat[i,j];

for (int i = 0; i < col; i++)
{
    for (int j = 0; j < filas; j++) Console.Write(trans[i,j] + " ");
    Console.WriteLine();
}
```

## Explicación :
Se intercambian filas y columnas, copiando cada elemento `mat[i,j]` en `trans[j,i]`.

---

## Ejercicio 7 – Producto de todos los elementos excepto el mismo

**Objetivo:** Crear un arreglo donde cada elemento es el producto de todos los demás.

```
int[] arr = {1,2,3,4};
int[] res = new int[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    int prod = 1;
    for (int j = 0; j < arr.Length; j++)
        if (i != j) prod *= arr[j];
    res[i] = prod;
}

foreach(int n in res) Console.Write(n + " ");
```

## Explicación :
Para cada posición, se multiplican todos los demás elementos y se guarda el resultado.

---

## Ejercicio 8 – Buscar en arreglo rotado

**Objetivo:** Buscar un elemento en un arreglo ordenado y rotado.

```
int[] arr = {4,5,6,7,0,1,2};
int target = 0;
int izquierda = 0, derecha = arr.Length - 1;

while (izquierda <= derecha)
{
    int medio = (izquierda + derecha) / 2;
    if (arr[medio] == target) { Console.WriteLine("Encontrado en: " + medio); break; }

    if (arr[izquierda] <= arr[medio])
    {
        if (target >= arr[izquierda] && target < arr[medio]) derecha = medio - 1;
        else izquierda = medio + 1;
    }
    else
    {
        if (target > arr[medio] && target <= arr[derecha]) izquierda = medio + 1;
        else derecha = medio - 1;
    }
}
```

## Explicación :
Se aplica búsqueda binaria adaptada a un arreglo rotado, comparando segmentos ordenados.

---

## Ejercicio 9 – Recorrido en espiral de matriz

**Objetivo:** Recorrer una matriz en **espiral**.

```
int[,] mat = { {1,2,3}, {4,5,6}, {7,8,9} };
int filas = 3, col = 3;
int top = 0, bottom = filas-1, left = 0, right = col-1;

while(top <= bottom && left <= right)
{
  for(int i=left;i<=right;i++) Console.Write(mat[top,i] + " ");
    top++;
    for(int i=top;i<=bottom;i++) Console.Write(mat[i,right] + " ");
    right--;
    if(top <= bottom) { for(int i=right;i>=left;i--) Console.Write(mat[bottom,i] + " "); bottom--; }
    if(left <= right) { for(int i=bottom;i>=top;i--) Console.Write(mat[i,left] + " "); left++; }
}
```

## Explicación :
Se recorren los bordes de la matriz en orden: fila superior, columna derecha, fila inferior, columna izquierda, y se repite hasta recorrer toda la matriz.

---

## Ejercicio 10 – Subconjuntos que suman un valor

**Objetivo:** Generar todos los subconjuntos de un arreglo cuya suma sea un objetivo.

```
int[] arr = {2,3,6,7};
int target = 7;
List<int> temp = new List<int>();
Subsets(arr, target, 0, temp, 0);

static void Subsets(int[] arr, int target, int suma, List<int> temp, int start)
{
    if (suma == target)
    {
        Console.WriteLine("[" + string.Join(", ", temp) + "]");
        return;
    }
    if (suma > target) return;

    for(int i=start;i<arr.Length;i++)
    {
        temp.Add(arr[i]);
        Subsets(arr, target, suma+arr[i], temp, i); // permitir repetir
        temp.RemoveAt(temp.Count-1);
    }
}
```

## Explicación :
Se usa **recursión** para generar combinaciones. Cada vez que la suma llega al objetivo, se imprime el subconjunto. Permite repetir elementos.

