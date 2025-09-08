# Ejercicio 8 - Detectar número primo en C#

Este programa solicita al usuario un número entero y determina si es **primo** o no utilizando un bucle `for`.

## Código

using System;

class NumeroPrimo
{
    static void Main()
    {
        Console.Write("Ingrese un número para comprobar si es primo: ");
        string entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int numero))
        {
            Console.WriteLine("❌ Entrada inválida. Debe ingresar un número entero.");
            return;
        }

        bool esPrimo = true;

        if (numero <= 1)
        {
            esPrimo = false;
        }
        else
        {
            // Solo es necesario verificar hasta la raíz cuadrada del número
            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }

        if (esPrimo)
            Console.WriteLine($"✔ {numero} es un número primo.");
        else
            Console.WriteLine($"✘ {numero} no es un número primo.");
    }
}
Explicación
El usuario ingresa un número entero.

Se valida la entrada con int.TryParse.

Un número no es primo si:

Es menor o igual a 1.

Tiene un divisor distinto de 1 y de sí mismo.

El bucle for recorre desde 2 hasta la raíz cuadrada del número (i * i <= numero).

Si encuentra un divisor, marca el número como no primo y se interrumpe el ciclo.

Se muestra el resultado en pantalla.

Ejemplo de ejecución
yaml
Copiar código
Ingrese un número para comprobar si es primo: 7
✔ 7 es un número primo.

Ingrese un número para comprobar si es primo: 9
✘ 9 no es un número primo.