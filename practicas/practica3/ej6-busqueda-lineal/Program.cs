// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 6!");


int[] numeros = { 5, 8, 12, 3, 17, 25, 10, 30, 7, 20 };

Console.Write("Ingrese un número: ");
int buscado = Convert.ToInt32(Console.ReadLine());


int posicion = -1;


for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == buscado)
    {
        posicion = i;
        break;
    }
}


if (posicion != -1)
{
    Console.WriteLine($"El número {buscado} se encuentra en la posición {posicion}");
}
else
{
    Console.WriteLine($"El número {buscado} NO se encuentra en el arreglo");
}