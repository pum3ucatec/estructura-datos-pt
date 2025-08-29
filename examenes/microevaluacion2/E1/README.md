# Lista Simple con Inserción al Inicio

Este proyecto implementa una lista enlazada simple en C#.  
La lista comienza con los valores iniciales `P K C D D A` y permite insertar nuevos elementos al inicio, ademas de mostrar los datos por consola.

## Archivos principales

- **Nodo.cs**  
  Define la estructura del nodo, con un campo `Dato` (string) y una referencia al siguiente nodo.

- **Cola.cs**  
  Contiene la logica de la lista: agregar un nodo al inicio y mostrar todos los elementos.

- **Programa.cs**  
  Punto de entrada del programa. Contiene el menu de opciones para interactuar con la lista.

## Funcionalidades

1. Mostrar la lista completa.  
2. Insertar un nuevo valor al inicio.  
3. Salir del programa.  

La lista se inicializa automaticamente con los elementos:  


## Ejecución

Dentro de la carpeta del proyecto, compilar y ejecutar con:

```bash
dotnet run
Lista inicial:
Elementos: P K C D D A 

--- Menu ---
1. Mostrar lista
2. Insertar al inicio
3. Salir
Elige una opción: 2
Escribe el valor a insertar al inicio: X
'X' agregado al inicio.

--- Menu ---
1. Mostrar lista
2. Insertar al inicio
3. Salir
Elige una opción: 1
Elementos: X P K C D D A
