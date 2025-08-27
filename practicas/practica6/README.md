# Proyecto de Cola en C#

Este proyecto implementa una cola (queue) utilizando un arreglo circular en C#. La cola permite realizar operaciones básicas como agregar, eliminar y consultar elementos, así como verificar su estado.

## Funcionalidades

El programa ofrece las siguientes funcionalidades:

1. **Mostrar Cola**: Muestra todos los elementos en la cola.
2. **Agregar (Enqueue)**: Permite agregar un carácter a la cola.
3. **Eliminar (Dequeue)**: Elimina el carácter en la parte frontal de la cola.
4. **Ver primer elemento (Peek)**: Muestra el carácter en la parte frontal de la cola sin eliminarlo.
5. **Cantidad de elementos (Count)**: Devuelve la cantidad actual de elementos en la cola.
6. **Capacidad de la cola (Size)**: Muestra la capacidad máxima de la cola.
7. **Buscar un elemento (Contains)**: Verifica si un carácter específico está presente en la cola.
8. **Verificar si está vacía (IsEmpty)**: Indica si la cola está vacía.
9. **Verificar si está llena (IsFull)**: Indica si la cola está llena.
10. **Salir**: Termina la ejecución del programa.

## Requisitos

- .NET Core o .NET Framework instalado en tu máquina.
- Un entorno de desarrollo como Visual Studio o Visual Studio Code.

## Instrucciones de Uso

1. Clona este repositorio o descarga los archivos.
2. Abre el proyecto en tu entorno de desarrollo.
3. Compila y ejecuta el programa.
4. Sigue las instrucciones en la consola para interactuar con la cola.

## Ejemplo de Uso

Al ejecutar el programa, se presentará un menú con las opciones disponibles. Puedes seleccionar una opción ingresando el número correspondiente y siguiendo las instrucciones adicionales que se muestren en la consola.

## Estructura del Código

- **Principal**: Clase que contiene el método `Main`, donde se ejecuta el programa y se maneja la interacción con el usuario.
- **QueueBase**: Clase base que define la estructura y las operaciones básicas de la cola.
- **MyQueue**: Clase que hereda de `QueueBase` y proporciona implementaciones específicas para las operaciones de la cola.

## Contribuciones

Si deseas contribuir a este proyecto, siéntete libre de hacer un fork y enviar un pull request con tus mejoras.

## Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo LICENSE para más detalles.