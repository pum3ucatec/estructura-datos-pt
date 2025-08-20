
// Crea un programa que lea 8 números en un arreglo y muestre el mayor y el menor.
int[] numeros = new int[8];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write(" Ingresa un numero " + (i + 1) + " : ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

int mayor = numeros[0];
int menor = numeros[0];


for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] > mayor)
        mayor = numeros[i];

    if (numeros[i] < menor)
        menor = numeros[i];
}

Console.WriteLine("/n El siguiente numero es mayor :" + mayor);
Console.WriteLine("/n El siguiente numero es menor :" + menor);