# Documentación: Lista Enlazada Simple en C#

Este proyecto implementa una **lista enlazada simple** en C#, donde cada nodo contiene un dato entero y una referencia al siguiente nodo.

---

## Estructura principal del código

### **Clase `NodoLista`**
- Representa cada nodo de la lista.
- Contiene:
  - `Dato`: el valor almacenado en el nodo.
  - `SiguienteNodo`: referencia al siguiente nodo de la lista.

```csharp
public class NodoLista
{
    public int Dato { get; set; }
    public NodoLista? SiguienteNodo { get; set; }

    public NodoLista(int dato)
    {
        Dato = dato;
        SiguienteNodo = null;
    }
}

```

**Clase ListaEnlazada**

### Contiene todos los métodos para manipular la lista.

## Métodos principales:

1. EstaVacia()

- Verifica si la lista no tiene elementos.

2. AñadirAlInicio(int valor)

- Inserta un nuevo nodo al inicio de la lista.

3. AñadirAlFinal(int valor)

- Inserta un nuevo nodo al final de la lista.

4. InsertarDespuesDe(int valorReferencia, int valorNuevo)

- Inserta un nuevo nodo después de un valor existente.

5. EliminarPrimero()

- Elimina el primer nodo de la lista.

6. EliminarPorValor(int valor)

- Busca y elimina el primer nodo que contenga el valor dado.

7. EliminarPorPosicion(int posicion)

- Elimina el nodo en la posición indicada (inicia en 0).

8. BuscarIndiceDe(int valor)

- Retorna el índice del valor buscado, o -1 si no existe.

9. ContarElementos()

- Cuenta la cantidad de nodos en la lista.

10. VaciarLista()

- Elimina todos los elementos de la lista.

11. InvertirLista()

- Invierte el orden de los nodos de la lista.

12. ObtenerElementos()

- Devuelve los valores de los nodos en forma de IEnumerable<int>.

# La Estructura del menú:
===== MENÚ =====
1) Añadir al inicio
2) Añadir al final
3) Insertar después de un valor
4) Eliminar primero
5) Eliminar por valor
6) Eliminar por posición
7) Buscar valor
8) Mostrar lista
9) Contar elementos
10) Invertir lista
11) Vaciar lista
0) Salir


-   El usuario elige una opción escribiendo el número correspondiente.

-   Cada opción ejecuta un método de la clase ListaEnlazada.

-   El programa sigue en ejecución hasta que se elige la opción 0 (Salir).