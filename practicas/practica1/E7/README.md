# Ejercicio 7 - Suma de 5 números en C#

Este programa solicita al usuario **5 números enteros** (uno por uno) y calcula su suma utilizando un bucle `for`.

## Código


using System;

class SumaCincoNumeros
{
    static void Main()
    {
        int total = 0;

        // Se piden 5 números al usuario
        for (int contador = 1; contador <= 5; contador++)
        {
            Console.Write($"Ingrese el número {contador}: ");
            string entrada = Console.ReadLine();
            
            if (int.TryParse(entrada, out int numero))
            {
                total += numero; // se acumula el valor ingresado
            }
            else
            {
                Console.WriteLine("Entrada inválida, se tomará como 0.");
            }
        }

        Console.WriteLine($"La suma total de los 5 números es: {total}");
    }
}
Explicación
Se inicializa la variable total en 0.

Se utiliza un bucle for que va desde 1 hasta 5.

En cada iteración:

Se pide un número al usuario.

Se intenta convertir con int.TryParse.

Si es válido, se suma a total. Si no, se cuenta como 0 y se muestra un aviso.

Al final, se muestra la suma de los 5 números.

Ejemplo de ejecución
yaml
Copiar código
Ingrese el número 1: 10
Ingrese el número 2: 5
Ingrese el número 3: abc
Entrada inválida, se tomará como 0.
Ingrese el número 4: 20
Ingrese el número 5: 15
La suma total de los 5 números es: 50