
---
#  Lista Enlazada Simple en C#
---

Este proyecto implementa una **Lista Enlazada Simple** en C#, con énfasis en la operación **Insertar al Principio**.

---

##  Descripción del Código

- **Nodo**
  - Representa cada elemento de la lista.
  - Contiene:
    - `Dato`: Este almacena un número entero.
    - `Siguiente`: Es referencia al siguiente nodo.

- **ListaEnlazada**
  - Contiene la referencia al primer nodo (`Cabeza`).
  - Métodos principales:
    - `InsertarAlPrincipio(int dato)`: agrega un nuevo nodo al inicio de la lista.
    - `Mostrar()`: recorrera y mostrara los valores de la lista en consola.

- **Program**
  - Esta es la clase principal que prueba la funcionalidad.
  - Inserta los siguientes valores `30`, `20`, `10` en la lista al principio.
  - Finalmente mostrara la lista resultante.

---

##  Ejecución del Programa

Al ejecutar el código, se obtiene la siguiente salida:

```
Lista enlazada:
10 -> 20 -> 30 -> null
```