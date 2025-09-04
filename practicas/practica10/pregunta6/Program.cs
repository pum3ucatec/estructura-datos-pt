
class Program
{
    static void Main(string[] args)
    {
        int numero = 12345;
        int cantidadDigitos = ContarDigitosRecursivo(numero);
        Console.WriteLine($"El número {numero} tiene {cantidadDigitos} dígitos.");
    }
    public static int ContarDigitosRecursivo(int n)
    {

        if (n < 10)
        {
            return 1;
        }

        return 1 + ContarDigitosRecursivo(n / 10);
    }
}