// Declara un arreglo de 5 enteros y asígnales valores manualmente. 
//Luego imprime todos los valores en pantalla/


int[] numeros = { 30, 60, 90, 120, 150 };

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("///Estos son los numeros del arreglo///");

Console.ResetColor();

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}