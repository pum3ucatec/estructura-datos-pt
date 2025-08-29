# MICROEVALUACION 2

## LISTAS SIMPLES CON NODOS

Las listas simples son una estructura de datos en la que cada elemento, llamado nodo, contiene un valor y un puntero al siguiente nodo.

Para esta microevaluacion se tienen tres archivos:

- **Program.cs:** Contiene el menú principal y la interacción con el usuario.
- **lista-simple.cs:** Implementa la lógica de la lista enlazada simple y sus operaciones.
- **Nodo.cs:** Define la clase Nodo utilizada en la lista.

Antes de desarrollar los planteamientos es necesario primero tener la clase "Nodo"

```c#
public class Nodo
{
    public string Name { get; set; }
    public Nodo Next { get; set; }

    public Nodo(string name)
    {
        this.Name = name;
        this.Next = null;
    }
}
```

---

### PREGUNTA 1: Añadir un elemento en la cabeza de la lista

```c#
using System;

public class ListaSimple
{
    public Nodo Head { get; set; }

    public ListaSimple()
    {
        this.Head = null;
    }

    public void InsertarInicio(string name)
    {
        Nodo nuevoNodo = new Nodo(name);
        nuevoNodo.Next = Head;
        Head = nuevoNodo;
    }
```

- Se crea un metodo publico `InsertarInicio`, que recibira un dato que se guardara en el nuevo nodo `string name`.

```c#
public void InsertarInicio(string name)
```

- Se crea un nuevo nodo que recive un valor `name` , hacemos que el siguiente del nuevo nodo sea el que estaba en la cabeza, y por ultimo que el puntero de la cabeza apunte al nuevo nodo.

```c#
 {
    Nodo nuevoNodo = new Nodo(name);
    nuevoNodo.Next = Head;
    Head = nuevoNodo;
 }
```

### PREGUNTA 2: Eliminar elementos alrededor de un nodo

**_¡¡¡El siguiente bloque de codigo presenta un error!!!_**

### 1. Metodo inexistente (IsEmpty)

- El error se encuetra aqui, puesto que se agrega un metodo que no esta en la clase `IsEmpty`

```c#
  public void EliminarAlrededor(string name)
{
    if (IsEmpty())
    {
        Console.WriteLine("La lista esta vacia");
        return;
    }
```

---

- Para que sea correcto antes se deberia definir antes de la siguiente manera:

---

```c#
public bool IsEmpty()
{
    return Head == null;
}
```

### 2. Inicio de la busqueda

- Se inicia en la cabeza, la iteracion continua hasta que `actual == null` (no se encontro) o `actual.Name == name` (se encontro).

```c#
    Nodo actual = Head;
    Nodo anterior = null;

    while (actual != null && actual.Name != name)
        {
            anterior = actual;
            actual = actual.Next;
        }

    if (actual == null)
    {
        Console.WriteLine($"El elemento '{name}' no se encontró en la lista.");
        return;
    }
```

### 3. Eliminar el anterior al actual

- Verifica si nodo anterior existe, si existe y `AAnterior` es null, se actualiza el nodo actual como la cabeza, si existe un `AAnterior` se enlaza directamente con el nodo actual.

```c#
    if (anterior != null)
    {
        Nodo AAnterior = null;
        Nodo current = Head;
        while (current != null && current.Next != actual)
        {
            AAnterior = current;
            current = current.Next;
        }
        if (AAnterior == null)
        {

            Head = actual;
        }
        else
        {
            AAnterior.Next = actual;
        }
    }
```

### 4. Eliminar el siguiente al actual

- Primero se verifica si eciste un nodo siguiente al actual, si es asi, se lo elimina saltandolo, de manera que nodo actual apunte al siguiente del siguiente, si no muestra un mensaje

```c#
    if (actual.Next != null)
    {
        actual.Next = actual.Next.Next;
    }
    else
    {
        Console.WriteLine($"No hay nodo siguiente a '{name}' para eliminar.");

}
}
```
