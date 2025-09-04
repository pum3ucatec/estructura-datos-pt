using System;

class Programa
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ LISTA SIMPLE =====");
            Console.WriteLine("1. Mostrar lista");
            Console.WriteLine("2. Insertar al inicio");
            Console.WriteLine("3. Insertar al final");
            Console.WriteLine("4. Eliminar un elemento");
            Console.WriteLine("5. Buscar un elemento");
            Console.WriteLine("6. Contar elementos");
            Console.WriteLine("7. Verificar si está vacía");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");

            string entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Error: debe ingresar un número.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    lista.Mostrar();
                    break;

                case 2:
                    Console.Write("Valor para insertar al inicio: ");
                    lista.InsertarInicio(Console.ReadLine());
                    break;

                case 3:
                    Console.Write("Valor para insertar al final: ");
                    lista.InsertarFinal(Console.ReadLine());
                    break;

                case 4:
                    Console.Write("Valor a eliminar: ");
                    lista.Eliminar(Console.ReadLine());
                    break;

                case 5:
                    Console.Write("Valor a buscar: ");
                    string buscado = Console.ReadLine();
                    Console.WriteLine(lista.Contiene(buscado)
                        ? $"El elemento '{buscado}' está en la lista."
                        : $"El elemento '{buscado}' no se encuentra en la lista.");
                    break;

                case 6:
                    Console.WriteLine($"Cantidad de elementos: {lista.Contar()}");
                    break;

                case 7:
                    Console.WriteLine(lista.EstaVacia()
                        ? "La lista está vacía."
                        : "La lista contiene elementos.");
                    break;

                case 0:
                    Console.WriteLine("Fin del programa.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }
}
