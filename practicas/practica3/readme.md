# Manipulación de Arreglos en C#
Esta practica contiene 10 programas en C# que demuestran diversas operaciones comunes con arreglos unidimensionales y bidimensionales.

## Programas incluidos
1. Programa1 - Recorrido básico de arreglo
Archivo: Program.cs (Programa)
```
csharp
int[] numeros = { 10, 20, 30, 40, 50 };
Recorre e imprime todos los valores de un arreglo predefinido.
```
##  2. Programa2 - Arreglo con más elementos
Archivo: Program.cs (Programa2)
```
csharp
int[] numeros = { 1,2,3,4,5,6,7,8,9,10 };
Similar al anterior pero con un arreglo de 10 elementos.
```
## 3. Programa3 - Suma de elementos
Archivo: Program.cs (Programa3)
```
csharp
int[] numeros = { 5, 10, 15, 20 };
int suma = 0;
Calcula la suma de todos los elementos de un arreglo.
```
## 4. Programa4 - Cálculo de promedio
Archivo: Program.cs (Programa4)
```
csharp
int[] notas = { 80, 70, 90, 60, 100 };
double promedio = (double)suma / notas.Length;
Calcula el promedio de valores en un arreglo, utilizando conversión de tipo para precisión decimal.
```
## 5. Programa5 - Encontrar mayor y menor
Archivo: Program.cs (Programa5)
```
csharp
int[] numeros = { 12, 5, 8, 20, 3, 17, 25, 10 };
int mayor = numeros[0];
int menor = numeros[0];
Encuentra el valor máximo y mínimo en un arreglo de números.
```
## 6. Programa6 - Búsqueda de elemento
Archivo: Program.cs (Programa6)
```
csharp
int[] numeros = { 3, 7, 10, 15, 17, 20, 25, 30, 40, 50 };
int buscado = int.Parse(Console.ReadLine());
Busca un número específico ingresado por el usuario dentro de un arreglo e indica su posición.
```
## 7. Programa7 - Conteo de ocurrencias
Archivo: Program.cs (Programa7)
```
csharp
int[] numeros = { 2, 5, 2, 8, 2, 9 };
int contador = 0;
Cuenta cuántas veces aparece un número específico en un arreglo.
```
## 8. Programa8 - Inversión de arreglo
Archivo: Program.cs (Programa8)
```
csharp
int[] original = { 1, 2, 3, 4, 5 };
int[] invertido = new int[original.Length];
Crea una copia invertida de un arreglo original.
```
## 9. Programa9 - Ordenamiento de arreglo
Archivo: Program.cs (Programa9)
```
csharp
int[] numeros = { 8, 3, 5, 1, 9 };
Ordena un arreglo de números utilizando el algoritmo de burbuja (Bubble Sort).
```
## 10. Programa10 - Manipulación de matriz bidimensional
Archivo: Program.cs (Programa10)
```
csharp
int[,] matriz = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
Calcula la suma de cada fila y cada columna de una matriz bidimensional.
```