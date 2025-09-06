public class NodoDoble
{
    public string Dato;          // Valor que guarda el nodo
    public NodoDoble Siguiente;  // Apunta al nodo de la derecha
    public NodoDoble Anterior;   // Apunta al nodo de la izquierda

    public NodoDoble(string dato)
    {
        Dato = dato;
        Siguiente = null;
        Anterior = null;
    }
}
