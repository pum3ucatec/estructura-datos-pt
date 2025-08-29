public class Nodo
{
    public string Valor { get; set; }
    public Nodo? Next { get; set; }

    public Nodo(string valor)
    {
        Valor = valor;
        Next = null;
    }
}
