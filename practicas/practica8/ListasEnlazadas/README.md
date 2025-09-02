#  Documentación: Lista Enlazada Simple en C#

##  Descripción General
Este programa implementa una **lista enlazada simple** en C#.  
Permite realizar distintas operaciones sobre la lista a través de un **menú interactivo en consola**.  

El objetivo es demostrar cómo funcionan las estructuras dinámicas de datos (listas enlazadas) y cómo se pueden manipular sus elementos.

---

##  Estructura del Programa

### Clase `Nodo`
Representa cada elemento de la lista.
- **Atributos:**
  - `Valor` → dato almacenado (entero).
  - `Siguiente` → referencia al siguiente nodo.
- **Constructor:** inicializa el valor y deja el puntero en `null`.

---

### Clase `ListaSimple`
Maneja la lista enlazada simple mediante nodos.  
Incluye operaciones para agregar, eliminar, buscar e invertir elementos.

#### Métodos principales:
- **`AgregarAlInicio(int numero)`**  
  Inserta un nuevo nodo al inicio de la lista.

- **`AgregarAlFinal(int numero)`**  
  Inserta un nodo al final de la lista.

- **`InsertarDespues(int referencia, int nuevoValor)`**  
  Agrega un nodo después de un valor específico en la lista.

- **`EliminarPrimero()`**  
  Elimina el primer nodo de la lista.

- **`EliminarPorValor(int valor)`**  
  Elimina la primera ocurrencia de un valor dado.

- **`EliminarPorIndice(int posicion)`**  
  Elimina el nodo que se encuentra en la posición indicada (basada en índice 0).

- **`BuscarIndice(int valor)`**  
  Devuelve el índice de un valor buscado o `-1` si no existe.

- **`Contar()`**  
  Retorna la cantidad de elementos en la lista.

- **`Vaciar()`**  
  Elimina todos los elementos de la lista.

- **`Invertir()`**  
  Invierte el orden de la lista.

- **`ComoEnumerable()`**  
  Recorre los elementos de la lista y los devuelve como secuencia iterable.

- **`ToString()`**  
  Devuelve una representación visual de la lista en formato:  
  `1 -> 2 -> 3`

---

### Clase `Principal`
Contiene el **método `Main`**, que ejecuta el programa y muestra un menú con las operaciones disponibles.

#### Métodos auxiliares:
- **`MostrarMenu()`**  
  Despliega las opciones disponibles para el usuario.
  
- **`LeerEntero(string mensaje)`**  
  Solicita al usuario ingresar un número entero de forma segura (valida entradas incorrectas).

---

## 🖥️ Menú del Programa
El menú interactivo incluye las siguientes opciones:

1. Agregar al inicio  
2. Agregar al final  
3. Insertar después de un valor  
4. Eliminar primero  
5. Eliminar por valor  
6. Eliminar por posición (0-based)  
7. Buscar valor (devuelve índice)  
8. Mostrar lista  
9. Contar elementos  
10. Invertir lista  
11. Vaciar lista  
0. Salir  

---


