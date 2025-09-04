# practica 10 en C# - Suma Recursiva de un Arreglo  

## 📌 Descripción  
Este programa en **C#** permite al usuario ingresar una cantidad determinada de números en un arreglo y calcular la suma de todos los elementos utilizando **recursividad**.  

Además, muestra todos los números ingresados antes de dar el resultado de la suma.  

---

## ⚙️ Funcionamiento  
1. El programa solicita al usuario la **cantidad de elementos del arreglo**.  
2. Pide que se **ingresen los valores uno por uno**.  
3. Muestra en pantalla los números que fueron ingresados.  
4. Calcula la **suma de los elementos del arreglo de manera recursiva**.  
5. Muestra el **resultado final de la suma**.  

---

## 📝 Código Principal  
```csharp
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de elementos del arreglo: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Por favor ingrese un número entero positivo: ");
        }

        int[] numeros = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el valor para la posición {i}: ");
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.Write($"Entrada inválida. Ingrese un número entero para la posición {i}: ");
            }
        }

        Console.WriteLine("Los números ingresados son: " + string.Join(", ", numeros));

        int resultado = SumaArregloRecursiva(numeros);
        Console.WriteLine("La suma del arreglo es: " + resultado);
    }

    public static int SumaArregloRecursiva(int[] arr)
    {
        if (arr == null) throw new ArgumentNullException(nameof(arr));
        return SumaDesde(arr, 0);
    }

    private static int SumaDesde(int[] arr, int i)
    {
        if (i == arr.Length) return 0;
        return arr[i] + SumaDesde(arr, i + 1);
    }
}
▶️ Ejemplo de Ejecución
yaml
Copiar código
Ingrese la cantidad de elementos del arreglo: 4
Ingrese el valor para la posición 0: 2
Ingrese el valor para la posición 1: 4
Ingrese el valor para la posición 2: 6
Ingrese el valor para la posición 3: 8

Los números ingresados son: 2, 4, 6, 8
La suma del arreglo es: 20
💡 Explicación del Código
int.TryParse → valida que la entrada sea un número entero.

string.Join(", ", numeros) → muestra los números ingresados en una sola línea.

SumaArregloRecursiva → función que inicia la recursividad.

SumaDesde → suma los elementos del arreglo de forma recursiva hasta llegar al final.