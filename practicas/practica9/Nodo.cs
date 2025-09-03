public class Nodo
{
    public string Valor { get; set; }
    public Nodo? Siguiente { get; set; } // Nodo puede ser null

    public Nodo(string valor)
    {
        this.Valor = valor;
        this.Siguiente = null;
    }
}
