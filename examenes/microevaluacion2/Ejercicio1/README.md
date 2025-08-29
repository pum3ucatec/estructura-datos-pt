# Implementación de Lista Enlazada (Tipo Cola) con Nodos en C#

Este proyecto es una aplicación de consola desarrollada en C# que implementa una estructura de datos de tipo lista enlazada simple. Aunque la clase principal se llama Cola, sus funcionalidades van más allá de una cola tradicional (FIFO - First-In, First-Out), permitiendo operaciones como insertar al principio, buscar elementos y eliminar el último elemento, convirtiéndola en una estructura de lista más versátil.
## 🚀 Funcionalidades

El programa presenta un menú interactivo que permite al usuario realizar las siguientes operaciones sobre la lista:

    Mostrar Lista: Imprime en consola todos los elementos actuales de la lista, desde el primero hasta el último.

    Insertar (Enqueue): Agrega un nuevo elemento al final de la lista.

    Eliminar (Dequeue): Quita el primer elemento de la lista.

    Ver primer elemento (Peek): Muestra el valor del primer elemento sin eliminarlo.

    Verificar si está vacía: Indica si la lista contiene elementos o no.

    Insertar al principio: Agrega un nuevo elemento al inicio de la lista.

    Contar elementos: Muestra la cantidad total de nodos en la lista.

    Buscar elemento: Verifica si un valor específico existe en la lista.

    Sacar un elemento: Elimina el último elemento de la lista.

    Salir: Termina la ejecución del programa.

## 📂 Estructura del Proyecto

El código está organizado en tres archivos principales dentro del namespace ColaNodo, cada uno con una responsabilidad clara:
1. ### Nodo.cs

Define la estructura fundamental de la lista. Cada instancia de esta clase representa un "nodo" que contiene:

    Dato: Un string que almacena el valor del nodo.

    Siguiente: Una referencia (puntero) al siguiente nodo en la lista. Si es el último nodo, su valor es null.

namespace ColaNodo
{
    public class Nodo
    {
        public string Dato { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}

2. ### Cola.cs

Contiene la lógica principal para gestionar la lista de nodos. Esta clase se encarga de:

    Mantener referencias al primero y ultimo nodo.

    Implementar todos los métodos para manipular la lista (insertar, eliminar, buscar, etc.).

namespace ColaNodo
{
    public class Cola
    {
        private Nodo primero;
        private Nodo ultimo;
        // ... implementación de los métodos ...
    }
}

3. ### Program.cs

Es el punto de entrada de la aplicación. Su función es:

    Crear una instancia de la clase Cola.

    Mostrar el menú de opciones al usuario en un bucle.

    Capturar la entrada del usuario y llamar a los métodos correspondientes de la clase Cola.

namespace ColaNodo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ... lógica del menú y la interacción con el usuario ...
        }
    }
}

## ⚙️ Cómo Compilar y Ejecutar

Para ejecutar este proyecto, necesitas tener instalado el SDK de .NET.
Pasos:

    Clonar o descargar el proyecto: Asegúrate de tener los tres archivos (Nodo.cs, Cola.cs, Program.cs) en la misma carpeta.

    Abrir una terminal: Abre una terminal o línea de comandos (como PowerShell, CMD o la terminal integrada de VS Code) en la carpeta del proyecto.

    Crear el archivo de proyecto (si no existe): Si solo tienes los archivos .cs, ejecuta el siguiente comando para crear un proyecto de consola de .NET. Esto generará un archivo .csproj necesario para la compilación.

    dotnet new console

        Nota: Este comando creará un Program.cs por defecto. Asegúrate de reemplazar el contenido de ese archivo con el tuyo.

    Ejecutar la aplicación: Una vez que el proyecto esté configurado, utiliza el siguiente comando para compilar y ejecutar el programa:

    dotnet run

La aplicación se iniciará en la terminal y verás el menú de opciones listo para interactuar.
## 📋 Ejemplo de Uso

A continuación, se muestra una secuencia de interacciones con el programa:

===== MENÚ Lista con NODOS =====
1. Mostrar Lista
2. Insertar (Agregar al final)
...
Seleccione una opción: 2
Ingrese el nombre a insertar: Juan
Se insertó: Juan

===== MENÚ Lista con NODOS =====
...
Seleccione una opción: 2
Ingrese el nombre a insertar: Maria
Se insertó: Maria

===== MENÚ Lista con NODOS =====
...
Seleccione una opción: 6
Ingrese el nombre a insertar al principio: Carlos
Se insertó al principio: Carlos

===== MENÚ Lista con NODOS =====
...
Seleccione una opción: 1
Lista: Carlos -> Juan -> Maria -> null

===== MENÚ Lista con NODOS =====
...
Seleccione una opción: 3
Se eliminó: Carlos

===== MENÚ Lista con NODOS =====
...
Seleccione una opción: 1
Lista: Juan -> Maria -> null

===== MENÚ Lista con NODOS =====
...
Seleccione una opción: 0
Saliendo del programa...

