# **Pregunta 2** - *Encontrar el número que falta*  
*En un arreglo de números del 1 al n, falta un número. Encuentra cuál es.*

*Ejemplo:*  
<pre>[1,2,4,5,6]</pre>  
→ Falta `3`.

**Estilo de nombrado:**

- Clase: → **PascalCase** (`Ejercicio2`)  
- Variables → **camelCase** (`n`, `arreglo`, `sumaEsperada`, `sumaActual`, `numeroFaltante`, `num`).

---

## **1. Descripción**

Este programa encuentra el número que falta en un arreglo de números consecutivos del 1 al n.  
Se utiliza la **fórmula de suma de una serie aritmética** `(n * (n + 1)) / 2` para calcular la suma esperada y luego se resta la suma de los números ingresados para encontrar el número faltante.

---

## **2. Flujo del programa**

1. Se define el arreglo con los números ingresados (faltando uno).  
2. Se calcula `n` como la longitud del arreglo más 1 (ya que falta un número).  
3. Se calcula la suma total esperada usando la fórmula de suma de serie aritmética.  
4. Se calcula la suma real de los números presentes en el arreglo.  
5. La diferencia entre la suma esperada y la suma real corresponde al número que falta.  
6. Se imprime el resultado.

---

## **3. Código**

```csharp
using System;

class Ejercicio2
{
    static void Main(string[] args)
    {
        int[] arreglo = { 1, 2, 4, 5, 6 };  // Falta el 3
        int n = arreglo.Length + 1; // porque falta un número

        int sumaEsperada = n * (n + 1) / 2;
        int sumaActual = 0;

        foreach (int num in arreglo)
        {
            sumaActual += num;
        }

        int numeroFaltante = sumaEsperada - sumaActual;

        Console.WriteLine("El número que falta es: " + numeroFaltante);
    }
}


