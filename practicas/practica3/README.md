# Practica 3
Para practicar:  
- Declaración e inicialización de arreglos  
- Recorridos con `for` y `foreach`  
- Suma, promedio y búsquedas  
- Ordenamiento y manipulación de arreglos  

---

##  Índice
1. [Declaración e inicialización](#-1-declaración-e-inicialización)
2. [Recorrido con `for`](#-2-recorrido-con-for)
3. [Suma de elementos de un arreglo](#-3-suma-de-elementos-de-un-arreglo)
4. [Promedio de un arreglo](#-4-promedio-de-un-arreglo)
5. [Mayor y menor valor](#-5-mayor-y-menor-valor)
6. [Buscar un número](#-6-buscar-un-número)
7. [Contar ocurrencias](#-7-contar-ocurrencias)
8. [Invertir un arreglo](#-8-invertir-un-arreglo)
9. [Ordenar con burbuja](#-9-ordenar-con-burbuja)
10. [Suma de filas y columnas de matriz 3x3](#-10-suma-de-filas-y-columnas-de-matriz-3x3)

---

##  1. Declaración e inicialización
**Descripción:** Se declara un arreglo de 5 enteros y se imprime con un bucle `for`.  

### Código:
```csharp
int[] numeros = { 10, 20, 30, 40, 50 };
for (int i = 0; i < numeros.Length; i++)
    Console.WriteLine(numeros[i]);
 ```

### Explicación:

int[] numeros = {10,20,30,40,50} crea un arreglo de enteros.

numeros.Length devuelve el tamaño del arreglo (5).

El bucle for recorre cada índice del arreglo.

Console.WriteLine(numeros[i]) imprime cada elemento.

## 2. Recorrido con for

### Descripción: Se recorre un arreglo de 10 enteros y se imprime cada elemento.

### Código:
```csharp
int[] arreglo10 = {1,2,3,4,5,6,7,8,9,10};
for (int i = 0; i < arreglo10.Length; i++)
    Console.WriteLine(arreglo10[i]);
 ```

### Explicación:

Se crea un arreglo de 10 elementos.

El bucle for recorre cada posición del arreglo.

Se imprimen los números uno por uno en la consola.

## 3. Suma de elementos de un arreglo

### Descripción: 
Calcula la suma de todos los elementos de un arreglo usando foreach.

### Código:
```csharp
int[] arr = { 5, 10, 15, 20 };
int suma = 0;
foreach (int n in arr)
    suma += n;
Console.WriteLine($"La suma es = {suma}");
 ```

### Explicación:

Se declara una variable acumuladora suma = 0.

foreach recorre cada elemento del arreglo arr.

Cada número se suma a la variable suma.

Se imprime el resultado final.

## 4. Promedio de un arreglo

### Descripción: 
Calcula el promedio de los elementos de un arreglo usando .Sum().

### Código:
```csharp
int[] notas = { 80, 70, 90, 60, 100 };
double promedio = (double)notas.Sum() / notas.Length;
Console.WriteLine($"El promedio es = {promedio}");
 ```

### Explicación:

notas.Sum() suma todos los elementos del arreglo.

notas.Length devuelve la cantidad de elementos.

Se divide la suma entre la cantidad para obtener el promedio.

Se imprime el resultado.

## 5. Mayor y menor valor

### Descripción: 
Encuentra el mayor y menor número de un arreglo usando .Max() y .Min().

### Código:
```csharp
int[] nums = { 12, 5, 8, 20, 3, 17, 25, 10 };
Console.WriteLine($"Mayor = {nums.Max()}, Menor = {nums.Min()}");
 ```

### Explicación:

nums.Max() devuelve el valor máximo del arreglo.

nums.Min() devuelve el valor mínimo del arreglo.

Se imprimen ambos valores en consola.

## 6. Buscar un número

### Descripción: 
Busca un número ingresado por el usuario dentro de un arreglo.

## Código:
```csharp
int[] buscarArr = { 5,8,12,17,20,25,30,35,40,45 };
int buscar = int.Parse(Console.ReadLine()!);
int pos = Array.IndexOf(buscarArr, buscar);
if (pos != -1)
    Console.WriteLine($"Número {buscar} en posición {pos}");
else
    Console.WriteLine("Número no encontrado");
 ```

### Explicación:

Array.IndexOf devuelve la posición del número si se encuentra, o -1 si no.

Se imprime la posición o un mensaje de "no encontrado".

## 7. Contar ocurrencias

### Descripción: 
Cuenta cuántas veces aparece un número ingresado en un arreglo.

### Código:
```csharp
int[] ocurrencias = {2,5,2,8,2,9};
int buscado = int.Parse(Console.ReadLine()!);
int conteo = ocurrencias.Count(x => x == buscado);
Console.WriteLine($"El número {buscado} aparece {conteo} veces");
 ```

### Explicación:

Count(x => x == buscado) cuenta cuántas veces el número aparece.

Se imprime el resultado.

## 8. Invertir un arreglo

### Descripción: 
Invierte un arreglo usando .Reverse().ToArray().

### Código:
```csharp
int[] original = {1,2,3,4,5};
int[] invertido = original.Reverse().ToArray();
Console.WriteLine("Invertido: " + string.Join(", ", invertido));
 ```

### Explicación:

original.Reverse() invierte los elementos del arreglo.

ToArray() convierte el resultado de Reverse() en un arreglo.

string.Join une los elementos para mostrarlos en consola.

## 9. Ordenar con burbuja

### Descripción: 
Ordena un arreglo de forma ascendente usando el método burbuja.

### Código:
```csharp
int[] desordenado = {8,3,5,1,9};
for (int i = 0; i < desordenado.Length-1; i++)
    for (int j = 0; j < desordenado.Length-i-1; j++)
        if (desordenado[j] > desordenado[j+1])
        {
            int temp = desordenado[j];
            desordenado[j] = desordenado[j+1];
            desordenado[j+1] = temp;
        }
Console.WriteLine("Ordenado: " + string.Join(", ", desordenado));
 ```

### Explicación:

Compara elementos adyacentes y los intercambia si están desordenados.

Repite hasta que todo el arreglo esté ordenado.

Se imprime el arreglo final.

## 10. Suma de filas y columnas de matriz 3x3

### Descripción: 
Calcula la suma de filas y columnas de una matriz 3x3.

### Código:
```csharp
int[,] matriz = { {1,2,3}, {4,5,6}, {7,8,9} };
// Suma de filas
for (int i=0;i<3;i++)
{
    int sumFila=0;
    for(int j=0;j<3;j++) sumFila += matriz[i,j];
    Console.WriteLine($"Fila {i+1}: {sumFila}");
}
// Suma de columnas
for (int j=0;j<3;j++)
{
    int sumCol=0;
    for(int i=0;i<3;i++) sumCol += matriz[i,j];
    Console.WriteLine($"Columna {j+1}: {sumCol}");
}
 ```

### Explicación:

Se recorre cada fila y se suma sus elementos.

Se recorre cada columna y se suma sus elementos.

Se imprimen los resultados por filas y columnas.

## Cami