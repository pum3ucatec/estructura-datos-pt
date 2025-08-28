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
            Console.WriteLine("---------------------");
            Console.WriteLine("[     MENÚ COLA     ]");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Mostrar COLA");
            Console.WriteLine("2. Equeue = Insertar");
            Console.WriteLine("3. Dequeue = Eliminar");
            Console.WriteLine("4. Peek = Ver primer elemento");
            Console.WriteLine("5. Count = Ver cantidad actual");
            Console.WriteLine("6. Size = Ver capacidad máxima");
            Console.WriteLine("7. Contains = Buscar elemento");
            Console.WriteLine("8. IsEmpty = Verificar si está vacía");
            Console.WriteLine("9. IsFull = Verificar si está llena");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione la opción que desea: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1: // Mostrar
                    cola.Mostrar();
                    break;

                case 2: // Enqueue Encolar, Insertar
                    Console.Write("Ingrese un carácter para insertar: ");
                    string entrada = Console.ReadLine();
                    if (!string.IsNullOrEmpty(entrada))
                        cola.Enqueue(entrada[0]);
                    else
                        Console.WriteLine(" Está entrada no es válida.");
                    break;

                case 3: // Dequeue Desencolar, Eliminar
                    char eliminado = cola.Dequeue();
                    if (eliminado != '\0')
                        Console.WriteLine("Se eliminó el carcater: " + eliminado);
                    break;

                case 4: // Peek  Front Ver primer elemento
                    char frente = cola.Peek();
                    if (frente != '\0')
                        Console.WriteLine("El frente de la cola está el caracter: " + frente);
                    break;

                case 5: // Count Cantidad actual y elementos
                    Console.WriteLine("La cantidad actual de elementos es: " + cola.GetCount());
                    break;

                case 6: // Size/Length Capacidad máxima poible
                    Console.WriteLine("La capacidad máxima de la cola es: " + cola.GetSize());
                    break;

                case 7: // Contains Contiene, Buscar si existe un elemento 
                    Console.Write("Ingrese el carácter que desea buscar en la cola: ");
                    string busqueda = Console.ReadLine();
                    if (!string.IsNullOrEmpty(busqueda))
                        Console.WriteLine(" ¿La cola contiene '{0}'?: {1}", busqueda[0], cola.Contains(busqueda[0]));
                    else
                        Console.WriteLine(" La entrada no es válida.");
                    break;

                case 8: // IsEmpty ¿Empty Cola vacía?
                    Console.WriteLine(" ¿La cola está vacía?: " + cola.IsEmpty());
                    break;

                case 9: // IsFull ¿Full Cola llena?
                    Console.WriteLine(" ¿La cola está llena?: " + cola.IsFull());
                    break;

                case 0:
                    Console.WriteLine("  Estas saliendo del programa de colas...");
                    break;

                default:
                    Console.WriteLine(" Está opción no es válida, Imgrese otro caracter.");
                    break;
            }

        } while (opcion != 0);
    }
}   
