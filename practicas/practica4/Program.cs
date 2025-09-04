class Principal
{
    static void Main(string[] args)
    {
        Pila pila = new Pila();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ PILA =====");
            Console.WriteLine("1. Mostrar pila");
            Console.WriteLine("2. Insertar (Push)");
            Console.WriteLine("3. Eliminar (Pop)");
            Console.WriteLine("4. Ver cima (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Vaciar la pila (Clear)");
            Console.WriteLine("7. Insertar varios datos");
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
                    pila.Mostrar();
                    break;

                case 2:
                    Console.Write("Ingrese el número a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                    {
                        pila.Push(valor);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;

                case 3:
                    pila.Pop();
                    break;

                case 4:
                    int cima = pila.Peek();
                    if (cima != -1)
                        Console.WriteLine($"Elemento en la cima: {cima}");
                    break;

                case 5:
                    Console.WriteLine(pila.IsEmpty() ? "La pila está vacía." : "La pila NO está vacía.");
                    break;

                case 6:
                    pila.Clear();  
                    break;

                case 7:
                    Console.Write("Ingrese la cantidad de números que quiere insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int cont))
                    {
                        for (int i = 0; i < cont; i++) 
                        {
                            Console.Write($"Ingrese el número {i + 1}: ");
                            if (int.TryParse(Console.ReadLine(), out int valorMultiple))
                            {
                                pila.Push(valorMultiple);
                            }
                            else
                            {
                                Console.WriteLine("Valor invál ido.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cantidad inválida.");
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
