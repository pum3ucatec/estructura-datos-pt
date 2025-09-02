#  Ejercicio 13 – Calcular el promedio de un arreglo

Este programa en C# recorre un **arreglo de notas**, calcula la **suma** de sus elementos y luego obtiene el **promedio**.

---

## Código fuente

```
using System;

class Program
{
    static void Main()
    {
        int[] notas = { 80, 70, 90, 60, 100 };
        int suma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }
        double promedio = (double)suma / notas.Length;
        Console.WriteLine("Promedio: " + promedio);
    }
}
```
## Explicación paso a paso
1. Declaración e inicialización del arreglo
```
int[] notas = { 80, 70, 90, 60, 100 };
```

- Se crea un arreglo de enteros llamado notas.

- Contiene 5 elementos: 80, 70, 90, 60 y 100.

2. Inicialización de la variable acumuladora
```
int suma = 0;
```

- suma almacenará la suma de todas las notas.

- Se inicia en 0 porque aún no se han sumado valores.

3. Bucle for para sumar las notas
```
for (int i = 0; i < notas.Length; i++)
{
    suma += notas[i];
}
```

- int i = 0; → el contador empieza en 0 (primer índice del arreglo).

- i < notas.Length; → el ciclo recorre todo el arreglo.

- suma += notas[i]; → agrega el valor de la nota actual al acumulador.

4. Calcular el promedio
```
double promedio = (double)suma / notas.Length;
```

- Se convierte suma a double para evitar truncamiento.

- Se divide entre la cantidad de elementos (notas.Length) para obtener el promedio.

5. Mostrar el resultado
```
Console.WriteLine("Promedio: " + promedio);
```

Imprime el promedio calculado en consola.