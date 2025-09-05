# Lista Enlazada Simple con Menú en C#

Este programa implementa una lista enlazada simple con varias operaciones y un menú interactivo para manipularla desde consola.

---

## Estructura General

- **NodoLista**: Clase que representa un nodo de la lista, con un valor entero y referencia al siguiente nodo.
- **ListaEnlazada**: Clase que gestiona la lista enlazada simple, con métodos para agregar, eliminar, buscar, contar, invertir y mostrar elementos.
- **ProgramaPrincipal**: Contiene el método `Main` y maneja el menú interactivo para que el usuario pueda usar la lista desde la consola.

---

## Detalle de Clases y Métodos

### Clase `NodoLista`

Representa un nodo individual de la lista.

- **Propiedades**:
  - `Dato` (int): Valor almacenado en el nodo.
  - `SiguienteNodo` (NodoLista?): Referencia al siguiente nodo en la lista (o null si es el último).

- **Constructor**:
  - `NodoLista(int dato)`: Inicializa el nodo con el valor proporcionado y referencia nula al siguiente nodo.

---

### Clase `ListaEnlazada`

Maneja la lista enlazada simple con operaciones comunes.

- **Campos**:
  - `cabeza` (NodoLista?): Nodo inicial de la lista.

- **Métodos**:

  - `bool EstaVacia()`: Devuelve `true` si la lista está vacía.

  - `void AñadirAlInicio(int valor)`: Inserta un nodo con el valor dado al inicio de la lista.

  - `void AñadirAlFinal(int valor)`: Añade un nodo con el valor dado al final de la lista.

  - `bool InsertarDespuesDe(int valorReferencia, int valorNuevo)`: Inserta un nuevo nodo con `valorNuevo` después del nodo que contiene `valorReferencia`. Devuelve `true` si se insertó correctamente.

  - `bool EliminarPrimero()`: Elimina el primer nodo de la lista. Devuelve `true` si se eliminó.

  - `bool EliminarPorValor(int valor)`: Elimina el primer nodo que contenga el valor especificado. Devuelve `true` si encontró y eliminó el nodo.

  - `bool EliminarPorPosicion(int posicion)`: Elimina el nodo en la posición dada (0-based). Devuelve `true` si la posición es válida y se elimina el nodo.

  - `int BuscarIndiceDe(int valor)`: Busca el índice del primer nodo que contenga el valor dado. Devuelve el índice o `-1` si no se encuentra.

  - `int ContarElementos()`: Cuenta y devuelve el número total de nodos en la lista.

  - `void VaciarLista()`: Elimina todos los nodos dejando la lista vacía.

  - `void InvertirLista()`: Invierte el orden de los nodos en la lista.

  - `IEnumerable<int> ObtenerElementos()`: Permite recorrer los valores de los nodos en orden.

  - `override string ToString()`: Devuelve una representación en cadena de la lista, por ejemplo: `1 -> 2 -> 3`.

---

### Clase `ProgramaPrincipal`

Contiene la lógica para interactuar con el usuario vía consola y manipular la lista enlazada.

- **Método `Main`**: Muestra un menú con opciones para realizar operaciones en la lista enlazada, lee las opciones del usuario y ejecuta los métodos correspondientes.

- **Método `MostrarOpciones()`**: Imprime en consola el menú con las opciones disponibles.

- **Método `LeerNumero(string mensaje)`**: Lee un número entero desde la consola, mostrando un mensaje personalizado y validando la entrada.

---

## Uso del Programa

Al ejecutar el programa, se muestra un menú con opciones para:

1. Añadir elementos al inicio o al final de la lista.
2. Insertar un nuevo elemento después de un valor específico.
3. Eliminar el primer nodo, eliminar por valor o eliminar por posición.
4. Buscar la posición de un valor.
5. Mostrar el contenido actual de la lista.
6. Contar la cantidad de elementos.
7. Invertir el orden de la lista.
8. Vaciar la lista.
9. Salir del programa.

El usuario debe ingresar la opción deseada y seguir las instrucciones para realizar la operación.

