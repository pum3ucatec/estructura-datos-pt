# Cola Circular de Caracteres en C#

## Descripción del Proyecto

Este proyecto implementa una **cola circular de caracteres** en C# con un **menú interactivo** que permite al usuario realizar operaciones comunes sobre la cola. La cola está diseñada para manejar de manera eficiente la inserción y eliminación de elementos sin desperdiciar espacio, utilizando un arreglo circular interno.

---

## Funcionalidades Principales

La clase `MyQueue` proporciona los siguientes métodos:

- **Enqueue(char valor):** Agrega un elemento al final de la cola. Si la cola está llena, muestra un mensaje de error.
- **Dequeue():** Elimina el elemento del frente de la cola. Si la cola está vacía, muestra un mensaje de error.
- **Peek():** Devuelve el elemento que se encuentra en el frente de la cola sin eliminarlo. Retorna `\0` si la cola está vacía.
- **IsEmpty():** Verifica si la cola está vacía y retorna `true` o `false`.
- **IsFull():** Verifica si la cola está llena y retorna `true` o `false`.
- **GetCount():** Devuelve la cantidad de elementos actualmente en la cola.
- **GetCapacity():** Retorna la capacidad máxima de la cola.
- **Contains(char valor):** Retorna `true` si el elemento existe en la cola; de lo contrario `false`.
- **Mostrar():** Muestra en consola todos los elementos de la cola en orden desde el frente hasta el final.

---

## Estructura del Proyecto

El proyecto contiene dos clases principales:

1. **`MyQueue`**: Implementa la lógica de la cola circular y todos los métodos para manipularla.
2. **`Program`**: Contiene el método `Main` y el menú interactivo que permite al usuario:
    - Visualizar los elementos de la cola.
    - Insertar y eliminar elementos.
    - Consultar el primer elemento, la cantidad de elementos y la capacidad máxima.
    - Buscar un elemento específico.
    - Verificar si la cola está vacía o llena.
    - Salir del programa de manera controlada.

---

## Uso del Programa

1. **Compilación:**
   ```bash
   dotnet build
Ejecución:

bash
Copiar
Editar
dotnet run
Interacción:

Al iniciar, el programa solicitará al usuario la capacidad máxima de la cola.

Posteriormente, se mostrará un menú interactivo con opciones numeradas.

El usuario podrá seleccionar la opción deseada ingresando un número y presionando Enter.

La aplicación validará las entradas y mostrará mensajes claros en caso de errores o acciones exitosas.

Ejemplo de Uso

```
Digite la capacidad maxima de la cola: 5

=== MENU DE COLA ===
1. Ver elementos
2. Agregar elemento
3. Quitar elemento
...
Ingrese opcion: 2
Digite un caracter para agregar: A
Elemento agregado exitosamente.

Ingrese opcion: 1
Elementos en la cola: A

Ingrese opcion: 3
Elemento eliminado: A
```

## Consideraciones Técnicas
- La cola está implementada como cola circular para aprovechar al máximo el arreglo subyacente y evitar el desplazamiento de elementos.

- Los métodos manejan de manera segura los casos de cola llena o vacía mostrando mensajes adecuados en la consola.

- El menú es interactivo y permite realizar múltiples operaciones hasta que el usuario decida salir.

### Autor
**Nombre:** Adrien Liev Condarco Gonzales

**Fecha:** 26 de agosto de 2025

**Lenguaje: C#**