using System;

class Principal
{
    static void Main(string[] args)
    {
        int tamanio;
        Console.WriteLine("===== CONFIGURACIÓN DE LA COLA =====");
        Console.Write("Ingrese el tamaño maximo de la cola: ");

        while (!int.TryParse(Console.ReadLine(), out tamanio) || tamanio <= 0)
        {
            Console.WriteLine("Debe ingresar un número entero positivo.");
            Console.Write("Ingrese el tamaño maximo de la cola: ");
        }
        MyQueue cola = new MyQueue(tamanio);
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA =====");
            Console.WriteLine("1. Mostrar COLA");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
			Console.WriteLine("6. Insertar varios elementos");
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
                    Console.Write("Ingrese el carácter a insertar: ");
                    char valor;
                    if (char.TryParse(Console.ReadLine(), out valor))
                        cola.Enqueue(valor);
                    else
                        Console.WriteLine("Debe ingresar un solo carácter.");
                    break;
                case 3:
                    cola.Dequeue();
                    break;
                case 4:
                    char frente = cola.Peek();
                    if (frente != '\0')
                        Console.WriteLine($"Frente de la cola: {frente}");
                    break;
                case 5:
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola NO está vacía.");
                    break;
				 case 6:
                    Console.Write("Ingrese varios caracteres separados por espacio: ");
                    string entrada = Console.ReadLine();
                    string[] elementos = entrada.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (var e in elementos)
                    {
                        if (e.Length == 1) 
                            cola.Enqueue(e[0]);
                        else
                            Console.WriteLine($"'{e}' no es un carácter válido.");
                    }
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
