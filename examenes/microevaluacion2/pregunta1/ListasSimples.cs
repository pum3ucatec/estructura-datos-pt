public class ListaSimple
{
    public Nodo Head { get; private set; }

    public ListaSimple()
    {
        this.Head = null;
    }

    public void AddFirst(string name)
    {
        Nodo nodo = new Nodo(name);
        nodo.Next = Head;  
        Head = nodo;       
    }


    public void View()
    {
        if (Head == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo current = Head;
        Console.Write("Lista: ");
        while (current != null)
        {
            Console.Write($"{current.Name} | ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}
