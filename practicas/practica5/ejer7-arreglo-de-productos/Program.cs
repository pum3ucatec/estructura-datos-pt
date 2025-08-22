// Dado un arreglo de enteros, construye un nuevo arreglo donde cada posición contenga el producto de 
// todos los elementos excepto el de esa posición (sin usar división).  
/* el codigo fuunciona asi:
En la posición 0: 4 × 5 × 11 = 220
En la posición 1: 12 × 5 × 11 = 660
En la posición 2: 12 × 4 × 11 = 528
En la posición 3: 12 × 4 × 5 = 240 */

using System;

class Ejercico7 {
    static void Main() {
        int[] arreglo = { 12, 4, 5, 11 };
        int n = arreglo.Length;

        int[] resultado = new int[n];
        int[] izquierda = new int[n];
        int[] derecha = new int[n];

        izquierda[0] = 1;
        for (int i = 1; i < n; i++) {
            izquierda[i] = izquierda[i - 1] * arreglo[i - 1];
        }

        derecha[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--) {
            derecha[i] = derecha[i + 1] * arreglo[i + 1];
        }

        for (int i = 0; i < n; i++) {
            resultado[i] = izquierda[i] * derecha[i];
        }

        Console.WriteLine("Resultado: " + string.Join(", ", resultado));
    }
}

