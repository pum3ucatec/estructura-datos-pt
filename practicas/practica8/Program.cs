using System;

class Nodo
{
    public int dato;      // valor que guarda el nodo
    public Nodo siguiente; // referencia al siguiente nodo

    public Nodo(int valor)
    {
        dato = valor;
        siguiente = null;
    }
}

class ListaSimple
{
    private Nodo cabeza; // primer nodo de la lista

    public ListaSimple()
    {
        cabeza = null; // al inicio la lista está vacía
    }

    // Insertar al inicio
    public void InsertarInicio(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        nuevo.siguiente = cabeza;
        cabeza = nuevo;
    }

    // Insertar al final
    public void InsertarFinal(int valor)
    {
        Nodo nuevo = new Nodo(valor);

        if (cabeza == null) // si está vacía
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo aux = cabeza;
            while (aux.siguiente != null)
            {
                aux = aux.siguiente;
            }
            aux.siguiente = nuevo;
        }
    }

    // Eliminar un nodo por valor
    public void Eliminar(int valor)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (cabeza.dato == valor) // si el valor está en el primer nodo
        {
            cabeza = cabeza.siguiente;
            return;
        }

        Nodo aux = cabeza;
        while (aux.siguiente != null && aux.siguiente.dato != valor)
        {
            aux = aux.siguiente;
        }

        if (aux.siguiente != null)
        {
            aux.siguiente = aux.siguiente.siguiente;
        }
        else
        {
            Console.WriteLine("El valor no se encontró en la lista.");
        }
    }

    // Buscar un valor en la lista
    public bool Buscar(int valor)
    {
        Nodo aux = cabeza;
        while (aux != null)
        {
            if (aux.dato == valor)
            {
                return true;
            }
            aux = aux.siguiente;
        }
        return false;
    }

    // Mostrar todos los elementos de la lista
    public void Mostrar()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo aux = cabeza;
        Console.Write("Lista: ");
        while (aux != null)
        {
            Console.Write(aux.dato + " -> ");
            aux = aux.siguiente;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();
        int opcion, valor;

        do
        {
            Console.WriteLine("\n===== MENÚ LISTA SIMPLE =====");
            Console.WriteLine("1. Insertar al inicio");
            Console.WriteLine("2. Insertar al final");
            Console.WriteLine("3. Eliminar un valor");
            Console.WriteLine("4. Buscar un valor");
            Console.WriteLine("5. Mostrar lista");
            Console.WriteLine("6. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa un valor: ");
                    valor = int.Parse(Console.ReadLine());
                    lista.InsertarInicio(valor);
                    break;
                case 2:
                    Console.Write("Ingresa un valor: ");
                    valor = int.Parse(Console.ReadLine());
                    lista.InsertarFinal(valor);
                    break;
                case 3:
                    Console.Write("Ingresa el valor a eliminar: ");
                    valor = int.Parse(Console.ReadLine());
                    lista.Eliminar(valor);
                    break;
                case 4:
                    Console.Write("Ingresa el valor a buscar: ");
                    valor = int.Parse(Console.ReadLine());
                    bool encontrado = lista.Buscar(valor);
                    Console.WriteLine(encontrado ? "Valor encontrado." : "Valor no encontrado.");
                    break;
                case 5:
                    lista.Mostrar();
                    break;
                case 6:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 6);
    }
}
