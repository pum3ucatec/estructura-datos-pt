class Principal
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA con NODOS =====");
            Console.WriteLine("1. Mostrar Cola");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Contar elementos");
            Console.WriteLine("7. Limpiar cola");
            Console.WriteLine("8. Buscar si existe un elemento");
            Console.WriteLine("9. Buscar elemento y mostrar posición");
            Console.WriteLine("10. Eliminar elemento por posición");
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
                    cola.View();
                    break;

                case 2:
                    Console.Write("Ingrese el nombre a insertar: ");
                    string valor = Console.ReadLine();
                    if (!string.IsNullOrEmpty(valor))
                    {
                        cola.Enqueue(valor);
                        Console.WriteLine("Elemento insertado.");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;

                case 3:
                    string eliminado = cola.Dequeue();
                    if (eliminado != null)
                        Console.WriteLine($"Elemento eliminado: {eliminado}");
                    break;

                case 4:
                    string frente = cola.Peek();
                    if (frente != null)
                        Console.WriteLine($"Elemento al frente: {frente}");
                    break;

                case 5:
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola NO está vacía.");
                    break;

                case 6:
                    Console.WriteLine($"Cantidad de elementos en la cola: {cola.Count()}");
                    break;

                case 7:
                    cola.Clear();
                    Console.WriteLine("Cola limpiada.");
                    break;

                case 8:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    if (cola.Contains(buscar))
                        Console.WriteLine("Elemento encontrado en la cola.");
                    else
                        Console.WriteLine("Elemento NO encontrado.");
                    break;

                case 9:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string nombreBuscar = Console.ReadLine();
                    int pos = cola.BuscarElementoConPosicion(nombreBuscar);
                    if (pos != -1)
                        Console.WriteLine($"Elemento '{nombreBuscar}' encontrado en la posición {pos}.");
                    else
                        Console.WriteLine("Elemento no encontrado.");
                    break;

                case 10:
                    Console.Write("Ingrese la posición del elemento a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int posicionEliminar))
                    {
                        string eliminadoPorPos = cola.EliminarPorPosicion(posicionEliminar);
                        if (eliminadoPorPos != null)
                            Console.WriteLine($"Elemento eliminado: {eliminadoPorPos}");
                        else
                            Console.WriteLine("No se pudo eliminar. Posición inválida.");
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un número válido.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}
