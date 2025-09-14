public class Nodo
{
    public string nombre;
    public Nodo next;
    public Nodo prev;

    public Nodo(string nombre)
    {
        this.nombre = nombre;
        this.next = null;
        this.prev = null;
    }
}
