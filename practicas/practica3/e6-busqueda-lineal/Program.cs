int[] datos = { 5, 9, 12, 17, 21, 30, 42, 55, 60, 75 };

Console.Write("Ingrese un número: ");
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
    Console.WriteLine("Número no encontrado en el arreglo.");
}
