#  Ejercicio 6 – Validación de número positivo con `do-while`

Este programa en C# solicita al usuario un número y **repite la petición hasta que el valor ingresado sea positivo**.  
Se utiliza un **bucle `do-while`**, ideal cuando necesitamos que el código se ejecute al menos una vez.

---

##  Código fuente

```
using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivo;
            do
            {
                Console.Write("Ingresa un número positivo: ");
                positivo = int.Parse(Console.ReadLine());
            } while (positivo <= 0);

            Console.WriteLine("Número válido: " + positivo);
        }
    }
}
```
## Explicación paso a paso
1. **Declaración de variable**
```
int positivo;
```

- Se declara una variable entera que almacenará el número ingresado por el usuario.

2. **Bucle do-while**
```
do
{
    Console.Write("Ingresa un número positivo: ");
    positivo = int.Parse(Console.ReadLine());
} while (positivo <= 0);
```

- do { ... } while (...) garantiza que el código se ejecute al menos una vez.

- La condición positivo <= 0 obliga a repetir el proceso si el número ingresado es cero o negativo.

3. **Salida final**
```
Console.WriteLine("Número válido: " + positivo);
```

