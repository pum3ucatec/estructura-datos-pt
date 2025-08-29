public class Nodo
{
    public string Name { get; set; }
    public Nodo Next { get; set; }

    public Nodo(string name)
    {
        this.Name = name;
        this.Next = null;
    }
}

// Nodo para la Lista Simple
public class NodoLista
{
    public int Dato { get; set; }
    public NodoLista Siguiente { get; set; }

    public NodoLista(int dato)
    {
        this.Dato = dato;
        this.Siguiente = null;
    }
}