using System;

/// <summary>
/// Representa un nodo en la cola enlazada.
/// </summary>
public class Nodo
{
    /// <summary>
    /// Valor almacenado en el nodo.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Referencia al siguiente nodo en la cola.
    /// </summary>
    public Nodo Next { get; set; }

    /// <summary>
    /// Inicializa una nueva instancia de la clase Nodo.
    /// </summary>
    /// <param name="name">Valor a almacenar en el nodo.</param>
    public Nodo(string name)
    {
        this.Name = name;
        this.Next = null;
    }
}

/// <summary>
/// Implementación de una cola dinámica utilizando nodos enlazados.
/// </summary>
public class Cola
{
    /// <summary>
    /// Referencia al primer elemento de la cola.
    /// </summary>
    public Nodo Front { get; private set; }

    /// <summary>
    /// Referencia al último elemento de la cola.
    /// </summary>
    public Nodo Rear { get; private set; }

    /// <summary>
    /// Inicializa una nueva instancia de la clase Cola vacía.
    /// </summary>
    public Cola()
    {
        this.Front = null;
        this.Rear = null;
    }

    /// <summary>
    /// Agrega un elemento al final de la cola.
    /// </summary>
    /// <param name="name">Elemento a agregar.</param>
    public void Enqueue(string name)
    {
        Nodo nodo = new Nodo(name);

        if (this.Front == null)
        {
            // Si la cola está vacía, el nuevo nodo es tanto el frente como el final
            this.Front = nodo;
            this.Rear = nodo;
        }
        else
        {
            // Agrega el nuevo nodo al final y actualiza la referencia Rear
            this.Rear.Next = nodo;
            this.Rear = nodo;
        }
        
        Console.WriteLine($"Elemento '{name}' agregado a la cola.");
    }

    /// <summary>
    /// Elimina y devuelve el elemento al frente de la cola.
    /// </summary>
    /// <returns>Elemento eliminado o null si la cola está vacía.</returns>
    public string Dequeue()
    {
        if (this.Front == null)
        {
            Console.WriteLine("La cola está vacía. No se puede eliminar.");
            return null;
        }

        string valorEliminado = this.Front.Name;
        this.Front = this.Front.Next;

        // Si Front se vuelve null, también Rear debe ser null
        if (this.Front == null)
        {
            this.Rear = null;
        }

        Console.WriteLine($"Elemento '{valorEliminado}' eliminado de la cola.");
        return valorEliminado;
    }

    /// <summary>
    /// Devuelve el elemento al frente de la cola sin eliminarlo.
    /// </summary>
    /// <returns>Elemento al frente o null si la cola está vacía.</returns>
    public string Peek()
    {
        if (this.Front == null)
        {
            Console.WriteLine("La cola está vacía.");
            return null;
        }

        return this.Front.Name;
    }

    /// <summary>
    /// Verifica si la cola está vacía.
    /// </summary>
    /// <returns>True si la cola está vacía, False en caso contrario.</returns>
    public bool IsEmpty()
    {
        return this.Front == null;
    }

    /// <summary>
    /// Muestra todos los elementos de la cola.
    /// </summary>
    public void View()
    {
        if (this.Front == null)
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Console.Write("Contenido de la cola: ");
        Nodo current = this.Front;

        while (current != null)
        {
            Console.Write($"{current.Name} | ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Clase principal que contiene el punto de entrada del programa.
/// </summary>
class Principal
{
    /// <summary>
    /// Método principal que muestra un menú interactivo para manipular la cola.
    /// </summary>
    static void Main(string[] args)
    {
        Cola cola = new Cola();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA con NODOS =====");
            Console.WriteLine("1. Mostrar Cola");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
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
                    cola.View();
                    break;
                case 2:
                    Console.Write("Ingrese el nombre a insertar: ");
                    string valor = Console.ReadLine();
                    if (!string.IsNullOrEmpty(valor))
                    {
                        cola.Enqueue(valor);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 3:
                    cola.Dequeue();
                    break;
                case 4:
                    string frente = cola.Peek();
                    if (frente != null)
                    {
                        Console.WriteLine($"Elemento en el frente: {frente}");
                    }
                    break;
                case 5:
                    Console.WriteLine($"La cola {(cola.IsEmpty() ? "está" : "no está")} vacía.");
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

        } while (opcion != 0);
    }
}
