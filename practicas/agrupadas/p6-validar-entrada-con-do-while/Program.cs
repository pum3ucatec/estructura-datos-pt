// Validar entrada con do-while
// Pedir al usuario que introduzca un numero positivo y seguir pidiendo  hast que lo haga correctamente.
// Camilaa

using System;

class Program
{
    static void Main()
    {
        int numero;
        
        do
        {
            Console.Write("Ingrese un número positivo: ");
            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Debe ingresar un número válido.");
                continue;
            }
            
            if (numero <= 0)
            {
                Console.WriteLine("El número debe ser positivo. Intente nuevamente.");
            }
            
        } while (numero <= 0);
        
        Console.WriteLine($"Ha ingresado correctamente el número positivo: {numero}");
    }
}

