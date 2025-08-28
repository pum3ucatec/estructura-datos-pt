# 📂 Sistema de Cola con Nodos en C#
## 📋 Descripción
Este proyecto implementa una estructura de datos de Cola (Queue) utilizando nodos enlazados en C#. La cola sigue el principio FIFO (First-In, First-Out), donde el primer elemento en entrar es el primero en salir.

## 🏗️ Estructura del Proyecto
### 📄 Archivos
```
Nodo.cs: Define la estructura básica de un nodo

Cola.cs: Implementa todas las operaciones de la cola

Program.cs: Menú interactivo para probar las funcionalidades
```

## 🔧 Funcionalidades Implementadas
### ✅ Operaciones Básicas

Método	Descripción	Complejidad
```
Enqueue()	Inserta elemento al final	O(1)

Dequeue()	Elimina elemento del frente	O(1)

Peek()	Muestra elemento del frente	O(1)

IsEmpty()	Verifica si está vacía	O(1)
```
### ✅ Operaciones Adicionales
Método	Descripción	Complejidad
```
Count	Retorna cantidad de elementos	O(1)

View()	Muestra todos los elementos	O(n)

Clear()	Vacía la cola completamente	O(1)

Contains()	Busca elemento en la cola	O(n)
```
## 🎯 Características Técnicas
### 🔗 Estructura de Nodos
```
csharp
public class Nodo
{
    public string Name { get; set; }
    public Nodo Next { get; set; }
}
📊 Propiedades de la Cola
Front: Apuntador al primer elemento

Rear: Apuntador al último elemento

Count: Contador de elementos (optimizado)
```
### 🛡️ Manejo de Errores
```
Validación de cola vacía en Dequeue() y Peek()

Validación de entrada de usuario

Mensajes informativos de error
```
## 🚀 Resultado Esperado
``` 
===== MENÚ COLA con NODOS =====
1. Mostrar Cola (View)
2. Insertar (Enqueue)
3. Eliminar (Dequeue) 
4. Ver frente (Peek)
5. Verificar si está vacía (IsEmpty)
6. Cantidad de elementos (Count)
7. Vaciar cola (Clear)
8. Buscar elemento (Contains)
0. Salir
```
