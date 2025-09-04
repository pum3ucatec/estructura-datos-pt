// See https://aka.ms/new-console-template for more information
using System;

class NodoDoble
{
    public int Dato;
    public NodoDoble Siguiente;
    public NodoDoble Anterior;

    public NodoDoble(int dato)
    {
        Dato = dato;
        Siguiente = null;
        Anterior = null;
    }
}

class ListaDoble
{
    private NodoDoble cabeza;
    private NodoDoble cola;
    private int capacidadMaxima;
    private int cantidad;

    public ListaDoble(int capacidad)
    {
        cabeza = null;
        cola = null;
        capacidadMaxima = capacidad;
        cantidad = 0;
    }


    public void Mostrar()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoDoble actual = cabeza;
        Console.Write("Lista: ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " <-> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }


    public void Insertar(int dato)
    {
        if (cantidad >= capacidadMaxima)
        {
            Console.WriteLine("La lista está llena. No se puede insertar más.");
            return;
        }

        NodoDoble nuevo = new NodoDoble(dato);
        if (cabeza == null)
        {
            cabeza = nuevo;
            cola = nuevo;
        }
        else
        {
            cola.Siguiente = nuevo;
            nuevo.Anterior = cola;
            cola = nuevo;
        }
        cantidad++;
    }


    public void Eliminar()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía, no se puede eliminar.");
            return;
        }
        Console.WriteLine("Se eliminó: " + cabeza.Dato);

        cabeza = cabeza.Siguiente;
        if (cabeza != null)
            cabeza.Anterior = null;
        else
            cola = null;
        cantidad--;
    }


    public void VerFrente()
    {
        if (cabeza == null)
            Console.WriteLine("La lista está vacía.");
        else
            Console.WriteLine("Frente: " + cabeza.Dato);
    }


    public void VerCapacidad()
    {
        Console.WriteLine($"Capacidad máxima: {capacidadMaxima}");
    }


    public void Existe(int valor)
    {
        NodoDoble actual = cabeza;
        while (actual != null)
        {
            if (actual.Dato == valor)
            {
                Console.WriteLine($"El elemento {valor} existe en la lista.");
                return;
            }
            actual = actual.Siguiente;
        }
        Console.WriteLine($"El elemento {valor} NO existe en la lista.");
    }


    public void EstaVacia()
    {
        Console.WriteLine(cabeza == null ? "La lista está vacía." : "La lista tiene elementos.");
    }


    public void EstaLlena()
    {
        Console.WriteLine(cantidad >= capacidadMaxima ? "La lista está llena." : "La lista NO está llena.");
    }
}

class Program
{
    static void Main()
    {
        ListaDoble lista = new ListaDoble(8);
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ LISTA DOBLE =====");
            Console.WriteLine("1. Mostrar LISTA");
            Console.WriteLine("2. Insertar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Ver frente");
            Console.WriteLine("5. Verificar la capacidad total de la lista");
            Console.WriteLine("6. Verificar si un elemento existe en la lista");
            Console.WriteLine("7. Verificar si la lista no tiene elementos");
            Console.WriteLine("8. Verificar si la lista está llena");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    lista.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese un número: ");
                    int num = int.Parse(Console.ReadLine());
                    lista.Insertar(num);
                    break;
                case 3:
                    lista.Eliminar();
                    break;
                case 4:
                    lista.VerFrente();
                    break;
                case 5:
                    lista.VerCapacidad();
                    break;
                case 6:
                    Console.Write("Ingrese el número a buscar: ");
                    int buscar = int.Parse(Console.ReadLine());
                    lista.Existe(buscar);
                    break;
                case 7:
                    lista.EstaVacia();
                    break;
                case 8:
                    lista.EstaLlena();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }
}
