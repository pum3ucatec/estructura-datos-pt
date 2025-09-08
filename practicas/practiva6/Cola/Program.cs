using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la capacidad de la cola: ");
        int capacidad = int.Parse(Console.ReadLine());

        MyQueue cola = new MyQueue(capacidad);
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA =====");
            Console.WriteLine("1. Mostrar COLA");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Verificar si está llena");
            Console.WriteLine("7. Tamaño de la COLA");
            Console.WriteLine("8. Vaciar COLA");
            Console.WriteLine("9. Buscar elemento");
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
                    Console.Write("Ingrese número: ");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                        cola.Insertar(numero);
                    else
                        Console.WriteLine("Número inválido.");
                    break;
                case 3:
                    int eliminado = cola.Eliminar();
                    if (eliminado != -1)
                        Console.WriteLine("Número eliminado: " + eliminado);
                    break;
                case 4:
                    int frente = cola.VerFrente();
                    if (frente != -1)
                        Console.WriteLine("Frente de la cola: " + frente);
                    break;
                case 5:
                    Console.WriteLine(cola.EstaVacia() ? "La cola está vacía." : "La cola no está vacía.");
                    break;
                case 6:
                    Console.WriteLine(cola.EstaLlena() ? "La cola está llena." : "La cola no está llena.");
                    break;
                case 7:
                    Console.WriteLine("Tamaño de la cola: " + cola.Tamaño());
                    break;
                case 8:
                    cola.Vaciar();
                    break;
                case 9:
                    Console.Write("Ingrese el elemento a buscar: ");
                    if (int.TryParse(Console.ReadLine(), out int elemento))
                        Console.WriteLine(cola.Buscar(elemento) ? "Elemento encontrado." : "Elemento no encontrado.");
                    else
                        Console.WriteLine("Número inválido.");
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}
