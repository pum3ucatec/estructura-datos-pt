using System;
using System.Collections.Generic;

class MiPila
{
    private Stack<int> elementos = new Stack<int>();

    public void Agregar(int numero)
    {
        elementos.Push(numero);
        Console.WriteLine($"[{numero}] añadido a la pila.");
    }

    public void AgregarVarios(int cantidad)
    {
        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Introduce el valor {i}: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int valor))
            {
                Agregar(valor);
            }
            else
            {
                Console.WriteLine("Entrada no válida. Se omite este valor.");
            }
        }
    }

    public void Quitar()
    {
        if (EstaVacia())
        {
            Console.WriteLine("No hay elementos para quitar. La pila está vacía.");
        }
        else
        {
            int quitado = elementos.Pop();
            Console.WriteLine($"Elemento {quitado} eliminado.");
        }
    }

    public int VerTope()
    {
        if (!EstaVacia())
        {
            return elementos.Peek();
        }

        Console.WriteLine("No se puede mostrar el tope: pila vacía.");
        return -1;
    }

    public bool EstaVacia()
    {
        return elementos.Count == 0;
    }

    public void VerTodo()
    {
        if (EstaVacia())
        {
            Console.WriteLine("Pila vacía. Nada que mostrar.");
        }
        else
        {
            Console.WriteLine("Contenido actual de la pila:");
            foreach (int num in elementos)
            {
                Console.WriteLine($"- {num}");
            }
        }
    }

    public int Total()
    {
        return elementos.Count;
    }

    public void Vaciar()
    {
        elementos.Clear();
        Console.WriteLine("Todos los elementos fueron eliminados.");
    }
}

class Programa
{
    static void Main()
    {
        MiPila pilaUsuario = new MiPila();
        int eleccion = -1;

        while (eleccion != 0)
        {
            Console.WriteLine("\n===== MENÚ DE PILA PERSONALIZADA =====");
            Console.WriteLine("1. Ver pila");
            Console.WriteLine("2. Añadir un elemento");
            Console.WriteLine("3. Quitar el último");
            Console.WriteLine("4. Consultar el tope");
            Console.WriteLine("5. ¿Está vacía?");
            Console.WriteLine("6. Total de elementos");
            Console.WriteLine("7. Vaciar la pila");
            Console.WriteLine("8. Añadir múltiples elementos");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            string input = Console.ReadLine();
            if (!int.TryParse(input, out eleccion))
            {
                Console.WriteLine("Entrada inválida. Intenta con un número.");
                continue;
            }

            switch (eleccion)
            {
                case 1:
                    pilaUsuario.VerTodo();
                    break;

                case 2:
                    Console.Write("Introduce un número: ");
                    if (int.TryParse(Console.ReadLine(), out int nuevo))
                    {
                        pilaUsuario.Agregar(nuevo);
                    }
                    else
                    {
                        Console.WriteLine("Dato incorrecto.");
                    }
                    break;

                case 3:
                    pilaUsuario.Quitar();
                    break;

                case 4:
                    int tope = pilaUsuario.VerTope();
                    if (tope != -1)
                    {
                        Console.WriteLine($"El tope actual es: {tope}");
                    }
                    break;

                case 5:
                    Console.WriteLine(pilaUsuario.EstaVacia() ? "Sí, la pila está vacía." : "No, la pila tiene elementos.");
                    break;

                case 6:
                    Console.WriteLine($"Número total de elementos: {pilaUsuario.Total()}");
                    break;

                case 7:
                    pilaUsuario.Vaciar();
                    break;

                case 8:
                    Console.Write("¿Cuántos elementos quieres ingresar?: ");
                    if (int.TryParse(Console.ReadLine(), out int cantidad))
                    {
                        pilaUsuario.AgregarVarios(cantidad);
                    }
                    else
                    {
                        Console.WriteLine("Cantidad no válida.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Finalizando el programa. ¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción desconocida. Intenta nuevamente.");
                    break;
            }
        }
    }
}
