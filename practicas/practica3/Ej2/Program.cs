
// Crea un arreglo de 10 números enteros y muéstralos en consola utilizando un ciclo for.
int[] numeros = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("Estos son los 10 numeros del arreglo");

Console.ResetColor();

for (int i = 0; i < numeros.Length; i++) {
    Console.WriteLine("Numero " + i + ": " + numeros[i]);

    }