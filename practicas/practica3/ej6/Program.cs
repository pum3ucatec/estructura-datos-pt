int[] numeros = { 4, 9, 12, 6, 17, 20, 3, 11, 8, 5 };

Console.Write("Ingrese un número: ");
int buscado = int.Parse(Console.ReadLine());
bool encontrado = false;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == buscado)
    {
        Console.WriteLine($"El número {buscado} se encuentra en la posición {i}");
        encontrado = true;
        break;
    }
}

if (!encontrado)
{
    Console.WriteLine($"El número {buscado} no se encuentra en el arreglo.");
}
