# Practica 5
#  Ejercicios de Arreglos y Matrices 



---

## 1. Rotación de un Arreglo
**Descripción:**  
Rota los elementos de un arreglo hacia la derecha `k` posiciones.

### Código:
```csharp
int[] arr = { 1, 2, 3, 4, 5 };
int k = 2;
```
### Explicación:

Se calcula k % n para evitar rotaciones innecesarias.

Se copian los últimos k elementos al inicio y el resto después.

Resultado: [4, 5, 1, 2, 3].

## 2. Subarreglo con Suma Máxima (Kadane’s Algorithm)

### Descripción:
Encuentra el subarreglo contiguo con la suma más grande.

### Código:
```csharp
int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
```


### Explicación:

maxActual guarda la suma máxima hasta el elemento actual.

maxGlobal guarda la suma máxima encontrada.

Se usa Math.Max para decidir si iniciar nuevo subarreglo o continuar.

## 3. Eliminar Duplicados en un Arreglo Ordenado

### Descripción:
Elimina duplicados de un arreglo ordenado sin usar colecciones adicionales.

### Código:
```csharp
int[] arr = { 1, 1, 2, 2, 3, 4, 4 };
```


### Explicación:

Se usa un puntero lento j para sobrescribir duplicados.

Solo se mantiene un valor único de cada elemento.

## 4. Encontrar el Número que Falta

### Descripción:
Encuentra el número que falta en un arreglo del 1 al n.

### Código:
```csharp
int[] arr = { 1, 2, 4, 5, 6 };
```


### Explicación:

Se calcula la suma esperada de 1..n.

Se resta la suma real del arreglo para obtener el número faltante.

## 5. Intersección de Dos Arreglos

### Descripción:
Encuentra los elementos comunes entre dos arreglos sin LINQ.

### Código:
```csharp
int[] arr1 = { 1, 2, 2, 1 };
int[] arr2 = { 2, 2 };
```

### Explicación:

Se recorre arr1 y se busca coincidencias en arr2.

Los elementos encontrados se marcan para evitar contar más de una vez.

## 6. Matriz Transpuesta

### Descripción:
Genera la transpuesta de una matriz (intercambia filas y columnas).

### Código:
```csharp
int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 } };
```


### Explicación:

Se crea una matriz nueva de tamaño cols x filas.

Se asigna transpuesta[j, i] = matriz[i, j].

## 7. Arreglo de Productos Excepto el Índice

### Descripción:
Cada posición contiene el producto de todos los elementos excepto el de esa posición, sin usar división.

### Código:
```csharp
int[] arr = { 1, 2, 3, 4 };
```


### Explicación:

Se calculan productos a la izquierda y a la derecha de cada índice.

El resultado es izquierda[i] * derecha[i].

## 8. Buscar Elemento en Arreglo Rotado

### Descripción:
Busca un elemento en un arreglo rotado y ordenado usando búsqueda binaria modificada.

### Código:
```csharp
int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
```


### Explicación:

Se verifica cuál lado del arreglo está ordenado.

Se ajustan los límites (inicio, fin) según la ubicación del objetivo.

## 9. Espiral en una Matriz

### Descripción:
Recorre e imprime los elementos de una matriz en forma de espiral.

### Código:
```csharp
int[,] matriz = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
```


### Explicación:

Se usan cuatro variables: filaInicio, filaFin, colInicio, colFin.

Se recorre la matriz en capas, moviéndose en orden: izquierda→derecha, arriba→abajo, derecha→izquierda, abajo→arriba.

## 10. Suma de Subconjuntos (Backtracking)

### Descripción:
Encuentra todos los subconjuntos cuya suma sea igual a un número objetivo (target).

### Código:
```csharp
int[] arr = { 2, 3, 6, 7 };
int target = 7;
```

### Explicación:

Se utiliza recursión y backtracking.

actual.Add() incluye el elemento y sigue buscando.

actual.RemoveAt() retrocede para explorar otras combinaciones.