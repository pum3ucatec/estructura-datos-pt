using System;

public class Cola
{
    private Nodo cabeza;

    public Cola()
    {
        cabeza = null;
    }

    public void AgregarAlInicio(string dato)
    {
        Nodo nuevoNodo = new Nodo(dato);
        nuevoNodo.Siguiente = cabeza;
        cabeza = nuevoNodo;
    }

    public void Mostrar()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacia.");
            return;
        }

        Nodo actual = cabeza;
        Console.Write("Elementos: ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }

    public void EliminarAlrededor(string valor)
    {
        if (cabeza == null || cabeza.Siguiente == null) return;

        Nodo actual = cabeza;
        Nodo anterior = null;

        while (actual != null)
        {
            if (actual.Dato == valor)
            {
                if (anterior != null)
                {
                    Nodo antesDeAnterior = cabeza;
                    if (antesDeAnterior == anterior)
                    {
                        cabeza = actual;
                    }
                    else
                    {
                        while (antesDeAnterior.Siguiente != anterior)
                            antesDeAnterior = antesDeAnterior.Siguiente;

                        antesDeAnterior.Siguiente = actual;
                    }
                }

                if (actual.Siguiente != null)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                }

                return;
            }

            anterior = actual;
            actual = actual.Siguiente;
        }
    }
}
