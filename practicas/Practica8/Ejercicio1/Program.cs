using System;

/// Clase principal que ejecuta el programa de ejemplo.
public class Program
{
    public static void Main()
    {
        ListaEnlazada MiLista = new ListaEnlazada();

        // Inserción al principio de la lista
        MiLista.InsertarAlPrincipio(30);
        MiLista.InsertarAlPrincipio(20);
        MiLista.InsertarAlPrincipio(10);

        Console.WriteLine("Lista enlazada:");
        MiLista.Mostrar();
    }
}
