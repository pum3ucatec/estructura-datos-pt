public class ListasSimples
{
    public Nodo? cabeza = null;

    public void InsertarAlPrincipio(string dato)
    {
        var nuevo = new Nodo(dato);
        nuevo.Siguiente = cabeza;
        cabeza = nuevo;
    }

    public void Mostrar()
    {
        Nodo? actual = cabeza;
        Console.Write("Lista: ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
 
}