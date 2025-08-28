Práctica 7: Colas Dinámicas en C#

Autor: Escobar Rosas Edwin

Descripción

Este proyecto implementa una cola dinámica en C# utilizando nodos enlazados.
Permite agregar, eliminar y buscar nombres de manera interactiva, mostrando la posición de cada elemento, así como el primero y el último de la fila. La cola es ilimitada y su visualización ayuda a entender cómo se organiza internamente.

Estructura del proyecto
practica7/
│
├─ Nodo.cs      # Representa cada nodo de la cola
├─ Cola.cs      # Implementa la cola dinámica con operaciones básicas
├─ Program.cs   # Menú interactivo en consola
└─ README.md    # Documentación del proyecto

Archivos principales
Nodo.cs

Representa un nodo de la cola.
Contiene:

Dato → El valor almacenado (nombre).

Siguiente → Referencia al siguiente nodo en la cola.

Cola.cs

Implementa la estructura de la cola dinámica.
Funciones principales:

Enqueue(string dato) → Agrega un nombre al final.

Dequeue() → Elimina el primer elemento.

Remove(string dato) → Elimina un nombre específico.

Peek() → Muestra el primer elemento sin eliminarlo.

Last() → Muestra el último elemento.

Contains(string dato) → Verifica si un nombre existe.

IndexOf(string dato) → Obtiene la posición/fila de un nombre.

Count() → Retorna la cantidad de elementos.

Clear() → Vacía toda la cola.

View() → Muestra todos los elementos con su posición.

IsEmpty() → Verifica si la cola está vacía.

Program.cs

Contiene el menú interactivo en consola.
Permite:

Agregar nombres a la cola.

Eliminar un nombre específico.

Ver el primer elemento (Peek).

Ver todos los elementos con posición/fila.

Contar elementos en la cola.

Vaciar la cola (Clear).

Buscar uno o varios nombres mostrando su posición.

Ver el último elemento de la cola.

Salir del programa.

La búsqueda permite ingresar varios nombres separados por coma.
Las posiciones comienzan desde 1 (frente de la cola).

Ejemplo de ejecución
===== MENÚ DE COLA =====
1. Encolar (Agregar)
2. Eliminar un nombre específico
3. Ver primer elemento (Peek)
4. Ver todos los elementos con posición
5. Cantidad de elementos
6. Vaciar cola (Clear)
7. Buscar nombres (uno o varios)
8. Ver último elemento de la cola
0. Salir
Elige una opción: 1
Ingresa un nombre: Laura
'Laura' agregado a la cola.

Elige una opción: 1
Ingresa un nombre: Juan
'Juan' agregado a la cola.

Elige una opción: 4
Elementos en la cola con su posición:
1. Laura
2. Juan

Elige una opción: 7
Ingresa los nombres a buscar (separados por coma): Juan, Pedro
'Juan' está en la fila 2 de la cola.
'Pedro' NO está en la cola.

Elige una opción: 2
Ingresa el nombre a eliminar: Laura
'Laura' eliminado de la cola.

Elige una opción: 3
Primero en la cola: Juan

Elige una opción: 8
Último en la cola: Juan

Diagrama simple de la cola
[ Frente ] → Juan → Sofia → [ Final ]


El primer nodo está al frente y se elimina primero.

Los nuevos nombres se agregan al final.

Cada nodo apunta al siguiente (Siguiente).

Se puede buscar cualquier nombre y ver su posición/fila.

Características

Cola dinámica sin límite de elementos.

Permite agregar, eliminar y buscar nombres fácilmente.

Muestra posición/fila de cada elemento.

Permite búsqueda de múltiples nombres a la vez.

Muestra primer y último elemento de la cola.

Menú interactivo y claro.

Código modular en Nodo.cs, Cola.cs y Program.cs.

Cómo ejecutar

Abrir PowerShell en la carpeta del proyecto (practica7).

Ejecutar:

dotnet run


Seguir las instrucciones del menú interactivo.

Notas sobre C# y referencias nulas

En el código se utiliza ? para declarar nodos y propiedades nullable, por ejemplo:

private Nodo? frente;
public Nodo? Siguiente { get; set; }


Esto indica que la variable puede contener null, lo cual tiene sentido:

Al inicio, la cola está vacía → frente = null

El último nodo apunta a null → Siguiente = null

Esto evita warnings del compilador sobre referencias nulas y posibles errores en tiempo de ejecución.