using System;

/// <summary>
/// Programa principal que demuestra diversas operaciones con arreglos en C#
/// </summary>
class Program
{
    /// <summary>
    /// Método principal que ejecuta todas las prácticas de arreglos
    /// </summary>
    static void Main()
    {
        Console.WriteLine("📘 Práctica: Arreglos en C#");
        Console.WriteLine("===========================\n");
        
        Practica1_DeclaracionInicializacion();
        Practica2_RecorridoConFor();
        Practica3_SumaElementos();
        Practica4_PromedioCalificaciones();
        Practica5_MayorMenorValor();
        Practica6_BusquedaLineal();
        Practica7_ContarOcurrencias();
        Practica8_InvertirArreglo();
        Practica9_OrdenamientoBurbuja();
        Practica10_MatrizBidimensional();

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }

    /// <summary>
    /// 1. Declara un arreglo de 5 enteros y los imprime en pantalla
    /// </summary>
    static void Practica1_DeclaracionInicializacion()
    {
        Console.WriteLine("1. DECLARACIÓN E INICIALIZACIÓN");
        Console.WriteLine("-------------------------------");
        
        // Declaración e inicialización manual del arreglo
        int[] numeros = { 10, 20, 30, 40, 50 };
        
        Console.WriteLine("Valores del arreglo:");
        for (int indice = 0; indice < numeros.Length; indice++)
        {
            Console.WriteLine($"Posición {indice}: {numeros[indice]}");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// 2. Crea un arreglo de 10 números y los muestra usando ciclo for
    /// </summary>
    static void Practica2_RecorridoConFor()
    {
        Console.WriteLine("2. RECORRIDO CON CICLO FOR");
        Console.WriteLine("--------------------------");
        
        int[] arregloNumeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        Console.WriteLine("Recorriendo arreglo con for:");
        for (int indice = 0; indice < arregloNumeros.Length; indice++)
        {
            Console.Write(arregloNumeros[indice] + " ");
        }
        Console.WriteLine("\n");
    }

    /// <summary>
    /// 3. Calcula la suma de todos los elementos de un arreglo
    /// </summary>
    static void Practica3_SumaElementos()
    {
        Console.WriteLine("3. SUMA DE ELEMENTOS");
        Console.WriteLine("--------------------");
        
        int[] arregloSuma = { 5, 10, 15, 20 };
        int sumaTotal = 0;
        
        // Sumar todos los elementos del arreglo
        foreach (int numero in arregloSuma)
        {
            sumaTotal += numero;
        }
        
        Console.WriteLine($"Arreglo: [{string.Join(", ", arregloSuma)}]");
        Console.WriteLine($"Suma total: {sumaTotal}\n");
    }

    /// <summary>
    /// 4. Ingresa 5 calificaciones y calcula el promedio
    /// </summary>
    static void Practica4_PromedioCalificaciones()
    {
        Console.WriteLine("4. PROMEDIO DE CALIFICACIONES");
        Console.WriteLine("-----------------------------");
        
        double[] calificaciones = { 80, 70, 90, 60, 100 };
        double sumaCalificaciones = 0;
        
        // Calcular suma de calificaciones
        foreach (double calificacion in calificaciones)
        {
            sumaCalificaciones += calificacion;
        }
        
        double promedio = sumaCalificaciones / calificaciones.Length;
        
        Console.WriteLine($"Calificaciones: [{string.Join(", ", calificaciones)}]");
        Console.WriteLine($"Promedio: {promedio:F0}\n");
    }

    /// <summary>
    /// 5. Encuentra el mayor y menor valor en un arreglo de 8 números
    /// </summary>
    static void Practica5_MayorMenorValor()
    {
        Console.WriteLine("5. MAYOR Y MENOR VALOR");
        Console.WriteLine("----------------------");
        
        int[] numeros = { 12, 5, 8, 20, 3, 17, 25, 10 };
        int mayor = numeros[0];
        int menor = numeros[0];
        
        // Buscar el mayor y menor valor
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor) mayor = numeros[i];
            if (numeros[i] < menor) menor = numeros[i];
        }
        
        Console.WriteLine($"Números: [{string.Join(", ", numeros)}]");
        Console.WriteLine($"Mayor valor: {mayor}");
        Console.WriteLine($"Menor valor: {menor}\n");
    }

    /// <summary>
    /// 6. Busca un número en el arreglo y muestra su posición si existe
    /// </summary>
    static void Practica6_BusquedaLineal()
    {
        Console.WriteLine("6. BÚSQUEDA LINEAL");
        Console.WriteLine("-------------------");
        
        int[] arregloBusqueda = { 2, 7, 15, 8, 17, 3, 9, 12, 6, 4 };
        bool numeroEncontrado = false;
        
        Console.Write("Ingrese un número a buscar: ");
        int numeroBuscado = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Buscando número {numeroBuscado} en el arreglo...");
        
        // Búsqueda lineal
        for (int posicion = 0; posicion < arregloBusqueda.Length; posicion++)
        {
            if (arregloBusqueda[posicion] == numeroBuscado)
            {
                Console.WriteLine($"✅ El número {numeroBuscado} se encuentra en la posición {posicion}");
                numeroEncontrado = true;
                break;
            }
        }
        
        if (!numeroEncontrado)
        {
            Console.WriteLine($"❌ El número {numeroBuscado} no se encuentra en el arreglo");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// 7. Cuenta cuántas veces aparece un número en el arreglo
    /// </summary>
    static void Practica7_ContarOcurrencias()
    {
        Console.WriteLine("7. CONTAR OCURRENCIAS");
        Console.WriteLine("---------------------");
        
        int[] arregloOcurrencias = { 2, 5, 2, 8, 2, 9 };
        int contador = 0;
        
        Console.Write("Ingrese el número a contar: ");
        int numeroAContar = int.Parse(Console.ReadLine());
        
        // Contar ocurrencias
        foreach (int numero in arregloOcurrencias)
        {
            if (numero == numeroAContar) contador++;
        }
        
        Console.WriteLine($"Arreglo: [{string.Join(", ", arregloOcurrencias)}]");
        Console.WriteLine($"El número {numeroAContar} aparece {contador} veces\n");
    }

    /// <summary>
    /// 8. Crea un nuevo arreglo con los elementos en orden inverso
    /// </summary>
    static void Practica8_InvertirArreglo()
    {
        Console.WriteLine("8. INVERTIR ARREGLO");
        Console.WriteLine("-------------------");
        
        int[] arregloOriginal = { 1, 2, 3, 4, 5 };
        int[] arregloInvertido = new int[arregloOriginal.Length];
        
        // Invertir el arreglo
        for (int i = 0; i < arregloOriginal.Length; i++)
        {
            arregloInvertido[i] = arregloOriginal[arregloOriginal.Length - 1 - i];
        }
        
        Console.WriteLine($"Arreglo original: [{string.Join(", ", arregloOriginal)}]");
        Console.WriteLine($"Arreglo invertido: [{string.Join(", ", arregloInvertido)}]\n");
    }

    /// <summary>
    /// 9. Ordena un arreglo usando el algoritmo de burbuja
    /// </summary>
    static void Practica9_OrdenamientoBurbuja()
    {
        Console.WriteLine("9. ORDENAMIENTO BURBUJA");
        Console.WriteLine("-----------------------");
        
        int[] arregloDesordenado = { 8, 3, 5, 1, 9 };
        int[] arregloOrdenado = (int[])arregloDesordenado.Clone();
        
        // Algoritmo de ordenamiento burbuja
        for (int i = 0; i < arregloOrdenado.Length - 1; i++)
        {
            for (int j = 0; j < arregloOrdenado.Length - 1 - i; j++)
            {
                if (arregloOrdenado[j] > arregloOrdenado[j + 1])
                {
                    // Intercambiar elementos
                    int temporal = arregloOrdenado[j];
                    arregloOrdenado[j] = arregloOrdenado[j + 1];
                    arregloOrdenado[j + 1] = temporal;
                }
            }
        }
        
        Console.WriteLine($"Arreglo desordenado: [{string.Join(", ", arregloDesordenado)}]");
        Console.WriteLine($"Arreglo ordenado: [{string.Join(", ", arregloOrdenado)}]\n");
    }

    /// <summary>
    /// 10. Trabaja con matriz bidimensional y calcula sumas de filas y columnas
    /// </summary>
    static void Practica10_MatrizBidimensional()
    {
        Console.WriteLine("10. MATRIZ BIDIMENSIONAL");
        Console.WriteLine("------------------------");
        
        // Declaración e inicialización de matriz 3x3
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        
        // Mostrar matriz
        Console.WriteLine("Matriz 3x3:");
        for (int fila = 0; fila < 3; fila++)
        {
            for (int columna = 0; columna < 3; columna++)
            {
                Console.Write($"{matriz[fila, columna]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // Calcular y mostrar suma de filas
        Console.WriteLine("Suma de filas:");
        for (int fila = 0; fila < 3; fila++)
        {
            int sumaFila = 0;
            for (int columna = 0; columna < 3; columna++)
            {
                sumaFila += matriz[fila, columna];
            }
            Console.WriteLine($"Fila {fila + 1}: {sumaFila}");
        }
        Console.WriteLine();

        // Calcular y mostrar suma de columnas
        Console.WriteLine("Suma de columnas:");
        for (int columna = 0; columna < 3; columna++)
        {
            int sumaColumna = 0;
            for (int fila = 0; fila < 3; fila++)
            {
                sumaColumna += matriz[fila, columna];
            }
            Console.WriteLine($"Columna {columna + 1}: {sumaColumna}");
        }
        Console.WriteLine();
    }
}
