using System;

class Cola
{
    private int[] elementos;
    private int frente, tamaño, cantidad, final;
    public Cola(int tamaño)
    {
        this.tamaño = tamaño;
        elementos = new int[tamaño];
        frente = 0;
        final = -1;
        cantidad = 0;
    }

    public void Enqueue(int elemento)
    {
        if (cantidad == tamaño)
        {
            Console.WriteLine("Cola llena. No se puede insertar el elemento.");
            return;
        }
        final = (final + 1) % tamaño;
        elementos[final] = elemento;
        cantidad++;
    }
    public int Dequeue()
    {
        if (cantidad == 0)
        {
            Console.WriteLine("Cola vacía. No se puede eliminar ningún elemento.");
            return -1;
        }
        int elemento = elementos[frente];
        frente = (frente + 1) % tamaño;
        cantidad--;
        return elemento;
    }


    public int Peek()
    {
        if (cantidad == 0)
        {
            Console.WriteLine("Cola vacía. No hay elementos para mostrar.");
            return -1;
        }
        return elementos[frente];
    }

    public bool EstaVacia()
    {
        return cantidad == 0;
    }

    public void Mostrar()
    {
        if (cantidad == 0)
        {
            Console.WriteLine("Cola vacía.");
            return;
        }

        Console.Write("Cola: ");
        for (int i = 0; i < cantidad; i++)
            Console.Write(elementos[(frente + i) % tamaño] + " ");
        Console.WriteLine();
    }
}



class Principal
{
    static void Main(string[] args)
    {
        Cola cola = new Cola(5);
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA =====");
            Console.WriteLine("1. Mostrar COLA");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
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
                    cola.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese el número a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                    {

                        cola.Enqueue(numero);
                        Console.WriteLine($"✅ Número {numero} insertado en la cola.");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;
                case 3:
                    int eliminado = cola.Dequeue();
                    if (eliminado != -1)
                        Console.WriteLine($"Número {eliminado} eliminado de la cola.");
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine($" Frente de la cola: {cola.Peek()}");
                    }
                    catch (Exception m)
                    {
                        Console.WriteLine(m.Message);
                    }
                    break;
                case 5:
                    Console.WriteLine(cola.EstaVacia() ? "Cola vacía." : "Cola con elementos.");
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