Colas Dinámicas

Este proyecto implementa una cola dinámica en C# con un menú interactivo, permitiendo al usuario agregar, eliminar y consultar elementos en la cola de manera sencilla. Está diseñado para practicar estructuras de datos y operaciones básicas de colas utilizando programación orientada a objetos.

🔹 Características

Implementación de cola dinámica con nodos enlazados.

Permite agregar cualquier cantidad de elementos sin límite.

Menú interactivo con colores para mejorar la experiencia visual.

Operaciones disponibles:

Enqueue (Agregar): Agrega un elemento al final de la cola.

Dequeue (Eliminar): Elimina el primer elemento de la cola.

Peek (Ver primero): Muestra el primer elemento sin eliminarlo.

View (Ver todos): Muestra todos los elementos de la cola.

Count (Cantidad): Indica cuántos elementos hay en la cola.

IsEmpty (Vacía): Verifica si la cola está vacía.

Clear (Vaciar): Elimina todos los elementos de la cola.

Contains (Buscar): Verifica si un elemento específico está en la cola.

🔹 Descripción de los archivos

Nodo.cs:
Representa un nodo individual de la cola. Contiene:

Dato: el valor que guarda el nodo (en este caso un nombre).

Siguiente: referencia al siguiente nodo en la cola.

Cola.cs:
Implementa la estructura de la cola dinámica. Contiene:

Referencias a los nodos frente y final.

Métodos para todas las operaciones de la cola (Enqueue, Dequeue, Peek, View, Count, IsEmpty, Clear, Contains).

Manejo del número de elementos de la cola.

Program.cs:
Implementa el menú interactivo que permite al usuario interactuar con la cola. Contiene:

Opciones para agregar, eliminar, consultar y buscar elementos.

Validación de entradas y mensajes claros con colores en consola.

Salida ordenada y amigable para el usuario.

🔹 Cómo ejecutar

Abrir la terminal en la carpeta del proyecto.

Ejecutar:

dotnet run


Seguir las opciones del menú.

Ingresar nombres cuando se agreguen elementos.

Usar 0 para salir del programa.

🔹 Autor

Escobar Rosas Edwin
Proyecto de práctica de estructuras de datos en C#.