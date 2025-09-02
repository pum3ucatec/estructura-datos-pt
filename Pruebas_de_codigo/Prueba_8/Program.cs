using System;

class Program
{
    static void Main()
    {
        // Crear una fila simple con capacidad de 5
        string[] fila = new string[5];
        int frente = 0;   // primer elemento
        int final = -1;   // último elemento
        int cantidad = 0; // cuántos elementos hay en la fila

        // 👉 Colocar (Enqueue) un elemento en la fila
        if (cantidad < fila.Length)
        {
            final++;
            fila[final] = "Persona 1";
            cantidad++;
            Console.WriteLine("Colocado en la fila: Persona 1");
        }

        // 👉 Sacar (Dequeue) un elemento de la fila
        if (cantidad > 0)
        {
            string persona = fila[frente];
            Console.WriteLine("Sale de la fila: " + persona);

            // mover el frente
            frente++;
            cantidad--;
        }

        // Mostrar cuántos quedan en la fila
        Console.WriteLine("Cantidad actual en la fila: " + cantidad);
    }
}
