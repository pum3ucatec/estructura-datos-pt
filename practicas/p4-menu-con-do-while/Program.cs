        int opcion;
        do
        {
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar 2 números");
            Console.WriteLine("3. Salir");
            Console.Write("Elija una opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
                Console.WriteLine("¡Hola!");
            else if (opcion == 2)
            {
                Console.Write("Ingrese número 1: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Ingrese número 2: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"La suma es {a + b}");
            }
        } while (opcion != 3);