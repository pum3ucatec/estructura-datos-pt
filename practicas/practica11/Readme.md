# README – Ejercicios de Recursividad en C#

En este proyecto trabajamos 10 problemas clásicos.
Primero se resolvieron con iteración (bucles for o while) y luego se reescribieron en recursividad (la función se llama a sí misma).

La recursividad es una forma más natural de resolver algunos problemas porque divide la tarea en subproblemas más pequeños, aunque puede ser menos eficiente que la versión iterativa.

## 1. Factorial de un número

Pregunta:
Implementar una función que calcule el factorial de un número n.

### Versión Iterativa
```
public static int FactorialIterativo(int n)
{
    int resultado = 1;
    for (int i = 1; i <= n; i++)
        resultado *= i;
    return resultado;
}
```

### Versión Recursiva
```
public static BigInteger FactorialRecursivo(BigInteger n)
{
    if (n <= 1) return 1;
    return n * FactorialRecursivo(n - 1);
}
```
- Iterativo: usa un for para multiplicar números.

- Recursivo: usa la definición matemática n! = n * (n-1)!.

-  Ventaja de lo recursivo:
Refleja directamente la definición matemática y el código queda más corto y fácil de entender.


## 2. Suma de los primeros N números

### Iterativo
Pregunta:
Calcular la suma de los primeros n números naturales.
```
public static int SumaIterativa(int n)
{
    int suma = 0;
    for (int i = 1; i <= n; i++)
        suma += i;
    return suma;
}
```
### Recursivo
```
public static long SumaRecursiva(long n)
{
    if (n == 0) return 0;
    return n + SumaRecursiva(n - 1);
}
```
- Iterativo: usa un for acumulando la suma.

- Recursivo: descompone la suma como n + (n-1) + ....

-  Ventaja de lo recursivo:
Expresa mejor la idea de “descomponer el problema en partes más pequeñas”.


## 3. Fibonacci
Pregunta:
Calcular el término n de la secuencia de Fibonacci.
### Iterativo
```
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

### Recursivo
```
public static long FibonacciRecursivo(long n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
}
```
- Iterativo: usa variables y un bucle for.

- Recursivo: sigue la definición F(n) = F(n-1) + F(n-2).

-  Ventaja de lo recursivo:
El código refleja exactamente la definición de Fibonacci. 

## 4. Potencia
Pregunta:
Calcular base^exponente (base elevado al exponente).
### Iterativo
```
public static int PotenciaIterativa(int baseNum, int exp)
{
    int resultado = 1;
    for (int i = 1; i <= exp; i++)
        resultado *= baseNum;
    return resultado;
}
```

### Recursivo
```
public static long PotenciaRecursiva(long baseNum, long exp)
{
    if (exp == 0) return 1;
    return baseNum * PotenciaRecursiva(baseNum, exp - 1);
}
```
- Iterativo: multiplica en un bucle.

- Recursivo: usa base^exp = base * base^(exp-1).

- Ventaja de lo recursivo:
Explica mejor el concepto matemático de potencia y hace el código más claro.

## 5. Invertir cadena
Pregunta:
Invertir una cadena de texto.
### Iterativo
```
public static string InvertirCadenaIterativa(string cadena)
{
    char[] array = cadena.ToCharArray();
    Array.Reverse(array);
    return new string(array);
}
```

### Recursivo
```
public static string InvertirCadenaRecursiva(string cadena)
{
    if (cadena.Length <= 1) return cadena;
    return InvertirCadenaRecursiva(cadena.Substring(1)) + cadena[0];
}
```

- Iterativo: convierte a arreglo y usa Array.Reverse().

- Recursivo: mueve el primer carácter al final y repite con el resto.

-  Ventaja de lo recursivo:
Permite invertir sin depender de funciones auxiliares como Array.Reverse.

## 6. Contar dígitos
Pregunta:
Contar la cantidad de dígitos que tiene un número entero positivo.
### Iterativo
```
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

### Recursivo
```
public static long ContarDigitosRecursivo(long n)
{
    if (n == 0) return 0;
    return 1 + ContarDigitosRecursivo(n / 10);
}
```

- Iterativo: divide entre 10 en un while.

- Recursivo: cuenta 1 y llama con n/10.

-  Ventaja de lo recursivo:
El problema se entiende como “saco un dígito y cuento el resto”.

## 7. Máximo Común Divisor (MCD)
Pregunta:
Calcular el máximo común divisor (MCD) de dos números.
### Iterativo
```
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

### Recursivo
```
public static long MCDRecursivo(long a, long b)
{
    if (b == 0) return a;
    return MCDRecursivo(b, a % b);
}
```
- Iterativo: usa un bucle con el algoritmo de Euclides.

- Recursivo: aplica directamente la fórmula MCD(a,b) = MCD(b, a mod b).

- Ventaja de lo recursivo:
El código es más corto y refleja mejor el algoritmo original de Euclides.

## 8. Suma de un arreglo
Pregunta:
Calcular la suma de todos los elementos de un arreglo.
### Iterativo
```
public static int SumaArregloIterativa(int[] arr)
{
    int suma = 0;
    foreach (int num in arr)
        suma += num;
    return suma;
}
```

### Recursivo
```
public static long SumaArregloRecursiva(long[] arr, int i)
{
    if (i < 0) return 0;
    return arr[i] + SumaArregloRecursiva(arr, i - 1);
}
```

- Iterativo: usa foreach para recorrer y acumular.

- Recursivo: suma el último elemento + la suma del resto.

- Ventaja de lo recursivo:
El arreglo se divide naturalmente en partes más pequeñas.

## 9. Buscar en un arreglo
Pregunta:
Determinar si un número existe en un arreglo.
### Iterativo
```
public static bool BuscarElementoIterativo(int[] arr, int valor)
{
    foreach (int num in arr)
        if (num == valor)
            return true;
    return false;
}
```

### Recursivo
```
public static bool BuscarElementoRecursivo(long[] arr, int i, long valor)
{
    if (i < 0) return false;
    if (arr[i] == valor) return true;
    return BuscarElementoRecursivo(arr, i - 1, valor);
}
```

- Iterativo: recorre con foreach.

- Recursivo: revisa el último elemento y llama con el resto.

- Ventaja de lo recursivo:
Permite expresar la búsqueda como una condición más simple:
“¿Está en la última posición o en el resto?”.

## 10. Decimal a binario
Pregunta:
Convertir un número decimal en su representación binaria.
### Iterativo
```
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

### Recursivo
```
public static string DecimalABinarioRecursivo(long n)
{
    if (n == 0) return "0";
    if (n == 1) return "1";
    return DecimalABinarioRecursivo(n / 2) + (n % 2);
}
```
- Iterativo: usa un while para dividir entre 2.

- Recursivo: llama con n/2 y concatena el resto (n%2).

- Ventaja de lo recursivo:
El número se descompone paso a paso hasta llegar al caso base.
Se parece mucho a cómo lo hacemos manualmente.