# Examen Parcial - Pregunta 1

## Enunciado

Escribe un programa que recorra e imprima los elementos de una matriz en forma de espiral.  
Ejemplo:  
Entrada: `[ [1, 2, 3], [4, 5, 6], [7, 8, 9] ]`  
Salida: `[1, 2, 3, 6, 9, 8, 7, 4, 5]`

---

## Explicación del código

- Se usa una función llamada `RecorridoEspiral`.
- Se recorren los bordes de la matriz por capas.
- Se usó PascalCase para nombrar métodos (`RecorridoEspiral`) y clases (`Program`).
- Se utilizó la estructura `List<int>` para guardar los números en orden.

---

## Código

```csharp
// el mismo código que está en pregunta1.cs va aquí (puedes copiarlo)
```

---

## Cómo ejecutar el código

1. Asegúrate de estar en la carpeta del proyecto.
2. Si es un nuevo proyecto, ejecuta:

```bash
dotnet new console -n ExamenParcial
```

3. Copia el código en el archivo `Program.cs`.
4. Luego, ejecuta:

```bash
dotnet run
```

---

## Resultado esperado

```
Matriz en espiral:
1, 2, 3, 6, 9, 8, 7, 4, 5
```

# Examen Parcial - Pregunta 2

## Enunciado

> Encontrar el número que falta en un arreglo de números del 1 al n.  
> Ejemplo:  
> Entrada: `[1, 2, 4, 5, 6]`  
> Salida: `3`

---

## Explicación del código

- Se calcula la suma esperada de los números del 1 al n usando la fórmula `n*(n+1)/2`.
- Se suma el total de los números presentes en el arreglo.
- El número faltante es la diferencia entre la suma esperada y la suma real.
- Se usó PascalCase para el nombre del método `EncontrarNumeroFaltante`.
- El código está organizado en el método `Main` para ejecución y el método auxiliar para la lógica.

---

## Código

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] arreglo = {1, 2, 4, 5, 6};
        int n = 6; // El rango esperado es de 1 a 6

        int faltante = EncontrarNumeroFaltante(arreglo, n);
        Console.WriteLine($"El número que falta es: {faltante}");
    }

    static int EncontrarNumeroFaltante(int[] arreglo, int n)
    {
        int sumaEsperada = n * (n + 1) / 2;
        int sumaArreglo = 0;

        foreach (int num in arreglo)
        {
            sumaArreglo += num;
        }

        return sumaEsperada - sumaArreglo;
    }
}
```

---

## Cómo ejecutar el código

1. Abre la terminal en la carpeta donde esté el archivo `pregunta2.cs`.
2. Si no tienes un proyecto creado, crea uno con:

   ```bash
   dotnet new console -n ExamenParcial
   ```

3. Copia el código en `Program.cs` o en `pregunta2.cs` si manejas varios archivos.
4. Ejecuta el programa con:

   ```bash
   dotnet run
   ```

---

## Resultado esperado

```
El número que falta es: 3
```
