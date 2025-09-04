# Lista Enlazada Simple de Nombres
## Descripción del Programa
Este programa implementa una lista enlazada simple en C# que permite almacenar y gestionar nombres mediante un menú interactivo.
## Estructura de Datos
```
Clase Nodo
csharp
class Nodo
{
    public string nombre;       // Almacena el dato (nombre)
    public Nodo siguiente;      // Puntero al siguiente nodo
}
```
Componentes:

nombre: Campo que almacena el valor del nodo (string)

siguiente: Referencia al próximo nodo en la lista

Variable Global
```
csharp
static Nodo inicio = null;      // Puntero al primer nodo de la lista
inicio: Apunta al primer elemento de la lista (cabeza de la lista)
```
## Funcionalidades del Menú
### 1. Agregar nombre al inicio
```
csharp
static void AgregarNombre()
```
Funcionamiento:

Solicita al usuario ingresar un nombre

Crea un nuevo nodo con el nombre

El nuevo nodo apunta al actual inicio

inicio se actualiza para apuntar al nuevo nodo

#### Visualización:
```
text
Antes: [A] → [B] → null
Después: [Nuevo] → [A] → [B] → null
```
### 2. Ver todos los nombres
```
csharp
static void VerNombres()
```
Funcionamiento:

Verifica si la lista está vacía (inicio == null)

Recorre la lista desde inicio hasta encontrar null

Imprime cada nombre con un número de posición

### 3. Salir
Termina la ejecución del programa

## Flujo de Ejecución
Ejemplo de Uso:
```
text
LISTA DE NOMBRES
1. Agregar nombre al inicio
2. Ver todos los nombres
3. Salir
Elige una opción: 1

Ingresa un nombre: Ana
Nombre agregado al inicio

Elige una opción: 1
Ingresa un nombre: Carlos
Nombre agregado al inicio

Elige una opción: 2

Nombres en la lista:
1. Carlos
2. Ana
```
## Estructura en Memoria
```
Lista Vacía:
text
inicio → null
Después de agregar "Ana":
text
inicio → [nombre: "Ana", siguiente: null]
Después de agregar "Carlos":
text
inicio → [nombre: "Carlos", siguiente: → [nombre: "Ana", siguiente: null]]
```