public class Nodo
{
    public string Value { get; set; }
    public Nodo Next { get; set; }

    public Nodo(string value)
    {
        Value = value;
        Next = null;
    }
}

