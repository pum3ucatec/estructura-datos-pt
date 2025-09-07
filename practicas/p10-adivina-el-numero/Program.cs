Random rnd = new Random();
int secreto = rnd.Next(1, 51); // Número aleatorio entre 1 y 50
int intento;

do
{
    Console.Write("Adivina el número (1-50): ");
    intento = int.Parse(Console.ReadLine());

    if (intento > secreto)
    {
        Console.WriteLine("El número secreto es menor.");
    }
    else if (intento < secreto)
    {
        Console.WriteLine("El número secreto es mayor.");
    }

} while (intento != secreto);

Console.WriteLine("🎉 ¡Correcto! Has adivinado el número.");
