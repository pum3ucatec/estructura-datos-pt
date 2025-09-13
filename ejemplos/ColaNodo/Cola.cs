public class Cola
{
    public Nodo Front { get; private set; }

    public Nodo Rear { get; private set; }

    public Cola()
    {
        this.Front = null;
        this.Rear = null;
    }

    public void Enqueue(string name)
    {
        Nodo nodo = new Nodo(name);

        if (this.Front == null)
        {
            this.Front = nodo;
            this.Rear = nodo;
        }
        else
        {
            this.Rear.Next = nodo;
            this.Rear = nodo;
        }
    }

    public void View()
    {
        Nodo current = this.Front;

        while (current != null)
        {
            Console.Write($"{current.Name} | ");
            current = current.Next;
        }

    }
}