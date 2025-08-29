using System;

class Program
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();
        ListaSimple lista = new ListaSimple();
        int opcion;

        do
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("        MENÚ PRINCIPAL");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Mostrar COLA");
            Console.WriteLine("2. Enqueue = Insertar nombre en cola");
            Console.WriteLine("3. Dequeue = Eliminar primero en cola");
            Console.WriteLine("4. RemoveAt = Eliminar por posición en cola");
            Console.WriteLine("5. Peek = Ver primer elemento en cola");
            Console.WriteLine("6. Count = Ver cantidad actual en cola");
            Console.WriteLine("7. Search = Buscar nombre y posición en cola");
            Console.WriteLine("8. Contains = Verificar si existe un nombre en cola");
            Console.WriteLine("9. Clear = Vaciar la cola");
            Console.WriteLine("10. Insertar al principio en Lista Simple");
            Console.WriteLine("11. Eliminar alrededor de un valor en Lista Simple");
            Console.WriteLine("12. Mostrar Lista Simple");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione la opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine(" Opción inválida.");
                continue;
            }

            switch (opcion)
            {
                case 1: cola.View(); break;

                case 2:
                    Console.Write("Ingrese un nombre: ");
                    string nombre = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nombre))
                        cola.Enqueue(nombre);
                    else
                        Console.WriteLine(" Nombre inválido.");
                    break;

                case 3:
                    string eliminado = cola.Dequeue();
                    if (eliminado != null)
                        Console.WriteLine($" Se eliminó: {eliminado}");
                    break;

                case 4:
                    Console.Write("Ingrese la posición a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int pos))
                    {
                        string eliminadoPos = cola.RemoveAt(pos);
                        if (eliminadoPos != null)
                            Console.WriteLine($" Se eliminó: {eliminadoPos}");
                    }
                    else Console.WriteLine(" Posición inválida.");
                    break;

                case 5:
                    string frente = cola.Peek();
                    Console.WriteLine(frente != null ? $" Frente: {frente}" : " Cola vacía.");
                    break;

                case 6:
                    Console.WriteLine($" La cola tiene {cola.Count()} elementos.");
                    break;

                case 7:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    int posBuscada = cola.Search(buscar);
                    Console.WriteLine(posBuscada != -1
                        ? $" '{buscar}' está en la posición {posBuscada}"
                        : " No se encontró ese nombre.");
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
                    Console.WriteLine(" Cola vaciada.");
                    break;

                case 10:
                    Console.Write("Ingrese un número para insertar al principio: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                        lista.InsertarAlPrincipio(valor);
                    else
                        Console.WriteLine(" Valor inválido.");
                    break;

                case 11:
                    Console.Write("Ingrese el valor para eliminar alrededor: ");
                    if (int.TryParse(Console.ReadLine(), out int v))
                        lista.EliminarAlrededor(v);
                    else
                        Console.WriteLine(" Valor inválido.");
                    break;

                case 12:
                    lista.Mostrar();
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

