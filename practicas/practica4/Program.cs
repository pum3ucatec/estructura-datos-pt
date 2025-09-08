using System;
using System.Collections.Generic;

class Pila
{
    private List<int> elementos;

    public Pila()
    {
        elementos = new List<int>();
    }

    public void Push(int valor)
    {
        elementos.Add(valor);
        Console.WriteLine($"Elemento {valor} insertado correctamente.");
    }

    public void Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía. No se puede eliminar.");
            return;
        }

        int valorEliminado = elementos[elementos.Count - 1];
        elementos.RemoveAt(elementos.Count - 1);
        Console.WriteLine($"Elemento {valorEliminado} eliminado correctamente.");
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía.");
            return -1;
        }
        return elementos[elementos.Count - 1];
    }

    public bool IsEmpty()
    {
        return elementos.Count == 0;
    }

    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía.");
            return;
        }

        Console.WriteLine("Contenido de la pila (de arriba a abajo):");
        for (int i = elementos.Count - 1; i >= 0; i--)
        {
            Console.WriteLine($"│ {elementos[i]} │");
            if (i > 0) Console.WriteLine("├───┤");
        }
        Console.WriteLine("└───┘");
    }

    public void Clear()
    {
        elementos.Clear();
        Console.WriteLine("Pila limpiada completamente.");
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
            Console.WriteLine("3. Insertar N elementos (Push N)");
            Console.WriteLine("4. Eliminar (Pop)");
            Console.WriteLine("5. Ver cima (Peek)");
            Console.WriteLine("6. Verificar si está vacía");
            Console.WriteLine("7. Limpiar pila (Clear)");
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
                    Console.Write("¿Cuántos elementos desea insertar? ");
                    if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.Write($"Elemento {i + 1}: ");
                            if (int.TryParse(Console.ReadLine(), out int valorN))
                            {
                                pila.Push(valorN);
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido, intente nuevamente.");
                                i--; // Permite reintentar el mismo índice
                            }
                        }
                        Console.WriteLine($"Se insertaron {cantidad} elementos correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Cantidad inválida. Debe ser un número mayor a 0.");
                    }
                    break;
                case 4:
                    pila.Pop();
                    break;
                case 5:
                    int cima = pila.Peek();
                    if (cima != -1)
                        Console.WriteLine($"Elemento en la cima: {cima}");
                    break;
                case 6:
                    Console.WriteLine(pila.IsEmpty() ? "La pila está vacía." : "La pila NO está vacía.");
                    break;
                case 7:
                    pila.Clear();
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
