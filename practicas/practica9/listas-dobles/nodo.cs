class NodoDoble(int? dato)
{
    public int? Dato { get; set; } = dato;
    public NodoDoble? Siguiente { get; set; }
    public NodoDoble? Anterior { get; set; }


}