int[] arregloOcurrencias = { 2, 5, 2, 8, 2, 9 };
        Console.WriteLine("Ejercicio 7:");
        Console.WriteLine($"Arreglo: [{string.Join(", ", arregloOcurrencias)}]");
        Console.Write("Número buscado: ");
        int numContar = int.Parse(Console.ReadLine());
        int contador = 0;
        for (int i = 0; i < arregloOcurrencias.Length; i++)
        {
            if (arregloOcurrencias[i] == numContar)
                contador++;
        }
        Console.WriteLine($"El número aparece {contador} veces\n");
