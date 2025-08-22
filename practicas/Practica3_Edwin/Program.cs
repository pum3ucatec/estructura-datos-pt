using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Práctica 3 - Arreglos en C# ===");
        Console.WriteLine("Selecciona un ejercicio (1 al 10): ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Ejercicio1();
                break;
            case 2:
                Ejercicio2();
                break;
            case 3:
                Ejercicio3();
                break;
            case 4:
                Ejercicio4();
                break;
            case 5:
                Ejercicio5();
                break;
            case 6:
                Ejercicio6();
                break;
            case 7:
                Ejercicio7();
                break;
            case 8:
                Ejercicio8();
                break;
            case 9:
                Ejercicio9();
                break;
            case 10:
                Ejercicio10();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    static void Ejercicio1()
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }
    }

    static void Ejercicio2()
    {
        int[] numeros = new int[10];
        for (int i = 0; i < 10; i++)
        {
            numeros[i] = i + 1;
        }
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }

    static void Ejercicio3()
    {
        int[] arreglo = { 5, 10, 15, 20 };
        int suma = 0;
        foreach (int num in arreglo)
        {
            suma += num;
        }
        Console.WriteLine("Suma: " + suma);
    }

    static void Ejercicio4()
    {
        int[] notas = { 80, 70, 90, 60, 100 };
        int suma = 0;
        foreach (int nota in notas)
        {
            suma += nota;
        }
        Console.WriteLine("Promedio: " + (suma / notas.Length));
    }

    static void Ejercicio5()
    {
        int[] numeros = { 12, 5, 8, 20, 3, 17, 25, 10 };
        int mayor = numeros[0];
        int menor = numeros[0];

        foreach (int num in numeros)
        {
            if (num > mayor) mayor = num;
            if (num < menor) menor = num;
        }

        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);
    }

    static void Ejercicio6()
    {
        int[] arreglo = { 3, 7, 9, 14, 17, 20, 21, 33, 45, 50 };
        Console.Write("Ingrese un número: ");
        int buscado = int.Parse(Console.ReadLine());
        bool encontrado = false;

        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == buscado)
            {
                Console.WriteLine($"El número {buscado} se encuentra en la posición {i}");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
            Console.WriteLine("El número no se encuentra en el arreglo.");
    }

    static void Ejercicio7()
    {
        int[] arreglo = { 2, 5, 2, 8, 2, 9 };
        Console.Write("Número buscado: ");
        int buscado = int.Parse(Console.ReadLine());
        int contador = 0;

        foreach (int num in arreglo)
        {
            if (num == buscado) contador++;
        }

        Console.WriteLine($"El número aparece {contador} veces");
    }

    static void Ejercicio8()
    {
        int[] original = { 1, 2, 3, 4, 5 };
        int[] invertido = new int[original.Length];

        for (int i = 0; i < original.Length; i++)
        {
            invertido[i] = original[original.Length - 1 - i];
        }

        Console.WriteLine("Arreglo invertido:");
        foreach (int num in invertido)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Ejercicio9()
    {
        int[] arreglo = { 8, 3, 5, 1, 9 };

        for (int i = 0; i < arreglo.Length - 1; i++)
        {
            for (int j = 0; j < arreglo.Length - 1 - i; j++)
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    int temp = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Arreglo ordenado:");
        foreach (int num in arreglo)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Ejercicio10()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Suma de filas:");
        for (int i = 0; i < 3; i++)
        {
            int sumaFila = 0;
            for (int j = 0; j < 3; j++)
            {
                sumaFila += matriz[i, j];
            }
            Console.WriteLine($"Fila {i + 1}: {sumaFila}");
        }

        Console.WriteLine("Suma de columnas:");
        for (int j = 0; j < 3; j++)
        {
            int sumaCol = 0;
            for (int i = 0; i < 3; i++)
            {
                sumaCol += matriz[i, j];
            }
            Console.WriteLine($"Columna {j + 1}: {sumaCol}");
        }
    }
}
