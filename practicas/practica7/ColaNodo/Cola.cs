public class Cola
{
    public Nodo front { get; private set; }

    public Nodo rear { get; private set; }

    public Cola()
    {
        this.front = null;
        this.rear = null;
    }

    public void Enqueue(string name)
    {
        Nodo nodo = new Nodo(name);

        if (this.front == null)
        {
            this.front = nodo;
            this.rear = nodo;
        }
        else
        {
            this.rear.Next = nodo;
            this.rear = nodo;
        }
    }

    public void View()
    {
        Nodo current = this.front;

        while (current != null)
        {
            Console.Write($"{current.Name} | ");
            current = current.Next;
        }

    }
}