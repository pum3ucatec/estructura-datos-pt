**Indice**

- [Ejercicio 7: Máximo Común Divisor (MCD) - Recursividad](#ejercicio-7-máximo-común-divisor-mcd---recursividad)
	- [Enunciado](#enunciado)
	- [Solución Iterativa](#solución-iterativa)
	- [Explicación de la Solución Iterativa](#explicación-de-la-solución-iterativa)
	- [Solución Recursiva](#solución-recursiva)
	- [Explicación de la Solución Recursiva](#explicación-de-la-solución-recursiva)
	- [Comparación y Modificación](#comparación-y-modificación)


# Ejercicio 7: Máximo Común Divisor (MCD) - Recursividad

## Enunciado

**Pregunta:**  
Calcular el máximo común divisor (MCD) de dos números.

## Solución Iterativa

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

---

## Explicación de la Solución Iterativa

- Se utiliza el algoritmo de Euclides.
- Mientras `b` sea distinto de cero, se actualizan los valores de `a` y `b`:
  - `a` toma el valor de `b`.
  - `b` toma el valor de `a % b` (el resto de la división).
- Cuando `b` es cero, el valor de `a` es el MCD.

---

## Solución Recursiva

```csharp
using System;

class Program
{
    public static int MCD(int a, int b)
    {
        if (b == 0)
            return a;
        return MCD(b, a % b);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Calcular MCD (Recursivo) ===");

        Console.Write("Ingresa el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = MCD(num1, num2);

        Console.WriteLine($"El MCD de {num1} y {num2} es: {resultado}");
    }
}
```


## Explicación de la Solución Recursiva

- La función `MCD` se llama a sí misma con los parámetros `b` y `a % b`.
- El caso base es cuando `b` es cero; en ese momento, se retorna `a`.
- El proceso se repite hasta llegar al caso base, resolviendo el problema de manera recursiva.

---

## Comparación y Modificación

- **Iterativo:** Utiliza un bucle `while` para repetir el proceso.
- **Recursivo:** Elimina el bucle y utiliza llamadas recursivas.