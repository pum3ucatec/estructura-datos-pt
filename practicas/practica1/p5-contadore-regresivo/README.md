# 📘 Ejercicio 5 - Contador regresivo con `while` en C#

## 🎯 Objetivo
- Comprender el uso de la estructura repetitiva `while` en C#.  
- Implementar un programa que realice un **conteo regresivo** desde un número inicial hasta 0.  
- Practicar la lógica de decremento en bucles.  

---

## 📜 Descripción
El programa comienza con el número `30` y utiliza un bucle `while` para **restar uno en cada iteración** hasta llegar a 0.  
En cada ciclo, el valor actual de la variable se muestra en consola.

---

## 🧩 Explicación del Código

```csharp
using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 30; // Se inicializa el contador en 30
            
            // El bucle se ejecuta mientras c sea mayor que 0
            while (c > 0)
            {
                Console.WriteLine(c); // Muestra el valor actual de c
                c--; // Decrementa el contador en 1
            }
        }
    }
}
🔎 Paso a paso:
Se declara la variable c con el valor inicial 30.

La condición del bucle while (c > 0) asegura que se repita mientras c sea mayor a 0.

Dentro del bucle:

Se imprime el valor actual de c.

Se reduce el valor de c en 1 (c--).

El ciclo finaliza cuando c llega a 0.

🖥️ Ejemplo de Ejecución
python-repl
Copiar código
30
29
28
...
3
2
1