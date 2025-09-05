using System;
using System.Collections.Generic;

class Pila
{
    private Stack<int> stack = new Stack<int>();

    // Insertar un elemento
    public void Push(int valor)
    {
        stack.Push(valor);
        Console.WriteLine($"Se insertó: {valor}");
    }

    // Insertar n elementos
    public void PushN(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Ingrese el elemento {i}: ");
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                stack.Push(valor);
            }
            else
            {
                Console.WriteLine("Valor inválido, se omitirá.");
            }
        }
        Console.WriteLine($"Se insertaron {n} elementos.");
    }

    // Eliminar un elemento
    public void Pop()
    {
        if (stack.Count > 0)
            Console.WriteLine($"Se eliminó: {stack.Pop()}");
        else
            Console.WriteLine("La pila está vacía.");
    }

    // Ver la cima
    public int Peek()
    {
        if (stack.Count > 0)
            return stack.Peek();
        Console.WriteLine("La pila está vacía.");
        return -1;
    }

    // Mostrar todos los elementos
    public void Mostrar()
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("La pila está vacía.");
            return;
        }

        Console.WriteLine("Elementos en la pila:");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
    }

    // Verificar si está vacía
    public bool IsEmpty()
    {
        return stack.Count == 0;
    }

    // Contar elementos
    public int Count()
    {
        return stack.Count;
    }

    // Limpiar pila
    public void Clear()
    {
        stack.Clear();
        Console.WriteLine("La pila fue vaciada.");
    }
}

class Principal
{
    static void Main(string[] args)
    {
        Pila pila = new Pila();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ PILA =====");
            Console.WriteLine("1. Mostrar pila");
            Console.WriteLine("2. Insertar (Push)");
            Console.WriteLine("3. Eliminar (Pop)");
            Console.WriteLine("4. Ver cima (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Contar elementos (Count)");
            Console.WriteLine("7. Vaciar pila (Clear)");
            Console.WriteLine("8. Insertar varios (Push n)");
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
                    Console.WriteLine(pila.IsEmpty() ? "La pila está vacía." : "La pila NO está vacía.");
                    break;
                case 6:
                    Console.WriteLine($"La pila tiene {pila.Count()} elementos.");
                    break;
                case 7:
                    pila.Clear();
                    break;
                case 8:
                    Console.Write("¿Cuántos elementos desea insertar?: ");
                    if (int.TryParse(Console.ReadLine(), out int n))
                    {
                        pila.PushN(n);
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}

