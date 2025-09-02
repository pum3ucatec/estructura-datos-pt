
#  Documentación Técnica del Programa de Colas en C#

##  Descripción General
Este programa implementa un **menú interactivo en consola** que permite gestionar una **estructura de datos tipo Cola (Queue)**.  
El flujo de ejecución se controla mediante un bucle `while`, en el cual el usuario selecciona diferentes operaciones para manipular los elementos de la cola.

El programa utiliza una instancia de la clase `Cola`, que debe contar con los métodos básicos de manejo de colas (`Enqueue`, `Dequeue`, `Peek`, `IsEmpty`, `Count`, `Contains`, `Clear`, `Mostrar`).

---

##  Estructura del Código

### 1. Creación de la Cola
```csharp
Cola MiCola = new Cola();
bool Salir = false;
```

### 2. Menú Interactivo

El menú se ejecuta en un bucle while (!Salir).
Cada iteración muestra las opciones disponibles y espera la entrada del usuario.

### Opciones disponibles: 
1. Enqueue (Insertar)

2. Dequeue (Eliminar)

3. Peek (Ver frente)

4. IsEmpty (¿Vacía?)

5. Count (Cantidad)

6. Contains (Buscar)

7. Clear (Vaciar cola)

8. Mostrar cola

9. Salir

### 3. Variables Clave

- Opcion: almacena la elección del usuario en el menú.

- Valor: texto ingresado para insertar en la cola.

- Eliminado: elemento retirado mediante Dequeue().

- Frente: primer elemento consultado mediante Peek().

- Buscado: texto a localizar mediante Contains().

## Operaciones Implementadas

__1. Enqueue (Insertar)__
```
string Valor = Console.ReadLine();
MiCola.Enqueue(Valor);
 ```
 Esto agrega un nuevo elemento al final de la cola

__2. Dequeue (Eliminar)__
```
var Eliminado = MiCola.Dequeue();
```
* Elimina y retorna el primer elemento de la cola.

* Si la cola está vacía, muestra el mensaje correspondiente.

__3. Peek (Ver frente)__
```
var Frente = MiCola.Peek();
```
* Retorna el elemento en el frente de la cola sin eliminarlo.

__4. IsEmpty (Verificar si la cola esta vacia)__
```
MiCola.IsEmpty();
```
* Devuelve 'true' si la cola está vacía, caso contrario 'false'.

__5. Count (Cantidad)__
```
MiCola.Count();
```
* Retorna la cantidad de elementos almacenados en la cola.

__6. Contains (Buscar)__
```
MiCola.Contains(Buscado);
```
* Busca un valor dentro de la cola.

* Devuelve 'true' si se encuentra el elemento, de caso contrario devuelve 'false'.

__7. Clear (Limpiar cola)__
```
MiCola.Clear();
```
* Elimina todos los elementos de la cola.

__8.Mostrar cola__
MiCola.Mostrar();
Recorre y despliega en consola todos los elementos en orden 'FIFO'.

__9.Salir__
```
Salir = true;
```
### __4. Métodos Esperados en la Clase Cola__

- Para el correcto funcionamiento del programa, la clase Cola debe incluir:

- Enqueue(string valor) → Inserta un elemento.

- Dequeue() → Elimina y devuelve el frente.

- Peek() → Consulta el frente sin eliminarlo.

- IsEmpty() → Verifica si la cola está vacía.

- Count() → Retorna el número de elementos.

- Contains(string valor) → Busca un elemento en la cola.

- Clear() → Vacía la cola.

- Mostrar() → Imprime los elementos de la cola.

### 5. Conclusion
Este programa es un ejemplo práctico del manejo de la estructura de datos Cola (FIFO) en C#.
Permite al usuario interactuar con la cola de forma dinámica, aplicando las operaciones más representativas.