
---
#  Lista Doblemente Enlazada en C#

Este proyecto implementa una **Lista Doblemente Enlazada** en C#, donde cada nodo contiene:
- Un **dato**.
- Una referencia al **nodo anterior**.
- Una referencia al **nodo siguiente**.

---

## Estructura del Código

- **NodoDoble**
  - Representa cada elemento de la lista.
  - Propiedades:
    - `Dato`: almacena el valor del nodo.
    - `Anterior`: referencia al nodo previo.
    - `Siguiente`: referencia al nodo siguiente.

- **ListaDoble**
  - Clase que gestiona la lista.
  - Métodos principales:
    - `InsertarAlInicio(int dato)`: agrega un nodo al inicio.
    - `InsertarAlFinal(int dato)`: agrega un nodo al final.
    - `Eliminar(int dato)`: elimina el primer nodo que contenga el valor indicado.
    - `MostrarAdelante()`: recorre la lista desde la cabeza hasta el final.
    - `MostrarAtras()`: recorre la lista desde el final hasta la cabeza.

- **Program**
  - Clase principal que prueba la lista.
  - Inserta elementos, los muestra en ambos sentidos y elimina un valor.

---

##  Ejecución del Programa

Salida esperada:

```
Recorrido hacia adelante:
NULL - 10 - 20 - 30 - 40 - NULL

Recorrido hacia atrás:
NULL - 40 - 30 - 20 - 10 - NULL

Eliminando el 30...
Lista después de eliminar:
NULL - 10 - 20 - 40 - NULL
````

