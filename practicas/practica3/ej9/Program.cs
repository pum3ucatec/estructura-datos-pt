 int[] desordenado = { 8, 3, 5, 1, 9 };
        for (int i = 0; i < desordenado.Length - 1; i++)
        {
            for (int j = 0; j < desordenado.Length - 1 - i; j++)
            {
                if (desordenado[j] > desordenado[j + 1])
                {
                    int temp = desordenado[j];
                    desordenado[j] = desordenado[j + 1];
                    desordenado[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Ejercicio 9:");
        Console.WriteLine($"Arreglo ordenado: [{string.Join(", ", desordenado)}]\n");