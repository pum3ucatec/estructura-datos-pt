# Documentación de 10 Programas con Arreglos en C#

Este documento contiene 10 programas en **C#** que trabajan con arreglos unidimensionales y bidimensionales. Cada ejercicio incluye una breve explicación de su funcionamiento y el código correspondiente.

---

## Ejercicio 1: Recorrer y mostrar un arreglo
Este programa recorre un arreglo de números y muestra cada elemento en consola.
```csharp
int[] numeros = { 10, 20, 30, 40, 50 };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
```

## Ejercicio 2: Mostrar números del 1 al 10 en un arreglo
```csharp
int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
```
**Explicación:** Recorre un arreglo con números del 1 al 10 y los muestra uno por uno en consola.

# Ejercicio 3: Suma de elementos de un arreglo
```csharp
int[] arreglo = { 5, 10, 15, 20 };
int suma = 0;

for (int i = 0; i < arreglo.Length; i++)
{
    suma += arreglo[i];
}

Console.WriteLine("Arreglo: [" + string.Join(", ", arreglo) + "]");
Console.WriteLine("Suma: " + suma);
```
**Explicación:** Calcula la suma de todos los elementos del arreglo y muestra el resultado.

# Ejercicio 4: Promedio de notas
```csharp

int[] notas = { 80, 70, 90, 60, 100 };
int suma = 0;

for (int i = 0; i < notas.Length; i++)
{
    suma += notas[i];
}

double promedio = (double)suma / notas.Length;

Console.WriteLine("Notas: [" + string.Join(", ", notas) + "]");
Console.WriteLine("Promedio: " + promedio);
```
**Explicación:** Suma todas las notas del arreglo y luego calcula el promedio dividiendo entre la cantidad de elementos.

# Ejercicio 5: Encontrar el mayor y menor en un arreglo
```csharp

int[] numeros = { 12, 5, 8, 20, 3, 17, 25, 10 };
int mayor = numeros[0];
int menor = numeros[0];

for (int i = 1; i < numeros.Length; i++)
{
    if (numeros[i] > mayor)
        mayor = numeros[i];
    if (numeros[i] < menor)
        menor = numeros[i];
}

Console.WriteLine("Números: [" + string.Join(", ", numeros) + "]");
Console.WriteLine("Mayor: " + mayor);
Console.WriteLine("Menor: " + menor);
```
**Explicación:** Recorre el arreglo comparando cada número para encontrar el mayor y el menor.

# Ejercicio 6: Buscar un número en el arreglo
``` csharp
int[] numeros = { 4, 8, 15, 16, 23, 42, 7, 9, 1, 17 };

Console.Write("Ingrese un número: ");
int numBuscado = int.Parse(Console.ReadLine());

int posicion = -1;
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == numBuscado)
    {
        posicion = i;
        break;
    }
}

if (posicion != -1)
    Console.WriteLine($"El número {numBuscado} se encuentra en la posición {posicion}");
else
    Console.WriteLine($"El número {numBuscado} no se encontró en el arreglo");
```
**Explicación:** Permite ingresar un número y busca si existe en el arreglo, mostrando su posición.

# Ejercicio 7: Contar cuántas veces aparece un número
```csharp
int[] arreglo = { 2, 5, 2, 8, 2, 9 };

Console.Write("Número buscado: ");
int numBuscado = int.Parse(Console.ReadLine());

int contador = 0;
for (int i = 0; i < arreglo.Length; i++)
{
    if (arreglo[i] == numBuscado)
        contador++;
}

Console.WriteLine($"El número aparece {contador} veces");
```
**Explicación:** Recorre el arreglo y cuenta cuántas veces aparece el número ingresado.

## Ejercicio 8: Invertir un arreglo
```csharp

int[] original = { 1, 2, 3, 4, 5 };
int[] invertido = new int[original.Length];

for (int i = 0; i < original.Length; i++)
{
    invertido[i] = original[original.Length - 1 - i];
}

Console.WriteLine("Arreglo original: [" + string.Join(", ", original) + "]");
Console.WriteLine("Arreglo invertido: [" + string.Join(", ", invertido) + "]");
```
**Explicación:** Crea un nuevo arreglo con los elementos en orden inverso al original.

# Ejercicio 9: Ordenar un arreglo (Método Burbuja)
```csharp

int[] arreglo = { 8, 3, 5, 1, 9 };

for (int i = 0; i < arreglo.Length - 1; i++)
{
    for (int j = 0; j < arreglo.Length - 1 - i; j++)
    {
        if (arreglo[j] > arreglo[j + 1])
        {
            int temp = arreglo[j];
            arreglo[j] = arreglo[j + 1];
            arreglo[j + 1] = temp;
        }
    }
}

Console.WriteLine("Arreglo ordenado: [" + string.Join(", ", arreglo) + "]");
```
**Explicación:** Usa el algoritmo de ordenamiento burbuja para ordenar los elementos de menor a mayor.

# Ejercicio 10: Suma de filas y columnas en una matriz
```csharp
int[,] matriz = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

// Suma filas
Console.WriteLine("Suma de filas:");
for (int i = 0; i < 3; i++)
{
    int sumaFila = 0;
    for (int j = 0; j < 3; j++)
    {
        sumaFila += matriz[i, j];
    }
    Console.WriteLine($"Fila {i + 1}: {sumaFila}");
}

// Suma columnas
Console.WriteLine("\nSuma de columnas:");
for (int j = 0; j < 3; j++)
{
    int sumaColumna = 0;
    for (int i = 0; i < 3; i++)
    {
        sumaColumna += matriz[i, j];
    }
    Console.WriteLine($"Columna {j + 1}: {sumaColumna}");
}
```
**Explicación:** Calcula y muestra la suma de cada fila y cada columna de una matriz de 3x3.
