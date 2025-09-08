using System;

class EntradaPositiva
{
    static void Main()
    {
        int valor;

        // Se repite hasta que el usuario escriba un número mayor a 0
        do
        {
            Console.Write("Por favor, ingrese un número entero positivo: ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out valor); // intenta convertir el texto en número
        } 
        while (valor <= 0);

        Console.WriteLine(" Número aceptado: " + valor);
    }
}
