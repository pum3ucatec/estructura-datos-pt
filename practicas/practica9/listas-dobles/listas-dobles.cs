using System;

class ListaDoble
{
    public int? valor;
    public NodoDoble? cabeza;
    public NodoDoble? cola;

    public ListaDoble()
    {
        valor = null;
        cabeza = null;
        cola = null;
    }
    public void MostrarHaciaDelante()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }
        NodoDoble? actual = cabeza;
        Console.Write("Lista hacia adelante: ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }

    public void MostrarHaciaAtras()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoDoble? actual = cola;
        Console.Write("Lista hacia atrás: ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " ");
            actual = actual.Anterior;
        }
        Console.WriteLine();
    }

    public void InsertarAlInicio(int valor)
    {
        int encontrado = Buscar(valor);
        if (encontrado != -1)
        {
            Console.WriteLine($"El elemento {valor} ya existe en la lista. No se permiten duplicados.");
            return;
        }
        NodoDoble nuevoNodo = new(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
            cola = nuevoNodo;
        }
        else
        {
            nuevoNodo.Siguiente = cabeza;
            cabeza.Anterior = nuevoNodo;
            cabeza = nuevoNodo;
        }
        Console.WriteLine($"Elemento {valor} insertado al inicio.");
    }

    public void InsertarAlFinal(int valor)
    {
        int encontrado = Buscar(valor);
        if (encontrado != -1)
        {
            Console.WriteLine($"El elemento {valor} ya existe en la lista. No se permiten duplicados.");
            return;
        }
        NodoDoble nuevoNodo = new(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
            cola = nuevoNodo;
        }
        else
        {
            while (cola?.Siguiente != null)
            {
                cola = cola.Siguiente;

            }
            Console.WriteLine($"Elemento {valor} insertado al final.");
        }
    }

    public int Contar()
    {
        int contador = 0;
        NodoDoble? actual = cabeza;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    public void EliminarPorValor(int valor)
    {
        if (cabeza == null)
        {
            Console.WriteLine("Posición inválida o lista vacía.");
            return;
        }

        NodoDoble? actual = cabeza;
        int indice = 1;

        while (actual != null && actual.Dato != valor)
        {
            actual = actual.Siguiente;
            indice++;
        }
        if (actual == null)
        {
            Console.WriteLine("Elemento no encontrado.");
            return;
        }

    }

    public int Buscar(int valor)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return -1;
        }

        NodoDoble? actual = cabeza;
        int posicion = 1;
        bool encontrado = false;

        while (actual != null)
        {
            if (actual.Dato == valor)
            {
                Console.WriteLine($"Elemento {valor} encontrado en la posición {posicion}.");
                encontrado = true;
                break;
            }
            actual = actual.Siguiente;
            posicion++;
        }

        if (!encontrado)
        {
            Console.WriteLine($"Elemento {valor} no encontrado en la lista.");
            return -1;
        }
        return posicion;
    }


    public bool Empty()
    {
        return cabeza == null;
    }

    public void LimpiarPantalla()
    {
        Console.WriteLine("Presiona Enter para continuar...");
        Console.ReadLine();
        Console.Clear();
    }

}
