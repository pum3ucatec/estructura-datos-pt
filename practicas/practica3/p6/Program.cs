int[] numeros = { 3, 7, 10, 17, 5, 8, 12, 20, 1, 9 };
Console.Write("Ingrese un número a buscar: ");
int buscado = int.Parse(Console.ReadLine());

int posicion = -1;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == buscado)
    {
        posicion = i;
        break; // encontramos el número y salimos del bucle
    }
}

if (posicion != -1)
    Console.WriteLine("El número " + buscado + " se encuentra en la posición " + posicion);
else
    Console.WriteLine("El número " + buscado + " no está en el arreglo");
