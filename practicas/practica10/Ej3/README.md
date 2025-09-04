# PRACTICA 10: Secuencia de Fibonacci en C#

## Integrantes
- Adrien Liev Condarco Gonzales
- Alan Ponce de Leon Terrazas

## Descripción
Este proyecto implementa un método para calcular el **término n de la secuencia de Fibonacci** utilizando **recursividad** en C#.  
La secuencia de Fibonacci se define como:

- `F(0) = 0`  
- `F(1) = 1`  
- `F(n) = F(n-1) + F(n-2)` para `n > 1`

---

## Funcionamiento del código
El método `FibonacciRecursivo` utiliza llamadas recursivas para obtener el valor de la posición `n`:

```csharp
public static int FibonacciRecursivo(int n)
{
    if (n == 0) return 0;   // caso base
    if (n == 1) return 1;   // caso base
    return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
}
```

- Casos base:

Si n = 0, devuelve 0.

Si n = 1, devuelve 1.

- Caso recursivo:

Para cualquier n > 1, devuelve la suma de los dos términos anteriores:

``F(n) = F(n-1) + F(n-2).``

En el método Main, se prueba la función con el valor n = 6:

``Console.WriteLine(FibonacciRecursivo(6));  // Salida: 8``

### Ejemplo de ejecución

Al ejecutar el programa, la salida en consola será:

8

Esto corresponde al término F(6) de la secuencia de Fibonacci:

```
F(0) = 0
F(1) = 1
F(2) = 1
F(3) = 2
F(4) = 3
F(5) = 5
F(6) = 8
```