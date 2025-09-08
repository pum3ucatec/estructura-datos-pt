# Ejercicio 10 - Juego: Adivina el número en C#

Este programa es un **juego interactivo** donde el sistema genera un número aleatorio entre 1 y 50.  
El usuario debe adivinarlo, recibiendo pistas si el número es mayor o menor, usando un bucle `do-while`.

## Código

```csharp
using System;

class JuegoAdivinaNumero
{
    static void Main()
    {
        Random generador = new Random();
        int numeroSecreto = generador.Next(1, 51); // número aleatorio entre 1 y 50
        int intentoUsuario;
        int contadorIntentos = 0;

        Console.WriteLine(" ¡Bienvenido al juego de Adivina el Número!");

        do
        {
            Console.Write("Ingresa tu intento (1-50): ");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out intentoUsuario))
            {
                Console.WriteLine(" Entrada inválida. Por favor ingresa un número entero.");
                continue;
            }

            contadorIntentos++;

            if (intentoUsuario < numeroSecreto)
                Console.WriteLine("⬆ Más alto...");
            else if (intentoUsuario > numeroSecreto)
                Console.WriteLine("⬇ Más bajo...");
            else
                Console.WriteLine($" ¡Correcto! Adivinaste el número {numeroSecreto} en {contadorIntentos} intentos.");

        } while (intentoUsuario != numeroSecreto);
    }
}
Explicación
Se genera un número aleatorio entre 1 y 50 usando Random.Next.

Se inicia un bucle do-while para que el usuario intente adivinar el número.

Cada intento se valida con int.TryParse para evitar errores si no ingresa un número.

Se dan pistas:

Si el intento es menor, se indica "Más alto".

Si es mayor, se indica "Más bajo".

El juego termina cuando el usuario adivina el número, mostrando la cantidad de intentos realizados.

Ejemplo de ejecución
java
Copiar código
 ¡Bienvenido al juego de Adivina el Número!
Ingresa tu intento (1-50): 25
⬆ Más alto...
Ingresa tu intento (1-50): 40
⬇ Más bajo...
Ingresa tu intento (1-50): 32
 ¡Correcto! Adivinaste el número 32 en 3 intentos.