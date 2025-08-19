// See https://aka.ms/new-console-template for more information
int[] numeros = { 4, 8, 15, 16, 23, 42, 7, 9, 1, 17 };

Console.Write("Ingrese un número: ");
int numBuscado = int.Parse(Console.ReadLine());

int posicion = -1;
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == numBuscado)
    {
        posicion = i;
        break;
    }
}

if (posicion != -1)
    Console.WriteLine($"El número {numBuscado} se encuentra en la posición {posicion}");
else
    Console.WriteLine($"El número {numBuscado} no se encontró en el arreglo");
