# Documentación de la Práctica 9  
**Tema:** Lista Doblemente Enlazada en C#  

---

## Índice
1. [Introducción](#introducción)  
2. [Clase NodoDoble](#clase-nododoble)  
3. [Clase ListasDobles](#clase-listasdobles)  
   1. [Métodos principales](#métodos-principales)  
      - [Mostrar lista](#mostrar-lista)  
      - [Inserciones](#inserciones)  
      - [Eliminaciones](#eliminaciones)  
      - [Operaciones adicionales](#operaciones-adicionales)  
4. [Clase Program](#clase-program)  
5. [Salida esperada](#salida-esperada)  
   1. [Ejemplos de ejecución](#ejemplos-de-ejecución)  
6. [Diagrama de flujo](#diagrama-de-flujo)  

---

## Introducción
Este proyecto implementa una **Lista Doblemente Enlazada** en C#. Cada nodo tiene referencias tanto al **siguiente** como al **anterior**, lo que permite recorrer la lista en ambas direcciones y facilita operaciones de inserción y eliminación.  

**Convenciones de nombres:**  
- Clases y métodos → PascalCase  
- Variables locales y parámetros → camelCase  

---

## Clase NodoDoble
Representa un nodo de la lista doble, que puede ser recorrido hacia adelante y hacia atrás.  

Archivo: `nodo-doble/Program.cs`  

**Atributos:**  
- `Dato`: almacena el valor del nodo.  
- `Siguiente`: referencia al siguiente nodo.  
- `Anterior`: referencia al nodo anterior.  

---

## Clase ListasDobles
Contiene la lógica principal de la lista.  

Archivo: `ListasDobles.cs`  

**Atributos principales:**  
- `cabeza`: primer nodo de la lista.  
- `cola`: último nodo de la lista.  

### Métodos principales

#### Mostrar lista
- `MostrarHaciaAdelante()`: imprime desde la cabeza hasta la cola.  
- `MostrarHaciaAtras()`: imprime desde la cola hasta la cabeza.  

#### Inserciones
- `InsertarAlInicio(int dato)`: agrega un nodo al inicio.  
- `InsertarAlFinal(int dato)`: agrega un nodo al final.  

#### Eliminaciones
- `EliminarAlInicio()`: elimina el primer nodo.  
- `EliminarAlFinal()`: elimina el último nodo.  
- `EliminarEnPosicion(int posicion)`: elimina un nodo en una posición específica.  

#### Operaciones adicionales
- `Buscar(int dato)`: encuentra un valor y devuelve su posición.  
- `Contar()`: devuelve la cantidad de nodos.  
- `EstaVacia()`: indica si la lista está vacía.  
- `Vaciar()`: elimina todos los nodos.  

---

## Clase Program
Contiene un **menú interactivo** que permite al usuario probar todas las operaciones de la lista doble.  

Archivo: `Program/Program.cs`  

**Descripción:**  
- El bucle `do-while` mantiene el menú activo hasta que se elige la opción `0` (Salir).  
- Las opciones incluyen mostrar la lista, insertar, eliminar, contar, buscar y vaciar.  

---

## Salida esperada
=== MENÚ LISTA DOBLE ===

Mostrar lista hacia adelante

Mostrar lista hacia atrás

Insertar al inicio

Insertar al final

Eliminar al inicio

Eliminar al final

Eliminar en una posición específica

Buscar un elemento

Contar elementos

Verificar si está vacía

Vaciar lista

Salir

### Ejemplos de ejecución
**Mostrar lista hacia adelante:**  
Elige una opción: 1
Lista hacia adelante: 5 <-> 6 <-> 9 <-> 1 <-> null


**Eliminar de una posición específica:**  


Elige una opción: 7
Ingrese la posición a eliminar: 3
Nodo en la posición 3 eliminado.


**Buscar un elemento:**  


Elige una opción: 8
Ingrese el elemento a buscar: 5
Elemento 5 no encontrado en la lista.


**Contar elementos:**  


Elige una opción: 9
La lista tiene 3 elementos.


---


---

## Diagrama de flujo
Se recomienda un diagrama donde se muestre:  
1. Inicio → mostrar menú.  
2. Selección de opción → llamar al método correspondiente de `ListasDobles`.  
3. Repetir menú hasta opción 0 → salir.  
