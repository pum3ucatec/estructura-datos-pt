using System;

class ProgramaCola
{
    static void Main(string[] args)
    {
        Console.Write("Defina la capacidad de la cola: ");
        if (!int.TryParse(Console.ReadLine(), out int limite) || limite <= 0)
        {
            Console.WriteLine("Capacidad no válida. Fin del programa.");
            return;
        }

        ColaCaracteres miCola = new ColaCaracteres(limite);
        int seleccion;

        do
        {
            Console.WriteLine("\n=== GESTIÓN DE COLA DE CARACTERES ===");
            Console.WriteLine("1) Ver elementos de la cola");
            Console.WriteLine("2) Agregar un carácter");
            Console.WriteLine("3) Quitar un carácter");
            Console.WriteLine("4) Consultar el primer carácter");
            Console.WriteLine("5) ¿Está vacía la cola?");
            Console.WriteLine("6) ¿Cuántos elementos hay?");
            Console.WriteLine("7) ¿Cuál es la capacidad máxima?");
            Console.WriteLine("8) Buscar un carácter");
            Console.WriteLine("9) ¿La cola está llena?");
            Console.WriteLine("0) Salir del programa");
            Console.Write("Opción elegida: ");

            if (!int.TryParse(Console.ReadLine(), out seleccion))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                continue;
            }

            switch (seleccion)
            {
                case 1:
                    miCola.VerCola();
                    break;
                case 2:
                    Console.Write("Carácter a insertar: ");
                    string dato = Console.ReadLine();
                    if (!string.IsNullOrEmpty(dato) && dato.Length == 1)
                    {
                        miCola.Insertar(dato[0]);
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar solo un carácter.");
                    }
                    break;
                case 3:
                    miCola.Eliminar();
                    break;
                case 4:
                    char primero = miCola.Frente();
                    if (primero != '\0')
                        Console.WriteLine($"Carácter al frente: '{primero}'");
                    break;
                case 5:
                    Console.WriteLine(miCola.EstaVacia() ? "La cola está vacía." : "Hay elementos en la cola.");
                    break;
                case 6:
                    Console.WriteLine($"Elementos en cola: {miCola.Cantidad()}");
                    break;
                case 7:
                    Console.WriteLine($"Capacidad total: {miCola.Capacidad()}");
                    break;
                case 8:
                    Console.Write("Carácter a buscar: ");
                    string busqueda = Console.ReadLine();
                    if (!string.IsNullOrEmpty(busqueda) && busqueda.Length == 1)
                    {
                        Console.WriteLine(miCola.Buscar(busqueda[0]) ? "El carácter está presente." : "No se encontró el carácter.");
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                    break;
                case 9:
                    Console.WriteLine(miCola.EstaLlena() ? "La cola está llena." : "Aún hay espacio disponible.");
                    break;
                case 0:
                    Console.WriteLine("Finalizando ejecución...");
                    break;
                default:
                    Console.WriteLine("Opción no reconocida.");
                    break;
            }

        } while (seleccion != 0);
    }
}
