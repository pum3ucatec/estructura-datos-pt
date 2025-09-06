using System;
class Ejercicio8 {
    static int Buscar(int[] arreglo, int objetivo) {
        int inicio = 0, fin = arreglo.Length - 1;
        while (inicio <= fin) {
            int mid = (inicio + fin) / 2;
            if (arreglo[mid] == objetivo) return mid;

            if (arreglo[inicio] <= arreglo[mid]) {
                if (objetivo >= arreglo[inicio] && objetivo < arreglo[mid]) fin = mid - 1;
                else inicio = mid + 1;
            } else {
                if (objetivo > arreglo[mid] && objetivo <= arreglo[fin]) inicio = mid + 1;
                else fin = mid - 1;
            }
        }
        return -1;
    }

    static void Main() {
        int[] arreglo = {4,5,6,7,0,1,2};
        int objetivo = 0;
        Console.WriteLine("Índice encontrado: " + Buscar(arreglo, objetivo));
    }
}
