using System;

class Principal
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el tamaño de la cola: ");
        int tamaño;
        while (!int.TryParse(Console.ReadLine(), out tamaño) || tamaño <= 0)
        {
            Console.Write("Tamaño inválido. Ingrese un número entero positivo: ");
        }

        MyQueue cola = new MyQueue(tamaño);
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA =====");
            Console.WriteLine("1. Mostrar COLA");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Ver cantidad de elementos (Count)");
            Console.WriteLine("6. Ver capacidad de la cola (Size)");
            Console.WriteLine("7. Buscar elemento (Contains)");
            Console.WriteLine("8. Verificar si está vacía (IsEmpty)");
            Console.WriteLine("9. Verificar si está llena (IsFull)");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("⚠️ Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1: // Mostrar
                    cola.Mostrar();
                    break;

                case 2: // Enqueue
                    Console.Write("Ingrese un carácter a insertar: ");
                    string entrada = Console.ReadLine();
                    if (!string.IsNullOrEmpty(entrada))
                        cola.Enqueue(entrada[0]);
                    else
                        Console.WriteLine("⚠️ Entrada no válida.");
                    break;

                case 3: // Dequeue
                    char eliminado = cola.Dequeue();
                    if (eliminado != '\0')
                        Console.WriteLine("✅ Se eliminó: " + eliminado);
                    break;

                case 4: // Peek
                    char frente = cola.Peek();
                    if (frente != '\0')
                        Console.WriteLine("👀 El frente de la cola es: " + frente);
                    break;

                case 5: // GetCount
                    Console.WriteLine("📊 Cantidad actual de elementos: " + cola.GetCount());
                    break;

                case 6: // GetSize
                    Console.WriteLine("📏 Capacidad máxima de la cola: " + cola.GetSize());
                    break;

                case 7: // Contains
                    Console.Write("Ingrese el carácter a buscar: ");
                    string busqueda = Console.ReadLine();
                    if (!string.IsNullOrEmpty(busqueda))
                        Console.WriteLine("🔍 ¿La cola contiene '{0}'?: {1}", busqueda[0], cola.Contains(busqueda[0]));
                    else
                        Console.WriteLine("⚠️ Entrada no válida.");
                    break;

                case 8: // IsEmpty
                    Console.WriteLine("❓ ¿Cola vacía?: " + cola.IsEmpty());
                    break;

                case 9: // IsFull
                    Console.WriteLine("❓ ¿Cola llena?: " + cola.IsFull());
                    break;

                case 0:
                    Console.WriteLine("👋 Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("⚠️ Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}


