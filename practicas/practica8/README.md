# Practica 8 Lista Simple en C#

Este proyecto implementa una **Lista Simple (Singly Linked List)** en C# con un **menú interactivo** para manipularla desde la consola.

---

## Estructura del proyecto

El proyecto está dividido en tres archivos:

1. `Nodo.cs` – Define la estructura de un nodo de la lista.
2. `ListaSimple.cs` – Contiene la clase con todas las operaciones de la lista.
3. `Program.cs` – Programa principal con un menú interactivo para el usuario.

Todos los archivos pertenecen al namespace `ListaSimpleApp`.

---

## 1. Nodo

```csharp
class Nodo
{
    public int dato;
    public Nodo? siguiente;

    public Nodo(int valor)
    {
        dato = valor;
        siguiente = null;
    }
}
Cada nodo guarda un dato y referencia al siguiente nodo.

siguiente puede ser null si es el último nodo.

2. ListaSimple
csharp
Copiar código
class ListaSimple
{
    private Nodo? cabeza;

    public void InsertarInicio(int valor) { ... }
    public void InsertarFinal(int valor) { ... }
    public void Eliminar(int valor) { ... }
    public bool Buscar(int valor) { ... }
    public void Mostrar() { ... }
}
cabeza apunta al primer nodo de la lista.

Si cabeza == null, la lista está vacía.

Operaciones principales:
Insertar al inicio: agrega un nodo al principio de la lista.

Insertar al final: agrega un nodo al final.

Eliminar: elimina la primera ocurrencia de un valor.

Buscar: verifica si un valor existe en la lista.

Mostrar: imprime todos los elementos de la lista.

3. Programa Principal
csharp
Copiar código
class Program
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();
        // Menú interactivo
    }
}
Permite al usuario elegir opciones para manipular la lista: insertar, eliminar, buscar y mostrar.

Maneja entradas inválidas usando int.TryParse para evitar errores.

Menú de opciones:
markdown
Copiar código
===== MENÚ LISTA SIMPLE =====
1. Insertar al inicio
2. Insertar al final
3. Eliminar un valor
4. Buscar un valor
5. Mostrar lista
6. Salir
Ejemplo de uso
Insertar 10 al inicio y 20 al final:

rust
Copiar código
Lista: 10 -> 20 -> null
Buscar 10:

nginx
Copiar código
Valor encontrado.
Eliminar 10:

yaml
Copiar código
Lista: 20 -> null
Conceptos y características
Nodo y referencias: estructuras dinámicas enlazadas.

Nullables (Nodo?): seguridad contra null reference en C# 8+.

TryParse: entrada segura de datos por consola.

Ciclos while y do-while: para recorrer la lista y el menú.

Separación por archivos: buena organización y escalabilidad del proyecto.

