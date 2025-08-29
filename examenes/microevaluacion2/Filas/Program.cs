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
            /*console.WriteLine("4. Elimina un valor especifico de la cola");*/
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
                        cola.insert(valor);
                    else
                        Console.WriteLine("Valor inválido.");
                    break;
                case 3:
                    string eliminado = cola.Eliminar();
                    if (eliminado != null)
                        Console.WriteLine($"Elemento eliminado: {eliminado}");
                    break; 
                /*case 4:
                    console.WriteLine("Ingrese el valor a retirar de la cola");
                    int posicion = console.ReadLine();
                    console.WriteLine(cola.delete_p(posicion));
                    break;*/               
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
