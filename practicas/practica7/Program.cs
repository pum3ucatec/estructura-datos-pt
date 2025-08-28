﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();
        int opcion;

        do
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("        MENÚ DE COLA");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Mostrar COLA");
            Console.WriteLine("2. Enqueue = Insertar nombre");
            Console.WriteLine("3. Dequeue = Eliminar primero");
            Console.WriteLine("4. RemoveAt = Eliminar por posición");
            Console.WriteLine("5. Peek = Ver primer elemento");
            Console.WriteLine("6. Count = Ver cantidad actual");
            Console.WriteLine("7. Search = Buscar nombre y posición");
            Console.WriteLine("8. Contains = Verificar si existe un nombre");
            Console.WriteLine("9. Clear = Vaciar la cola");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione la opción que desea hacer en la cola: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Está opción es inválida.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    cola.View();
                    break;

                case 2:
                    Console.Write("Ingrese un nombre: ");
                    string nombre = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nombre))
                        cola.Enqueue(nombre);
                    else
                        Console.WriteLine("Este nombre es inválido.");
                    break;

                case 3:
                    string eliminado = cola.Dequeue();
                    if (eliminado != null)
                        Console.WriteLine($"Se eliminó este nombre en la cola: {eliminado}");
                    break;

                case 4:
                    Console.Write("Ingrese la posición que desea eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int pos))
                    {
                        string eliminadoPos = cola.RemoveAt(pos);
                        if (eliminadoPos != null)
                            Console.WriteLine($"Se eliminó: {eliminadoPos}");
                    }
                    else
                    {
                        Console.WriteLine("Posición inválida.");
                    }
                    break;

                case 5:
                    string frente = cola.Peek();
                    Console.WriteLine(frente != null ? $" Frente: {frente}" : " La cola está vacía.");
                    break;

                case 6:
                    Console.WriteLine($" La cola tiene {cola.Count()} elementos.");
                    break;

                case 7:
                    Console.Write("Ingrese el nombre que desea buscar: ");
                    string buscar = Console.ReadLine();
                    int posBuscada = cola.Search(buscar);
                    if (posBuscada != -1)
                        Console.WriteLine($" '{buscar}' se encuentra en la posición {posBuscada}");
                    else
                        Console.WriteLine(" No se encontró ese nombre.");
                    break;

                case 8:
                    Console.Write("Ingrese el nombre a verificar: ");
                    string existe = Console.ReadLine();
                    Console.WriteLine(cola.Contains(existe)
                        ? $" '{existe}' está en la cola."
                        : $" '{existe}' no está en la cola.");
                    break;

                case 9:
                    cola.Clear();
                    Console.WriteLine(" La cola fue vaciada.");
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

