# Guía del codigo trabajado de la Practica 8


## 1 ¿Cómo funciona este programa?

### 1.1. La lista enlazada

En este programa, los datos están organizados en una **lista enlazada simple**. La lista comienza con un nodo llamado **cabeza**, que es el primer nodo de la lista. Cada nodo contiene un número y tiene un enlace (puntero) al siguiente nodo.

La **cabeza** de la lista es el punto de partida, y a partir de ahí, el programa puede moverse de un nodo a otro, siguiendo los enlaces entre ellos.

### 1.2. ¿Qué se puede hacer con esta lista?

El programa permite realizar varias operaciones sobre la lista enlazada. Aquí están algunas de las más importantes:

#### **Insertar elementos**
- Puedes **insertar un número al principio** de la lista o al **final**. 
- También es posible **insertar un número después de otro** valor específico que ya esté en la lista.

#### **Eliminar elementos**
- Se pueden **eliminar nodos** de la lista de diferentes maneras: 
  - Eliminar el **primer nodo**.
  - Eliminar el **primer nodo que tenga un valor específico**.
  - Eliminar un nodo en una **posición específica**.

#### **Buscar y contar elementos**
- El programa te permite **buscar un valor** en la lista y te dice en qué posición se encuentra.
- También puedes **contar cuántos nodos** (elementos) hay en la lista.

#### **Ver la lista**
- Se puede **mostrar la lista completa** para ver todos los valores en el orden en que están almacenados.
- El programa también tiene la opción de **invertir el orden de los nodos**, para que el último nodo pase a ser el primero y viceversa.

#### **Vaciar la lista**
- Si lo deseas, puedes **vaciar toda la lista** y eliminar todos los nodos.

### 12.3. El menú interactivo

El programa tiene un **menú de opciones** que le permite al usuario elegir qué operación desea realizar en la lista. Las opciones incluyen:
1. Insertar un valor al principio o al final.
2. Insertar un valor después de otro.
3. Eliminar el primer valor o un valor específico.
4. Buscar un valor y obtener su posición.
5. Contar cuántos nodos hay en la lista.
6. Mostrar los valores de la lista.
7. Invertir el orden de la lista.
8. Vaciar toda la lista.
9. Salir del programa.

Cada vez que el usuario elige una opción, el programa realiza la operación correspondiente y luego muestra la lista actualizada.

## 32. Ejemplo de uso

Imagina que el programa se está ejecutando y el usuario hace lo siguiente:

1. Inserta el número **10** al principio de la lista.
2. Inserta el número **20** al final de la lista.
3. Muestra la lista, que ahora contiene los números **10** y **20**.
4. Cuenta cuántos nodos hay en la lista y muestra que hay **2** nodos.
5. El usuario decide eliminar el número **10** de la lista.
6. Muestra la lista nuevamente, y ahora solo queda **20**.
7. Finalmente, el usuario decide salir del programa.

## 3. ¿Por qué usar listas enlazadas?

Las listas enlazadas son útiles cuando se necesita almacenar datos de manera dinámica, es decir, donde no sabemos de antemano cuántos elementos va a haber. A diferencia de los arreglos (que tienen un tamaño fijo), las listas enlazadas pueden crecer o reducirse a medida que se agregan o eliminan elementos.

Además, las listas enlazadas permiten realizar operaciones como **insertar o eliminar elementos rápidamente** sin tener que mover los otros elementos (como ocurre en un arreglo).







