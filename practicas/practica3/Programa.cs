using System;

namespace practica3
{
    public class program
    {
        public static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\n=== práctica 3: arreglos en c# ===");
                Console.WriteLine("1. declaración e inicialización");
                Console.WriteLine("2. recorrido con for");
                Console.WriteLine("3. suma de elementos");
                Console.WriteLine("4. promedio de elementos");
                Console.WriteLine("5. mayor y menor valor");
                Console.WriteLine("6. búsqueda lineal");
                Console.WriteLine("7. contar ocurrencias");
                Console.WriteLine("8. invertir arreglo");
                Console.WriteLine("9. ordenamiento (burbuja)");
                Console.WriteLine("10. arreglo bidimensional (matriz)");
                Console.WriteLine("0. salir");
                Console.Write("seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine() ?? "0");

                switch (opcion)
                {
                    case 1: ejercicio1(); break;
                    case 2: ejercicio2(); break;
                    case 3: ejercicio3(); break;
                    case 4: ejercicio4(); break;
                    case 5: ejercicio5(); break;
                    case 6: ejercicio6(); break;
                    case 7: ejercicio7(); break;
                    case 8: ejercicio8(); break;
                    case 9: ejercicio9(); break;
                    case 10: ejercicio10(); break;
                }

            } while (opcion != 0);
        }

        // 1. declaración e inicialización
        static void ejercicio1()
        {
            int[] numeros = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < numeros.Length; i++)
                Console.WriteLine(numeros[i]);
        }

        // 2. recorrido con for
        static void ejercicio2()
        {
            int[] numeros = new int[10];
            for (int i = 0; i < numeros.Length; i++)
                numeros[i] = i + 1;

            for (int i = 0; i < numeros.Length; i++)
                Console.WriteLine(numeros[i]);
        }

        // 3. suma de elementos
        static void ejercicio3()
        {
            int[] arreglo = { 5, 10, 15, 20 };
            int suma = 0;
            for (int i = 0; i < arreglo.Length; i++)
                suma += arreglo[i];

            Console.WriteLine("suma: " + suma);
        }

        // 4. promedio de elementos
        static void ejercicio4()
        {
            int[] notas = { 80, 70, 90, 60, 100 };
            int suma = 0;
            for (int i = 0; i < notas.Length; i++)
                suma += notas[i];

            double promedio = (double)suma / notas.Length;
            Console.WriteLine("promedio: " + promedio);
        }

        // 5. mayor y menor valor
        static void ejercicio5()
        {
            int[] numeros = { 12, 5, 8, 20, 3, 17, 25, 10 };
            int mayor = numeros[0];
            int menor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor) mayor = numeros[i];
                if (numeros[i] < menor) menor = numeros[i];
            }

            Console.WriteLine("mayor: " + mayor);
            Console.WriteLine("menor: " + menor);
        }

        // 6. búsqueda lineal
        static void ejercicio6()
        {
            int[] numeros = { 10, 15, 17, 20, 25, 30, 35, 40, 45, 50 };
            Console.Write("ingrese un número: ");
            int buscado = int.Parse(Console.ReadLine() ?? "0");
            bool encontrado = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscado)
                {
                    Console.WriteLine($"el número {buscado} se encuentra en la posición {i}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
                Console.WriteLine("número no encontrado.");
        }

        // 7. contar ocurrencias
        static void ejercicio7()
        {
            int[] arreglo = { 2, 5, 2, 8, 2, 9 };
            Console.Write("número buscado: ");
            int buscado = int.Parse(Console.ReadLine() ?? "0");
            int contador = 0;

            for (int i = 0; i < arreglo.Length; i++)
                if (arreglo[i] == buscado) contador++;

            Console.WriteLine($"el número aparece {contador} veces");
        }

        // 8. invertir arreglo
        static void ejercicio8()
        {
            int[] arreglo = { 1, 2, 3, 4, 5 };
            int[] invertido = new int[arreglo.Length];

            for (int i = 0; i < arreglo.Length; i++)
                invertido[i] = arreglo[arreglo.Length - 1 - i];

            Console.WriteLine("arreglo invertido:");
            for (int i = 0; i < invertido.Length; i++)
                Console.Write(invertido[i] + " ");
            Console.WriteLine();
        }

        // 9. ordenamiento burbuja
        static void ejercicio9()
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

            Console.WriteLine("arreglo ordenado:");
            foreach (int num in arreglo)
                Console.Write(num + " ");
            Console.WriteLine();
        }

        // 10. matriz 3x3 con suma de filas y columnas
        static void ejercicio10()
        {
            int[,] matriz = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine("matriz:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(matriz[i, j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("suma de filas:");
            for (int i = 0; i < 3; i++)
            {
                int sumafila = 0;
                for (int j = 0; j < 3; j++)
                    sumafila += matriz[i, j];
                Console.WriteLine($"fila {i + 1}: {sumafila}");
            }

            Console.WriteLine("suma de columnas:");
            for (int j = 0; j < 3; j++)
            {
                int sumacol = 0;
                for (int i = 0; i < 3; i++)
                    sumacol += matriz[i, j];
                Console.WriteLine($"columna {j + 1}: {sumacol}");
            }
        }
    }
}
