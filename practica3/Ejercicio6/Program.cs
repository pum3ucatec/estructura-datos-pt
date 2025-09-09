using System;

int[] datos = { 4, 9, 15, 6, 17, 2, 8, 13, 20, 5 };
Console.WriteLine("Ingrese un número: ");
int buscado = int.Parse(Console.ReadLine());
bool encontrado = false;

for (int i = 0; i < datos.Length; i++)
{
    if (datos[i] == buscado)
    {
        Console.WriteLine($"El número {buscado} se encuentra en la posición {i}");
        encontrado = true;
        break;
    }
}

if (!encontrado)
{
    Console.WriteLine("El número no se encuentra en el arreglo.");
}