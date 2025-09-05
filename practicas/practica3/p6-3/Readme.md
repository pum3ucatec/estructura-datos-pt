#  Ejercicio 6 – Buscar un número en un arreglo

Este programa en C# permite al usuario **buscar un número** dentro de un arreglo.  
Si el número existe, muestra su **posición**; si no, indica que no se encontró.

---

## Código fuente

```
int[] datos = { 5, 9, 12, 17, 21, 30, 42, 55, 60, 75 };

Console.Write("Ingrese un número: ");
int buscado = int.Parse(Console.ReadLine());
bool encontrado = false;

for (int i = 0; i < datos.Length; i++)
{
    if (datos[i] == buscado)
    {
        Console.WriteLine($"El número {buscado} se encuentra en la posición {i}");
        encontrado = true;
        break;
    }
}

if (!encontrado)
{
    Console.WriteLine("Número no encontrado en el arreglo.");
}
```
Explicación 

Se define un arreglo datos con 10 números.

Se pide al usuario un número a buscar.

Se recorre el arreglo con un bucle for:

Si el número coincide, se imprime la posición y se termina el bucle (break).

Si al final no se encontró, se muestra un mensaje indicando que no está en el arreglos