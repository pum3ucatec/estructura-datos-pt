#  Ejercicio 4 – Menú interactivo en C#

Este programa en C# implementa un **menú interactivo** que permite al usuario elegir entre distintas opciones:  
1. Mostrar un saludo.  
2. Sumar dos números.  
3. Salir del programa.  

Se utiliza un **bucle `do-while`** para repetir el menú hasta que el usuario decida salir, junto con una **estructura `switch`** para manejar las opciones.

---

##  Código fuente

```
using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Sumar 2 números");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("¡Hola espero andes muy bien!");
                        break;
                    case 2:
                        Console.Write("Número 1: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Número 2: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Suma: " + (a + b));
                        break;
                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (opcion != 3);
        }
    }
}

```
## Explicación paso a paso
1. **Menú dentro de un do-while**

do
{
   
   // Mostrar menú y leer opción

}   while (opcion != 3);


- El menú se repite al menos una vez.

- El ciclo continúa hasta que el usuario elija la opción 3 (Salir).

2. **Lectura de la opción**

opcion = int.Parse(Console.ReadLine());

- El usuario escribe un número.

- int.Parse(...) lo convierte a entero para usarlo en el switch.

3. **Estructura switch
switch (opcion)**
```
{
    case 1:
        Console.WriteLine("¡Hola espero andes muy bien!");
        break;
    case 2:
        // Pedir dos números y sumarlos
        break;
    case 3:
        Console.WriteLine("Saliendo...");
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}
```

- case 1: → Muestra un saludo.

- case 2: → Pide dos números y los suma.

- case 3: → Finaliza el programa.

- default: → Muestra un mensaje si la opción es inválida.
