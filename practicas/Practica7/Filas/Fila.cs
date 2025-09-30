using System;

public class Fila
{
    private Nodo? Head { get; set; }

    public Fila()
    {
        Head = null;
    }
    // Inserta al principio (lista simple)
    public void InsertFirst(string valor)
    {
        Nodo nuevo = new Nodo(valor);
        nuevo.Next = Head;
        Head = nuevo;
    }

    // Elimina los nodos a la izquierda y derecha de una posición dada (1-based).
    // Si alguno de los lados no existe, solo elimina el que exista.
    public void DeleteAround(int posicion)
    {
        if (Head == null || posicion < 1) 
        {
            Console.WriteLine("No se puede eliminar alrededor: posición inválida o lista vacía.");
            return;
        }

        int n = Count();
        if (posicion > n)
        {
            Console.WriteLine("No se puede eliminar alrededor: la posición excede el tamaño de la lista.");
            return;
        }

        // Eliminamos primero el de la derecha (posicion + 1), luego el de la izquierda (posicion - 1)
        bool elimDerecha = RemoveAt(posicion + 1);
        bool elimIzquierda = RemoveAt(posicion - 1);

        if (!elimDerecha && !elimIzquierda)
        {
            Console.WriteLine("No había elementos en uno o ambos lados para eliminar.");
        }
        else
        {
            Console.WriteLine($"Eliminación alrededor completada. Izquierda: {elimIzquierda}, Derecha: {elimDerecha}.");
        }
    }

    // Muestra el contenido
    public void View()
    {
        Nodo? actual = Head;

        if (actual == null)
        {
            Console.WriteLine("La fila está vacía.");
            return;
        }

        Console.Write("Contenido de la lista: ");
        while (actual != null)
        {
            Console.Write(actual.Valor + " -> ");
            actual = actual.Next;
        }
        Console.WriteLine("null");
    }

    // Cuenta elementos
    public int Count()
    {
        int c = 0;
        var a = Head;
        while (a != null) { c++; a = a.Next; }
        return c;
    }

    // Elimina elemento en índice 1-based
    private bool RemoveAt(int index)
    {
        if (index < 1 || Head == null) return false;

        if (index == 1)
        {
            Head = Head.Next;
            return true;
        }

        int i = 1;
        Nodo? prev = null;
        Nodo? curr = Head;

        while (curr != null && i < index)
        {
            prev = curr;
            curr = curr.Next;
            i++;
        }

        if (curr == null) return false;

        // quitar curr
        if (prev != null) prev.Next = curr.Next;
        return true;
    }
}
