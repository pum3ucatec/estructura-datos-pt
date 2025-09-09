using System;

/// Programa principal que prueba la lista doblemente enlazada
public class Program
{
    public static void Main()
    {
        ListaDoble lista = new ListaDoble();

        lista.InsertarAlInicio(20);
        lista.InsertarAlInicio(10);
        lista.InsertarAlFinal(30);
        lista.InsertarAlFinal(40);

        Console.WriteLine("Recorrido hacia adelante:");
        lista.MostrarAdelante();

        Console.WriteLine("Recorrido hacia atrás:");
        lista.MostrarAtras();

        Console.WriteLine("Eliminando el 30...");
        lista.Eliminar(30);

        Console.WriteLine("Lista después de eliminar:");
        lista.MostrarAdelante();
    }
}
