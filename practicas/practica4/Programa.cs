using System;
using System.Collections.Generic;

class MiPila
{
    private Stack<int> datos;

    public MiPila()
    {
        datos = new Stack<int>();
    }

    public void Agregar(int numero)
    {
        datos.Push(numero);
        Console.WriteLine($"Insertado: {numero}");
    }

    public void Quitar()
    {
        if (datos.Count > 0)
        {
            int eliminado = datos.Pop();
            Console.WriteLine($"Eliminado: {eliminado}");
        }
        else
        {
            Console.WriteLine(" La pila está vacía.");
        }
    }

    public int VerTope()
    {
        if (datos.Count > 0)
        {
            return datos.Peek();
        }
        Console.WriteLine(" No hay elementos en la pila.");
        return -1;
    }

    public bool EstaVacia()
    {
        return datos.Count == 0;
    }

    public void Vaciar()
    {
        datos.Clear();
        Console.WriteLine("La pila se limpió por completo.");
    }

    public void MostrarTodo()
    {
        if (datos.Count == 0)
        {
            Console.WriteLine(" La pila está vacía.");
            return;
        }

        Console.WriteLine(" Contenido de la pila (de arriba a abajo):");
        foreach (int item in datos)
        {
            Console.WriteLine(item);
        }
    }
}

class Programa
{
    static void Main()
    {
        MiPila pila = new MiPila();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ PILA =====");
            Console.WriteLine("1. Ver pila");
            Console.WriteLine("2. Insertar elemento");
            Console.WriteLine("3. Eliminar elemento");
            Console.WriteLine("4. Consultar cima");
            Console.WriteLine("5. Revisar si está vacía");
            Console.WriteLine("6. Vaciar pila");
            Console.WriteLine("7. Insertar varios elementos");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine(" Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    pila.MostrarTodo();
                    break;
                case 2:
                    Console.Write("Número a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                        pila.Agregar(valor);
                    else
                        Console.WriteLine("⚠ Valor inválido.");
                    break;
                case 3:
                    pila.Quitar();
                    break;
                case 4:
                    int tope = pila.VerTope();
                    if (tope != -1)
                        Console.WriteLine($"Elemento en la cima: {tope}");
                    break;
                case 5:
                    Console.WriteLine(pila.EstaVacia() ? "La pila está vacía." : "La pila tiene elementos.");
                    break;
                case 6:
                    pila.Vaciar();
                    break;
                case 7:
                    Console.Write("Ingrese los números (separados por espacio): ");
                    string entrada = Console.ReadLine();
                    string[] lista = entrada.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (string val in lista)
                    {
                        if (int.TryParse(val, out int n))
                            pila.Agregar(n);
                        else
                            Console.WriteLine($" '{val}' no es válido.");
                    }
                    break;
                case 0:
                    Console.WriteLine(" Programa finalizado.");
                    break;
                default:
                    Console.WriteLine(" Opción no reconocida.");
                    break;
            }

        } while (opcion != 0);
    }
}
