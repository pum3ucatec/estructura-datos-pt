using System;

/// Clase ListaEnlazada que gestiona las operaciones principales
/// de una lista enlazada simple.
public class ListaEnlazada
{
    public Nodo Cabeza { get; private set; }

    /// Inserta un nuevo nodo al principio de la lista enlazada.
    public void InsertarAlPrincipio(int dato)
    {
        Nodo NuevoNodo = new Nodo(dato);
        NuevoNodo.Siguiente = Cabeza; // El nuevo nodo apunta al anterior primer nodo
        Cabeza = NuevoNodo;           // Ahora este nodo es la nueva cabeza de la lista
    }

    /// Recorre la lista enlazada mostrando sus elementos en consola.
    public void Mostrar()
    {
        Nodo Actual = Cabeza;
        while (Actual != null)
        {
            Console.Write(Actual.Dato + " -> ");
            Actual = Actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}