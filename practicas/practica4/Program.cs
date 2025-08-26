using System;
using System.Collections.Generic;

class PilaSimple
{
    private Stack<int> pila = new Stack<int>();

    public void Meter(int num)
    {
        pila.Push(num);
        Console.WriteLine(num + "metido en la pila");
    }
    public void Sacar()
    {
        if (pila.Count == 0)
        {
            Console.WriteLine("La pila esta vacia , nada que sacar ");
        }
        else
        {
            int eliminado = pila.Pop();
            Console.WriteLine("Se saco :" + eliminado);
        }
    }

    public void MostrarTope()
    {
        if (pila.Count > 0)
        {
            Console.WriteLine("El tope es: " + pila.Peek());
        }
        else
        {
            Console.WriteLine("La pila esta vacia , no hay tope");
        }
    }
    public void MostrarTodo()
    {
        if (pila.Count == 0)
        {
            Console.WriteLine("No hay nada en la pila");
        }
        else
        {
            Console.WriteLine("Elementos en la pila :");
            foreach (int n in pila)
            {
                Console.WriteLine(n);
            }
        }
    }
    public void VaciarPila()
    {
        pila.Clear();
        Console.WriteLine("Pila vaciada");
    }

    public void MeterVarios()
    {
        Console.Write("¿Cuantos numeros quieres meter : ?");
        int cant = 0;
        int.TryParse(Console.ReadLine(), out cant);

        for (int i = 0; i < cant; i++)
        {
            Console.Write("Numero" + (i + 1) + ":");
            int num = 0;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                Meter(num);
            }
            else
            {
                Console.WriteLine("Eso no es un numero, se omite");
            }
        }
    }
    public int Cantidad()
    {
        return pila.Count;
    }
    public bool EstaVacia()
    {
        return pila.Count == 0;
    }
}

class Program
{
    static void Main()
    {
        PilaSimple p = new PilaSimple();
        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("\n1. Ver pila");
            Console.WriteLine("2. Meter número");
            Console.WriteLine("3. Sacar número");
            Console.WriteLine("4. Ver tope");
            Console.WriteLine("5. Esta vacía?");
            Console.WriteLine("6. Cantidad de elementos");
            Console.WriteLine("7. Vaciar pila");
            Console.WriteLine("8. Meter varios");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Opcion : ");

            int.TryParse(Console.ReadLine(), out opcion);

            if (opcion == 1) p.MostrarTodo();
            else if (opcion == 2)
            {
                Console.Write("Numero a meter : ");
                int n = 0;
                if (int.TryParse(Console.ReadLine(), out n))
                    p.Meter(n);
                else
                    Console.WriteLine("Entrada invalida");
            }
            else if (opcion == 3) p.Sacar();
            else if (opcion == 4) p.MostrarTope();
            else if (opcion == 5) Console.WriteLine(p.EstaVacia() ? "Si esta vacia" : " No esta vacia");
            else if (opcion == 6) Console.WriteLine("Total elementos : " + p.Cantidad());
            else if (opcion == 7) p.VaciarPila();
            else if (opcion == 8) p.MeterVarios();
            else if (opcion == 0) Console.WriteLine("Adios!");
            else Console.WriteLine("Opcion invalida");
                   
        }

    }
}
 