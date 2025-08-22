# **PROYECTO: ENCONTRAR EL NÚMERO FALTANTE EN UN ARREGLO**
- Este programa en **C#** encuentra el número que falta en un arreglo que contiene los números del `1` al `n` que se nos pido a nosotros los estudiantes por resolver de manera individual.  .  
***
- Ejemplo de ejecución:  
  Entrada → `[1, 2, 4, 5, 6]`  
  Salida → `Falta el número: 3`  
***
## ***Explicación de lo Utilizado***
1. *Convenciones de Código:*
   - **PascalCase** → usado en nombres de clases y métodos.  
     - Ejemplo: `NumeroFaltante`, `EncontrarFaltante`.  
   - **camelCase** → usado en variables locales.  
     - Ejemplo: `sumaEsperada`, `sumaReal`.  
   - Se utilizó la librería **System.Linq** para usar el método `.Sum()`, que simplifica el cálculo de la suma del arreglo.  

2. *Algoritmo Implementado:*
   - Se calcula la suma esperada de los números del 1 al `n` usando la fórmula:  
     \[
     sumaEsperada = \frac{n \cdot (n+1)}{2}
     \]  
   - Se obtiene la suma real de los elementos presentes en el arreglo.  
   - Se resta `sumaEsperada - sumaReal`.  
   - El resultado es el número faltante .  

***

## ***Ejemplo Paso a Paso***
Arreglo: `[1, 2, 4, 5, 6]`  
- `n = 6` (porque debería ir de 1 a 6).  
- `sumaEsperada = 21`.  
- `sumaReal = 18`.  
- Resultado → **Falta el número 3**  

***
## ***Comandos para Ejecutar***

1. Verificar que esté instalado **.NET SDK**:
   ```bash
   dotnet --version

2. Posteriormente agrega el comando(el cual sirve para crear una plantilla básica listo para que trabajemos en nuestro proyecto):
    ```bash
   dotnet new console

3. Por ultimo ejecutamos nuestro programa:
    ```bash
   dotnet run

   ***

## ***Código Principal***
```csharp
using System;
using System.Linq;

class NumeroFaltante
{
    static void Main()
    {
        int[] arreglo = { 1, 2, 4, 5, 6 };

        int faltante = EncontrarFaltante(arreglo);

        Console.WriteLine("Arreglo: [" + string.Join(", ", arreglo) + "]");
        Console.WriteLine("Número faltante: " + faltante);
    }

    static int EncontrarFaltante(int[] arreglo)
    {
        int n = arreglo.Length + 1; // porque falta un número
        int sumaEsperada = n * (n + 1) / 2;
        int sumaReal = arreglo.Sum();

        return sumaEsperada - sumaReal;
    }
}

   ***


