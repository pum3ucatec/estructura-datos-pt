using System;

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
            Console.WriteLine("6. Cantidad de elementos en la cola");
            Console.WriteLine("7. Buscar un valor específico (Contains)");
            Console.WriteLine("8. Borrar toda la cola");
            console.WriteLine("9. Elimina un valor especifico de la cola");
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
                        cola.Enqueue(valor);
                    else
                        Console.WriteLine("Valor inválido.");
                    break;
                case 3:
                    string eliminado = cola.Dequeue();
                    if (eliminado != null)
                        Console.WriteLine($"Elemento eliminado: {eliminado}");
                    break;
                case 4:
                    string frente = cola.Peek();
                    if (frente != null)
                        Console.WriteLine($"Elemento en el frente: {frente}");
                    break;
                case 5:
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola NO está vacía.");
                    break;
                case 6:
                    Console.WriteLine($"Cantidad de elementos en la cola: {cola.Count()}");
                break;
                case 7:
                    Console.Write("Ingrese el valor a buscar: ");
                    string buscar = Console.ReadLine();
                    Console.WriteLine(cola.Contains(buscar)
                        ? $"El valor \"{buscar}\" SÍ está en la cola."
                        : $"El valor \"{buscar}\" NO está en la cola.");
                    break;
                case 8:
                    cola.Clear();
                    break; 
                case 9:
                    console.WriteLine("Ingrese el valor a retirar de la cola");
                    int posicion = console.ReadLine();
                    console.WriteLine(cola.delete_p(posicion));
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
