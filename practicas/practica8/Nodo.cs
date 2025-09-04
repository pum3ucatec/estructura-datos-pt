namespace ListaSimpleApp
{
    public class Nodo
    {
        public int Dato { get; set; }
        public Nodo? Siguiente { get; set; }

        public Nodo(int valor)
        {
            Dato = valor;
            Siguiente = null;
        }
    }
}
