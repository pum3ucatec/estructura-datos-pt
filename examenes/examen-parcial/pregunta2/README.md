# FUNCIONAMIENTO PREGUNTA 2

- Importamos la biblioteca .NET y Colections Generic

```c#
using System;
using System.Collections.Generic;
```

## Clase principal

### Metodo principal

- Creamos un arreglo con numeros

```c#
int[] arreglo = { 1, 2, 4, 5, 7, 8, 10 };
```

- Definimos la cantidad de numeros que deberian existir dentro del arreglo

```c#
int n = 10;
int[] faltantes = EncontrarFaltantes(arreglo, n);

Console.WriteLine("Los números que faltan son: " + string.Join(", ", faltantes));

```

Llamamos al metodo **EncontrarFaltantes** que nos devolvera un arreglo con los numeros que faltan, y despues se imprime la lista

---

### Metodo para encontrar a los faltantes

- El metodo recibira los arreglos y la cantidad de numeros existentes

```c#
    static int[] EncontrarFaltantes(int[] arr, int n)
        {
            bool[] presente = new bool[n + 1];
            foreach (int num in arr)
            {
                if (num >= 1 && num <= n)
                    presente[num] = true;
            }
        }
```

Se crea un booleano para ver si cada numero existe, es n + 1, porque el indice empiece el 0

---

Se recorren los numeros del arreglo del original y si existe se marca como true

```c#
foreach (int num in arr)
{
    if (num >= 1 && num <= n)
        presente[num] = true;
}
```

---

- Se crea una lista para guardar los numeros que faltan

```c#
var listaFaltantes = new System.Collections.Generic.List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (!presente[i])
            listaFaltantes.Add(i);
            }
```

Con el **for** revisamos cada numero desde 1 a n, y si no esta se añade a la lista

---

- Finalmente la lista se convierte en un arreglo y se devuelve

```c#
return listaFaltantes.ToArray();
```
