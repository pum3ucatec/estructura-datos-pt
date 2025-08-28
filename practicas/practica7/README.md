Colas Dinámicas

Escobar Rosas Edwin

Práctica: 7

Descripción

Este proyecto implementa una cola dinámica en C#.
Permite agregar, eliminar y buscar nombres de manera interactiva, mostrando la posición de cada elemento, así como el primero y el último de la fila.
La cola es ilimitada y su visualización ayuda a entender cómo se organiza internamente.

Archivos principales
Nodo.cs

Representa un nodo de la cola.

Contiene:

Dato: el nombre almacenado.

Siguiente: referencia al siguiente nodo.

Cola.cs

Implementa la cola dinámica.

Funciones principales:

Enqueue(string dato): agregar un nombre al final.

Dequeue(): eliminar el primer elemento.

Remove(string dato): eliminar un nombre específico.

Peek(): mostrar el primer elemento sin eliminarlo.

Last(): mostrar el último elemento.

Contains(string dato): verificar si un nombre existe.

IndexOf(string dato): obtener la posición/fila de un nombre.

Count(): cantidad de elementos.

Clear(): vaciar toda la cola.

View(): mostrar todos los elementos.

Program.cs

Contiene el menú interactivo en consola con colores.

Funciones del menú:

Agregar nombres a la cola.

Eliminar un nombre específico.

Ver el primer elemento (Peek).

Ver todos los elementos con posición/fila.

Ver cantidad de elementos.

Vaciar la cola (Clear).

Buscar uno o varios nombres mostrando su posición.

Ver el último elemento de la cola.

Salir del programa.

La búsqueda permite ingresar varios nombres separados por coma.

Las posiciones comienzan desde 1 (frente de la cola).

Cómo ejecutar

Abrir PowerShell en la carpeta del proyecto (practica7).

Ejecutar:

dotnet run


Seguir las instrucciones del menú interactivo.

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

Elige una opción: 1
 Ingresa un nombre: Sofia
 'Sofia' agregado a la cola.

Elige una opción: 4
 Elementos en la cola con su posición:
1. Laura
2. Juan
3. Sofia

Elige una opción: 7
 Ingresa los nombres a buscar (separados por coma): Juan, Pedro, Sofia
 'Juan' está en la fila 2 de la cola.
 'Pedro' NO está en la cola.
 'Sofia' está en la fila 3 de la cola.

Elige una opción: 2
 Ingresa el nombre a eliminar: Laura
 'Laura' eliminado de la cola.

Elige una opción: 3
Primero en la cola: Juan

Elige una opción: 8
Último en la cola: Sofia

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

Menú interactivo y con colores.

Código modular en Nodo.cs, Cola.cs y Program.cs. 