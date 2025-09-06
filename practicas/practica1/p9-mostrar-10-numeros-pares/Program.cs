using System;
class Ejercicio9
{
    static void Main()
    {
        int i = 1;
        int cont = 0;

        while (cont < 10)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                cont++;
            }
            i++;
        }
    }
}