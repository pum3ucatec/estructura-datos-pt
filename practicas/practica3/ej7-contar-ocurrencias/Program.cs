// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 7!");



int[] numeros = { 22, 53, 21, 8, 23, 8 };


Console.WriteLine("Arreglo: [" + string.Join(", ", numeros) + "]");


Console.Write("Número buscado: ");
int buscado = Convert.ToInt32(Console.ReadLine());


int contador = 0;
foreach (int num in numeros)
{
    if (num == buscado)
    {
        contador++;
    }
}


Console.WriteLine($"El número aparece {contador} veces");