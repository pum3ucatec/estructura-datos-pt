using System;

namespace Practica3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\n=== Práctica 3: Arreglos en C# ===");
                Console.WriteLine("1. Declaración e inicialización");
                Console.WriteLine("2. Recorrido con for");
                Console.WriteLine("3. Suma de elementos");
                Console.WriteLine("4. Promedio de elementos");
                Console.WriteLine("5. Mayor y menor valor");
                Console.WriteLine("6. Búsqueda lineal");
                Console.WriteLine("7. Contar ocurrencias");
                Console.WriteLine("8. Invertir arreglo");
                Console.WriteLine("9. Ordenamiento (Burbuja)");
                Console.WriteLine("10. Arreglo bidimensional (Matriz)");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine() ?? "0");

                switch (opcion)
                {
                    case 1: Ejercicio1(); break;
                    case 2: Ejercicio2(); break;
                    case 3: Ejercicio3(); break;
                    case 4: Ejercicio4(); break;
                    case 5: Ejercicio5(); break;
                    case 6: Ejercicio6(); break;
                    case 7: Ejercicio7(); break;
                    case 8: Ejercicio8(); break;
                    case 9: Ejercicio9(); break;
                    case 10: Ejercicio10(); break;
                }

            } while (opcion != 0);
        }

        // 1. Declaración e inicialización
        static void Ejercicio1()
        {
            int[] numeros = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < numeros.Length; i++)
                Console.WriteLine(numeros[i]);
        }

        // 2. Recorrido con for
        static void Ejercicio2()
        {
            int[] numeros = new int[10];
            for (int i = 0; i < numeros.Length; i++)
                numeros[i] = i + 1;

            for (int i = 0; i < numeros.Length; i++)
                Console.WriteLine(numeros[i]);
        }

        // 3. Suma de elementos
        static void Ejercicio3()
        {
            int[] arreglo = { 5, 10, 15, 20 };
            int suma = 0;
            for (int i = 0; i < arreglo.Length; i++)
                suma += arreglo[i];

            Console.WriteLine("Suma: " + suma);
        }

        // 4. Promedio de elementos
        static void Ejercicio4()
        {
            int[] notas = { 80, 70, 90, 60, 100 };
            int suma = 0;
            for (int i = 0; i < notas.Length; i++)
                suma += notas[i];

            double promedio = (double)suma / notas.Length;
            Console.WriteLine("Promedio: " + promedio);
        }

        // 5. Mayor y menor valor
        static void Ejercicio5()
        {
            int[] numeros = { 12, 5, 8, 20, 3, 17, 25, 10 };
            int mayor = numeros[0];
            int menor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor) mayor = numeros[i];
                if (numeros[i] < menor) menor = numeros[i];
            }

            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Menor: " + menor);
        }

        // 6. Búsqueda lineal
        static void Ejercicio6()
        {
            int[] numeros = { 10, 15, 17, 20, 25, 30, 35, 40, 45, 50 };
            Console.Write("Ingrese un número: ");
            int buscado = int.Parse(Console.ReadLine() ?? "0");
            bool encontrado = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscado)
                {
                    Console.WriteLine($"El número {buscado} se encuentra en la posición {i}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
                Console.WriteLine("Número no encontrado.");
        }

        // 7. Contar ocurrencias
        static void Ejercicio7()
        {
            int[] arreglo = { 2, 5, 2, 8, 2, 9 };
            Console.Write("Número buscado: ");
            int buscado = int.Parse(Console.ReadLine() ?? "0");
            int contador = 0;

            for (int i = 0; i < arreglo.Length; i++)
                if (arreglo[i] == buscado) contador++;

            Console.WriteLine($"El número aparece {contador} veces");
        }

        // 8. Invertir arreglo
        static void Ejercicio8()
        {
            int[] arreglo = { 1, 2, 3, 4, 5 };
            int[] invertido = new int[arreglo.Length];

            for (int i = 0; i < arreglo.Length; i++)
                invertido[i] = arreglo[arreglo.Length - 1 - i];

            Console.WriteLine("Arreglo invertido:");
            for (int i = 0; i < invertido.Length; i++)
                Console.Write(invertido[i] + " ");
            Console.WriteLine();
        }

        // 9. Ordenamiento Burbuja
        static void Ejercicio9()
        {
            int[] arreglo = { 8, 3, 5, 1, 9 };

            for (int i = 0; i < arreglo.Length - 1; i++)
                for (int j = 0; j < arreglo.Length - i - 1; j++)
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }

            Console.WriteLine("Arreglo ordenado:");
            foreach (int num in arreglo)
                Console.Write(num + " ");
            Console.WriteLine();
        }

        // 10. Matriz 3x3 con suma de filas y columnas
        static void Ejercicio10()
        {
            int[,] matriz = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine("Matriz:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(matriz[i, j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("Suma de filas:");
            for (int i = 0; i < 3; i++)
            {
                int sumaFila = 0;
                for (int j = 0; j < 3; j++)
                    sumaFila += matriz[i, j];
                Console.WriteLine($"Fila {i + 1}: {sumaFila}");
            }

            Console.WriteLine("Suma de columnas:");
            for (int j = 0; j < 3; j++)
            {
                int sumaCol = 0;
                for (int i = 0; i < 3; i++)
                    sumaCol += matriz[i, j];
                Console.WriteLine($"Columna {j + 1}: {sumaCol}");
            }
        }
    }
}
