#  Lista Simple en C# 
Este proyecto es una implementación de una Lista Simple (singly linked list) en C#.  

---

## Archivos / Clases principales

- **Nodo**: clase que representa un nodo de la lista.  
  - Campos: `Valor` (string) y `Siguiente` (Nodo).  
  - Constructor: recibe el valor y pone `Siguiente = null`.

- **ListaSimple**: clase que contiene la lista y las operaciones.  
  - Campo: `Head` (cabeza de la lista, primer nodo).
  - Operaciones implementadas: insertar al inicio, insertar al final, eliminar por valor, buscar, contar, verificar si está vacía, vaciar y mostrar.

- **Principal (Main)**: menú interactivo para usar la lista desde la consola.

---

##  Explicación 

### 1) Nodo
```
public class Nodo
{
    public string Valor { get; set; }
    public Nodo Siguiente { get; set; }

    public Nodo(string valor)
    {
        this.Valor = valor;
        this.Siguiente = null;
    }
}
```
Un Nodo guarda un Valor y referencia al siguiente Nodo (Siguiente).

Cuando creamos un nodo nuevo, el siguiente es null.

2) Inicializar la lista
```
public class ListaSimple
{
    public Nodo Head { get; private set; }

    public ListaSimple()
    {
        this.Head = null;
    }
}
```

Head apunta al primer nodo. Si es null, la lista está vacía.

3) Insertar al inicio
```
public void InsertarAlInicio(string valor)
{
    Nodo nodo = new Nodo(valor);
    nodo.Siguiente = this.Head;
    this.Head = nodo;
}
```

Creamos un nodo nuevo.

Apuntamos su Siguiente al antiguo Head.

Actualizamos Head al nodo nuevo.

4) Insertar al final
```
public void InsertarAlFinal(string valor)
{
    Nodo nodo = new Nodo(valor);
    if (this.Head == null) this.Head = nodo;
    else {
        Nodo actual = this.Head;
        while (actual.Siguiente != null) actual = actual.Siguiente;
        actual.Siguiente = nodo;
    }
}
```

Si la lista está vacía, el nuevo nodo es Head.

Si no, recorremos hasta el último nodo y enlazamos el nuevo al final.

5) Eliminar por valor
```
public string Eliminar(string valor)
{
    if (this.Head == null) return null;
    if (Head.Valor == valor) { Head = Head.Siguiente; return valor; }
    Nodo anterior = Head;
    Nodo actual = Head.Siguiente;
    while (actual != null) {
        if (actual.Valor == valor) { anterior.Siguiente = actual.Siguiente; return valor; }
        anterior = actual;
        actual = actual.Siguiente;
    }
    return null;
}
```

Se intenta eliminar la primera aparición del valor.

Si está en Head, se mueve Head.

Si está en medio/fin, se ajusta el enlace del anterior para saltar el nodo eliminado.

6) Buscar (Contains)
```
public bool Contiene(string valor)
{
    Nodo actual = this.Head;
    while (actual != null) {
        if (actual.Valor == valor) return true;
        actual = actual.Siguiente;
    }
    return false;
}
```

Recorre la lista y devuelve true si encuentra el valor.

7) Verificar si está vacía y contar elementos
```
public bool EstaVacia() { return this.Head == null; }

public int Count()
{
    int contador = 0;
    Nodo actual = this.Head;
    while (actual != null) { contador++; actual = actual.Siguiente; }
    return contador;
}
```

EstaVacia comprueba si Head == null.

Count recorre la lista y cuenta nodos.

8) Vaciar la lista
```
public void Vaciar() { this.Head = null; }

```
Poner Head = null elimina las referencias y la lista queda vacía (el recolector de memoria se encarga de liberar).

9) Mostrar la lista
```
public void Ver()
{
    if (this.Head == null) { Console.WriteLine("La lista está vacía."); return; }
    Nodo actual = this.Head;
    Console.Write("Lista: ");
    while (actual != null) {
        Console.Write(actual.Valor + (actual.Siguiente != null ? " -> " : ""));
        actual = actual.Siguiente;
    }
    Console.WriteLine();
}
```

## Comandos nuevos

1. **string.Equals(valor1, valor2, StringComparison.OrdinalIgnoreCase)**

Permite comparar cadenas ignorando mayúsculas y minúsculas.
```
if (string.Equals("Hola", "hola", StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("Son iguales!");

```

2. **int.TryParse(Console.ReadLine(), out opcion)**

Convierte un texto en número entero de forma segura, sin que el programa se caiga si el usuario escribe mal.

```
int numero;
if (int.TryParse("123", out numero))
    Console.WriteLine("Convertido: " + numero);
else
    Console.WriteLine("No se pudo convertir.");
```


3. **Operador ternario ? :**

Es como un if resumido en una sola línea.
```
int edad = 20;
string mensaje = (edad >= 18) ? "Mayor de edad" : "Menor de edad";
Console.WriteLine(mensaje);
```

En la lista se usó para imprimir la flecha -> solo si hay otro nodo después.

4. **do { ... } while (condición);**

Un ciclo parecido al while, pero que siempre se ejecuta al menos una vez, aunque la condición sea falsa.

