using System;

class CalculadoraBasica
{
    static void Main()
    {
        int opc;
        do
        {
            Console.Clear();
            Console.WriteLine("=== CALCULADORA BASICA ===");
            Console.WriteLine("1) Sumar");
            Console.WriteLine("2) Restar");
            Console.WriteLine("3) Multiplicar");
            Console.WriteLine("4) Dividir");
            Console.WriteLine("5) Potencia");
            Console.WriteLine("6) Raiz cuadrada");
            Console.WriteLine("7) Porcentaje");
            Console.WriteLine("8) Valor absoluto");
            Console.WriteLine("9) Grados a radianes");
            Console.WriteLine("0) Salir");
            Console.Write("Opcion: ");

            opc = Convert.ToInt32(Console.ReadLine());
            double x, y, res;

            if (opc == 1)
            {
                Console.Write("Num1: "); x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Num2: "); y = Convert.ToDouble(Console.ReadLine());
                res = x + y;
                Console.WriteLine("Resultado: " + res);
            }
            else if (opc == 2)
            {
                Console.Write("Num1: "); x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Num2: "); y = Convert.ToDouble(Console.ReadLine());
                res = x - y;
                Console.WriteLine("Resultado: " + res);
            }
            else if (opc == 3)
            {
                Console.Write("Num1: "); x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Num2: "); y = Convert.ToDouble(Console.ReadLine());
                res = x * y;
                Console.WriteLine("Resultado: " + res);
            }
            else if (opc == 4)
            {
                Console.Write("Dividendo: "); x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Divisor: "); y = Convert.ToDouble(Console.ReadLine());
                if (y != 0)
                {
                    res = x / y;
                    Console.WriteLine("Resultado: " + res);
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre 0");
                }
            }
            else if (opc == 5)
            {
                Console.Write("Base: "); x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Exponente: "); y = Convert.ToDouble(Console.ReadLine());
                res = Math.Pow(x, y);
                Console.WriteLine("Resultado: " + res);
            }
            else if (opc == 6)
            {
                Console.Write("Numero: "); x = Convert.ToDouble(Console.ReadLine());
                if (x >= 0)
                {
                    res = Math.Sqrt(x);
                    Console.WriteLine("Raiz: " + res);
                }
                else
                {
                    Console.WriteLine("No se puede calcular la raiz de un numero negativo");
                }
            }
            else if (opc == 7)
            {
                Console.Write("Numero: "); x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Porcentaje: "); y = Convert.ToDouble(Console.ReadLine());
                res = (x * y) / 100;
                Console.WriteLine(y + "% de " + x + " = " + res);
            }
            else if (opc == 8)
            {
                Console.Write("Numero: "); x = Convert.ToDouble(Console.ReadLine());
                res = Math.Abs(x);
                Console.WriteLine("Valor absoluto: " + res);
            }
            else if (opc == 9)
            {
                Console.Write("Grados: "); x = Convert.ToDouble(Console.ReadLine());
                res = x * (Math.PI / 180);
                Console.WriteLine("En radianes: " + res);
            }
            else if (opc == 0)
            {
                Console.WriteLine("Saliendo...");
            }
            else
            {
                Console.WriteLine("Opcion invalida");
            }

            if (opc != 0)
            {
                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opc != 0);
    }
}
