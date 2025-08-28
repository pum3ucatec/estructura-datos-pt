using System;

class Principal
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ DE COLA (NODOS) =====");
            Console.WriteLine("1. Mostrar Cola");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver Frente (Peek)");
            Console.WriteLine("5. Verificar si está Vacía");
            Console.WriteLine("6. Contar Elementos");
            Console.WriteLine("7. Limpiar Cola (Clear)");
            Console.WriteLine("8. Buscar en la Cola (Contains)");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("⚠️ Entrada inválida. Por favor ingrese un número.");
                continue;
            }

            Console.WriteLine(); // Espacio visual

            switch (opcion)
            {
                case 1:
                    cola.View();
                    break;

                case 2:
                    Console.Write("Ingrese el valor a insertar: ");
                    string valor = Console.ReadLine()?.Trim();
                    if (!string.IsNullOrEmpty(valor))
                    {
                        cola.Enqueue(valor);
                        Console.WriteLine($"✅ '{valor}' fue insertado en la cola.");
                    }
                    else
                    {
                        Console.WriteLine("⚠️ Valor inválido. No se insertó en la cola.");
                    }
                    break;

                case 3:
                    string eliminado = cola.Dequeue();
                    if (eliminado != null)
                        Console.WriteLine($"✅ Elemento eliminado: {eliminado}");
                    else
                        Console.WriteLine("⚠️ No se pudo eliminar. La cola está vacía.");
                    break;

                case 4:
                    string frente = cola.Peek();
                    if (frente != null)
                        Console.WriteLine($"👀 Elemento al frente: {frente}");
                    else
                        Console.WriteLine("⚠️ La cola está vacía, no hay frente.");
                    break;

                case 5:
                    Console.WriteLine(cola.IsEmpty()
                        ? "ℹ️ La cola está vacía."
                        : "ℹ️ La cola tiene elementos.");
                    break;

                case 6:
                    Console.WriteLine($"📊 Cantidad de elementos en la cola: {cola.Count()}");
                    break;

                case 7:
                    cola.Clear();
                    Console.WriteLine("✅ La cola fue limpiada correctamente.");
                    break;

                case 8:
                    Console.Write("Ingrese el valor a buscar: ");
                    string buscar = Console.ReadLine()?.Trim();
                    if (!string.IsNullOrEmpty(buscar))
                    {
                        bool encontrado = cola.Contains(buscar);
                        Console.WriteLine(encontrado
                            ? $"🔎 El valor '{buscar}' está en la cola."
                            : $"❌ El valor '{buscar}' no se encontró en la cola.");
                    }
                    else
                    {
                        Console.WriteLine("⚠️ Valor inválido para búsqueda.");
                    }
                    break;

                case 0:
                    Console.WriteLine("👋 Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("⚠️ Opción no válida. Intente de nuevo.");
                    break;
            }

        } while (opcion != 0);
    }
}
