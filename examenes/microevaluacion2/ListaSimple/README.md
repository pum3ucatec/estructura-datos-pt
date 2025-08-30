# LISTAS SIMPLES
### MICROEVALUACION 2
1. Insertar al principio en un alista simple
2. Eliminar al rededor 
 # Introduccion

Este proyecto implementa **listas simples** y una **cola dinámica** en C#, incluyendo operaciones básicas y avanzadas, junto con un menú interactivo para probarlas.

---

## Archivos del Proyecto

* **ListaSimple.cs** → Implementación de una lista enlazada simple con inserción, eliminación alrededor y mostrar.
* **Nodos.cs** → Definición de las clases `Nodo` y `NodoLista`.
* **Program.cs** → Programa principal con un menú de opciones para interactuar con la cola y la lista simple.

---

##  Funcionalidades

### 🔹 Lista Simple

* **Insertar al principio** → Agrega un nuevo nodo al inicio de la lista.
* **Eliminar alrededor** → Busca un nodo y elimina su anterior y posterior (si existen).
* **Mostrar lista** → Recorre e imprime los nodos en formato `dato -> ... -> null`.

### 🔹 Cola Dinámica (Pendiente de implementar)

* **Enqueue (Insertar)** → Agregar un elemento al final de la cola.
* **Dequeue (Eliminar)** → Eliminar el primer elemento.
* **Peek** → Consultar el primer elemento sin eliminarlo.
* **Count** → Número de elementos en la cola.
* **Clear** → Vaciar la cola.
* **Contains** → Verificar si un elemento existe.
* **IsEmpty** → Verificar si la cola está vacía.
* **IsFull** → Verificar si la cola está llena (en este caso, no aplica para una dinámica).

---

##  Explicación del Código

### 1️ ListaSimple.cs

```csharp
public void InsertarAlPrincipio(int valor)
{
    NodoLista nuevo = new NodoLista(valor);
    nuevo.Siguiente = cabeza;
    cabeza = nuevo;
}
```

 Inserta un nodo al inicio.

```csharp
public void EliminarAlrededor(int valor)
{
    // Busca el nodo con el valor
    // Si lo encuentra elimina el anterior y el siguiente
}
```

 Permite eliminar los nodos que rodean a un valor dado.

```csharp
public void Mostrar()
{
    // Recorre e imprime la lista
}
```

 Imprime todos los nodos de la lista en orden.

---

### 2️ Nodos.cs

```csharp
public class NodoLista
{
    public int Dato { get; set; }
    public NodoLista Siguiente { get; set; }

    public NodoLista(int dato)
    {
        this.Dato = dato;
        this.Siguiente = null;
    }
}
```

 Clase que representa cada nodo de la lista simple.
---

### 3️ Program.cs

Menú principal:

```csharp
Console.WriteLine("1. Mostrar lista");
Console.WriteLine("2. Insertar al principio en Lista Simple");
Console.WriteLine("3. Eliminar alrededor de un valor en Lista Simple");
Console.WriteLine("0. Salir");
```

* **Opción 1** → Llama a `cola.Mostrar()`.
* **Opción 2** → Inserta un nodo al inicio de la lista.
* **Opción 3** → Elimina alrededor de un valor dado.
* **Opción 0** → Termina la ejecución.

---

##  Ejemplo de Ejecución

```
==============================
        MENÚ PRINCIPAL
==============================
1. Mostrar lista
2. Insertar al principio en Lista Simple
3. Eliminar alrededor de un valor en Lista Simple
0. Salir
Seleccione la opción: 2
Ingrese un número para insertar al principio: 5
```

Salida esperada al mostrar:

```
5 -> null
```

---

##  Diagrama de Lista Simple

```
Cabeza → [5] → [10] → [15] → null
```

Tras eliminar alrededor de `10`:

```
Cabeza → [5] → [15] → null
```

---


