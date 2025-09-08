# Ejercicio 6 - Validar entrada con do-while en C#

Este programa solicita al usuario un **número positivo** y no permite continuar hasta que se introduzca correctamente.  
Se implementa un bucle `do-while` para repetir la solicitud de datos las veces que sea necesario.

## Código


using System;

class EntradaPositiva
{
    static void Main()
    {
        int valor;

        // Se repite hasta que el usuario escriba un número mayor a 0
        do
        {
            Console.Write("Por favor, ingrese un número entero positivo: ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out valor); // intenta convertir el texto en número
        } 
        while (valor <= 0);

        Console.WriteLine("Número aceptado: " + valor);
    }
}
Explicación
Se declara la variable valor para guardar el número ingresado.

Dentro del bucle do-while:

Se solicita un número desde consola.

Se usa int.TryParse para convertir el texto a número (más seguro que int.Parse, evita errores si el usuario escribe algo inválido).

El ciclo se repite mientras valor <= 0.

Cuando el usuario ingresa un número positivo, el programa finaliza mostrando un mensaje de confirmación.

Ejemplo de ejecución
yaml
Copiar código
Por favor, ingrese un número entero positivo: -3
Por favor, ingrese un número entero positivo: 0
Por favor, ingrese un número entero positivo: 12
 Número aceptado: 12