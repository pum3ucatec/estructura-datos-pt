**INDICE**
- [1. 10 Ejercicios de Arreglos en C#](#1-10-ejercicios-de-arreglos-en-c)
	- [1.1. Ejercicio 1 (Arreglo con 5 enteros).](#11-ejercicio-1-arreglo-con-5-enteros)
	- [1.2. Ejercicio 2 (Recorrido con for).](#12-ejercicio-2-recorrido-con-for)
	- [1.3. Ejercicico 3 (Suma de elementos).](#13-ejercicico-3-suma-de-elementos)
	- [1.4. Ejercicio 4 (Promedio de elementos)](#14-ejercicio-4-promedio-de-elementos)
	- [1.5. Ejercicio 5 (Mayor y menor valor).](#15-ejercicio-5-mayor-y-menor-valor)
	- [1.6. Ejercicio 6 (Búsqueda lineal)](#16-ejercicio-6-búsqueda-lineal)
	- [1.7. Ejercicio 7 (Contar ocurrencias).](#17-ejercicio-7-contar-ocurrencias)
	- [1.8. Ejercicio 8 (Invertir arreglo).](#18-ejercicio-8-invertir-arreglo)
	- [1.9. Ejercicio 9 (Ordenamiento (Burbuja)).](#19-ejercicio-9-ordenamiento-burbuja)
	- [1.10. Arreglo bidimensional (Matriz)](#110-arreglo-bidimensional-matriz)



# 1. 10 Ejercicios de Arreglos en C#

Esta practica contiene **10 ejercicios prácticos en C#** sobre el manejo de arreglos (unidimensionales y bidimensionales).

Cada ejercicio está explicado de manera simple e incluye un pequeño código de ejemplo.

- Para hacer correr o ejecutar los ejercicios en la terminal intregrada del VSCode se debe realizar el siguiente comando

**ojo:** Asegurate de estar en la carpeta/archivo correcto al hacerlo

```bash
dotnet run
```

**DETALLE:** Todos los ejercicios tiene el respectivo
```csharp
using System;

class EjercicioN
{
    static void Main()
    {
		// En los ejemplos solo se incluye la parte que resuelve el problema o la operacion, por eso no se incluye lo inicial y las llaves finales.
	}
}
```

---

## 1.1. Ejercicio 1 (Arreglo con 5 enteros).

**Descripción:**  
Declara un arreglo de 5 enteros y asígnales valores manualmente. Luego imprime todos los valores en pantalla.

**Código:**

```csharp
int[] nums = { 10, 20, 30, 40, 50 };

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
```

**Salida:**

`10`
`20`
`30`
`40` 
`50`  --> En una columna.

## 1.2. Ejercicio 2 (Recorrido con for).

**Descripción:**

Crea un arreglo de 10 números enteros y muéstralos en consola utilizando un ciclo for.

- **Punto clave:** Usar Length para recorrer el arreglo completo.

**Codigo:**

```csharp
int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
```
**Salida:**

`1` `2` `3` `4` `5` `6` `7` `8` `9` `10` --> En una columna

## 1.3. Ejercicico 3 (Suma de elementos).

**Descripción:**

Dado un arreglo de enteros, calcula la suma de todos sus elementos.

**Codigo:**

```csharp
int[] nums = { 5, 10, 15, 20 };
		int sum = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			sum += nums[i]; 
        }

		Console.WriteLine("Arreglo: [5, 10, 15, 20]");
		Console.WriteLine($"Suma: {sum}");
```

**Salida:**
`Suma: 50`

## 1.4. Ejercicio 4 (Promedio de elementos)

**Descripción:**

Ingresa 5 calificaciones en un arreglo y calcula el promedio.

**Codigo:**
```csharp
int[] notas = new int[5];
        int suma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            notas[i] = LeerEntero($"Ingresa la nota #{i + 1}: ");
            suma += notas[i];
        }

        double promedio = (double)suma / notas.Length;

        Console.WriteLine($"Notas: [{string.Join(", ", notas)}]");
        Console.WriteLine($"Promedio: {promedio}");
    }

    static int LeerEntero(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int valor))
                return valor;

            Console.WriteLine("Error, intenta de nuevo.");
        }
```
**Entrada Ejemplo:**
`Notas: 80, 70, 90, 60, 100`

**Salida:**
`Promedio: 80`

## 1.5. Ejercicio 5 (Mayor y menor valor).

**Descripción:**
Lee 8 números en un arreglo y muestra el mayor y el menor.

**Codigo:**

```csharp 
int[] nums = new int[8];
		
        for (int i = 0; i < nums.Length; i++)
			nums[i] = LeerEntero($"Ingresa el número #{i + 1}: ");

        int my = nums[0];
        int mn = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > my) my = nums[i];
            if (nums[i] < mn) mn = nums[i];
        }

        Console.WriteLine($"Números: [{string.Join(", ", nums)}]");
        Console.WriteLine($"Mayor: {my}");
        Console.WriteLine($"Menor: {mn}");
    }
    static int LeerEntero(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int valor))
                return valor;
            Console.WriteLine("Error, intenta de nuevo.");
        }
```
**Entrada Ejemplo:**
`Números: [12, 5, 8, 20, 3, 17, 25, 10]`

**Salida:**
`Mayor: 25`
`Menor: 3`

## 1.6. Ejercicio 6 (Búsqueda lineal)

**Descripción:**

Dado un arreglo de 10 números, pide un número al usuario y determina si está dentro del arreglo.
Si existe, imprime su posición.

**Codigo:**
```csharp
int[] datos = { 4, 9, 17, 23, 42, 17, 8, 12, 5, 33 };
        int buscado = LeerEntero("Ingrese un número a buscar: ");

        int indice = -1;
        for (int i = 0; i < datos.Length; i++)
        {
            if (datos[i] == buscado)
            {
                indice = i;
                break; 
            }
        }

        if (indice != -1)
            Console.WriteLine($"El número {buscado} se encuentra en el índice {indice} (posición {indice + 1}).");
        else
            Console.WriteLine($"El número {buscado} no está en el arreglo.");
    }

    static int LeerEntero(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int valor))
                return valor;
            Console.WriteLine("Error, intenta de nuevo.");
        }
```
**Entrada Ejemplo:**
`Ingrese un número: 17`

**Salida:**
`El número 17 se encuentra en la posición 4`

## 1.7. Ejercicio 7 (Contar ocurrencias).

**Descripción:**
Dado un arreglo, pide un número y cuenta cuántas veces aparece en él.

**Codigo:**
```csharp
int[] datos = { 2, 5, 2, 8, 2, 9 };
        int buscado = LeerEntero("Número a contar: ");

        int conteo = 0;
        for (int i = 0; i < datos.Length; i++)
            if (datos[i] == buscado) conteo++;

        Console.WriteLine($"Arreglo: [{string.Join(", ", datos)}]");
        Console.WriteLine($"Número buscado: {buscado}");
        Console.WriteLine($"El número aparece {conteo} {(conteo == 1 ? "vez" : "veces")}.");
    }

    static int LeerEntero(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int valor))
                return valor;
            Console.WriteLine("Error, intenta de nuevo.");
        }
```
Arreglo: [2, 5, 2, 8, 2, 9]

**Entrada:** Número buscado: `2`

**Salida:**
`El número aparece 3 veces`

## 1.8. Ejercicio 8 (Invertir arreglo).

**Descripción:**
Crea un segundo arreglo con los mismos elementos que el original pero en orden inverso.

**Codigo:**
```csharp
int[] original = { 1, 2, 3, 4, 5 };
        int[] invertido = new int[original.Length];

        for (int i = 0; i < original.Length; i++)
        {
            invertido[i] = original[original.Length - 1 - i];
        }

        Console.WriteLine($"Arreglo original:  [{string.Join(", ", original)}]");
        Console.WriteLine($"Arreglo invertido: [{string.Join(", ", invertido)}]");
    }
```

**Salida:**

`Arreglo original: [1, 2, 3, 4, 5]`

`Arreglo invertido: [5, 4, 3, 2, 1]`

## 1.9. Ejercicio 9 (Ordenamiento (Burbuja)).

**Descripción:**
Implementa el algoritmo de Burbuja para ordenar un arreglo de enteros de menor a mayor.

**Codigo:**
```csharp
int[] datos = { 8, 3, 5, 1, 9 };

        Console.WriteLine("Arreglo desordenado: [" + string.Join(", ", datos) + "]");

        for (int pasada = 0; pasada < datos.Length - 1; pasada++)
        {
            bool huboIntercambio = false;

            for (int i = 0; i < datos.Length - 1 - pasada; i++)
            {
                if (datos[i] > datos[i + 1])
                {
                    int aux = datos[i];
                    datos[i] = datos[i + 1];
                    datos[i + 1] = aux;
                    huboIntercambio = true;
                }
            }

            if (!huboIntercambio) break;
        }

        Console.WriteLine("Arreglo ordenado:   [" + string.Join(", ", datos) + "]");
    }
```

**Salida:**

`Arreglo desordenado: [8, 3, 5, 1, 9]`

`Arreglo ordenado:   [1, 3, 5, 8, 9]`

## 1.10. Arreglo bidimensional (Matriz)

**Descripción:**
Declara una matriz de 3x3, inicialízala y muestra la suma de cada fila y cada columna.

**Codigo:**
```csharp
int[,] matriz = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int filas = matriz.GetLength(0); 
        int columnas = matriz.GetLength(1);

        Console.WriteLine("Suma de filas:");
        for (int f = 0; f < filas; f++)
        {
            int sumaFila = 0;
            for (int c = 0; c < columnas; c++)
            {
                sumaFila += matriz[f, c];
            }
            Console.WriteLine($"Fila {f + 1}: {sumaFila}");
        }

        Console.WriteLine("\nSuma de columnas:");
        for (int c = 0; c < columnas; c++)
        {
            int sumaCol = 0;
            for (int f = 0; f < filas; f++)
            {
                sumaCol += matriz[f, c];
            }
            Console.WriteLine($"Columna {c + 1}: {sumaCol}");
        }
```

**Entrada Ejemplo:**
```text
Matriz:
[ 1 2 3 ]
[ 4 5 6 ]
[ 7 8 9 ]
```

**Salida:**

Suma de filas:

`Fila 1: 6`
`Fila 2: 15`
`Fila 3: 24`

Suma de columnas:

`Columna 1: 12`
`Columna 2: 15`
`Columna 3: 18`