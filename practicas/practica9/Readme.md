# Lista Doble en C# 

Implementación de una **lista doblemente enlazada** (cada nodo conoce a su `Siguiente` y a su `Anterior`). Incluye un menú por consola para practicar las operaciones básicas.

---

##  Clases del proyecto

- **`NodoDoble`**
  - Campos: `Dato` (string), `Siguiente` (NodoDoble), `Anterior` (NodoDoble).
  - Constructor: recibe un `dato` y deja `Siguiente = null` y `Anterior = null`.

- **`ListaDoble`**
  - Campos: `Inicio` (primer nodo) y `Fin` (último nodo).
  - Operaciones: Insertar al inicio, Insertar al final, Eliminar del inicio, Eliminar del final, Mostrar adelante, Mostrar atrás, Buscar.

- **`Principal`**
  - `Main` con un **menú** `do-while` y `switch` para probar cada operación.

---

##  Explicación 

### 1) Clase `NodoDoble`
```
public class NodoDoble
{
    public string Dato;
    public NodoDoble Siguiente;
    public NodoDoble Anterior;

    public NodoDoble(string dato)
    {
        Dato = dato;
        Siguiente = null;
        Anterior = null;
    }
}
```

Representa una “cajita” con:

Dato: lo que guardamos (texto).

Siguiente: apunta al nodo de la derecha.

Anterior: apunta al nodo de la izquierda.

### 2) Estructura base de la lista
```
public class ListaDoble
{
    public NodoDoble Inicio;
    public NodoDoble Fin;

    public ListaDoble()
    {
        Inicio = null;
        Fin = null;
    }
}
```

Si Inicio y Fin están en null, la lista está vacía.

Inicio siempre debe apuntar al primer nodo; Fin, al último.

### 3) Insertar al inicio
```
public void InsertarInicio(string dato)
{
    NodoDoble nuevo = new NodoDoble(dato);

    if (Inicio == null)  // lista vacía
    {
        Inicio = nuevo;
        Fin = nuevo;
    }
    else
    {
        nuevo.Siguiente = Inicio;
        Inicio.Anterior = nuevo;
        Inicio = nuevo;
    }
}
```

Caso vacío: el nuevo nodo se vuelve Inicio y Fin.

Caso normal: el nuevo nodo va antes del actual Inicio. Se conectan las referencias en ambos sentidos.

### 4) Insertar al final
```
public void InsertarFinal(string dato)
{
    NodoDoble nuevo = new NodoDoble(dato);

    if (Fin == null)  // lista vacía
    {
        Inicio = nuevo;
        Fin = nuevo;
    }
    else
    {
        Fin.Siguiente = nuevo;
        nuevo.Anterior = Fin;
        Fin = nuevo;
    }
}
```

Caso vacío: el nuevo nodo es Inicio y Fin.

Caso normal: se coloca después del Fin y se actualiza Fin.

### 5) Eliminar del inicio
```
public string EliminarInicio()
{
    if (Inicio == null) return null;

    string eliminado = Inicio.Dato;
    Inicio = Inicio.Siguiente;

    if (Inicio != null)
        Inicio.Anterior = null;
    else
        Fin = null;

    return eliminado;
}
```

Si hay al menos un nodo, movemos Inicio al siguiente.

Si quedó vacío, también ponemos Fin = null.

### 6) Eliminar del final
```
public string EliminarFinal()
{
    if (Fin == null) return null;

    string eliminado = Fin.Dato;
    Fin = Fin.Anterior;

    if (Fin != null)
        Fin.Siguiente = null;
    else
        Inicio = null;

    return eliminado;
}
```

Si hay al menos un nodo, movemos Fin al anterior.

Si quedó vacío, también ponemos Inicio = null.

### 7) Mostrar adelante (de inicio a fin)
```
public void MostrarAdelante()
{
    if (Inicio == null)
    {
        Console.WriteLine("La lista está vacía.");
        return;
    }

    NodoDoble actual = Inicio;
    Console.Write("Lista adelante: ");
    while (actual != null)
    {
        Console.Write(actual.Dato + " <-> ");
        actual = actual.Siguiente;
    }
    Console.WriteLine("null");
}
```



### 8) Mostrar atrás (de fin a inicio)
``` 
public void MostrarAtras()
{
    if (Fin == null)
    {
        Console.WriteLine("La lista está vacía.");
        return;
    }

    NodoDoble actual = Fin;
    Console.Write("Lista atrás: ");
    while (actual != null)
    {
        Console.Write(actual.Dato + " <-> ");
        actual = actual.Anterior;
    }
    Console.WriteLine("null");
}
```

Recorre usando Anterior.

### 9) Buscar un dato (simple)
```

public bool Buscar(string dato)
{
    NodoDoble actual = Inicio;

    while (actual != null)
    {
        if (actual.Dato.ToLower() == dato.ToLower())
        {
            return true;
        }
        actual = actual.Siguiente;
    }
    return false;
}
```

Compara con ToLower() para ignorar mayúsculas/minúsculas.

Devuelve true si lo encuentra.

### 10) Menú en Main
```
int opcion = -1;
do
{
    // 1) Mostrar menú
    // 2) Leer opción: int.Parse(Console.ReadLine())
    // 3) switch(opcion) { ... } para ejecutar cada caso
} while (opcion != 0);
```

do-while asegura que el menú aparece al menos una vez.

switch organiza las acciones (insertar, eliminar, mostrar, buscar, salir).

## Comandos 

`int.Parse(Console.ReadLine())`

Convierte lo que escribe el usuario a número entero (si escribe letras, falla).

`ToLower() en strings`
Útil para comparar textos sin importar mayúsculas/minúsculas.
`if (a.ToLower() == b.ToLower()) { ... }`

`do { ... } while (condición);`
El bloque se ejecuta al menos una vez antes de evaluar la condición.
