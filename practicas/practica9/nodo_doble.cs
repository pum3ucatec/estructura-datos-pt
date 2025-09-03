public class nodo_doble
{
    public string nombre { get; set; }
    public nodo_doble siguiente { get; set; }
    public nodo_doble anterior { get; set; }
   
    public nodo_doble(string nombre)
    {
        this.nombre = nombre;
        this.siguiente = null;
        this.anterior = null;
    }
}
