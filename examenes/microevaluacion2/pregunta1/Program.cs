using System;

class Programa
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();
        string[] valores = { "P", "K", "A", "D", "D", "A" };

        for (int i = valores.Length - 1; i >= 0; i--)
        {
            cola.AgregarAlInicio(valores[i]);
        }

        Console.WriteLine("Lista inicial:");
        cola.Mostrar();

        int opcion = 0;
        do
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Mostrar lista");
            Console.WriteLine("2. Insertar al inicio");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");

            string entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    cola.Mostrar();
                    break;

                case 2:
                    Console.Write("Escribe el valor a insertar al inicio: ");
                    string nuevoValor = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nuevoValor))
                    {
                        cola.AgregarAlInicio(nuevoValor);
                        Console.WriteLine($"'{nuevoValor}' agregado al inicio.");
                    }
                    else
                    {
                        Console.WriteLine("Valor no válido, intenta de nuevo.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción no reconocida, prueba otra.");
                    break;
            }

        } while (opcion != 3);
    }
}
