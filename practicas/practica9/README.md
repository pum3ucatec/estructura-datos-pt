**Indice**


- [**1. Implementación de una Lista Doblemente Enlazada en C#**](#1-implementación-de-una-lista-doblemente-enlazada-en-c)
	- [**1.1. Descripción del proyecto**](#11-descripción-del-proyecto)
	- [**1.2. Ejecucion**](#12-ejecucion)
- [**2. Archivos Principales**](#2-archivos-principales)
	- [**2.1. Archivo 1: nodo\_doble.cs**](#21-archivo-1-nodo_doblecs)
		- [2.1.1. Clase nodo\_doble](#211-clase-nodo_doble)
	- [**2.2. Archivo 2: lista\_doble.cs**](#22-archivo-2-lista_doblecs)
		- [2.2.1. Clase ListaDoble](#221-clase-listadoble)
	- [**2.3. Archivo 3: program.cs**](#23-archivo-3-programcs)
- [**3. Ejemplo de uso en consola**](#3-ejemplo-de-uso-en-consola)

---

# **1. Implementación de una Lista Doblemente Enlazada en C#**

## **1.1. Descripción del proyecto**
Este proyecto implementa una lista doblemente enlazada en C#, la cual permite almacenar y manipular elementos a traves de nodos que tienen referencias al siguiente y al anterior.  

Se ha creado una clase personalizada `lista_doble.cs` que encapsula las operaciones principales de la lista, junto con un menu interactivo en `program.cs` para que el usuario pueda probar cada funcionalidad.  

## **1.2. Ejecucion**
1. Descarga o abre el proyecto en **Visual Studio Code**.  
2. Abre la terminal integrada en la carpeta del proyecto.  
3. Compila y ejecuta con:  

```bash
dotnet run
```


# **2. Archivos Principales**

## **2.1. Archivo 1: nodo_doble.cs**

Este archivo contiene la definición d### e la1. clase nodo_doble, que representa un elemento de la lista.

### 2.1.1. Clase nodo_doble

- **Atributos principales:**

	- nombre -> almacena el valor del nodo.
	- siguiente -> referencia al nodo siguiente en la lista.
	- anterior -> referencia al nodo anterior en la lista.

## **2.2. Archivo 2: lista_doble.cs**

Este archivo contiene la clase que maneja todas las operaciones principales de la lista doblemente enlazada.

### 2.2.1. Clase ListaDoble

- Atributos principales:

	- cabeza -> primer nodo de la lista.
	- cola -> último nodo de la lista.
	- cantidad -> número de elementos en la lista.

- Operaciones principales:

	- insertar_inicio(dato) -> inserta un elemento al inicio.
	- insertar_final(dato) -> inserta un elemento al final.
	- eliminar(dato) -> elimina el primer nodo que contenga el dato.
	- mostrar_adelante() -> recorre y muestra la lista desde la cabeza hasta la cola.
	- mostrar_atras() -> recorre y muestra la lista desde la cola hasta la cabeza.
	- contiene(dato) -> verifica si un elemento existe en la lista.
	- contar() -> devuelve el número de elementos en la lista.
	- esta_vacia() -> indica si la lista está vacía.

## **2.3. Archivo 3: program.cs**

Este archivo contiene el programa principal, donde se muestra un menu interactivo en consola.

- Flujo del programa:
Al iniciar, aparece el menu interactivo:

```markdown
===== MENU LISTA DOBLE =====
1. Mostrar lista hacia adelante
2. Mostrar lista hacia atrás
3. Insertar al inicio
4. Insertar al final
5. Eliminar elemento
6. Buscar elemento
7. Cantidad de elementos
8. Verificar si está vacía
9. Salir
```

# **3. Ejemplo de uso en consola**
```csharp
===== MENU LISTA DOBLE =====
1. Mostrar lista hacia adelante
2. Mostrar lista hacia atrás
3. Insertar al inicio
4. Insertar al final
5. Eliminar elemento
6. Buscar elemento
7. Cantidad de elementos
8. Verificar si está vacía
9. Salir
```
```csharp
Seleccione una opción: 3
Ingrese el valor a insertar al inicio: A
Elemento 'A' insertado.
```
```csharp
Seleccione una opción: 4
Ingrese el valor a insertar al final: B
Elemento 'B' insertado.
```
```csharp
Seleccione una opción: 1
Lista adelante: A -> B -> null
```
```csharp
Seleccione una opción: 2
Lista atrás: B -> A -> null
```
```csharp
Seleccione una opción: 6
Ingrese el valor a buscar: A
El elemento 'A' está en la lista.
```
```csharp
Seleccione una opción: 5
Ingrese el valor a eliminar: A
Elemento 'A' eliminado.
```
```csharp
Seleccione una opción: 7
La lista tiene 1 elemento(s).
```
