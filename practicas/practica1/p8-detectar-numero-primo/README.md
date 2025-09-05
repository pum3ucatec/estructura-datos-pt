# 📘 Ejercicio 8 - Verificar si un número es primo en C#

## 🎯 Objetivo
- Aprender a determinar si un número es **primo**.  
- Practicar el uso de ciclos y condiciones en C#.  
- Optimizar la verificación de primos con `Math.Sqrt`.  

---

## 📜 Descripción
El programa pide al usuario un número entero y verifica si es **primo** o no.  
Un número **primo** es aquel que **solo tiene dos divisores: 1 y él mismo**.  
Ejemplos de números primos: 2, 3, 5, 7, 11, 13...  

---

## 🧩 Explicación del Código

```csharp
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

            // Caso especial: menores que 2 no son primos
            if (numero < 2)
            {
                esPrimo = false;
            }
            else
            {
                // Se verifica solo hasta la raíz cuadrada de 'numero'
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break; // Si encuentra un divisor, ya no es primo
                    }
                }
            }

            // Mostrar resultado
            if (esPrimo)
                Console.WriteLine("Es primo");
            else
                Console.WriteLine("No es primo");
        }
    }
}
🔎 Paso a paso:
El usuario ingresa un número entero.

Se inicializa esPrimo = true.

Si el número es menor que 2, automáticamente no es primo.

Si es mayor o igual a 2:

Se recorre desde 2 hasta Math.Sqrt(numero).

Si encuentra un divisor (numero % i == 0), se marca como no primo.

Se usa break para salir del bucle al encontrar un divisor.

Finalmente, se imprime si el número es primo o no.

🖥️ Ejemplo de Ejecución
nginx
Copiar código
Ingresa un número: 7
Es primo
yaml
Copiar código
Ingresa un número: 12
No es primo
yaml
Copiar código
Ingresa un número: 1
No es primo