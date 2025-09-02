#  Ejercicio 3 – Tabla de multiplicar en C#

Este programa en C# solicita al usuario un número y muestra en pantalla su **tabla de multiplicar del 1 al 10** utilizando un **bucle `for`**.

---

## Código fuente

```
using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
        }
    }
}
```
### Explicación paso a paso
1. **Entrada del usuario**

Console.Write("Ingresa un número: ")   
int num = int.Parse(Console.ReadLine());


**Se pide un número desde la consola.**

- Console.ReadLine() captura lo escrito.

- int.Parse(...) lo convierte en un número entero.

2. **Bucle for**

for (int i = 1; i <= 10; i++)

{

    Console.WriteLine(num + " x " + i + " = " + (num * i));
}


- int i = 1; → el contador empieza en 1.

- i <= 10; → el bucle se repite hasta que i llegue a 10.

- i++ → incrementa el contador en 1 en cada vuelta.

- Console.WriteLine(...) → imprime cada multiplicación.

3. **Salida del resultado**

Si el usuario escribe 5, el programa mostrará:
```
5 x 1 = 5
5 x 2 = 10
5 x 3 = 15
5 x 4 = 20
5 x 5 = 25
5 x 6 = 30
5 x 7 = 35
5 x 8 = 40
5 x 9 = 45
5 x 10 = 50
