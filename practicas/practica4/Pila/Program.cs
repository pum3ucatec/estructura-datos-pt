﻿class Principal
{
    static void Main(string[] args)
    {
        Pila pila = new Pila();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ PILA =====");
            Console.WriteLine("1. Mostrar pila");
            Console.WriteLine("2. Insertar a la pila");
            Console.WriteLine("3. Eliminar de la pila");
            Console.WriteLine("4. Ver cima de la pila");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Limpiar pila");
            Console.WriteLine("7. Insertar varios elementos");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    pila.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese el número a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                    {
                        pila.Push(valor);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 3:
                    pila.Pop();
                    break;
                case 4:
                    int cima = pila.Peek();
                    if (cima != -1)
                        Console.WriteLine($"Elemento en la cima: {cima}");
                    break;
                case 5:
                    Console.WriteLine(pila.IsEmpty() ? "La pila está vacía." : "La pila no está vacía.");
                    break;
                case 6:
                    pila.Clear();
                    break;
                case 7:
                    Console.Write("Ingrese los números a insertar (separados por espacio): ");
                    string input = Console.ReadLine();
                    string[] valores = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (string val in valores)
                    {
                        if (int.TryParse(val, out int num))
                        {
                            pila.Push(num);
                        }
                        else
                        {
                            Console.WriteLine($"'{val}' no es un número válido.");
                        }
                    }
                    break;
                case 0:
                    Console.WriteLine("Chau, gracias por paticipar :p");
                    break;
                default:
                    Console.WriteLine("Opción no válida >:v");
                    break;
            }

        } while (opcion != 0);
    }
}