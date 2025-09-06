using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ejercicio de Pilas ===\n");

        Stack<int> Pila = new Stack<int>();
        int Opcion;

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

            Opcion = LeerEntero(0, 7);

            switch (Opcion)
            {
                case 1:
                    Console.Write("Ingresa un número a insertar: ");
                    int Valor = LeerEntero();
                    Pila.Push(Valor);
                    Console.WriteLine("✔ Elemento insertado.");
                    MostrarPila(Pila);
                    break;

                case 2:
                    if (Pila.Count > 0)
                    {
                        int Eliminado = Pila.Pop();
                        Console.WriteLine($"✔ Elemento {Eliminado} eliminado.");
                    }
                    else
                    {
                        Console.WriteLine("X La pila está vacía.");
                    }
                    MostrarPila(Pila);
                    break;

                case 3:
                    if (Pila.Count > 0)
                    {
                        int Superior = Pila.Peek();
                        Console.WriteLine($"✔ Elemento superior: {Superior}");
                    }
                    else
                    {
                        Console.WriteLine("X La pila está vacía.");
                    }
                    break;

                case 4:
                    Console.WriteLine($"✔ Cantidad de elementos en la pila: {Pila.Count}");
                    break;

                case 5:
                    Pila.Clear();
                    Console.WriteLine("✔ Pila limpiada.");
                    break;

                case 6:
                    Console.Write("¿Cuántos elementos deseas insertar? ");
                    int Cantidad = LeerEntero(1);
                    for (int i = 1; i <= Cantidad; i++)
                    {
                        Console.Write($"Ingresa el elemento {i}: ");
                        int Num = LeerEntero();
                        Pila.Push(Num);
                    }
                    Console.WriteLine($"✔ {Cantidad} elementos insertados en la pila.");
                    MostrarPila(Pila);
                    break;

                case 7:
                    MostrarPila(Pila);
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("X Opción inválida.");
                    break;
            }

        } while (Opcion != 0);
    }

    // ✅ Función para mostrar pila
    static void MostrarPila(Stack<int> Pila)
    {
        if (Pila.Count == 0)
        {
            Console.WriteLine("X La pila está vacía.");
            return;
        }

        Console.WriteLine("\nContenido de la pila (tope -> base):");
        foreach (var Item in Pila)
        {
            Console.WriteLine($"| {Item} |");
        }
        Console.WriteLine("-------");
    }

    // ✅ Leer entero con validación y rango
    static int LeerEntero(int Min = int.MinValue, int Max = int.MaxValue)
    {
        int Numero;
        while (true)
        {
            string? Entrada = Console.ReadLine();
            if (int.TryParse(Entrada, out Numero) && Numero >= Min && Numero <= Max)
                return Numero;

            Console.Write($"X Entrada inválida. Ingrese un número entre {Min} y {Max}: ");
        }
    }
}

