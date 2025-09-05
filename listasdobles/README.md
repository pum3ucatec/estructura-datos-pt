# Guía del programa de la Practica 9

Este código demuestra cómo funciona una lista doblemente enlazada en C# y proporciona un menú interactivo para gestionar la lista. 

## 1. Elementos del código

### Nodo

Cada **nodo** tiene tres elementos:
- Un **valor** que almacena la información.
- Un puntero **siguiente** que apunta al siguiente nodo.
- Un puntero **anterior** que apunta al nodo anterior.

### ListaDoble

La clase **ListaDoble** gestiona la lista:
- **Cabeza**: un puntero al primer nodo de la lista.
- **Cola**: un puntero al último nodo de la lista.

Dentro de esta clase, se implementan varias funciones:

- **InsertarAlPrincipio(valor)**: Inserta un nodo con el valor especificado al inicio de la lista.
- **InsertarAlFinal(valor)**: Inserta un nodo con el valor especificado al final de la lista.
- **EliminarDelPrincipio()**: Elimina el primer nodo de la lista.
- **EliminarDelFinal()**: Elimina el último nodo de la lista.
- **MostrarLista()**: Muestra los valores de los nodos en el orden de la lista (de cabeza a cola).
- **MostrarListaInvertida()**: Muestra los valores de los nodos en el orden inverso (de cola a cabeza).

## 2. Funciones del Menú

El programa ofrece un menú interactivo donde el usuario puede elegir entre varias opciones:

1. **Insertar al principio**: Agregar un valor al principio de la lista.
2. **Insertar al final**: Agregar un valor al final de la lista.
3. **Eliminar del principio**: Eliminar el primer nodo de la lista.
4. **Eliminar del final**: Eliminar el último nodo de la lista.
5. **Mostrar lista**: Mostrar la lista desde el principio hasta el final.
6. **Mostrar lista invertida**: Mostrar la lista desde el final hasta el principio.
7. **Salir**: Salir del programa.

## 3. Ejemplo de flujo del programa

### Paso 1: Insertar un valor
Supongamos que el usuario elige la opción "Insertar al principio" e ingresa el valor 10. El programa:
- Crea un nuevo nodo con el valor 10.
- Inserta este nodo al principio de la lista.

### Paso 2: Mostrar la lista
El usuario selecciona la opción "Mostrar lista". El programa recorre la lista desde el primer nodo hasta el último y muestra los valores almacenados en los nodos.

### Paso 3: Eliminar un valor
El usuario elige la opción "Eliminar del principio". El programa elimina el primer nodo de la lista y ajusta el puntero de la cabeza para que apunte al siguiente nodo.

### Paso 4: Salir
Cuando el usuario selecciona "Salir", el programa termina.

## 4. Beneficios de una Lista Doblemente Enlazada

- **Flexibilidad de recorrido**: La capacidad de recorrer la lista en ambas direcciones facilita muchas operaciones.
- **Eficiencia**: Las operaciones de inserción y eliminación en ambos extremos son rápidas y eficientes.


