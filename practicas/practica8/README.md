# Lista Simple en C#

Este proyecto implementa una lista enlazada simple en C#, con operaciones básicas de inserción, eliminación y visualización.  
Está dividido en tres archivos principales: `ListaSimple.cs`, `Nodo.cs` y `Program.cs`.

---

## Estructura del proyecto

ListaSimpleApp/
│── ListaSimple.cs # Clase que administra la lista (insertar, mostrar, eliminar)
│── Nodo.cs # Clase Nodo (almacena el dato y la referencia al siguiente)
│── Program.cs # Programa principal con menú interactivo en consola


---

## Funcionalidades

1. Agregar elemento → Inserta un nuevo nodo al final de la lista.  
2. Mostrar lista → Imprime todos los elementos en el orden en que fueron agregados.  
3. Eliminar elemento → Elimina un nodo de la lista si existe.  
4. Salir → Termina la ejecución del programa.

---

## Ejecución del programa

1. Compilar el proyecto con el siguiente comando en consola:

```bash
csc Program.cs ListaSimple.cs Nodo.cs
Esto generará un archivo ejecutable (Program.exe).

Ejecutar el programa:

bash
Copiar código
Program.exe
Ejemplo de uso
markdown
Copiar código
=== MENÚ LISTA ENLAZADA ===
1. Agregar elemento
2. Mostrar lista
3. Eliminar elemento
0. Salir
Seleccione una opción: 1
Ingrese el valor a insertar: 15

=== MENÚ LISTA ENLAZADA ===
1. Agregar elemento
2. Mostrar lista
3. Eliminar elemento
0. Salir
Seleccione una opción: 2
15 -> NULL