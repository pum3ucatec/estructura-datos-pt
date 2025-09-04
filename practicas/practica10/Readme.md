# Pregunta 7 - Máximo Común Divisor (MCD) - Recursivo

Calcular el máximo común divisor (MCD) de dos números usando recursividad.

## Ejemplo:

<pre>
MCD(48, 18) → 6
</pre>





Estilo de nombrado:
	•	Clase → PascalCase (Program)
	•	Método → PascalCase (MCDRecursivo)
	•	Variables → camelCase (a, b, temp)



## 1. Descripción

Este programa implementa el Algoritmo de Euclides para calcular el Máximo Común Divisor (MCD) de dos números enteros mediante recursividad.

La recursividad permite que la función se llame a sí misma con parámetros reducidos hasta llegar a un caso base.

El caso base ocurre cuando el segundo número (b) es igual a 0, en cuyo caso el primer número (a) es el resultado del MCD.



## 2. Flujo del programa
	1.	Se define el método recursivo MCDRecursivo(int a, int b).
	2.	El algoritmo sigue estos pasos:
	 · Si b == 0, retorna a (caso base).
	 · Si b != 0, se hace una llamada recursiva con los valores (b, a % b).
	3.	Este proceso se repite hasta que el divisor se vuelva cero.



## 3. Código Recursivo

```csharp
using System;

class Program
{
    public static int MCDRecursivo(int a, int b)
    {
        // Caso base
        if (b == 0)
            return a;

        // Llamada recursiva
        return MCDRecursivo(b, a % b);
    }

    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("El MCD es: " + MCDRecursivo(a, b));
    }
}
```




## 4. Ejecución
	1.	Entramos a la carpeta del ejercicio en la terminal.
Ejemplo:

	2.	Compilamos y ejecutamos con:

dotnet run


	3.	Ingresamos los datos por teclado:

<pre>
Ingrese el primer número: 48
Ingrese el segundo número: 18
</pre>



	4.	El programa mostrará el resultado:

<pre>
El MCD es: 6
</pre>






## 5. Ejemplo de llamadas recursivas

Para MCD(48, 18) el programa se ejecuta así:

	1.	MCDRecursivo(48, 18) → llama a MCDRecursivo(18, 48 % 18) → MCDRecursivo(18,12)

	2.	MCDRecursivo(18, 12) → llama a MCDRecursivo(12, 18 % 12) → MCDRecursivo(12, 6)

	3.	MCDRecursivo(12, 6) → llama a MCDRecursivo(6, 12 % 6) → MCDRecursivo(6, 0)

	4.	Caso base → retorna 6.

