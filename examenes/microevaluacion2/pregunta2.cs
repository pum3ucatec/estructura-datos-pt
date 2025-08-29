public void EliminarAlrededor(int valor){
    if (cabeza == null || cabeza.siguiente == null) return;

    Nodo actual = cabeza;
    Nodo anterior = null;

    while (actual != null && actual.dato != valor)
    {
        anterior = actual;
        actual = actual.siguiente;
    }

    if (actual == null) return; // no se encontró el valor

    // Eliminar anterior si existe
    if (anterior != null)
    {
        // Buscar el nodo antes del anterior
        Nodo temp = cabeza;
        if (temp == anterior)
            cabeza = actual; // si estaba al inicio
        else
        {
            while (temp.siguiente != anterior)
                temp = temp.siguiente;
            temp.siguiente = actual;
        }
    }

    // Eliminar siguiente si existe
    if (actual.siguiente != null)
        actual.siguiente = actual.siguiente.siguiente;
}