using System;

/// <summary>
/// Representa un nodo de la pila con un valor y referencia al siguiente nodo
/// </summary>
class Nodo
{
    public int Valor { get; set; }
    public Nodo Siguiente { get; set; }

    /// <summary>
    /// Constructor que inicializa un nuevo nodo con el valor especificado
    /// </summary>
    /// <param name="valor">Valor numérico a almacenar en el nodo</param>
    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

/// <summary>
/// Implementación de una pila (LIFO - Last In First Out) usando listas enlazadas
/// </summary>
class Pila
{
    private Nodo cima;      // Referencia al elemento superior de la pila
    private int tamaño;     // Contador del número de elementos en la pila

    /// <summary>
    /// Constructor que inicializa una pila vacía
    /// </summary>
    public Pila()
    {
        cima = null;
        tamaño = 0;
    }

    /// <summary>
    /// Inserta un nuevo elemento en la cima de la pila
    /// </summary>
    /// <param name="valor">Valor a insertar</param>
    public void Push(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        nuevoNodo.Siguiente = cima;
        cima = nuevoNodo;
        tamaño++;
        Console.WriteLine($"Elemento {valor} insertado correctamente.");
    }

    /// <summary>
    /// Elimina y retorna el elemento de la cima de la pila
    /// </summary>
    /// <returns>Valor eliminado o -1 si la pila está vacía</returns>
    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Error: La pila está vacía. No se puede eliminar.");
            return -1;
        }

        int valorEliminado = cima.Valor;
        cima = cima.Siguiente;
        tamaño--;
        Console.WriteLine($"Elemento {valorEliminado} eliminado correctamente.");
        return valorEliminado;
    }

    /// <summary>
    /// Obtiene el valor de la cima sin eliminarlo
    /// </summary>
    /// <returns>Valor de la cima o -1 si la pila está vacía</returns>
    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía.");
            return -1;
        }
        return cima.Valor;
    }

    /// <summary>
    /// Verifica si la pila no contiene elementos
    /// </summary>
    /// <returns>True si la pila está vacía, False en caso contrario</returns>
    public bool IsEmpty()
    {
        return cima == null;
    }

    /// <summary>
    /// Muestra todos los elementos de la pila en orden (de la cima al fondo)
    /// </summary>
    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía.");
            return;
        }

        Console.WriteLine("\n=== CONTENIDO DE LA PILA ===");
        Console.WriteLine($"Tamaño: {tamaño}");
        Console.WriteLine("Elementos (de la cima al fondo):");

        Nodo actual = cima;
        int posicion = 1;

        while (actual != null)
        {
            Console.WriteLine($"{posicion}. {actual.Valor}");
            actual = actual.Siguiente;
            posicion++;
        }
        Console.WriteLine("============================");
    }

    /// <summary>
    /// Obtiene el número de elementos en la pila
    /// </summary>
    public int Tamaño
    {
        get { return tamaño; }
    }
}

/// <summary>
/// Clase principal que contiene el punto de entrada del programa
/// </summary>
class Principal
{
    /// <summary>
    /// Método principal que ejecuta el menú interactivo de la pila
    /// </summary>
    /// <param name="args">Argumentos de línea de comandos</param>
    static void Main(string[] args)
    {
        Pila pila = new Pila();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ PILA =====");
            Console.WriteLine("1. Mostrar pila");
            Console.WriteLine("2. Insertar (Push)");
            Console.WriteLine("3. Eliminar (Pop)");
            Console.WriteLine("4. Ver cima (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    pila.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese el número a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                    {
                        pila.Push(valor);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 3:
                    pila.Pop();
                    break;
                case 4:
                    int cima = pila.Peek();
                    if (cima != -1)
                        Console.WriteLine($"Elemento en la cima: {cima}");
                    break;
                case 5:
                    Console.WriteLine(pila.IsEmpty() ? "La pila está vacía." : "La pila NO está vacía.");
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}
