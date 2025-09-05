// En un arreglo de números del `1` al `n`, falta un número. Encuentra cuál es.  
//Ejemplo: `[1, 2, 4, 5, 6]` → Falta `3`.ç
using System;

class Ejercicio4 {
    static void Main() {
        int[] numeros = { 1, 2, 3, 4, 6, 7 };
        int n = numeros.Length + 1;

        int sumaEsperada = n * (n + 1) / 2;
        int sumaActual = 0;

        foreach (int num in numeros) {
            sumaActual += num;
        }

        int faltante = sumaEsperada - sumaActual;
        Console.WriteLine("Número faltante: " + faltante);
    }
}
