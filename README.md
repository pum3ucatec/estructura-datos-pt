# 📘 Implementación de una Cola en C#

Este proyecto implementa una **cola circular (queue)** en **C#** utilizando un **arreglo**.  
La cola es una estructura de datos **FIFO (First In, First Out)**:  
➡️ El primer elemento en entrar es el primero en salir.  

---

## 🧩 Características Principales

- Uso de un **arreglo circular** para aprovechar el espacio disponible.  
- Implementa las operaciones básicas de una cola:  
  - **Enqueue** (insertar)  
  - **Dequeue** (eliminar)  
  - **Peek** (ver frente)  
  - **IsEmpty** (verificar si está vacía)  
  - **Mostrar** (imprimir contenido)  
- Incluye un **menú interactivo en consola** para probar las operaciones.  

---

## 🔑 Concepto de Cola

Una cola circular **recicla los índices** cuando llega al final del arreglo.  
Esto evita desperdiciar espacio en memoria.  

Ejemplo con una cola de tamaño **5**:  

| Operación | Cola (Front → Rear) | Explicación |
|-----------|----------------------|-------------|
| Enqueue(10) | [10] | Insertamos 10 |
| Enqueue(20) | [10, 20] | Insertamos 20 |
| Dequeue()   | [20] | Se elimina 10 (el primero en entrar) |
| Enqueue(30) | [20, 30] | Insertamos 30 |
| Enqueue(40) | [20, 30, 40] | Insertamos 40 |
| Enqueue(50) | [20, 30, 40, 50] | Insertamos 50 |
| Enqueue(60) | ❌ Cola llena | No se puede insertar |

---

## 🧱 Clase `MyQueue`

La clase **`MyQueue`** contiene la lógica de la cola circular.

### 📌 Atributos
- `Elements` → Arreglo que almacena los elementos.  
- `Size` → Capacidad máxima de la cola.  
- `Front` → Índice del primer elemento.  
- `Rear` → Índice del último elemento insertado.  
- `Count` → Número actual de elementos.  

