class Principal
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA con NODOS =====");
            Console.WriteLine("1. Mostrar Cola (View)");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar frente (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía (IsEmpty)");
            Console.WriteLine("6. Cantidad de elementos (Count)");
            Console.WriteLine("7. Vaciar cola (Clear)");
            Console.WriteLine("8. Buscar elemento (Contains)");
            Console.WriteLine("9. Eliminar por una posición");
            Console.WriteLine("10. Eliminar por búsqueda");
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
                        Console.WriteLine($"'{valor}' insertado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 3:
                    string eliminado = cola.Dequeue();
                    if (eliminado != null)
                    {
                        Console.WriteLine($"Elemento eliminado: {eliminado}");
                    }
                    break;
                case 4:
                    string frente = cola.Peek();
                    if (frente != null)
                    {
                        Console.WriteLine($"Elemento al frente: {frente}");
                    }
                    break;
                case 5:
                    Console.WriteLine($"La cola {(cola.IsEmpty() ? "SÍ" : "NO")} está vacía.");
                    break;
                case 6:
                    Console.WriteLine($"Cantidad de elementos en la cola: {cola.Count}");
                    break;
                case 7:
                    cola.Clear();
                    break;
                case 8:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    if (!string.IsNullOrEmpty(buscar))
                    {
                        bool encontrado = cola.Contains(buscar);
                        Console.WriteLine($"El elemento '{(encontrado ? "SÍ" : "NO")}' se encuentra en la cola.");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido para búsqueda.");
                    }
                    break;
                case 9:
                    Console.Write("Ingrese la posición a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int posicion))
                    {
                        string removido = cola.RemoveAt(posicion);
                        
                    }
                    else
                    {
                        Console.WriteLine("Posición inválida.");
                    }
                    break;
                case 10:
                    Console.Write("Ingrese el nombre a buscar y eliminar: ");
                    string buscarEliminar = Console.ReadLine();
                    if (!string.IsNullOrEmpty(buscarEliminar))
                    {
                        int posicionEncontrada;
                        string eliminadoBusqueda = cola.RemoveAndFindPosition(buscarEliminar, out posicionEncontrada);
                        
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido para búsqueda.");
                    }
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

        } while (opcion != 0);
    }
}