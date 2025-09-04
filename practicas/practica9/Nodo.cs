public class Nodo
{
    public string Valor { get; set; }
    public Nodo Siguiente { get; set; }

    public Nodo(string valor, Nodo siguiente = null)
    {
        Valor = valor;
        Siguiente = siguiente;
    }
}
