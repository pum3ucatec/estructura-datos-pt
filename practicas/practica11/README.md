#  Práctica de Recursividad en C#

En esta práctica se presentan 10 ejercicios clásicos resueltos mediante **recursión** en C#.  
Cada código solicita al usuario los valores a procesar y muestra el resultado en consola.

```csharp
1. Factorial de un número

**Descripción:**  
Calcula el factorial de un número entero positivo usando recursión.

static int Factorial(int n)
{
    if (n <= 1) return 1;
    return n * Factorial(n - 1);
}
Funcionamiento:

Se solicita al usuario un número n.

La función Factorial calcula n! recursivamente.

Se imprime el resultado en consola.

Ejemplo de salida:

Ingrese un número: 5
El factorial de 5 es: 120
```

```csharp
2. Suma de los primeros N números
Descripción:
Calcula la suma de los primeros n números naturales usando recursión.

static int Suma(int n)
{
    if (n <= 0) return 0;
    return n + Suma(n - 1);
}
Funcionamiento:

La función suma n al resultado de Suma(n-1) hasta llegar a 0.

El usuario ingresa el valor de n.

Ejemplo de salida:

Ingrese un número: 5
La suma de los primeros 5 números es: 15
```

```csharp

3. Secuencia de Fibonacci
Descripción:
Muestra los primeros n números de la secuencia de Fibonacci, separados por ->.

static int Fibonacci(int n)
{
    if (n <= 1) return n;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

static void FibonacciSecuencia(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(Fibonacci(i));
        if (i < n - 1) Console.Write(" -> ");
    }
    Console.WriteLine();
}
Funcionamiento:

La función Fibonacci calcula cada término recursivamente.

La función FibonacciSecuencia imprime los primeros n números con separador ->.

Ejemplo de salida:

Ingrese la cantidad de números: 5
0 -> 1 -> 1 -> 2 -> 3
```

```csharp

4. Potencia de un número
Descripción:
Calcula base^exponente de manera recursiva.


static int Potencia(int baseNum, int exp)
{
    if (exp == 0) return 1;
    return baseNum * Potencia(baseNum, exp - 1);
}
Funcionamiento:

Multiplica la base por el resultado de Potencia(baseNum, exp-1) hasta llegar a 0.

El usuario ingresa base y exponente.

Ejemplo de salida:

Ingrese la base: 2
Ingrese el exponente: 4
Resultado: 16

```

```csharp
5. Invertir una cadena
Descripción:
Invierte una cadena de texto usando recursión.

static string InvertirCadena(string s)
{
    if (s.Length <= 1) return s;
    return InvertirCadena(s.Substring(1)) + s[0];
}
Funcionamiento:

Toma la primera letra y la mueve al final recursivamente.

El usuario ingresa la cadena.

Ejemplo de salida:

Ingrese la cadena: hola
Cadena invertida: aloh

```

```csharp
6. Contar dígitos de un número
Descripción:
Cuenta la cantidad de dígitos de un número entero positivo recursivamente.

static int ContarDigitos(int n)
{
    if (n == 0) return 0;
    return 1 + ContarDigitos(n / 10);
}
Funcionamiento:

Divide el número entre 10 hasta llegar a 0, sumando 1 en cada llamada.

El usuario ingresa el número.

Ejemplo de salida:


Ingrese un número: 12345
Cantidad de dígitos: 5

```

```csharp
7. Máximo Común Divisor (MCD)
Descripción:
Calcula el MCD de dos números usando el algoritmo de Euclides recursivo.
static int MCD(int a, int b)
{
    if (b == 0) return a;
    return MCD(b, a % b);
}
Funcionamiento:

Se llama recursivamente hasta que el segundo número sea 0.

El usuario ingresa dos números.

Ejemplo de salida:

Ingrese el primer número: 12
Ingrese el segundo número: 18
El MCD es: 6

```

```csharp
8. Suma de un arreglo
Descripción:
Calcula la suma de todos los elementos de un arreglo recursivamente.
static int SumaArreglo(int[] arr, int n)
{
    if (n <= 0) return 0;
    return arr[n - 1] + SumaArreglo(arr, n - 1);
}
Funcionamiento:

Se suma el último elemento con la suma del resto del arreglo recursivamente.

El usuario ingresa la cantidad de elementos y los valores.

Ejemplo de salida:

Ingrese la cantidad de elementos: 3
Ingrese el elemento 1: 2
Ingrese el elemento 2: 3
Ingrese el elemento 3: 4
La suma del arreglo es: 9

```

```csharp
9. Buscar un elemento en un arreglo
Descripción:
Determina si un número existe en un arreglo de manera recursiva.

static bool BuscarElemento(int[] arr, int n, int valor)
{
    if (n <= 0) return false;
    if (arr[n - 1] == valor) return true;
    return BuscarElemento(arr, n - 1, valor);
}
Funcionamiento:

Compara el último elemento con el valor a buscar.

El usuario ingresa la cantidad de elementos, los valores y el número a buscar.

Ejemplo de salida:

Ingrese la cantidad de elementos: 3
Ingrese elemento 1: 2
Ingrese elemento 2: 3
Ingrese elemento 3: 4
Ingrese el número a buscar: 3
Número encontrado en el arreglo

```

```csharp
10. Convertir un número decimal a binario
Descripción:
Convierte un número decimal en su representación binaria recursivamente.

static string DecimalABinario(int n)
{
    if (n == 0) return "0";
    if (n == 1) return "1";
    return DecimalABinario(n / 2) + (n % 2);
}
Funcionamiento:

Divide el número entre 2 recursivamente y concatena el residuo al resultado.

El usuario ingresa el número decimal.

Ejemplo de salida:

Ingrese un número decimal: 10
Número en binario: 101
```
