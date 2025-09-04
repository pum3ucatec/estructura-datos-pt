# Práctica 10 - Pregunta 6: Contar Dígitos Recursivamente en C#

Este ejercicio muestra cómo contar la cantidad de dígitos de un número entero utilizando una función recursiva en C#.

---

## Índice

- [Práctica 10 - Pregunta 6: Contar Dígitos Recursivamente en C#](#práctica-10---pregunta-6-contar-dígitos-recursivamente-en-c)
  - [Índice](#índice)
  - [Descripción](#descripción)
  - [Ejemplo de uso](#ejemplo-de-uso)
  - [Código principal](#código-principal)

---

## Descripción

El programa define una función recursiva que recibe un número entero y retorna la cantidad de dígitos que contiene.  
La función se llama a sí misma dividiendo el número por 10 hasta que el número sea menor que 10 (caso base).

---

## Ejemplo de uso

Al ejecutar el programa, la salida será:

```
El número 12345 tiene 5 dígitos.
```

Se puede cambiar el valor de `numero` en el código para probar con otros números.

---

## Código principal

```csharp
class Program
{
    public static int ContarDigitosRecursivo(int n)
    {
        if (n < 10)
        {
            return 1;
        }
        return 1 + ContarDigitosRecursivo(n / 10);
    }
}
```
