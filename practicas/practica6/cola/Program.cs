using System;
using System.Collections.Generic;

// Clase que implementa una cola circular de caracteres
class MyQueue
{
    private char[] elementos;
    private int frente;
    private int final;
    private int cantidad;

    public MyQueue(int capacidad)
    {
        elementos = new char[capacidad];
        frente = 0;
        final = -1;
        cantidad = 0;
    }

    public void Enqueue(char valor)
    {
        if (IsFull())
        {
            Console.WriteLine("No se puede agregar, la cola esta llena.");
            return;
        }
        final = (final + 1) % elementos.Length;
        elementos[final] = valor;
        cantidad++;
    }

    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("No se puede eliminar, la cola esta vacia.");
            return;
        }
        char eliminado = elementos[frente];
        frente = (frente + 1) % elementos.Length;
        cantidad--;
        Console.WriteLine("Elemento eliminado: " + eliminado);
    }

    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola esta vacia.");
            return '\0';
        }
        return elementos[frente];
    }

    public bool IsEmpty()
    {
        return cantidad == 0;
    }

    public bool IsFull()
    {
        return cantidad == elementos.Length;
    }

    public int GetCount()
    {
        return cantidad;
    }

    public int GetCapacity()
    {
        return elementos.Length;
    }

    public bool Contains(char valor)
    {
        for (int i = 0; i < cantidad; i++)
        {
            int idx = (frente + i) % elementos.Length;
            if (elementos[idx] == valor) return true;
        }
        return false;
    }

    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola esta vacia.");
            return;
        }

        Console.Write("Elementos en la cola: ");
        for (int i = 0; i < cantidad; i++)
        {
            int idx = (frente + i) % elementos.Length;
            Console.Write(elementos[idx] + " ");
        }
        Console.WriteLine();
    }
}

// Clase principal con menú interactivo
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite la capacidad maxima de la cola: ");
        if (!int.TryParse(Console.ReadLine(), out int capacidad) || capacidad <= 0)
        {
            Console.WriteLine("Valor incorrecto.");
            return;
        }

        MyQueue cola = new MyQueue(capacidad);
        int opcion;

        do
        {
            Console.WriteLine("\n=== MENU DE COLA ===");
            Console.WriteLine("1. Ver elementos");
            Console.WriteLine("2. Agregar elemento");
            Console.WriteLine("3. Quitar elemento");
            Console.WriteLine("4. Ver primer elemento");
            Console.WriteLine("5. Ver si esta vacia");
            Console.WriteLine("6. Numero de elementos");
            Console.WriteLine("7. Capacidad de la cola");
            Console.WriteLine("8. Buscar elemento");
            Console.WriteLine("9. Ver si esta llena");
            Console.WriteLine("0. Salir");
            Console.Write("Ingrese opcion: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Debe digitar un numero valido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    cola.Mostrar();
                    break;

                case 2:
                    Console.Write("Digite un caracter para agregar: ");
                    string dato = Console.ReadLine();
                    if (!string.IsNullOrEmpty(dato) && dato.Length == 1)
                        cola.Enqueue(dato[0]);
                    else
                        Console.WriteLine("Entrada incorrecta, solo un caracter.");
                    break;

                case 3:
                    cola.Dequeue();
                    break;

                case 4:
                    char primero = cola.Peek();
                    if (primero != '\0') Console.WriteLine("Primer elemento: " + primero);
                    break;

                case 5:
                    Console.WriteLine(cola.IsEmpty() ? "La cola esta vacia." : "La cola contiene elementos.");
                    break;

                case 6:
                    Console.WriteLine("Cantidad de elementos: " + cola.GetCount());
                    break;

                case 7:
                    Console.WriteLine("Capacidad de la cola: " + cola.GetCapacity());
                    break;

                case 8:
                    Console.Write("Digite el caracter a buscar: ");
                    string buscar = Console.ReadLine();
                    if (!string.IsNullOrEmpty(buscar) && buscar.Length == 1)
                        Console.WriteLine(cola.Contains(buscar[0]) ? "Elemento encontrado." : "Elemento no encontrado.");
                    else
                        Console.WriteLine("Entrada incorrecta.");
                    break;

                case 9:
                    Console.WriteLine(cola.IsFull() ? "La cola esta llena." : "Aun hay espacio.");
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }

        } while (opcion != 0);
    }
}
