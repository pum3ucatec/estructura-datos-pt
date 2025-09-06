using System;
class Ejercicio10
{
    static void Main()
    {
        Random rnd = new Random();
        int num_secreto = rnd.Next(1, 51); 
        int num_intento;

        do
        {
            Console.Write("Adivina el número del 1 al 50: ");
            num_intento = int.Parse(Console.ReadLine());

            if (num_intento < num_secreto)
                Console.WriteLine("Fallaste! Es mayor");
            else if (num_intento > num_secreto)
                Console.WriteLine("Fallaste! Es menor");

        } while (num_intento != num_secreto);

        Console.WriteLine("¡Correcto, Ganaste! El número era " + num_secreto);
    }
}