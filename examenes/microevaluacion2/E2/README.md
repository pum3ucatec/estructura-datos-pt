# Lista Simple con Inserción al Inicio y Eliminación Alrededor

Este proyecto implementa una lista enlazada simple en C#.  
La lista inicia con los valores `P K A C D A` y permite insertar nuevos elementos al inicio, mostrar el contenido y eliminar los nodos que estén alrededor de un valor dado.

## Archivos

- **Nodo.cs**  
  Define la estructura de cada nodo con su dato y la referencia al siguiente.

- **Cola.cs**  
  Contiene las operaciones principales: insertar al inicio, mostrar y eliminar alrededor de un valor.

- **Programa.cs**  
  Programa principal con menú para interactuar con la lista.

## Funcionalidades

1. Mostrar la lista.  
2. Insertar un nuevo valor al inicio.  
3. Eliminar alrededor de un valor (se eliminan el nodo anterior y el siguiente si existen).  
4. Salir.  

La lista se carga automáticamente al iniciar con:


## Ejecución

Dentro de la carpeta del proyecto:

```bash
dotnet run
Lista inicial:
Elementos: P K C D D A 

--- Menú ---
1. Mostrar lista
2. Insertar al inicio
3. Eliminar alrededor de un valor
4. Salir
Elige una opción: 3
Escribe el valor alrededor del cual eliminar: A
Se eliminaron nodos alrededor de 'A'.

--- Menu ---
1. Mostrar lista
2. Insertar al inicio
3. Eliminar alrededor de un valor
4. Salir
Elige una opción: 1
Elementos: P C D A
