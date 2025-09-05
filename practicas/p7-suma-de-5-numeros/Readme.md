#  Ejercicio 7 – Suma de 5 números con `for`

Este programa en C# solicita al usuario **5 números** y calcula la **suma total** utilizando un **bucle `for`**.

---

##  Código fuente

```
using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ingresa número " + i + ": ");
                suma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Suma total: " + suma);
        }
    }
}
```
## Explicación paso a paso
1. **Inicialización de la variable acumuladora**
```
int suma = 0;
```

- suma almacenará la suma total de los números ingresados.

2. **Bucle for**
```
for (int i = 1; i <= 5; i++)
{
    Console.Write("Ingresa número " + i + ": ");
    suma += int.Parse(Console.ReadLine());
}
```

- int i = 1; → el contador empieza en 1.

- i <= 5; → el ciclo se repite 5 veces.

- i++ → incrementa el contador en 1 en cada vuelta.

**Dentro del bucle:**

- Se pide al usuario un número con Console.Write.
- Se convierte a entero con int.Parse.

- Se suma al acumulador suma usando suma += ....

3. **Mostrar el resultado**
```
Console.WriteLine("Suma total: " + suma);
```

Al finalizar el bucle, se imprime la suma de los 5 números.