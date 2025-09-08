# 📘 Ejercicio 7 - Suma de 5 números en C#

## 🎯 Objetivo
- Practicar el uso del bucle `for` en C#.  
- Solicitar varios números al usuario.  
- Acumular su suma en una variable.  

---

## 📜 Descripción
Este programa solicita al usuario que ingrese **5 números** uno por uno.  
Cada número se va sumando en una variable acumuladora (`suma`).  
Al final, el programa muestra el resultado de la suma total en consola.  

---

## 🧩 Explicación del Código

```csharp
using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0; // Variable acumuladora de la suma
            
            // Bucle que se repite 5 veces
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ingresa número " + i + ": ");
                suma += int.Parse(Console.ReadLine()); // Se suma el número ingresado
            }

            // Mostrar la suma total
            Console.WriteLine("Suma total: " + suma);
        }
    }
}
🔎 Paso a paso:
Se inicializa suma = 0.

Se usa un bucle for que va de i = 1 hasta i = 5.

En cada iteración:

Se pide al usuario que ingrese un número.

El número se convierte a entero con int.Parse.

Se suma a la variable acumuladora suma.

Al finalizar el bucle, se imprime la suma total en consola.

🖥️ Ejemplo de Ejecución
yaml
Copiar código
Ingresa número 1: 5
Ingresa número 2: 7
Ingresa número 3: 3
Ingresa número 4: 10
Ingresa número 5: 15
Suma total: 40