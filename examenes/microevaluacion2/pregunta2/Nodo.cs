namespace Pregunta2
{
    public class Nodo
    {
        public string Dato { get; set; }
1        public Nodo? Siguiente { get; set; }

        public Nodo(string dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
