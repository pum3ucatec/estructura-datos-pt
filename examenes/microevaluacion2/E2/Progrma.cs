using System;

class Programa
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();
        string[] valores = { "P", "K", "C", "D", "D", "A" };

        for (int i = valores.Length - 1; i >= 0; i--)
        {
            cola.AgregarAlInicio(valores[i]);
        }

        Console.WriteLine("Lista inicial:");
        cola.Mostrar();

        int opcion = 0;
        do
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Mostrar lista");
            Console.WriteLine("2. Insertar al inicio");
            Console.WriteLine("3. Eliminar alrededor de un valor");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opcion: ");

            string entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Por favor, ingresa un numero valido.");
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
                    Console.Write("Escribe el valor alrededor del cual eliminar: ");
                    string eliminar = Console.ReadLine();
                    cola.EliminarAlrededor(eliminar);
                    Console.WriteLine($"Se eliminaron nodos alrededor de '{eliminar}'.");
                    break;

                case 4:
                    Console.WriteLine("Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción no reconocida, prueba otra.");
                    break;
            }

        } while (opcion != 4);
    }
}
