# Implementación de una Pila en C#

Este programa implementa la estrutura de datos Pila(Stack) usando una clase llamada `Stack<int>` de .NET.

Se ha creado una clase personalizada `Pila` que encapsula las operaciones básicas y un menú interactivo para que el usuario pueda manipular la pila.


-  **Ejecución:**

	1. Descarga o actualiza la rama, entra al archivo `Program.cs`.
	2. Compila y ejecuta con (En la terminal intregrada del VSCode):

   ```bash
   dotnet run 
   ```
Interactúa con el menú para probar las distintas operaciones de la pila.


## 1. Funciones Principales

La clase `Pila` incluye los siguientes métodos:

- **`Push(int valor)`** -> Inserta un elemento en la pila.
- **`Pop()`** -> Elimina el último elemento insertado (el que está en la cima).
- **`Peek()`** -> Devuelve el elemento en la cima sin eliminarlo.
- **`IsEmpty()`** -> Retorna `true` si la pila está vacía.
- **`Clear()`** -> Vacía completamente la pila.
- **`Mostrar()`** -> Imprime todos los elementos de la pila (de arriba hacia abajo).

---

## 2. Menú Interactivo

El programa principal (`Principal`) muestra un menú con las siguientes opciones:

```text
	===== MENÚ PILA =====

	1. Mostrar pila
	2. Insertar (Push)
	3. Eliminar (Pop)
	4. Ver cima (Peek)
	5. Verificar si está vacía
	6. Limpiar pila (Clear)
	7. Insertar varios elementos (Push n)
	0. Salir
```


## 3. Como usarlo

**_3.1. Mostrar Pila_**

- **Seleccione una opción:** `1`
- **Elementos de la pila (de arriba hacia abajo):** 
`20`
`10` --> En una columna


**_3.2. Insertar elementos_**

- **Seleccione una opción:** `2`
- **Ingrese el número a insertar:** `10`

**Salida:**
`Se insertó: 10`


**_3.3. Eliminar elemento_**

- **Seleccione una opción:**  `3`
- **Salida:** `Se eliminó: 20`


**_3.4. Ver cima_**

- **Seleccione una opción:** `4`
- **Elemento en la cima:** `20`


**_3.5. Verificar si esta vacia_**

- **True:** `La pila está vacía.` 
- **False:** `La pila NO está vacía.`


 **_3.6. Limpiar pila_**

- **Seleccione una opción:** `6`
- **Salida:**`La pila ha sido vaciada.`


**_3.7. Insertar varios elementos_**

- **Seleccione una opción:** `7`
- **Ingrese los números a insertar (separados por espacio):** `30 40 50`

- **Salida:** 

	`Se insertó: 30`

	`Se insertó: 40`

	`Se insertó: 50`

