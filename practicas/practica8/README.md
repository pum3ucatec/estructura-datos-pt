**INDICE**
- [1. Implementacion de una Lista Simple en C#](#1-implementacion-de-una-lista-simple-en-c)
	- [1.1. Implementacion de una Lista Simple en C#](#11-implementacion-de-una-lista-simple-en-c)
	- [1.2. Ejecución:](#12-ejecución)
- [2. Archivos Principales](#2-archivos-principales)
	- [2.1. Archivo 1: lista\_simple.cs](#21-archivo-1-lista_simplecs)
		- [2.1.1. Clase Nodo](#211-clase-nodo)
		- [2.1.2. Clase ListaSimple](#212-clase-listasimple)
	- [2.2. Archivo 2: Program.cs](#22-archivo-2-programcs)
- [3. Ejemplo de uso en consola](#3-ejemplo-de-uso-en-consola)

# 1. Implementacion de una Lista Simple en C#

## 1.1. Implementacion de una Lista Simple en C#

Este proyecto implementa una Lista Simple en C# utilizando nodos enlazados, con un menu interactivo en consola que permite manipularla.

Se ha creado una clase personalizada `lista_simple.cs` que encapsula las operaciones basicas y un menu interactivo (`Program.cs`) para que el usuario pueda manipular la lista.

## 1.2. Ejecución:
Descarga o actualiza la rama, entra al archivo `Program.cs`.  
Compila y ejecuta con (en la terminal integrada de VSCode):

```bash
dotnet run
```

Interactúa con el menu para probar las distintas operaciones de la lista.

# 2. Archivos Principales
## 2.1. Archivo 1: lista_simple.cs

Este archivo contiene la definición de la clase Nodo y la clase ListaSimple que contiene las operaciones de la lista.

### 2.1.1. Clase Nodo

- Atributos principales:
	- Dato -> almacena el valor del nodo.
	- Siguiente -> referencia al siguiente nodo en la lista.

### 2.1.2. Clase ListaSimple

- Atributos principales:
	- cabeza -> primer nodo de la lista.
	- count -> cantidad de elementos en la lista.

- Operaciones principales:

	- InsertarInicio -> Inserta un elemento al inicio de la lista.
	- InsertarFinal -> Inserta un elemento al final de la lista.
	- Eliminar -> Elimina un elemento específico de la lista.
	- Mostrar -> Muestra todos los elementos de la lista en orden.
	- Contiene -> Verifica si un elemento existe en la lista.
	- Contar -> Devuelve la cantidad de elementos en la lista.
	- EstaVacia -> Comprueba si la lista está vacía.

## 2.2. Archivo 2: Program.cs

Este archivo contiene el programa principal con el menu interactivo en consola.

- Flujo del programa:
Al iniciar, aparece el menu interactivo:

```markdown
===== MENÚ LISTA SIMPLE =====
1. Mostrar lista
2. Insertar al inicio
3. Insertar al final
4. Eliminar elemento
5. Buscar elemento
6. Cantidad de elementos
7. Verificar si está vacía
8. Salir
```

- Opciones disponibles:
	- Mostrar lista -> Muestra todos los elementos en orden.
	- Insertar al inicio -> Inserta un solo caracter al inicio de la lista.
	- Insertar al final -> Inserta un solo caracter al final de la lista.
	- Eliminar elemento -> Elimina el primer nodo que contenga el caracter dado.
	- Buscar elemento -> Verifica si un caracter existe en la lista.
	- Cantidad de elementos -> Devuelve el número de elementos en la lista.
	- Verificar si está vacía -> Indica si la lista está vacía o no.
	- Salir -> Finaliza el programa.

# 3. Ejemplo de uso en consola
```markdown
===== MENÚ LISTA SIMPLE =====
1. Mostrar lista
2. Insertar al inicio
3. Insertar al final
4. Eliminar elemento
5. Buscar elemento
6. Cantidad de elementos
7. Verificar si está vacía
0. Salir
```
```markdown
Seleccione una opción: 2
Ingrese el caracter a insertar al inicio: A
Elemento 'A' insertado.
```
```markdown
Seleccione una opción: 3
Ingrese el caracter a insertar al final: B
Elemento 'B' insertado.
```
```markdown
Seleccione una opción: 1
Lista: A -> B -> null
```
