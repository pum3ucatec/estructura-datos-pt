Console.Write("Ingrese un número N: ");
        int N = int.Parse(Console.ReadLine());
        int suma = 0;
        int contador = 1;
        while (contador <= N)
        {
            suma += contador;
            contador++;
        }
        Console.WriteLine("La suma es: " + suma);
