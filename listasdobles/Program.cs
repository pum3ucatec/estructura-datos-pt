using System;

class Nodo
{
    public int Valor;
    public Nodo Siguiente;
    public Nodo Anterior;

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
        Anterior = null;
    }
}

class ListaDoble
{
    private Nodo cabeza;
    private Nodo cola;

    public ListaDoble()
    {
        cabeza = null;
        cola = null;
    }

    public void InsertarAlPrincipio(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
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
    }

    public void InsertarAlFinal(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (cola == null)
        {
            cabeza = nuevoNodo;
            cola = nuevoNodo;
        }
        else
        {
            cola.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = cola;
            cola = nuevoNodo;
        }
    }

    public void EliminarDelPrincipio()
    {
        if (cabeza != null)
        {
            if (cabeza == cola)
            {
                cabeza = null;
                cola = null;
            }
            else
            {
                cabeza = cabeza.Siguiente;
                cabeza.Anterior = null;
            }
        }
    }

    public void EliminarDelFinal()
    {
        if (cola != null)
        {
            if (cabeza == cola)
            {
                cabeza = null;
                cola = null;
            }
            else
            {
                cola = cola.Anterior;
                cola.Siguiente = null;
            }
        }
    }

    public void MostrarLista()
    {
        Nodo temp = cabeza;
        while (temp != null)
        {
            Console.Write(temp.Valor + " ");
            temp = temp.Siguiente;
        }
        Console.WriteLine();
    }

    public void MostrarListaInvertida()
    {
        Nodo temp = cola;
        while (temp != null)
        {
            Console.Write(temp.Valor + " ");
            temp = temp.Anterior;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaDoble lista = new ListaDoble();
        int opcion = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu de Lista Doble");
            Console.WriteLine("1. Insertar al principio");
            Console.WriteLine("2. Insertar al final");
            Console.WriteLine("3. Eliminar del principio");
            Console.WriteLine("4. Eliminar del final");
            Console.WriteLine("5. Mostrar lista");
            Console.WriteLine("6. Mostrar lista invertida");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el valor a insertar al principio: ");
                    int valor1 = Convert.ToInt32(Console.ReadLine());
                    lista.InsertarAlPrincipio(valor1);
                    break;
                case 2:
                    Console.Write("Ingrese el valor a insertar al final: ");
                    int valor2 = Convert.ToInt32(Console.ReadLine());
                    lista.InsertarAlFinal(valor2);
                    break;
                case 3:
                    lista.EliminarDelPrincipio();
                    Console.WriteLine("Elemento eliminado del principio.");
                    break;
                case 4:
                    lista.EliminarDelFinal();
                    Console.WriteLine("Elemento eliminado del final.");
                    break;
                case 5:
                    Console.WriteLine("Lista normal: ");
                    lista.MostrarLista();
                    break;
                case 6:
                    Console.WriteLine("Lista invertida: ");
                    lista.MostrarListaInvertida();
                    break;
                case 7:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        } while (opcion != 7);
    }
}
