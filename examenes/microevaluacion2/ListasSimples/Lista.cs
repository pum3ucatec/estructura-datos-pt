using System;
public class Lista
{
    private Nodo cabeza;

    public Lista()
    {
        cabeza = null;
    }

    // Pregunta #1 -> Insertar al principio
    public void InsertarAlPrincipio(string nombre)
    {
        Nodo nuevo = new Nodo(nombre);
        nuevo.Next = cabeza;
        cabeza = nuevo;
    }

    // Pregunta #2 -> Eliminar alrededor de un valor
    public void EliminarAlrededor(string nombre)
    {
        if (cabeza == null || cabeza.Next == null)
        {
            Console.WriteLine("La lista no tiene suficientes elementos");
            return;
        }

        Nodo actual = cabeza;
        Nodo anterior = null;

        while (actual != null && actual.Nombre != nombre)
        {
            anterior = actual;
            actual = actual.Next;
        }

        if (actual == null)
        {
            Console.WriteLine($"El nombre {nombre} no esta en la lista");
            return;
        }

        // eliminar nodo anterior
        if (anterior != null)
        {
            Console.WriteLine($"El nombre {anterior.Nombre} fue eliminado de la lista");
            if (anterior == cabeza)
                cabeza = actual;
            else
            {
                Nodo temp = cabeza;
                while (temp.Next != anterior)
                    temp = temp.Next;
                temp.Next = actual;
            }
        }

        // eliminar nodo siguiente
        if (actual.Next != null)
        {
            Console.WriteLine($"El nombre {actual.Next.Nombre} fue eliminado de la lista");
            actual.Next = actual.Next.Next;
        }
    }

    // View
    public void View()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista esta vacia");
            return;
        }

        Nodo temp = cabeza;
        while (temp != null)
        {
            Console.Write(temp.Nombre + " | ");
            temp = temp.Next;
        }
    }
}
