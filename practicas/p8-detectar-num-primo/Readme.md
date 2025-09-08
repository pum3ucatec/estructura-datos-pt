# Ejercicio 8 – Verificar si un número es primo en C#

Este programa en C# solicita un número entero y determina si es **primo** o **no primo**.  
Un número **primo** es aquel que solo es divisible entre **1** y **sí mismo** (ejemplo: 2, 3, 5, 7, 11…).

---

## Código fuente

```
using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());
            bool esPrimo = true;

            if (numero < 2)
            {
                esPrimo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }

            if (esPrimo)
                Console.WriteLine("Es primo");
            else
                Console.WriteLine("No es primo");
        }
    }
}
```
## Explicación paso a paso
1. **Entrada del número**
```
Console.Write("Ingresa un número: ");
int numero = int.Parse(Console.ReadLine());
```

- Se pide al usuario que ingrese un número.

- int.Parse(...) convierte el valor ingresado en entero.

2. **Inicialización de la variable de control**
```
bool esPrimo = true;
```
- Se asume que el número es primo hasta comprobar lo contrario.

3. **Condición inicial**
```
if (numero < 2)
{
    esPrimo = false;
}
```

- Los números menores que 2 no son primos (ejemplo: 0, 1, -5).

4. **Bucle for para verificar divisores**
```
for (int i = 2; i <= Math.Sqrt(numero); i++)
{
    if (numero % i == 0)
    {
        esPrimo = false;
        break;
    }
}
```

- El bucle recorre desde i = 2 hasta la raíz cuadrada del número (Math.Sqrt(numero)).

- Si encuentra un divisor exacto (numero % i == 0), el número no es primo y el bucle se detiene con break.

- Usar la raíz cuadrada optimiza el algoritmo, evitando comprobaciones innecesarias.

5. **Resultado final**
```
if (esPrimo)
    Console.WriteLine("Es primo");
else
    Console.WriteLine("No es primo");
```

- Si no se encontró ningún divisor, el número es primo.

- De lo contrario, no lo es.