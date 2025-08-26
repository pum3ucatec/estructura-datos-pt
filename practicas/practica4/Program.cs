
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ejercicio de Pilas ===\n");

        Stack<int> pila = new Stack<int>();
        int opcion;

        do
        {
            Console.WriteLine("\n--- MENÚ DE PILA ---");
            Console.WriteLine("1. Push (insertar elemento)");
            Console.WriteLine("2. Pop (eliminar elemento)");
            Console.WriteLine("3. Peek (ver elemento superior)");
            Console.WriteLine("4. Count (cantidad de elementos)");
            Console.WriteLine("5. Clear (limpiar pila)");
            Console.WriteLine("6. Push 'n' (insertar varios elementos)");
            Console.WriteLine("7. Mostrar pila");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            opcion = LeerEntero(0, 7);

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa un número a insertar: ");
                    int valor = LeerEntero();
                    pila.Push(valor);
                    Console.WriteLine("✔ Elemento insertado.");
                    MostrarPila(pila);
                    break;

                case 2:
                    if (pila.Count > 0)
                    {
                        int eliminado = pila.Pop();
                        Console.WriteLine($"✔ Elemento {eliminado} eliminado.");
                    }
                    else
                    {
                        Console.WriteLine("X La pila está vacía.");
                    }
                    MostrarPila(pila);
                    break;

                case 3:
                    if (pila.Count > 0)
                    {
                        int superior = pila.Peek();
                        Console.WriteLine($"✔ Elemento superior: {superior}");
                    }
                    else
                    {
                        Console.WriteLine("X La pila está vacía.");
                    }
                    break;

                case 4:
                    Console.WriteLine($"✔ Cantidad de elementos en la pila: {pila.Count}");
                    break;

                case 5:
                    pila.Clear();
                    Console.WriteLine("✔ Pila limpiada.");
                    break;

                case 6:
                    Console.Write("¿Cuántos elementos deseas insertar? ");
                    int cantidad = LeerEntero(1);
                    for (int i = 1; i <= cantidad; i++)
                    {
                        Console.Write($"Ingresa el elemento {i}: ");
                        int num = LeerEntero();
                        pila.Push(num);
                    }
                    Console.WriteLine($"✔ {cantidad} elementos insertados en la pila.");
                    MostrarPila(pila);
                    break;

                case 7:
                    MostrarPila(pila);
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("X Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }

    // ✅ Función para mostrar pila
    static void MostrarPila(Stack<int> pila)
    {
        if (pila.Count == 0)
        {
            Console.WriteLine("X La pila está vacía.");
            return;
        }

        Console.WriteLine("\nContenido de la pila (tope -> base):");
        foreach (var item in pila)
        {
            Console.WriteLine($"| {item} |");
        }
        Console.WriteLine("-------");
    }

    // ✅ Leer entero con validación y rango
    static int LeerEntero(int min = int.MinValue, int max = int.MaxValue)
    {
        int numero;
        while (true)
        {
            string? entrada = Console.ReadLine();
            if (int.TryParse(entrada, out numero) && numero >= min && numero <= max)
                return numero;

            Console.Write($"X Entrada inválida. Ingrese un número entre {min} y {max}: ");
        }
    }
}
