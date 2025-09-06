using System;

class Nodo
{
    public int Valor;
    public Nodo Siguiente;

    public Nodo(int valor) => Valor = valor;
}

class Lista
{
    private Nodo inicio;

    public void AgregarInicio(int v)
    {
        var nuevo = new Nodo(v) { Siguiente = inicio };
        inicio = nuevo;
    }

    public void AgregarFinal(int v)
    {
        var nuevo = new Nodo(v);
        if (inicio == null)
        {
            inicio = nuevo;
            return;
        }

        var act = inicio;
        while (act.Siguiente != null)
            act = act.Siguiente;
        act.Siguiente = nuevo;
    }

    public bool InsertarDespues(int refVal, int nuevoVal)
    {
        var act = inicio;
        while (act != null)
        {
            if (act.Valor == refVal)
            {
                var nuevo = new Nodo(nuevoVal) { Siguiente = act.Siguiente };
                act.Siguiente = nuevo;
                return true;
            }
            act = act.Siguiente;
        }
        return false;
    }

    public bool EliminarPrimero()
    {
        if (inicio == null) return false;
        inicio = inicio.Siguiente;
        return true;
    }

    public bool EliminarPorValor(int v)
    {
        if (inicio == null) return false;

        if (inicio.Valor == v)
        {
            inicio = inicio.Siguiente;
            return true;
        }

        var ant = inicio;
        var act = inicio.Siguiente;

        while (act != null)
        {
            if (act.Valor == v)
            {
                ant.Siguiente = act.Siguiente;
                return true;
            }
            ant = act;
            act = act.Siguiente;
        }

        return false;
    }

    public bool EliminarPorIndice(int i)
    {
        if (i < 0 || inicio == null) return false;
        if (i == 0)
        {
            inicio = inicio.Siguiente;
            return true;
        }

        var ant = inicio;
        var act = inicio.Siguiente;
        int pos = 1;

        while (act != null)
        {
            if (pos == i)
            {
                ant.Siguiente = act.Siguiente;
                return true;
            }
            ant = act;
            act = act.Siguiente;
            pos++;
        }

        return false;
    }

    public int Buscar(int v)
    {
        int i = 0;
        var act = inicio;
        while (act != null)
        {
            if (act.Valor == v) return i;
            act = act.Siguiente;
            i++;
        }
        return -1;
    }

    public int Contar()
    {
        int c = 0;
        var act = inicio;
        while (act != null)
        {
            c++;
            act = act.Siguiente;
        }
        return c;
    }

    public void Invertir()
    {
        Nodo prev = null, actual = inicio;

        while (actual != null)
        {
            var sig = actual.Siguiente;
            actual.Siguiente = prev;
            prev = actual;
            actual = sig;
        }

        inicio = prev;
    }

    public void Vaciar() => inicio = null;

    public override string ToString()
    {
        if (inicio == null) return "[vacía]";
        var act = inicio;
        string s = "";
        while (act != null)
        {
            s += act.Valor + (act.Siguiente != null ? " -> " : "");
            act = act.Siguiente;
        }
        return s;
    }
}

class Program
{
    static void Main()
    {
        var lista = new Lista();

        while (true)
        {
            Menu();
            Console.Write("Opción: ");
            var op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    lista.AgregarInicio(Pedir("Valor: "));
                    break;
                case "2":
                    lista.AgregarFinal(Pedir("Valor: "));
                    break;
                case "3":
                    int refVal = Pedir("Después de: ");
                    int nuevoVal = Pedir("Nuevo valor: ");
                    Console.WriteLine(lista.InsertarDespues(refVal, nuevoVal) ? "Insertado." : "No encontrado.");
                    break;
                case "4":
                    Console.WriteLine(lista.EliminarPrimero() ? "Eliminado." : "Lista vacía.");
                    break;
                case "5":
                    Console.WriteLine(lista.EliminarPorValor(Pedir("Valor a eliminar: ")) ? "Eliminado." : "No encontrado.");
                    break;
                case "6":
                    Console.WriteLine(lista.EliminarPorIndice(Pedir("Índice: ")) ? "Eliminado." : "Índice inválido.");
                    break;
                case "7":
                    int buscar = Pedir("Valor a buscar: ");
                    int pos = lista.Buscar(buscar);
                    Console.WriteLine(pos >= 0 ? $"Índice: {pos}" : "No encontrado.");
                    break;
                case "8":
                    Console.WriteLine("Lista: " + lista);
                    break;
                case "9":
                    Console.WriteLine("Elementos: " + lista.Contar());
                    break;
                case "10":
                    lista.Invertir();
                    Console.WriteLine("Lista invertida.");
                    break;
                case "11":
                    lista.Vaciar();
                    Console.WriteLine("Lista vaciada.");
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void Menu()
    {
        Console.WriteLine("== MENÚ ==");
        Console.WriteLine("1) Agregar al inicio");
        Console.WriteLine("2) Agregar al final");
        Console.WriteLine("3) Insertar después de un valor");
        Console.WriteLine("4) Eliminar primero");
        Console.WriteLine("5) Eliminar por valor");
        Console.WriteLine("6) Eliminar por índice");
        Console.WriteLine("7) Buscar valor");
        Console.WriteLine("8) Mostrar lista");
        Console.WriteLine("9) Contar elementos");
        Console.WriteLine("10) Invertir lista");
        Console.WriteLine("11) Vaciar lista");
        Console.WriteLine("0) Salir");
    }

    static int Pedir(string msg)
    {
        Console.Write(msg);
        while (!int.TryParse(Console.ReadLine(), out int v))
            Console.Write("Inválido. Intenta otra vez: ");
        return v;
    }
}
