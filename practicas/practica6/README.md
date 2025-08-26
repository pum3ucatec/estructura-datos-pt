# Implementación de una Cola en C#

Este proyecto implementa una cola (Queue) en C# utilizando arreglos circulares y herencia, con un menu interactivo en consola que permite manipularla.

Se ha creado una clase personalizada MyQueue.cs que encapsula las operaciones basicas y un menu interactivo (Program.cs) para que el usuario pueda manipular la cola.

**Ejecución:**

Descarga o actualiza la rama, entra al archivo Program.cs.
Compila y ejecuta con (En la terminal intregrada del VSCode):

```bash
dotnet run
```

Interactúa con el menú para probar las distintas operaciones de la cola.


## 1. Archivos Principales 


### 1.1. Archivo 1: MyQueue.cs

Este archivo contiene la definición de la clase base QueueBase y la clase derivada MyQueue que contiene las operaciones de la cola.

**1.1.1. Clase QueueBase**

- **Atributos principales:**
	- **Elements** -> arreglo donde se guardan los elementos.
	- **Size** -> tamaño maximo de la cola.
	- **Front** -> indice del primer elemento.
	- **Rear** -> indice del ultimo elemento.
	- **Count** -> cantidad de elementos en la cola.

- **Operaciones principales:**

	- **Enqueue:** -> Inserta un elemento al final de la cola.
	- **Dequeue:** -> Elimina el elemento en el frente de la cola.
	- **Peek:** -> Devuelve el elemento en el frente de la cola sin eliminarlo.
	- **Count:** -> Devuelve la cantidad de elementos almacenados actualmente en la cola.
	- **Size:** -> Devuelve la capacidad maxima de la cola.
	- **Contains:** -> Verifica si un elemento existe dentro de la cola.
	- **IsEmpty:** -> Comprueba si la cola esta vacia.
	- **IsFull:** -> Comprueba si la cola esta llena.
	- **Mostrar:** -> Muestra todos los elementos de la cola en orden.

### 1.2. Archivo 2: Principal.cs

Este archivo contiene el programa principal con el menu interactivo en consola.

- **Flujo del programa:**

Al iniciar, el usuario define el tamaño maximo de la cola.
Luego, aparece el menu interactivo:

```text
===== MENÚ COLA =====
1. Mostrar COLA
2. Insertar (Enqueue)
3. Eliminar (Dequeue)
4. Ver frente (Peek)
5. Verificar si está vacía (IsEmpty)
6. Insertar varios elementos
7. Cantidad de elementos (Count)
8. Tamaño de la cola (Size)
9. Buscar elemento (Contains)
10. Verificar si está llena (IsFull)
0. Salir
```

- **Opciones disponibles:**

	1. **Mostrar COLA** -> Muestra todos los elementos en orden.
	2. **Insertar (Enqueue)** -> Inserta un solo caracter.
	3. **Eliminar (Dequeue)** -> Elimina el primer elemento de la cola.
	4. **Ver frente (Peek)** -> Muestra el primer elemento sin eliminarlo.
	5. **Verificar si esta vacia (IsEmpty)** -> Indica si la cola esta vacia o no.
	6. **Insertar varios elementos** -> Permite ingresar varios caracteres separados por espacio y los agrega uno por uno a la cola.
	7. **Cantidad de elementos (Count)** -> Devuelve la cantidad de elementos almacenados actualmente en la cola.
	8. **Tamaño de la cola(Size)** -> Devuelve la capacidad maxima de la cola
	9. **Buscar elemento(Countains)** -> Verifica si un elemento existe dentro de la cola.
	10. **Verificar si esta llena(IsFull)** -> Comprueba si la cola esta llena.
	0. **Salir** -> Finaliza el programa.

### 1.3. Ejemplo de uso en consola
````text
===== CONFIGURACIÓN DE LA COLA =====
Ingrese el tamaño máximo de la cola: 4

===== MENÚ COLA =====
1. Mostrar COLA
2. Insertar (Enqueue)
3. Eliminar (Dequeue)
4. Ver frente (Peek)
5. Verificar si está vacía
6. Insertar varios elementos
0. Salir
Seleccione una opción: 6
Ingrese varios caracteres separados por espacio: A B C D E
 Elemento 'A' insertado en la cola.
 Elemento 'B' insertado en la cola.
 Elemento 'C' insertado en la cola.
 Elemento 'D' insertado en la cola.
 La cola está llena. No se puede insertar.
```