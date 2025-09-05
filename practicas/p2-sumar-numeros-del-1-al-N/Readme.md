# Ejercicio 2 – Suma de números con bucle `while`

Este programa en C# solicita al usuario un número entero `N` y calcula la **suma de todos los números desde 1 hasta N** utilizando un **bucle `while`**.

---

## Código fuente

```
using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número N: ");
            int N = int.Parse(Console.ReadLine());
            int suma = 0;
            int contador = 1;

            while (contador <= N)
            {
                suma += contador;
                contador++;
            }

            Console.WriteLine("Suma: " + suma);
        }
    }
}
```

# Explicación paso a paso

1. **Entrada del usuario**

Console.Write("Ingresa un número N: ");
int N = int.Parse(Console.ReadLine());


- Console.Write muestra un mensaje en pantalla.

- Console.ReadLine() captura lo que el usuario escribe.


2. **Inicialización de variables**

int suma = 0;
int contador = 1;


suma → acumula el resultado.

contador → empieza en 1 y se irá incrementando hasta llegar a N.

3. **Bucle while**

while (contador <= N)

{
    suma += contador;
    contador++;
}


- La condición contador <= N asegura que el bucle siga hasta que el contador llegue a N.

- suma += contador; equivale a suma = suma + contador;.

- contador++ incrementa el contador en 1 en cada vuelta.

4. **Salida del resultado**

Console.WriteLine("Suma: " + suma);


Muestra en consola la suma total.