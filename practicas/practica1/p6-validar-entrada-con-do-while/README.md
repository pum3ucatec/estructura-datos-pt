# 📘 Ejercicio 6 - Validar número positivo con `do...while` en C#

## 🎯 Objetivo
- Aprender el uso del bucle `do...while` en C#.  
- Repetir una acción hasta que el usuario ingrese un número positivo.  
- Validar datos de entrada para asegurar que cumplen una condición.  

---

## 📜 Descripción
Este programa solicita al usuario que ingrese un número positivo.  
Si el número ingresado es **menor o igual a 0**, el programa vuelve a pedir el dato.  
Cuando finalmente se introduce un número válido, se muestra el resultado en consola.  

---

## 🧩 Explicación del Código

```csharp
using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivo; // Variable para almacenar el número ingresado
            
            // El bucle se ejecuta al menos una vez
            do
            {
                Console.Write("Ingresa un número positivo: ");
                positivo = int.Parse(Console.ReadLine());
            } while (positivo <= 0); // Se repite mientras el número sea <= 0

            // Una vez que es válido, se imprime en consola
            Console.WriteLine("Número válido: " + positivo);
        }
    }
}
🔎 Paso a paso:
Se declara una variable entera positivo.

El bucle do...while se ejecuta al menos una vez, pidiendo un número al usuario.

Si el número es menor o igual a 0, la condición se cumple y el ciclo se repite.

Cuando el número es mayor que 0, el ciclo termina.

Finalmente, se imprime el número válido en consola.

.

🖥️ Ejemplo de Ejecución
Ingresa un número positivo: -3
Ingresa un número positivo: 0
Ingresa un número positivo: 7
Número válido: 7
