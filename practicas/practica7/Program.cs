using System;

class Program
{
    static void Main()
    {
        Cola cola = new Cola();
        int opcion;

        do
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== MENÚ DE COLA =====");
            Console.ResetColor();
            Console.WriteLine("1. Encolar (Agregar)");
            Console.WriteLine("2. Eliminar un nombre específico");
            Console.WriteLine("3. Ver primer elemento (Peek)");
            Console.WriteLine("4. Ver todos los elementos con posición");
            Console.WriteLine("5. Cantidad de elementos");
            Console.WriteLine("6. Vaciar cola (Clear)");
            Console.WriteLine("7. Buscar nombres (uno o varios)");
            Console.WriteLine("8. Ver último elemento de la cola");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Ingresa un número válido.");
                Console.ResetColor();
                continue;
            }

            Console.WriteLine();
            switch (opcion)
            {
                case 1:
                    Console.Write(" Ingresa un nombre: ");
                    string? nombre = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        cola.Enqueue(nombre);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" '{nombre}' agregado a la cola.");
                        Console.ResetColor();
                    }
                    break;

                case 2:
                    Console.Write(" Ingresa el nombre a eliminar: ");
                    string? nombreEliminar = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nombreEliminar))
                    {
                        bool eliminado = cola.Remove(nombreEliminar);
                        Console.ForegroundColor = eliminado ? ConsoleColor.Red : ConsoleColor.Yellow;
                        Console.WriteLine(eliminado
                            ? $" '{nombreEliminar}' eliminado de la cola."
                            : $" '{nombreEliminar}' no se encontró en la cola.");
                        Console.ResetColor();
                    }
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Primero en la cola: {cola.Peek() ?? "Nada, está vacía"}");
                    Console.ResetColor();
                    break;

                case 4:
                    Console.WriteLine(" Elementos en la cola con su posición:");
                    Nodo? actual = cola.Front;
                    int pos = 1;
                    while (actual != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{pos}. {actual.Dato}");
                        Console.ResetColor();
                        actual = actual.Siguiente;
                        pos++;
                    }
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($" Cantidad de elementos: {cola.Count()}");
                    Console.ResetColor();
                    break;

                case 6:
                    cola.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Cola vaciada.");
                    Console.ResetColor();
                    break;

                case 7:
                    Console.Write("🔎 Ingresa los nombres a buscar (separados por coma): ");
                    string? entrada = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(entrada))
                    {
                        string[] nombres = entrada.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                        foreach (string n in nombres)
                        {
                            int posicion = cola.IndexOf(n);
                            if (posicion != -1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($" '{n}' está en la fila {posicion} de la cola.");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($" '{n}' NO está en la cola.");
                            }
                        }
                        Console.ResetColor();
                    }
                    break;

                case 8:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($" Último en la cola: {cola.Last() ?? "Nada, está vacía"}");
                    Console.ResetColor();
                    break;

                case 0:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" Saliendo del programa...");
                    Console.ResetColor();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Opción no válida.");
                    Console.ResetColor();
                    break;
            }

        } while (opcion != 0);
    }
}
