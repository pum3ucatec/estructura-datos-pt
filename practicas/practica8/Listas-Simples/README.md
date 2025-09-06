# Lista Enlazada Simple en C#

Este proyecto implementa una **lista enlazada simple** con las operaciones fundamentales para manipularla de forma dinámica y eficiente.

## Funcionalidades principales

- **Agregar al inicio:** Inserta un nuevo nodo al principio de la lista.
- **Agregar al final:** Añade un nodo al final, recorriendo la lista si es necesario.
- **Insertar después de un valor:** Busca un nodo con un valor específico y agrega un nuevo nodo justo después.
- **Eliminar primero:** Quita el primer nodo, ajustando la referencia del inicio.
- **Eliminar por valor:** Busca y elimina el primer nodo que contiene un valor dado.
- **Eliminar por índice (0-based):** Borra el nodo que se encuentra en la posición indicada.
- **Buscar valor:** Retorna el índice del primer nodo que contiene el valor, o -1 si no existe.
- **Contar elementos:** Cuenta y devuelve la cantidad total de nodos en la lista.
- **Invertir lista:** Invierte el orden de los nodos, modificando las referencias para recorrerla al revés.
- **Vaciar lista:** Elimina todos los nodos dejando la lista completamente vacía.

## Características del código

- La clase `Nodo` representa cada elemento con un valor entero y referencia al siguiente nodo.
- La clase `Lista` maneja internamente el nodo de inicio y provee métodos para las operaciones mencionadas.
- Uso de bucles para recorrer la lista y realizar búsquedas, inserciones y eliminaciones.
- El programa principal ofrece un menú sencillo y claro para que el usuario interactúe y pruebe cada función.
- Validación básica para entradas y manejo de casos donde la lista esté vacía o los índices sean inválidos.
- Implementación clara y directa, ideal para aprender y entender cómo funcionan las listas enlazadas simples.

## Uso

Al ejecutar el programa, se muestra un menú con las opciones para manipular la lista. El usuario puede agregar, buscar, eliminar nodos y ver el estado actual de la lista por consola.

Este código es una base sólida para entender estructuras de datos dinámicas y puede ampliarse para incluir funcionalidades más avanzadas.
