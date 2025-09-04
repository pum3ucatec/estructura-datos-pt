
// Ingresa 5 calificaciones en un arreglo y calcula el promedio.

double[] calificaciones = new double[5];
        double suma = 0;

        // Pedimos al usuario que ingrese las calificaciones
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.Write("Ingrese la calificación " + (i + 1) + ": ");
            calificaciones[i] = Convert.ToDouble(Console.ReadLine());
            suma += calificaciones[i]; // Acumulamos la suma
        }

        // Calculamos el promedio
        double promedio = suma / calificaciones.Length;

        // Mostramos el resultado
        Console.WriteLine("\nEl promedio de las calificaciones es: " + promedio);