**Indice**

- [Ejercicios de Recursividad en C#](#ejercicios-de-recursividad-en-c)
	- [Cómo ejecutar los ejercicios](#cómo-ejecutar-los-ejercicios)
		- [1. Factorial de un número](#1-factorial-de-un-número)
		- [2. Suma de los primeros N números](#2-suma-de-los-primeros-n-números)
		- [3. Secuencia de Fibonacci](#3-secuencia-de-fibonacci)
		- [4. Potencia de un número](#4-potencia-de-un-número)
		- [5. Invertir una cadena](#5-invertir-una-cadena)
		- [6. Contar dígitos de un número](#6-contar-dígitos-de-un-número)
		- [7. Máximo Común Divisor (MCD)](#7-máximo-común-divisor-mcd)
		- [8. Suma de un arreglo](#8-suma-de-un-arreglo)
		- [9. Buscar un elemento en un arreglo](#9-buscar-un-elemento-en-un-arreglo)
		- [10. Convertir un número decimal a binario](#10-convertir-un-número-decimal-a-binario)

# Ejercicios de Recursividad en C#

Este repositorio contiene **10 ejercicios clásicos de programación** que normalmente se resuelven con **recursividad**.  

- En la práctica anterior se resolvieron con **iteraciones (bucles)**.  
- En esta nueva práctica, cada problema se resolvió con su **versión recursiva**.  

Cada programa se ejecuta desde consola, pide valores al usuario y muestra el resultado.  


## Cómo ejecutar los ejercicios

1. Asegúrate de tener instalado **.NET SDK** en tu computadora.  
	
Ejecuta con:

```bash
dotnet run
```

### 1. Factorial de un número

**Pregunta:**  
Implementar una función que calcule el factorial de un número `n`.

- **Iterativo:** se usaba un bucle for multiplicando del 1 al n.

```csharp
public static int FactorialIterativo(int n)
{
    int resultado = 1;
    for (int i = 1; i <= n; i++)
    {
        resultado *= i;
    }
    return resultado;
}
```

- **Recursivo:** La función se llama a sí misma con `n-1` hasta llegar a `n=0`.  
Cada llamada acumula el producto: `n * Factorial(n-1)`.  
	- Caso base: `Factorial(0) = 1`. 
```csharp
public static int factorial(int n)
{
    if (n == 0 || n == 1) 
        return 1;
    return n * factorial(n - 1);
}
```


### 2. Suma de los primeros N números

**Pregunta:**  
Calcular la suma de los primeros `n` números naturales.

- **Iterativo:** sumaba en un bucle for.
```csharp
public static int SumaIterativa(int n)
{
    int suma = 0;
    for (int i = 1; i <= n; i++)
    {
        suma += i;
    }
    return suma;
}
```

- **Recursivo:** La suma se calcula como `n + Suma(n-1)`.  
En cada llamada se reduce el valor de `n` hasta llegar a `0`.  
	- Caso base: `Suma(0) = 0`.  
```csharp

public static int suma(int n)
{
	if (n == 0)
		return 0;
	return n + suma(n - 1);
}
```


### 3. Secuencia de Fibonacci

**Pregunta:**  
Calcular el término `n` de la secuencia de Fibonacci.

- **Iterativo:** se usaban dos variables acumuladoras (a y b).
  
```csharp
public static int FibonacciIterativo(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;

    int a = 0, b = 1, temp;

    for (int i = 2; i <= n; i++)
    {
        temp = a + b;
        a = b;
        b = temp;
    }
    return b;
}
```

- **Recursivo:** Se define con dos casos base:  
  - `F(0) = 0`, `F(1) = 1`.  
Para `n > 1`, se calcula como `F(n-1) + F(n-2)`.  
Cada llamada genera dos subproblemas más pequeños.

```csharp
public static int fibonacci(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return fibonacci(n - 1) + fibonacci(n - 2);
}
```


### 4. Potencia de un número

**Pregunta:**  
Calcular `base^exponente` (base elevado al exponente).

- **Iterativo:** multiplicaba la base exp veces.

```csharp
public static int PotenciaIterativa(int baseNum, int exp)
{
    int resultado = 1;
    for (int i = 1; i <= exp; i++)
    {
        resultado *= baseNum;
    }
    return resultado;
}
```

- **Recursivo:** La potencia `b^exp` se resuelve multiplicando la base por el resultado de `Potencia(b, exp-1)`.  
	- Caso base: cualquier número elevado a 0 es `1`.

```csharp
public static int potencia(int baseNum, int exp)
{
    if (exp == 0) return 1;
    return baseNum * potencia(baseNum, exp - 1);
}
```


### 5. Invertir una cadena

**Pregunta:**  
Invertir una cadena de texto.

- **Iterativo:** se convertía en un char[] y se usaba Array.Reverse.

```csharp
public static string InvertirCadenaIterativa(string cadena)
{
    char[] array = cadena.ToCharArray();
    Array.Reverse(array);
    return new string(array);
}
```
- **Recursivo:** La cadena se invierte tomando el primer carácter y llamando a la función con el resto de la cadena.  
Luego, ese carácter se agrega al final de la llamada recursiva.  
  - Caso base: una cadena vacía o de un solo carácter ya está invertida. 
  
```csharp
public static string Invertir(string cadena)
{
    if (cadena.Length <= 1) 
        return cadena;
    return Invertir(cadena.Substring(1)) + cadena[0];
}
```


### 6. Contar dígitos de un número

**Pregunta:**  
Contar la cantidad de dígitos que tiene un número entero positivo.

- **Iterativo:** se dividía entre 10 hasta que fuera 0.

```csharp
public static int ContarDigitosIterativo(int n)
{
    int contador = 0;
    while (n > 0)
    {
        contador++;
        n /= 10;
    }
    return contador;
}
```

- **Recursivo:** Se divide el número entre 10 en cada llamada, sumando 1 al contador.  
	- Caso base: cuando el número es menor a 10, solo queda un dígito.

```csharp
public static int contar_digitos(int n)
{
    if (n < 10) 
        return 1;
    return 1 + contar_digitos(n / 10);
    }
```


### 7. Máximo Común Divisor (MCD)

**Pregunta:**  
Calcular el máximo común divisor (MCD) de dos números.

- **Iterativo:** se aplicaba el algoritmo de Euclides en un bucle while.

```csharp
public static int MCDIterativo(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}
```

- **Recursivo:** Usa el algoritmo de Euclides: `MCD(a,b) = MCD(b, a % b)`.  
	- Caso base: cuando `b = 0`, el resultado es `a`.
  
```csharp
public static int mcd(int a, int b)
{
    if (b == 0)
        return a;
    return mcd(b, a % b);
}
```


### 8. Suma de un arreglo

**Pregunta:**  
Calcular la suma de todos los elementos de un arreglo.

- **Iterativo:** se recorría con foreach.

```csharp
public static int SumaArregloIterativa(int[] arr)
{
    int suma = 0;
    foreach (int num in arr)
    {
        suma += num;
    }
    return suma;
}
```

- **Recursivo:** Se suma el último elemento con la suma de los `n-1` elementos anteriores.  
	- Caso base: si el arreglo está vacío (`n=0`), devuelve 0.  
  
```csharp
public static int suma_arreglo(int[] arr, int n)
{
	if (n == 0) 
        return 0;
    return arr[n - 1] + suma_arreglo(arr, n - 1);
}
```


### 9. Buscar un elemento en un arreglo

**Pregunta:**  
Determinar si un número existe en un arreglo.

**Iterativo:** se recorría con foreach comparando cada elemento.

```csharp
public static bool BuscarElementoIterativo(int[] arr, int valor)
{
    foreach (int num in arr)
    {
        if (num == valor)
            return true;
    }
    return false;
}
```

**Recursivo:** Compara el último elemento con el valor buscado.  
- Si coincide, devuelve `true`.  
- Si no, se llama recursivamente con los elementos restantes.  
	- Caso base: si no quedan elementos, devuelve `false`.

```csharp
public static bool buscar_elemento(int[] arr, int n, int valor)
{
    if (n == 0) 
        return false;
    if (arr[n - 1] == valor) 
	    return true;
    return buscar_elemento(arr, n - 1, valor);
    }
```

### 10. Convertir un número decimal a binario

**Pregunta:**  
Convertir un número decimal en su representación binaria.

- **Iterativo:** se dividía entre 2 y se almacenaban los restos en un string.

```csharp
public static string DecimalABinarioIterativo(int n)
{
    string binario = "";
    while (n > 0)
    {
        binario = (n % 2) + binario;
        n /= 2;
    }
    return binario;
}
```

- **Recursivo:** Divide el número entre 2 y llama recursivamente al cociente.  
Luego concatena el resto (`n % 2`) al final de la cadena generada.  
	- Caso base: cuando el número es 0, devuelve una cadena vacía. 

```csharp
public static string decimal_binario(int n)
{
    if (n == 0) return "";
    return decimal_binario(n / 2) + (n % 2);
}
```
