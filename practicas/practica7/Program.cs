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
            Console.WriteLine("2. Desencolar (Eliminar)");
            Console.WriteLine("3. Ver primer elemento (Peek)");
            Console.WriteLine("4. Ver todos los elementos");
            Console.WriteLine("5. Cantidad de elementos");
            Console.WriteLine("6. ¿Está vacía?");
            Console.WriteLine("7. Vaciar cola (Clear)");
            Console.WriteLine("8. Buscar un nombre (Contains)");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠️ Ingresa un número válido.");
                Console.ResetColor();
                continue;
            }

            Console.WriteLine();
            switch (opcion)
            {
                case 1:
                    Console.Write("👉 Ingresa un nombre: ");
                    string? nombre = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        cola.Enqueue(nombre);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"✔️ '{nombre}' agregado a la cola.");
                        Console.ResetColor();
                    }
                    break;

                case 2:
                    string? eliminado = cola.Dequeue();
                    Console.ForegroundColor = eliminado != null ? ConsoleColor.Red : ConsoleColor.Yellow;
                    Console.WriteLine(eliminado != null
                        ? $"❌ Se eliminó: {eliminado}"
                        : "⚠️ La cola está vacía.");
                    Console.ResetColor();
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"👀 Primero en la cola: {cola.Peek() ?? "Nada, está vacía"}");
                    Console.ResetColor();
                    break;

                case 4:
                    Console.WriteLine("📋 Elementos en la cola:");
                    cola.View();
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"📊 Cantidad de elementos: {cola.Count()}");
                    Console.ResetColor();
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"❓ ¿Está vacía?: {cola.IsEmpty()}");
                    Console.ResetColor();
                    break;

                case 7:
                    cola.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("🧹 Cola vaciada.");
                    Console.ResetColor();
                    break;

                case 8:
                    Console.Write("🔎 Ingresa el nombre a buscar: ");
                    string? buscar = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(buscar))
                    {
                        Console.ForegroundColor = cola.Contains(buscar) ? ConsoleColor.Green : ConsoleColor.Red;
                        Console.WriteLine(cola.Contains(buscar)
                            ? $"✅ La cola contiene a '{buscar}'."
                            : $"❌ La cola NO contiene a '{buscar}'.");
                        Console.ResetColor();
                    }
                    break;

                case 0:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("👋 Saliendo del programa...");
                    Console.ResetColor();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("⚠️ Opción no válida.");
                    Console.ResetColor();
                    break;
            }

        } while (opcion != 0);
    }
}
