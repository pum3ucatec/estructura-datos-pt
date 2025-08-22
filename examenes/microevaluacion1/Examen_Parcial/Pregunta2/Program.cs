
// Encontrar el Número que Falta En un arreglo de números del 1 al n, falta un número. Encuentra cuál es. Ejemplo: [1, 2, 4, 5, 6] → Falta 3.


        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 9 };
        int n = arr.Length + 1;
        int sumaTotal = n * (n + 1) / 2;
        int sumaArr = 0;

        foreach (int num in arr)
        {
            sumaArr += num;
        }

        int faltante = sumaTotal - sumaArr;
        Console.WriteLine("El número faltante es: " + faltante);
 