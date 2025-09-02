# 📂 Sistema de Gestión de Colas en C#

Este proyecto implementa una **cola circular (FIFO)** en C# con un **menú interactivo** para realizar operaciones básicas sobre la estructura de datos.

---

## 🏗️ Estructura del Proyecto

### 1. Program.cs
Contiene la clase principal con el menú interactivo que permite al usuario:

- Especificar el tamaño de la cola  
- Elegir entre **9 operaciones diferentes**  
- Interactuar con la cola mediante una **interfaz de consola**

### 2. MyQueue.cs
Implementa la clase `MyQueue` que representa una **cola circular** con las siguientes características:

- **Almacenamiento:** Arreglo de caracteres  
- **Manejo circular:** Usa aritmética modular para los índices  
- **Operaciones estándar:** `Enqueue`, `Dequeue`, `Peek`, etc.

---

## 🎯 Funcionalidades Implementadas

### Operaciones Disponibles

| Opción | Método / Acción                   | Descripción |
|--------|----------------------------------|------------|
| 1      | Mostrar COLA                     | Muestra el estado completo de la cola |
| 2      | Insertar (Enqueue)               | Añade un elemento al final |
| 3      | Eliminar (Dequeue)               | Remueve el elemento del frente |
| 4      | Ver frente (Peek)                | Consulta el elemento del frente |
| 5      | Ver final (Rear)                 | Consulta el elemento del final |
| 6      | Verificar si está vacía (IsEmpty)| Comprueba si la cola no tiene elementos |
| 7      | Verificar si está llena (IsFull) | Comprueba si la cola está al máximo |
| 8      | Buscar elemento (Contains)       | Encuentra la posición de un elemento |
| 9      | Ver cantidad de elementos (Count)| Muestra cuántos elementos hay actualmente |
| 0      | Salir                             | Cierra el programa |

---

## 🔧 Características Técnicas

- **Manejo de errores:** Validación de entradas y casos extremos  
- **Interfaz intuitiva:** Menú claro con opciones numeradas  
- **Representación visual:** Muestra la cola con indicadores de frente y final  
- **Estado completo:** Proporciona información detallada del estado de la cola  

---

## 📊 Ejemplo de Uso

Ingrese el tamaño de la cola: 3

===== MENÚ COLA =====

Mostrar COLA

Insertar (Enqueue)

Eliminar (Dequeue)

Ver frente (Peek)

Ver final (Rear)

Verificar si está vacía (IsEmpty)

Verificar si está llena (IsFull)

Buscar elemento (Contains)

Ver cantidad de elementos actuales (Count)

Salir
Seleccione una opción: