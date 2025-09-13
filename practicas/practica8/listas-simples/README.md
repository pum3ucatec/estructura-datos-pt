**INDICE**
- [Documentación de la practica8](#documentación-de-la-practica8)
  - [1. Clase `Nodo`](#1-clase-nodo)
  - [2. Clase `ListasSimples`](#2-clase-listassimples)
  - [3. Clase `Program`](#3-clase-program)
  - [4. Ejemplo de uso en consola](#4-ejemplo-de-uso-en-consola)
# Documentación de la practica8
Este proyecto implementa una estructura de datos denominada Lista Enlazada Simple. La lista enlazada permite manejar colecciones de datos sin necesidad de conocer su tamaño de antemano, a diferencia de los arreglos.

Este proyecto incluye:

- La clase ListasSimples, que encapsula toda la lógica de la estructura
- La interfaz de usuario mediante un menú en la consola.

Esta práctica sigue las siguientes convenciones de nombres:

- Clases y métodos → PascalCase 

- Variables locales y parámetros → camelCase
  
---

## 1. Clase `Nodo`
Representa la unidad básica de la lista.

**Archivo:** [`nodo/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica8/practicas/practica8/listas-simples/nodo.cs)

**Atributos**:

- **Dato**: Almacena el valor entero del nodo.

- **Siguiente**: Referencia al siguiente nodo en la lista (o null si es el último).

Gracias a la referencia Siguiente, los nodos se encadenan formando la lista.

---

## 2. Clase `ListasSimples`
Esta clase encapsula la lógica para manipular la lista. Posee como atributo principal la referencia cabeza, que apunta al primer nodo.

**Archivo:** [`listas-simples/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica8/practicas/practica8/listas-simples/listas-simples.cs)


**Métodos principales:**

1. `Mostrar()`

    - Recorre la lista desde la cabeza hasta llegar a null.

    - Imprime los valores en el formato:
  
          dato1 -> dato2 -> ... -> null

    - Si la lista está vacía, notifica al usuario.
  

2. `InsertarAlInicio(int dato)`

    - Crea un nuevo nodo con el valor dado.

    - El nodo recién creado apunta al nodo que era la cabeza.

    - La cabeza se actualiza para apuntar al nuevo nodo.


3. `InsertarAlFinal(int dato)`

    - Recorre la lista hasta encontrar el último nodo (`Siguiente == null`).

    - Inserta el nuevo nodo al final.

    - Si la lista está vacía, el nuevo nodo pasa a ser la cabeza.

4. `EliminarDeUnaPosicion(int posicion)`

   - Elimina el nodo en la posición indicada, en este caso no se toma en cuenta la posición 0.

   - **Casos:**

      - Si la posición es 1 → la cabeza pasa a ser el siguiente nodo.

      - Si la posición es mayor → se recorre hasta el nodo anterior y se ajusta la referencia.

    - Valida posiciones fuera de rango.


5. `Buscar(int dato)`

    - Recorre nodo por nodo verificando si el valor coincide.

    - Devuelve la posición en caso de éxito.

    - Si no lo encuentra, informa al usuario.

6. `Contar()`

   - Recorre toda la lista incrementando un contador.

   - Retorna el número total de nodos.


7. `EstaVacia()`

     - Retorna true si la cabeza es null.

8. `Vaciar()`

    - Asigna null a la cabeza, liberando la lista.

---

## 3. Clase `Program`

Contiene el menú interactivo que permite al usuario probar las operaciones.

Se ejecuta dentro de un bucle do-while hasta que el usuario elige la opción 0 (Salir).

Cada opción del menú corresponde a un método de la clase ListasSimples.


**Archivo:** [`Program/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica8/practicas/practica8/listas-simples/Program.cs)

**Ejemplo de opciones:**

        1. Mostrar lista
        2. Insertar al inicio
        3. Insertar al final
        4. Eliminar en una posición
        5. Buscar elemento
        6. Contar elementos
        7. Verificar si está vacía
        8. Vaciar lista
        9. Salir
   
## 4. Ejemplo de uso en consola


       === MENÚ LISTA SIMPLE ===
       1. Mostrar lista
       2. Insertar al inicio
       3. Insertar al final
       4. Eliminar en una posición específica
       5. Buscar un elemento
       6. Contar elementos
       7. Verificar si está vacía
       8. Vaciar lista
       0. Salir

       Elige una opción: 2
       Ingrese el dato:4

       Elige una opción: 3
       Ingrese el dato:5

En fin asi sucesivamnete con cada función

y eso seria todo **GRACIAS!!!**