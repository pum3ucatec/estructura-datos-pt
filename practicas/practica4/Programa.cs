﻿using System;
using System.Collections.Generic;

class PilaEnteros
{
    private Stack<int> datos = new Stack<int>();

    public void Insertar(int numero)
    {
        datos.Push(numero);
        Console.WriteLine($"Elemento {numero} agregado a la pila");
    }

    public void InsertarVarios(int cantidad)
    {
        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Ingrese el valor {i}: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int valor))
            {
                Insertar(valor);
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }
    }

    public void Eliminar()
    {
        if (EstaVacia())
        {
            Console.WriteLine("La pila está vacía");
        }
        else
        {
            int eliminado = datos.Pop();
            Console.WriteLine($"Elemento {eliminado} eliminado");
        }
    }

    public int ConsultarTope()
    {
        if (!EstaVacia())
        {
            return datos.Peek();
        }
        Console.WriteLine("No hay tope disponible");
        return -1;
    }

    public bool EstaVacia()
    {
        return datos.Count == 0;
    }

    public void MostrarTodo()
    {
        if (EstaVacia())
        {
            Console.WriteLine("Sin elementos en la pila");
        }
        else
        {
            Console.WriteLine("Elementos en la pila:");
            Console.WriteLine(string.Join(", ", datos));
        }
    }

    public int Cantidad()
    {
        return datos.Count;
    }

    public void Vaciar()
    {
        Console.Write("¿Desea vaciar la pila? (s/n): ");
        string resp = Console.ReadLine().ToLower();
        if (resp == "s")
        {
            datos.Clear();
            Console.WriteLine("Pila vaciada");
        }
        else
        {
            Console.WriteLine("Acción cancelada");
        }
    }
}

class Programa
{
    static void Main()
    {
        PilaEnteros pila = new PilaEnteros();
        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("\n==== MENÚ ====");
            Console.WriteLine("1. Insertar un elemento");
            Console.WriteLine("2. Insertar varios");
            Console.WriteLine("3. Mostrar pila");
            Console.WriteLine("4. Eliminar último");
            Console.WriteLine("5. Consultar tope");
            Console.WriteLine("6. Verificar si está vacía");
            Console.WriteLine("7. Contar elementos");
            Console.WriteLine("8. Vaciar pila");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");

            string entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Opción inválida");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un número: ");
                    if (int.TryParse(Console.ReadLine(), out int num))
                        pila.Insertar(num);
                    else
                        Console.WriteLine("Dato incorrecto");
                    break;

                case 2:
                    Console.Write("¿Cuántos desea ingresar?: ");
                    if (int.TryParse(Console.ReadLine(), out int cant))
                        pila.InsertarVarios(cant);
                    else
                        Console.WriteLine("Número inválido");
                    break;

                case 3:
                    pila.MostrarTodo();
                    break;

                case 4:
                    pila.Eliminar();
                    break;

                case 5:
                    int tope = pila.ConsultarTope();
                    if (tope != -1)
                        Console.WriteLine($"Tope actual: {tope}");
                    break;

                case 6:
                    Console.WriteLine(pila.EstaVacia() ? "Está vacía" : "Tiene elementos");
                    break;

                case 7:
                    Console.WriteLine($"Total: {pila.Cantidad()}");
                    break;

                case 8:
                    pila.Vaciar();
                    break;

                case 0:
                    Console.WriteLine("Fin del programa");
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}