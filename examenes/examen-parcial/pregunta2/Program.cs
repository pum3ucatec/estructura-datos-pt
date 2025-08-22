// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pregunta 2!");


int[] numeros = { 1, 2, 4, 5, 6 };  // Ejemplo
int faltante = EncontrarFaltante(numeros);

Console.WriteLine("El número que falta es: " + faltante);


static int EncontrarFaltante(int[] arr)
{
    int n = arr.Length + 1; // Porque falta un número
    int sumaEsperada = n * (n + 1) / 2;

    int sumaReal = 0;
    foreach (int num in arr)
        sumaReal += num;

    return sumaEsperada - sumaReal;
}