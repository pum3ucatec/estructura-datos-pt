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
            Console.WriteLine("5. Verificar si esta vacia (IsEmpity)");
            Console.WriteLine("6. Contar elementos de la lista (Count)");
            Console.WriteLine("7. Limpiar cola (Clear)");
            Console.WriteLine("8. Buscar un elemento(Countains)");
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
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 3:
                    cola.Dequeue();
                    break;
                case 4:
                    cola.Peek();
                    break;
                case 5:
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía " : "La cola no está vacía.");
                    break;
                case 6:
                    cola.Count();
                    Console.WriteLine($"La cola tiene {cola.Count()} elementos.");
                    break;
                case 7:
                    cola.Clear();
                    Console.WriteLine("La cola ha sido limpiada.");
                    break; 
                case 8:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string elemento = Console.ReadLine();
                    int pos = cola.Contains(elemento);
                    if (pos != -1)
                        Console.WriteLine($"El elemento está en la posición {pos}");
                    else
                        Console.WriteLine("El elemento no está en la cola.");
                    break;
                case 0:
                    break;
                default:
                    break;
            }

        } while (opcion != 0);
    }
}