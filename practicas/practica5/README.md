# Ejercicios de Listas Simples en C#

---

# Ejercicio 1: Insertar al principio en una lista simple

**Objetivo:** Insertar un nuevo nodo al inicio de una lista simple.

**Explicación:**  
El programa crea una lista simple y permite insertar un nodo al principio. El nodo insertado se convierte en la nueva cabeza (`head`) de la lista.

**Código en C#:**
```csharp
public class Nodo
{
    public string Dato;
    public Nodo Siguiente;

    public Nodo(string dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

public class ListaSimple
{
    public Nodo Head;

    public void InsertarAlPrincipio(string dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.Siguiente = Head;
        Head = nuevo;
    }

    public void Mostrar()
    {
        Nodo actual = Head;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}

Salida esperada:

Juan -> Pedro -> null
```

# Ejercicio 2: Insertar al final en una lista simple
Objetivo: Insertar un nodo al final de una lista simple.


Explicación:
El nodo se recorre hasta el último elemento (null) y se inserta el nuevo nodo ahí.

Código en C#:

``` csharp
Copiar código
public void InsertarAlFinal(string dato)
{
    Nodo nuevo = new Nodo(dato);
    if (Head == null)
    {
        Head = nuevo;
        return;
    }
    Nodo actual = Head;
    while (actual.Siguiente != null)
    {
        actual = actual.Siguiente;
    }
    actual.Siguiente = nuevo;
}
Salida esperada:


Pedro -> Juan -> Maria -> null
```
# Ejercicio 3: Insertar después de un nodo específico
Objetivo: Insertar un nodo después de un nodo con un valor específico.

Explicación:
Se busca el nodo que contiene el valor y se enlaza el nuevo nodo justo después.

Código en C#:

```csharp

public void InsertarDespuesDe(string datoReferencia, string nuevoDato)
{
    Nodo actual = Head;
    while (actual != null && actual.Dato != datoReferencia)
    {
        actual = actual.Siguiente;
    }
    if (actual == null) return;

    Nodo nuevo = new Nodo(nuevoDato);
    nuevo.Siguiente = actual.Siguiente;
    actual.Siguiente = nuevo;
}
Salida esperada:

Pedro -> Juan -> Carlos -> Maria -> null
```
# Ejercicio 4: Eliminar el primer nodo
Objetivo: Eliminar el primer nodo de la lista simple.

Explicación:
Se actualiza la referencia de la cabeza al siguiente nodo.

Código en C#:

```csharp
Copiar código
public void EliminarPrimero()
{
    if (Head != null)
    {
        Head = Head.Siguiente;
    }
}
Salida esperada:


Juan -> Maria -> null
```
# Ejercicio 5: Eliminar el último nodo
Objetivo: Eliminar el último nodo de la lista simple.

Explicación:
Se recorre hasta el penúltimo nodo y se apunta su referencia a null.

Código en C#:

```csharp

public void EliminarUltimo()
{
    if (Head == null) return;
    if (Head.Siguiente == null)
    {
        Head = null;
        return;
    }
    Nodo actual = Head;
    while (actual.Siguiente.Siguiente != null)
    {
        actual = actual.Siguiente;
    }
    actual.Siguiente = null;
}
Salida esperada:

Pedro -> Juan -> null
```

# Ejercicio 6: Eliminar un nodo por valor
Objetivo: Eliminar el primer nodo que contenga un valor específico.

Explicación:
Se busca el nodo previo al que contiene el valor y se ajustan los punteros para omitirlo.

Código en C#:

```csharp
public void EliminarPorValor(string dato)
{
    if (Head == null) return;
    if (Head.Dato == dato)
    {
        Head = Head.Siguiente;
        return;
    }
    Nodo actual = Head;
    while (actual.Siguiente != null && actual.Siguiente.Dato != dato)
    {
        actual = actual.Siguiente;
    }
    if (actual.Siguiente != null)
    {
        actual.Siguiente = actual.Siguiente.Siguiente;
    }
}
Salida esperada:


Pedro -> Maria -> null
```
# Ejercicio 7: Buscar un nodo en la lista
Objetivo: Buscar un valor dentro de la lista simple.

Explicación:
Se recorre la lista hasta encontrar el valor o llegar al final.

Código en C#:

```csharp

public bool Buscar(string dato)
{
    Nodo actual = Head;
    while (actual != null)
    {
        if (actual.Dato == dato) return true;
        actual = actual.Siguiente;
    }
    return false;
}
Salida esperada:

Buscar "Maria": true
Buscar "Luis": false
```

# Ejercicio 8: Contar los nodos de la lista
Objetivo: Contar cuántos nodos hay en la lista.

Explicación:
Se recorre toda la lista sumando uno por cada nodo encontrado.

Código en C#:

```csharp
Copiar código
public int Contar()
{
    int contador = 0;
    Nodo actual = Head;
    while (actual != null)
    {
        contador++;
        actual = actual.Siguiente;
    }
    return contador;
}
Salida esperada:

yaml
Copiar código
Cantidad de nodos: 3
```

# Ejercicio 9: Invertir la lista simple
Objetivo: Invertir el orden de los nodos en la lista.

Explicación:
Se recorren los nodos cambiando las referencias Siguiente para que apunten al anterior.

Código en C#:

```csharp
public void Invertir()
{
    Nodo anterior = null, actual = Head, siguiente = null;
    while (actual != null)
    {
        siguiente = actual.Siguiente;
        actual.Siguiente = anterior;
        anterior = actual;
        actual = siguiente;
    }
    Head = anterior;
}
Salida esperada:

Maria -> Juan -> Pedro -> null
```

# Ejercicio 10: Mostrar la lista en consola
Objetivo: Recorrer y mostrar todos los nodos de la lista.

Explicación:
Se imprime el valor de cada nodo hasta llegar a null.

Código en C#:

```csharp

public void Mostrar()
{
    Nodo actual = Head;
    while (actual != null)
    {
        Console.Write(actual.Dato + " -> ");
        actual = actual.Siguiente;
    }
    Console.WriteLine("null");
}
Salida esperada:

Pedro -> Juan -> Maria -> null
```