using System;

class Cola
{
    private int[] elementos;
    private int frente, final, cantidad, tamaño;

    public Cola(int tamaño)
    {
        this.tamaño = tamaño;
        elementos = new int[tamaño];
        frente = 0;
        final = -1;
        cantidad = 0;
    }

    public void Enqueue(int valor)
    {
        if (cantidad == tamaño)
        {
            Console.WriteLine(" Cola llena.");
            return;
        }
        final = (final + 1) % tamaño;
        elementos[final] = valor;
        cantidad++;
    }

    public int Dequeue()
    {
        if (cantidad == 0)
        {
            Console.WriteLine(" Cola vacía.");
            return -1;
        }
        int valor = elementos[frente];
        frente = (frente + 1) % tamaño;
        cantidad--;
        return valor;
    }

    public int Peek()
    {
        if (cantidad == 0)
            throw new InvalidOperationException("Cola vacía.");
        return elementos[frente];
    }

    public bool EstaVacia() => cantidad == 0;

    public bool EstaLlena() => cantidad == tamaño;

    public bool Contiene(int valor)
    {
        for (int i = 0; i < cantidad; i++)
        {
            if (elementos[(frente + i) % tamaño] == valor)
                return true;
        }
        return false;
    }

    public int CapacidadTotal() => tamaño;

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
            Console.WriteLine("5. Verificar la capacidad total de la cola");
            Console.WriteLine("6. Verificar si un elemento existe en la cola");
            Console.WriteLine("7. Verificar si la cola no tiene elementos");
            Console.WriteLine("8. Verificar si la cola está llena");
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
                        Console.WriteLine($" Número {numero} insertado en la cola.");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;

                case 3:
                    int eliminado = cola.Dequeue();
                    if (eliminado != -1)
                        Console.WriteLine($" Se eliminó {eliminado} de la cola.");
                    break;

                case 4:
                    try
                    {
                        Console.WriteLine($" Frente de la cola: {cola.Peek()}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;

                case 5:
                    Console.WriteLine($" Capacidad total de la cola: {cola.CapacidadTotal()} elementos.");
                    break;

                case 6:
                    Console.Write("Ingrese el número a buscar en la cola: ");
                    if (int.TryParse(Console.ReadLine(), out int buscado))
                    {
                        Console.WriteLine(cola.Contiene(buscado)
                            ? $" El número {buscado} está en la cola."
                            : $" El número {buscado} NO está en la cola.");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;

                case 7:
                    Console.WriteLine(cola.EstaVacia() ? " La cola no tiene elementos." : " La cola tiene elementos.");
                    break;

                case 8:
                    Console.WriteLine(cola.EstaLlena() ? " La cola está llena." : " La cola NO está llena.");
                    break;

                case 0:
                    Console.WriteLine(" Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine(" Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}
