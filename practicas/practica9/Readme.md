# Lista Doblemente Enlazada
## Descripción del Programa
Este programa implementa una lista doblemente enlazada en C# que permite almacenar y gestionar nombres con operaciones en ambos extremos.

## Estructura de Datos Mejorada
```
Clase Nodo (Doble)
csharp
class Nodo
{
    public string nombre;       // Almacena el dato (nombre)
    public Nodo siguiente;      // Puntero al siguiente nodo
    public Nodo anterior;       // Puntero al nodo anterior (NUEVO)
}
```
Componentes:

nombre: Campo que almacena el valor del nodo

siguiente: Referencia al próximo nodo en la lista

anterior: Referencia al nodo anterior en la lista (NUEVO)

Variables Globales
```
csharp
static Nodo inicio = null;      // Puntero al primer nodo
static Nodo fin = null;         // Puntero al último nodo (NUEVO)
```
## Funcionalidades del Menú Mejorado
### 1. Agregar nombre al inicio
```
csharp
static void AgregarAlInicio()
```
Funcionamiento:

Crea nuevo nodo con puntero siguiente al actual inicio

Si la lista no está vacía, el actual inicio apunta al nuevo nodo como anterior

Actualiza inicio para apuntar al nuevo nodo

### 2. Agregar nombre al final (NUEVO)
```
csharp
static void AgregarAlFinal()
```
Funcionamiento:

Crea nuevo nodo con puntero anterior al actual fin

Si la lista no está vacía, el actual fin apunta al nuevo nodo como siguiente

Actualiza fin para apuntar al nuevo nodo

### 3. Ver nombres desde el inicio
```
csharp
static void VerDesdeInicio()
```
Funcionamiento:

Recorre desde inicio hasta null usando siguiente

### 4. Ver nombres desde el final (✅ NUEVO)
```
csharp
static void VerDesdeFinal()
```
Funcionamiento:

Recorre desde fin hasta null usando anterior

### Estructura en Memoria (Doble)
```
Lista con "Ana" y "Carlos":
text
inicio → [nombre: "Carlos", anterior: null, siguiente: →] 
          ↓
          [nombre: "Ana", anterior: ←, siguiente: null] ← fin
```


### Ejemplo de Ejecución
```
text
LISTA DOBLE DE NOMBRES
1. Agregar nombre al inicio
2. Agregar nombre al final
3. Ver nombres desde el inicio
4. Ver nombres desde el final
5. Salir
Elige una opción: 1
Ingresa un nombre: Carlos
Nombre agregado al inicio

Elige una opción: 2
Ingresa un nombre: Ana
Nombre agregado al final

Elige una opción: 3

Nombres desde el inicio:
1. Carlos
2. Ana

Elige una opción: 4

Nombres desde el final:
1. Ana
2. Carlos
```