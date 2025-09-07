# 📘 Prácticas con Arreglos en C#

Este programa contiene **10 ejercicios prácticos** para aprender a trabajar con **arreglos y matrices en C#**.  
Cada sección explica cómo funciona el código, qué hace y muestra ejemplos de salida.

----------

## 🔹 1. Declaración e inicialización

**Cómo funciona:**  
Se crea un arreglo de 5 enteros y se imprime cada elemento con su índice.

`int[] numeros = { 10, 20, 30, 40, 50 }; for (int indice = 0; indice < numeros.Length; indice++)
{
    Console.WriteLine($"Posición {indice}: {numeros[indice]}");
}` 

📌 El arreglo se inicializa manualmente y se recorre con `for`.

**Ejemplo de salida:**

`Posición  0:  10  Posición  1:  20  Posición  2:  30  Posición  3:  40  Posición  4:  50` 

----------

## 🔹 2. Recorrido con ciclo for

**Cómo funciona:**  
Se crea un arreglo con los números del 1 al 10 y se recorren con un `for`.

`int[] arregloNumeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; for (int indice = 0; indice < arregloNumeros.Length; indice++)
{
    Console.Write(arregloNumeros[indice] + " ");
}` 

📌 El ciclo recorre todo el arreglo y muestra los elementos en una sola línea.

**Ejemplo de salida:**

`1 2 3 4 5 6 7 8 9 10` 

----------

## 🔹 3. Suma de elementos

**Cómo funciona:**  
Se suman todos los elementos de un arreglo usando `foreach`.

`int[] arregloSuma = { 5, 10, 15, 20 }; int sumaTotal = 0; foreach (int numero in arregloSuma)
{
    sumaTotal += numero;
}` 

📌 `foreach` recorre todos los elementos y acumula su valor.

**Ejemplo de salida:**

`Arreglo: [5, 10, 15, 20] Suma total:  50` 

----------

## 🔹 4. Promedio de calificaciones

**Cómo funciona:**  
Se almacenan 5 calificaciones y se calcula su promedio.

`double[] calificaciones = { 80, 70, 90, 60, 100 }; double sumaCalificaciones = 0; foreach (double calificacion in calificaciones)
{
    sumaCalificaciones += calificacion;
} double promedio = sumaCalificaciones / calificaciones.Length;` 

📌 El promedio es la suma dividida entre la cantidad de calificaciones.

**Ejemplo de salida:**

`Calificaciones: [80, 70, 90, 60, 100]  Promedio: 80` 

----------

## 🔹 5. Mayor y menor valor

**Cómo funciona:**  
Se busca el mayor y el menor valor en un arreglo.

`int[] numeros = { 12, 5, 8, 20, 3, 17, 25, 10 }; int mayor = numeros[0]; int menor = numeros[0]; for (int i = 1; i < numeros.Length; i++)
{ if (numeros[i] > mayor) mayor = numeros[i]; if (numeros[i] < menor) menor = numeros[i];
}` 

📌 Se comparan todos los elementos para identificar el mayor y el menor.

**Ejemplo de salida:**

`Números: [12, 5, 8, 20, 3, 17, 25, 10] Mayor valor:  25  Menor valor:  3` 

----------

## 🔹 6. Búsqueda lineal

**Cómo funciona:**  
El usuario ingresa un número y el programa busca si existe en el arreglo.

`int[] arregloBusqueda = { 2, 7, 15, 8, 17, 3, 9, 12, 6, 4 }; for (int posicion = 0; posicion < arregloBusqueda.Length; posicion++)
{ if (arregloBusqueda[posicion] == numeroBuscado)
    {
        Console.WriteLine($"✅ Se encuentra en la posición {posicion}"); break;
    }
}` 

📌 Si encuentra el número, muestra su posición; si no, indica que no está.

**Ejemplo de salida:**

`Ingrese un número a buscar: 15 ✅ El número 15 se encuentra en la posición 2` 

----------

## 🔹 7. Contar ocurrencias

**Cómo funciona:**  
Se cuenta cuántas veces aparece un número en el arreglo.

`int[] arregloOcurrencias = { 2, 5, 2, 8, 2, 9 }; int contador = 0; foreach (int numero in arregloOcurrencias)
{ if (numero == numeroAContar) contador++;
}` 

📌 Usa un `foreach` para incrementar el contador cada vez que encuentra el número.

**Ejemplo de salida:**

`Ingrese el número a contar: 2 El número 2 aparece 3 veces` 

----------

## 🔹 8. Invertir arreglo

**Cómo funciona:**  
Se genera un nuevo arreglo con los elementos del original en orden inverso.

`int[] arregloOriginal = { 1, 2, 3, 4, 5 }; int[] arregloInvertido = new  int[arregloOriginal.Length]; for (int i = 0; i < arregloOriginal.Length; i++)
{
    arregloInvertido[i] = arregloOriginal[arregloOriginal.Length - 1 - i];
}` 

📌 Se copia desde el último elemento hacia adelante.

**Ejemplo de salida:**

`Arreglo  original: [1, 2, 3, 4, 5]  Arreglo  invertido: [5, 4, 3, 2, 1]` 

----------

## 🔹 9. Ordenamiento burbuja

**Cómo funciona:**  
Ordena un arreglo de menor a mayor con el algoritmo de **burbuja**.

`for (int i = 0; i < arregloOrdenado.Length - 1; i++)
{ for (int j = 0; j < arregloOrdenado.Length - 1 - i; j++)
    { if (arregloOrdenado[j] > arregloOrdenado[j + 1])
        { int temporal = arregloOrdenado[j];
            arregloOrdenado[j] = arregloOrdenado[j + 1];
            arregloOrdenado[j + 1] = temporal;
        }
    }
}` 

📌 Compara elementos adyacentes e intercambia si están en orden incorrecto.

**Ejemplo de salida:**

`Arreglo  desordenado: [8, 3, 5, 1, 9]  Arreglo  ordenado: [1, 3, 5, 8, 9]` 

----------

## 🔹 10. Matriz bidimensional

**Cómo funciona:**  
Se declara una matriz `3x3`, se muestra y se calculan las sumas de filas y columnas.

`int[,] matriz = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};` 

-   **Mostrar matriz:** doble `for` anidado.
    
-   **Sumar filas:** recorrer columnas por cada fila.
    
-   **Sumar columnas:** recorrer filas por cada columna.
    

**Ejemplo de salida:**

`Matriz 3x3:  1  2  3  4  5  6  7  8  9  Suma de filas:  Fila 1:  6  Fila 2:  15  Fila 3:  24  Suma de columnas:  Columna 1:  12  Columna 2:  15  Columna 3:  18`
