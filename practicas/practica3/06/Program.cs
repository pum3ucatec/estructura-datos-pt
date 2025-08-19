int[] arreglo = { 10, 15, 20, 17, 25, 30, 40, 50, 60, 70 };
int buscado = 17;
bool encontrado = false;

for (int i = 0; i < arreglo.Length; i++)
{
    if (arreglo[i] == buscado)
    {
        Console.WriteLine("El número " + buscado + " se encuentra en la posición " + i);
        encontrado = true;
        break;
    }
}

if (!encontrado)
    Console.WriteLine("Número no encontrado.");
