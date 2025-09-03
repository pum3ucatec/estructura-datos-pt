using System;

public class NodoDoble
{
    public string Name { get; set; }
    public NodoDoble Next { get; set; }
    public NodoDoble Prev { get; set; }

    public NodoDoble(string name)
    {
        this.Name = name;
        this.Next = null;
        this.Prev = null;
    }
}
