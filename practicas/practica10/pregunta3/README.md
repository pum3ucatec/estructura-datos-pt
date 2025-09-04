# PRACTICA 10: Secuencia de Fibonacci en C#

## Integrantes
- Adrien Liev Condarco Gonzales
- Alan Ponce de Leon Terrazas

## Descripción
Este proyecto implementa un programa en C# que calcula e imprime la **secuencia de Fibonacci hasta n términos** utilizando **recursividad**.  
La secuencia de Fibonacci se define como:

- `F(0) = 0`  
- `F(1) = 1`  
- `F(n) = F(n-1) + F(n-2)` para `n > 1`

---

## Funcionamiento del código
El método `FibonacciRecursivo` utiliza llamadas recursivas para calcular el valor de cada término de la secuencia:

```csharp
public static int FibonacciRecursivo(int n)
{
    if (n == 0) return 0;   // caso base
    if (n == 1) return 1;   // caso base
    return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2); // recursión
}
```

- Casos base:

    - Si n = 0, devuelve 0.

    - Si n = 1, devuelve 1.

- Caso recursivo:

    - Para cualquier ``n > 1``, devuelve la suma de los dos términos anteriores:
``F(n) = F(n-1) + F(n-2)``

En el método ``Main``, se solicita al usuario la cantidad de términos y se muestra la secuencia completa:

```csharp
Console.Write("Ingresa la cantidad de términos de la secuencia: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"\nSecuencia de Fibonacci con {n} términos:");

for (int i = 0; i < n; i++)
{
    Console.Write(FibonacciRecursivo(i) + " ");
}
```

### Ejemplo de ejecución

- Entrada del usuario:

```
Ingresa la cantidad de términos de la secuencia: 7
```

- Salida en consola:

```
Secuencia de Fibonacci con 7 términos:
0 1 1 2 3 5 8
```

Esto corresponde a los primeros 7 términos de la secuencia de Fibonacci.
