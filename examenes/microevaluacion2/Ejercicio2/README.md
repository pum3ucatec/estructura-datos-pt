# Implementación de Lista Enlazada Simple en C# (Versión 2)

Este proyecto es una segunda versión de la aplicación de consola en C# que implementa una lista enlazada simple. A diferencia de la primera versión, esta implementación gestiona la lista utilizando únicamente un puntero al nodo inicial (root), lo que implica cambios en la lógica de algunas operaciones.

Además, se ha añadido la funcionalidad de eliminar un nodo en una posición específica, haciendo la estructura más flexible.
## 🚀 Funcionalidades

El programa ofrece un menú interactivo con las siguientes opciones:

    Mostrar Lista: Imprime todos los elementos de la lista en la consola.

    Insertar (Agregar al final): Añade un elemento al final de la lista. Esta operación ahora requiere recorrer toda la lista para encontrar el último nodo.

    Eliminar (Quitar del principio): Elimina el primer elemento (root) de la lista.

    Ver primer elemento: Muestra el valor del primer elemento sin modificar la lista.

    Verificar si está vacía: Comprueba si la lista tiene elementos.

    Insertar al principio: Añade un nuevo elemento al inicio de la lista, convirtiéndolo en el nuevo root.

    Verificar la cantidad de elementos: Cuenta y muestra el número total de nodos.

    Buscar elemento: Busca un valor en la lista y, si lo encuentra, muestra su posición (índice).

    Eliminar en una posición específica: Permite al usuario eliminar un elemento indicando su índice (empezando desde 0).

    Salir: Cierra la aplicación.

## 📂 Estructura del Proyecto

El código sigue organizado en tres archivos lógicos:
1. ### Nodo.cs

La definición del Nodo no ha cambiado. Sigue siendo el bloque de construcción esencial de la lista.

    Dato: Almacena el valor (string).

    Siguiente: Referencia al próximo Nodo.

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

Este archivo contiene la lógica principal y ha sido modificado significativamente:

    Solo utiliza un puntero private Nodo root; para gestionar toda la lista.

    El método Enqueue (insertar al final) ahora itera desde root hasta encontrar el último nodo antes de añadir el nuevo.

    Incluye el nuevo método EliminarEnPosicion(int posicion) para borrar nodos por su índice.

namespace ColaNodo
{
    public class Cola
    {
        private Nodo root; // Único puntero al inicio de la lista
        // ... implementación de los métodos ...
    }
}

3. ### Program.cs

El punto de entrada de la aplicación. Gestiona la interacción con el usuario.

    El menú se ha actualizado para incluir la opción 9: "Eliminar en una posición específica".

    Contiene la lógica para pedir al usuario el índice del nodo a eliminar y llamar al método correspondiente.

namespace ColaNodo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ... lógica del menú actualizada ...
        }
    }
}

## ⚙️ Cómo Compilar y Ejecutar

El proceso para ejecutar el proyecto es el mismo que en la versión anterior. Necesitas el SDK de .NET.

    Tener los archivos: Coloca Nodo.cs, Cola.cs, y Program.cs en la misma carpeta.

    Abrir una terminal: Navega a la carpeta del proyecto usando una terminal o el terminal integrado de VS Code.

    Crear archivo de proyecto (si es necesario): Si aún no tienes un archivo .csproj, créalo con:

    dotnet new console

    Recuerda reemplazar el Program.cs generado por el tuyo.

    Ejecutar: Compila y corre el programa con:

    dotnet run

    El menú interactivo aparecerá en tu terminal.

## 📋 Ejemplo de Uso (con la nueva función)

Aquí se muestra un ejemplo de cómo usar la nueva funcionalidad de eliminación por posición:

===== MENÚ Lista con NODOS =====
...
Seleccione una opción: 2
Ingrese el valor a insertar: A
Se insertó: A

===== MENÚ Lista con NODOS =====
...
Seleccione una opción: 2
Ingrese el valor a insertar: B
Se insertó: B

===== MENÚ Lista con NODOS =====
...
Seleccione una opción: 2
Ingrese el valor a insertar: C
Se insertó: C

===== MENÚ Lista con NODOS =====
...
Seleccione una opción: 1
Lista: A -> B -> C -> null

===== MENÚ Lista con NODOS =====
...
Seleccione una opción: 9
Ingrese la posición a eliminar (empezando en 0): 1
Se eliminó: B en posición 1

===== MENÚ Lista con NODOS =====
...
Seleccione una opción: 1
Lista: A -> C -> null

===== MENÚ Lista con NODOS =====
...
Seleccione una opción: 0
Saliendo del programa...

