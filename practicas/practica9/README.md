# Practica 9
#  Lista Dobles

Las listas dobles a  diferencia de la lista simple, cada nodo tiene un puntero al **siguiente (Next)** y otro al **anterior (Prev)**, lo que permite recorrer la lista en ambas direcciones.

Incluye:
- Clase `NodoDoble`: Representa cada nodo de la lista.
- Clase `ListaDoble`: Implementa operaciones comunes sobre la lista.
- Programa principal con menú interactivo.

---

## 1. Clase NodoDoble

###  Descripción
Define la estructura básica de cada nodo en la lista doble.  
Cada nodo guarda un **nombre**, una referencia al **siguiente nodo** y otra al **nodo anterior**.

###  Código
```csharp
public class NodoDoble
{
    public string Name { get; set; }
    public NodoDoble Next { get; set; }
    public NodoDoble Prev { get; set; }

    public NodoDoble(string name)
    {
        this.Name = name;
        this.Next = null;
        this.Prev = null;
    }
}
```
###  Explicación

Name: almacena el dato del nodo (en este caso, un nombre).

Next: apunta al siguiente nodo de la lista.

Prev: apunta al nodo anterior.

El constructor inicializa los punteros en null.

## 2. Clase ListaDoble
### Descripción

La clase ListaDoble implementa la lista doblemente enlazada.
Permite insertar, eliminar, buscar y recorrer los nodos tanto hacia adelante como hacia atrás.

### Código
```csharp
public class ListaDoble
{
    private NodoDoble cabeza;  // primer nodo
    private NodoDoble cola;    // último nodo
    private int CountElements; // contador

    public ListaDoble()
    {
        cabeza = null;
        cola = null;
        CountElements = 0;
    }

    // Insertar al final
    public void Insertar(string name)
    {
        NodoDoble nodo = new NodoDoble(name);
        if (cabeza == null)
        {
            cabeza = nodo;
            cola = nodo;
        }
        else
        {
            cola.Next = nodo;
            nodo.Prev = cola;
            cola = nodo;
        }
        CountElements++;
    }

    // Eliminar primero
    public string EliminarPrimero()
    {
        if (cabeza == null) { Console.WriteLine("La lista está vacía."); return null; }

        string valor = cabeza.Name;
        cabeza = cabeza.Next;

        if (cabeza != null) cabeza.Prev = null;
        else cola = null; // si se borró el último nodo

        CountElements--;
        return valor;
    }

    // Eliminar último
    public string EliminarUltimo()
    {
        if (cola == null) { Console.WriteLine("La lista está vacía."); return null; }

        string valor = cola.Name;
        cola = cola.Prev;

        if (cola != null) cola.Next = null;
        else cabeza = null;

        CountElements--;
        return valor;
    }

    // Eliminar en posición específica
    public string EliminarEn(int posicion)
    {
        if (cabeza == null || posicion < 1 || posicion > CountElements)
        {
            Console.WriteLine("Posición inválida.");
            return null;
        }

        if (posicion == 1) return EliminarPrimero();
        if (posicion == CountElements) return EliminarUltimo();

        NodoDoble current = cabeza;
        int index = 1;
        while (index < posicion) { current = current.Next; index++; }

        string valor = current.Name;
        current.Prev.Next = current.Next;
        current.Next.Prev = current.Prev;

        CountElements--;
        return valor;
    }

    // Mostrar hacia adelante
    public void MostrarAdelante()
    {
        NodoDoble current = cabeza;
        if (current == null) { Console.WriteLine("La lista está vacía."); return; }

        Console.WriteLine("Lista de inicio a fin:");
        while (current != null)
        {
            Console.Write($"| {current.Name} ");
            current = current.Next;
        }
        Console.WriteLine("|");
    }

    // Mostrar hacia atrás
    public void MostrarAtras()
    {
        NodoDoble current = cola;
        if (current == null) { Console.WriteLine("La lista está vacía."); return; }

        Console.WriteLine("Lista de fin a inicio:");
        while (current != null)
        {
            Console.Write($"| {current.Name} ");
            current = current.Prev;
        }
        Console.WriteLine("|");
    }

    // Métodos auxiliares
    public string VerPrimero() => cabeza != null ? cabeza.Name : null;
    public string VerUltimo() => cola != null ? cola.Name : null;
    public int Buscar(string name)
    {
        NodoDoble current = cabeza;
        int pos = 1;
        while (current != null)
        {
            if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                return pos;
            current = current.Next;
            pos++;
        }
        return -1;
    }
    public bool Contiene(string name) => Buscar(name) != -1;
    public void Vaciar() { cabeza = null; cola = null; CountElements = 0; }
    public int Count() => CountElements;
    public bool EstaVacia() => cabeza == null;
}
```
### Explicación

Insertar: Agrega nodos al final de la lista.

EliminarPrimero / EliminarUltimo: Eliminan nodos desde los extremos.

EliminarEn: Elimina un nodo en una posición específica.

MostrarAdelante / MostrarAtras: Permiten recorrer la lista en ambas direcciones.

VerPrimero / VerUltimo: Devuelven el primer o último valor.

Buscar: Retorna la posición de un elemento si existe.

Contiene: Verifica si un valor está en la lista.

Vaciar: Borra todos los nodos.

Count: Devuelve la cantidad actual de elementos.

## 3. Programa Principal (Menú Interactivo)
###  Descripción

Permite al usuario interactuar con la lista doblemente enlazada mediante un menú.

### Código
```csharp
class Program
{
    static void Main(string[] args)
    {
        ListaDoble lista = new ListaDoble();
        int opcion;

        do
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("     MENÚ DE LISTA DOBLE");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Mostrar lista adelante");
            Console.WriteLine("2. Mostrar lista atrás");
            Console.WriteLine("3. Insertar nombre");
            Console.WriteLine("4. Eliminar primero");
            Console.WriteLine("5. Eliminar último");
            Console.WriteLine("6. Eliminar por posición");
            Console.WriteLine("7. Ver primer elemento");
            Console.WriteLine("8. Ver último elemento");
            Console.WriteLine("9. Ver cantidad");
            Console.WriteLine("10. Buscar nombre");
            Console.WriteLine("11. Verificar existencia");
            Console.WriteLine("12. Vaciar lista");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }

            switch (opcion)
            {
                case 1: lista.MostrarAdelante(); break;
                case 2: lista.MostrarAtras(); break;
                case 3:
                    Console.Write("Ingrese un nombre: ");
                    string nombre = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nombre)) lista.Insertar(nombre);
                    else Console.WriteLine("Nombre inválido.");
                    break;
                case 4:
                    string elimPrimero = lista.EliminarPrimero();
                    if (elimPrimero != null) Console.WriteLine($"Se eliminó: {elimPrimero}");
                    break;
                case 5:
                    string elimUltimo = lista.EliminarUltimo();
                    if (elimUltimo != null) Console.WriteLine($"Se eliminó: {elimUltimo}");
                    break;
                case 6:
                    Console.Write("Ingrese posición: ");
                    if (int.TryParse(Console.ReadLine(), out int pos))
                    {
                        string eliminado = lista.EliminarEn(pos);
                        if (eliminado != null) Console.WriteLine($"Se eliminó: {eliminado}");
                    }
                    else Console.WriteLine("Posición inválida.");
                    break;
                case 7:
                    Console.WriteLine(lista.VerPrimero() != null ? $"Primero: {lista.VerPrimero()}" : "Lista vacía.");
                    break;
                case 8:
                    Console.WriteLine(lista.VerUltimo() != null ? $"Último: {lista.VerUltimo()}" : "Lista vacía.");
                    break;
                case 9: Console.WriteLine($"Cantidad de elementos: {lista.Count()}"); break;
                case 10:
                    Console.Write("Ingrese nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    int posEncontrada = lista.Buscar(buscar);
                    Console.WriteLine(posEncontrada != -1 ? $"'{buscar}' está en la posición {posEncontrada}" : "No encontrado.");
                    break;
                case 11:
                    Console.Write("Ingrese nombre a verificar: ");
                    string existe = Console.ReadLine();
                    Console.WriteLine(lista.Contiene(existe) ? $"'{existe}' está en la lista." : $"'{existe}' no está en la lista.");
                    break;
                case 12: lista.Vaciar(); Console.WriteLine("Lista vaciada."); break;
                case 0: Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción no válida."); break;
            }

        } while (opcion != 0);
    }
}
```

### Explicación

Presenta un menú con opciones claras para manejar la lista doble.

Permite insertar, eliminar, mostrar, buscar y vaciar la lista.

El recorrido puede hacerse hacia adelante o hacia atrás gracias a los punteros dobles.

Se valida la entrada del usuario para evitar errores.