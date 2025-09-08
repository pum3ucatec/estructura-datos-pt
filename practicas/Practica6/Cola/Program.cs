using System;
class Principal
{
    static void Main(string[] args)
    {
        Cola cola = new Cola(5);  // Cola de tamaño 5
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
            Console.WriteLine("7. Ver la cantidad(count)");
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
                    Console.Write("Ingrese el número a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                    {
                        cola.Enqueue(valor);
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar un número válido.");
                    }
                    break;

                case 3:
                    cola.Dequeue();
                    break;

                case 4:
                    int frente = cola.Peek();
                    if (frente != -1)
                        Console.WriteLine("El frente de la cola es: " + frente);
                    break;

                case 5:
                    if (cola.EstaVacia())
                        Console.WriteLine("La cola está vacía.");
                    else
                        Console.WriteLine("La cola NO está vacía.");
                    break;
                case 6:
                    Console.WriteLine(cola.EstaLlena() ? "Sí, está llena" : "No, aún hay espacio");
                    break;
                case 7:
                    Console.WriteLine("Cantidad de elementos: " + cola.Conteo());
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
