using System;

class Program
{
    static void Main()
    {
        Pila pila = new Pila();
        int opcion;

        do
        {
            Console.WriteLine("\n--- Menú Pila ---");
            Console.WriteLine("1. Mostrar pila");
            Console.WriteLine("2. Insertar (Push)");
            Console.WriteLine("3. Insertar N elementos (Push N)");
            Console.WriteLine("4. Eliminar (Pop)");
            Console.WriteLine("5. Ver cima (Peek)");
            Console.WriteLine("6. Verificar si está vacía");
            Console.WriteLine("7. Limpiar pila (Clear)");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    pila.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese el número a insertar: ");
                    int valor = int.Parse(Console.ReadLine());
                    pila.Push(valor);
                    break;
                case 3:
                    Console.Write("Ingrese la cantidad de números a insertar: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Ingrese el número {i + 1}: ");
                        int num = int.Parse(Console.ReadLine());
                        pila.Push(num);
                    }
                    break;
                case 4:
                    pila.Pop();
                    break;
                case 5:
                    pila.Peek();
                    break;
                case 6:
                    if (pila.IsEmpty())
                        Console.WriteLine("La pila está vacía.");
                    else
                        Console.WriteLine("La pila NO está vacía.");
                    break;
                case 7:
                    pila.Clear();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }
}
