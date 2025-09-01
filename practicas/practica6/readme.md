# 📂 Sistema de Gestión de Colas en C#

Este proyecto implementa una cola circular (FIFO) en C# con un menú interactivo para realizar operaciones básicas sobre la estructura de datos.

## 🏗️ Estructura del Proyecto
### 1. Program.cs

Contiene la clase principal con el menú interactivo que permite al usuario:

- Especificar el tamaño de la cola

- Elegir entre 9 operaciones diferentes

- Interactuar con la cola mediante una interfaz de consola


### 2. MyQueue.cs
- Implementa la clase MyQueue que representa una cola circular con las siguientes características:

- Almacenamiento: Arreglo de caracteres

- Manejo circular: Usa aritmética modular para los índices

- Operaciones estándar: Enqueue, Dequeue, Peek, etc.

## 🎯 Funcionalidades Implementadas
### Operaciones Disponibles:
Mostrar COLA - Muestra el estado completo de la cola

Insertar (Enqueue) - Añade un elemento al final

Eliminar (Dequeue) - Remueve el elemento del frente

Ver frente (Peek) - Consulta el elemento del frente

Ver final (Rear) - Consulta el elemento del final

Verificar si está vacía - Comprueba si la cola no tiene elementos

Verificar si está llena - Comprueba si la cola está al máximo

Buscar elemento - Encuentra la posición de un elemento

Ver cantidad de elementos - Muestra cuántos elementos hay actualmente

## 🔧 Características Técnicas
Manejo de errores: Validación de entradas y manejo de casos extremos

Interfaz intuitiva: Menú claro con opciones numeradas

Representación visual: Muestra la cola con indicadores de frente y final

Estado completo: Proporciona información detallada del estado de la cola

## 📊 Ejemplo de Uso
```
text
Ingrese el tamaño de la cola: 3

===== MENÚ COLA =====
1. Mostrar COLA
2. Insertar (Enqueue)
3. Eliminar (Dequeue)
4. Ver frente (Peek)
5. Ver final (Rear)
6. Verificar si está vacía (IsEmpty)
7. Verificar si está llena (IsFull)
8. Buscar elemento (Contains)
9. Ver cantidad de elementos actuales (Count)
0. Salir
Seleccione una opción: 
```