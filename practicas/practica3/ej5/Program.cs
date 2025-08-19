Console.WriteLine("Hello, World!");
       int[] calificaciones = { 80, 70, 90, 60, 100 };
        int sumaCal = 0;
        for (int i = 0; i < calificaciones.Length; i++)
        {
            sumaCal += calificaciones[i];
        }
        double promedio = (double)sumaCal / calificaciones.Length;
        Console.WriteLine("Ejercicio 4:");
        Console.WriteLine($"Notas: [{string.Join(", ", calificaciones)}]");
        Console.WriteLine($"Promedio: {promedio}\n");