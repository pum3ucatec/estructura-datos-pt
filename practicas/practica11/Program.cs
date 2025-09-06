using System;
using System.Numerics; // Necesario para BigInteger

class Program
{
    // 1. Factorial con BigInteger
    public static BigInteger FactorialRecursivo(BigInteger n)
    {
        if (n <= 1) return 1;
        return n * FactorialRecursivo(n - 1);
    }

    // 2. Suma de N números naturales
    public static long SumaRecursiva(long n)
    {
        if (n == 0) return 0;
        return n + SumaRecursiva(n - 1);
    }

    // 3. Fibonacci
    public static long FibonacciRecursivo(long n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
    }

    // 4. Potencia base^exp
    public static long PotenciaRecursiva(long baseNum, long exp)
    {
        if (exp == 0) return 1;
        return baseNum * PotenciaRecursiva(baseNum, exp - 1);
    }

    // 5. Invertir cadena
    public static string InvertirCadenaRecursiva(string cadena)
    {
        if (cadena.Length <= 1) return cadena;
        return InvertirCadenaRecursiva(cadena.Substring(1)) + cadena[0];
    }

    // 6. Contar dígitos
    public static long ContarDigitosRecursivo(long n)
    {
        if (n == 0) return 0;
        return 1 + ContarDigitosRecursivo(n / 10);
    }

    // 7. Máximo Común Divisor (MCD)
    public static long MCDRecursivo(long a, long b)
    {
        if (b == 0) return a;
        return MCDRecursivo(b, a % b);
    }

    // 8. Suma de arreglo
    public static long SumaArregloRecursiva(long[] arr, int i)
    {
        if (i < 0) return 0;
        return arr[i] + SumaArregloRecursiva(arr, i - 1);
    }

    // 9. Buscar en arreglo
    public static bool BuscarElementoRecursivo(long[] arr, int i, long valor)
    {
        if (i < 0) return false;
        if (arr[i] == valor) return true;
        return BuscarElementoRecursivo(arr, i - 1, valor);
    }

    // 10. Decimal a binario
    public static string DecimalABinarioRecursivo(long n)
    {
        if (n == 0) return "0";
        if (n == 1) return "1";
        return DecimalABinarioRecursivo(n / 2) + (n % 2);
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n📘 MENÚ DE EJERCICIOS RECURSIVOS");
            Console.WriteLine("1. Factorial");
            Console.WriteLine("2. Suma de N números naturales");
            Console.WriteLine("3. Fibonacci");
            Console.WriteLine("4. Potencia");
            Console.WriteLine("5. Invertir cadena");
            Console.WriteLine("6. Contar dígitos");
            Console.WriteLine("7. Máximo Común Divisor (MCD)");
            Console.WriteLine("8. Suma de arreglo");
            Console.WriteLine("9. Buscar en arreglo");
            Console.WriteLine("10. Decimal a binario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 0) break;

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un número: ");
                    BigInteger numFact = BigInteger.Parse(Console.ReadLine());
                    Console.WriteLine($"Factorial de {numFact} = {FactorialRecursivo(numFact)}");
                    break;

                case 2:
                    Console.Write("Ingrese un número: ");
                    long nSuma = long.Parse(Console.ReadLine());
                    Console.WriteLine($"Suma = {SumaRecursiva(nSuma)}");
                    break;

                case 3:
                    Console.Write("Ingrese la posición n: ");
                    long nFib = long.Parse(Console.ReadLine());
                    Console.WriteLine($"Fibonacci({nFib}) = {FibonacciRecursivo(nFib)}");
                    break;

                case 4:
                    Console.Write("Ingrese la base: ");
                    long baseNum = long.Parse(Console.ReadLine());
                    Console.Write("Ingrese el exponente: ");
                    long exp = long.Parse(Console.ReadLine());
                    Console.WriteLine($"{baseNum}^{exp} = {PotenciaRecursiva(baseNum, exp)}");
                    break;

                case 5:
                    Console.Write("Ingrese una cadena: ");
                    string cad = Console.ReadLine();
                    Console.WriteLine($"Invertida = {InvertirCadenaRecursiva(cad)}");
                    break;

                case 6:
                    Console.Write("Ingrese un número: ");
                    long numDig = long.Parse(Console.ReadLine());
                    Console.WriteLine($"Cantidad de dígitos = {ContarDigitosRecursivo(numDig)}");
                    break;

                case 7:
                    Console.Write("Ingrese el primer número: ");
                    long a = long.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    long b = long.Parse(Console.ReadLine());
                    Console.WriteLine($"MCD({a},{b}) = {MCDRecursivo(a, b)}");
                    break;

                case 8:
                    long[] arreglo = { 1, 2, 3, 4, 5 };
                    Console.WriteLine("Arreglo: " + string.Join(", ", arreglo));
                    Console.WriteLine($"Suma = {SumaArregloRecursiva(arreglo, arreglo.Length - 1)}");
                    break;

                case 9:
                    long[] arrBuscar = { 10, 20, 30, 40, 50 };
                    Console.Write("Ingrese el número a buscar: ");
                    long buscado = long.Parse(Console.ReadLine());
                    bool encontrado = BuscarElementoRecursivo(arrBuscar, arrBuscar.Length - 1, buscado);
                    Console.WriteLine(encontrado ? "Encontrado" : "No encontrado");
                    break;

                case 10:
                    Console.Write("Ingrese un número decimal: ");
                    long numDec = long.Parse(Console.ReadLine());
                    Console.WriteLine($"Binario = {DecimalABinarioRecursivo(numDec)}");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}
