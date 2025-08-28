# Implementacion de Cola con Nodos en C#

## Descripcion

Este proyecto implementa una Cola usando Nodos enlazados con C#

El programa tiene un menu interactivo para insertar, eliminar, ver y gestionar los elementos de la cola.

### Como Ejecutar el Programa

**1. Requisitos**

- Tener instalado .NET SDK o Visual Studio con soporte para C#.

**2. Clonar o descargar el proyecto**

```bash
git clone git@github.com:pum3ucatec/estructura-datos-pt.git 
```
**ojo:** Tomar en cuenta que se tiene que tener llave .ssh, si no se puede usar la https.

Cambiate a la rama.
```bash
git checkout ChilenoJennifer/Practica7
```
Descarga la rama.
```bash
git pull origin ChilenoJennifer/Practica7
```
Enta a tu VSCode o tu editor de codigo.
```bash
code .
```

**3. Compilar y ejecutar**

Si usas la terminal con .NET:
- En el archivo correspondiente, Practica7, `Program.cs`
```bash
dotnet run
```

## Estructura del Proyecto

El proyecto esta dividido en tres archivos principales:

### 1. `Nodo.cs`

Representa un nodo de la cola.

- **Atributos:**
  - `Name` -> valor del nodo (tipo `string`).
  - `Next` -> referencia al siguiente nodo.
- **Constructor**: inicializa el nodo con un valor (`Name`).

```csharp
public class Nodo
{
    public string Name { get; set; }
    public Nodo? Next { get; set; }

    public Nodo(string name)
    {
        this.Name = name;
        this.Next = null;
    }
}
```

### 2. `Cola.cs`

Define la estructura de la Cola y sus operaciones principales.

- **Atributos:**
	- `Front` -> apunta al primer nodo (frente).
	- `Rear` -> apunta al último nodo (final).
	- `count` -> lleva la cantidad de elementos.

- **Metodos implementados:**
	- `Enqueue(string name)` -> inserta un elemento al final.
	- `Dequeue()` -> elimina el primer elemento.
	- `Peek()` -> muestra el valor en el frente sin eliminarlo.
	- `IsEmpty()` -> verifica si la cola está vacía.
	- `GetCount()` -> devuelve el número de elementos.
	- `Contains(string name)` -> busca si un elemento existe.
	- `Clear()` -> vacía toda la cola.
	- `View()` -> imprime todos los elementos.

### 3. `Program.cs`

Contiene el menu interactivo que permite al usuario manipular la cola.

- **Opciones disponibles:**

	- Mostrar Cola (View)
	- Insertar (Enqueue)
	- Eliminar (Dequeue)
	- Ver frente (Peek)
	- Verificar si está vacía (IsEmpty)
	- Cantidad de elementos (Count)
	- Buscar elemento (Contains)
	- Limpiar Cola (Clear)
	- Salir

### 4. Ejemplo de Uso
```markdown
===== MENÚ COLA con NODOS =====
1. Mostrar Cola(View)
2. Insertar (Enqueue)
3. Eliminar (Dequeue)
4. Ver frente (Peek)
5. Verificar si está vacía(IsEmpty)
6. Cantidad de elementos (Count)
7. Buscar elemento (Contains)
8. Limpiar Cola (Clear)
0. Salir
```
```markdown
Seleccione una opción: 2
Ingrese el nombre a insertar: Ana
```
```markdown
Seleccione una opción: 2
Ingrese el nombre a insertar: Pedro
```
```markdown
Seleccione una opción: 1
Cola: Ana | Pedro |
```
```markdown
Seleccione una opción: 3
Elemento eliminado: Ana
```
```markdown
Seleccione una opción: 1
Cola: Pedro |
```