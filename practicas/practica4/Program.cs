using System;
using System.Collections.Generic;

class Pila
{
    private Stack<int> stack = new Stack<int>();

    public void Push(int valor)
    {
        stack.Push(valor);
        Console.WriteLine($"{valor} insertado en la pila.");
    }

    public void Pop()
    {
        if (!IsEmpty())
        {
            int eliminado = stack.Pop();
            Console.WriteLine($"{eliminado} eliminado de la pila.");
        }
        else
        {
            Console.WriteLine("La pila está vacía. No se puede eliminar.");
        }
    }

    public int Peek()
    {
        if (!IsEmpty())
            return stack.Peek();
        else
        {
            Console.WriteLine("La pila está vacía.");
            return -1;
        }
    }

    public bool IsEmpty()
    {
        return stack.Count == 0;
    }

    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía.");
            return;
        }

        Console.WriteLine("Contenido de la pila:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }

    // Vaciar toda la pila
    public void Clear()
    {
        stack.Clear();
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
            Console.WriteLine("6. Insertar varios elementos (Push N)");
            Console.WriteLine("7. Vaciar pila (Clear)");
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
                    Console.Write("¿Cuántos elementos desea insertar?: ");
                    if (int.TryParse(Console.ReadLine(), out int n))
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write($"Ingrese el elemento {i + 1}: ");
                            if (int.TryParse(Console.ReadLine(), out int val))
                            {
                                pila.Push(val);
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido, se omitirá.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;
                case 7:
                    pila.Clear();
                    Console.WriteLine("La pila ha sido vaciada.");
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
