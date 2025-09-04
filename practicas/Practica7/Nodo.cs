public class Nodo
{
    public string Data { get; set; }
    public Nodo? Next { get; set; } // puede ser null

    public Nodo(string data)
    {
        Data = data;
        Next = null;
    }
}
