# 📌 Practca 9 Lista Simple en C#  

Este proyecto es una implementación de una **Lista Simple (singly linked list)** en **C#**, con un menú interactivo en consola para manipularla.  

---

## 📂 Archivos / Clases principales

- **Nodo**  
  Clase que representa un nodo de la lista.  
  - Campos: `Valor` (string) y `Siguiente` (Nodo).  
  - Constructor: recibe el valor y pone `Siguiente = null`.  

- **ListaSimple**  
  Clase que contiene la lista y las operaciones principales.  
  - Campo: `Head` (cabeza de la lista, primer nodo).  
  - Operaciones: insertar al inicio, insertar al final, eliminar por valor, buscar, contar, verificar si está vacía, vaciar y mostrar.  

- **Principal (Main)**  
  Programa con un menú de consola para probar la lista de manera interactiva.  

---

## ⚙️ Explicación del código

### 1️⃣ Nodo
```csharp
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
Un Nodo guarda un valor y la referencia al siguiente nodo.
El último nodo siempre tiene Siguiente = null.

2️⃣ Inicializar la lista
csharp
Copiar código
public class ListaSimple
{
    public Nodo Head { get; private set; }

    public ListaSimple()
    {
        this.Head = null;
    }
}
Head apunta al primer nodo.
Si es null, significa que la lista está vacía.

3️⃣ Insertar al inicio
csharp
Copiar código
public void InsertarAlInicio(string valor)
{
    Nodo nodo = new Nodo(valor);
    nodo.Siguiente = this.Head;
    this.Head = nodo;
}
Se crea un nuevo nodo.

Su Siguiente apunta al nodo que era la cabeza.

Se actualiza la cabeza (Head) con el nuevo nodo.

4️⃣ Insertar al final
csharp
Copiar código
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
Si la lista está vacía, el nuevo nodo pasa a ser Head.

Si no, se recorre hasta el último nodo y se enlaza el nuevo.

5️⃣ Eliminar por valor
csharp
Copiar código
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
Si el valor está en la cabeza, se mueve Head.

Si está en el medio/final, se ajustan los enlaces para saltar el nodo eliminado.

6️⃣ Buscar (Contiene)
csharp
Copiar código
public bool Contiene(string valor)
{
    Nodo actual = this.Head;
    while (actual != null) {
        if (actual.Valor == valor) return true;
        actual = actual.Siguiente;
    }
    return false;
}
Recorre la lista y devuelve true si encuentra el valor.

7️⃣ Verificar si está vacía y contar elementos
csharp
Copiar código
public bool EstaVacia() { return this.Head == null; }

public int Count()
{
    int contador = 0;
    Nodo actual = this.Head;
    while (actual != null) { contador++; actual = actual.Siguiente; }
    return contador;
}
EstaVacia() revisa si Head == null.

Count() recorre la lista sumando nodos.

8️⃣ Vaciar la lista
csharp
Copiar código
public void Vaciar() { this.Head = null; }
Basta con poner Head = null.
El garbage collector de C# libera los nodos automáticamente.

9️⃣ Mostrar la lista
csharp
Copiar código
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
Imprime todos los nodos con una flecha (->) entre ellos.

🆕 Comandos y estructuras usadas en el proyecto
string.Equals(valor1, valor2, StringComparison.OrdinalIgnoreCase)
Compara cadenas ignorando mayúsculas y minúsculas.

csharp
Copiar código
if (string.Equals("Hola", "hola", StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("Son iguales!");
int.TryParse(Console.ReadLine(), out opcion)
Convierte un texto en número de forma segura.

csharp
Copiar código
int numero;
if (int.TryParse("123", out numero))
    Console.WriteLine("Convertido: " + numero);
else
    Console.WriteLine("No se pudo convertir.");
Operador ternario ? :
Es como un if resumido en una sola línea.

csharp
Copiar código
int edad = 20;
string mensaje = (edad >= 18) ? "Mayor de edad" : "Menor de edad";
Console.WriteLine(mensaje);
do { ... } while (condición);
Ciclo que siempre se ejecuta al menos una vez.

csharp
Copiar código
int i = 0;
do {
    Console.WriteLine("Se ejecuta al menos una vez");
} while (i > 0);
▶️ Ejemplo de uso
markdown
Copiar código
===== MENÚ LISTA SIMPLE =====
1. Mostrar Lista (Ver)
2. Insertar al inicio
3. Insertar al final
4. Eliminar (por valor)
5. Buscar (Contiene)
6. ¿Está vacía?
7. Contar elementos
8. Vaciar lista
0. Salir
Ejemplo de salida:

less
Copiar código
Valor a insertar al inicio: A
Valor a insertar al final: B
Lista: A -> B
Cantidad de elementos: 2