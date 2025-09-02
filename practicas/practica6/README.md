# Práctica 6: Implementación de Colas en C#
Nombre: Edwin Escross  
Carrera: Ingeniería de Sistemas  
Práctica: Estructura de Datos – Colas en C#  

## Introducción  
En esta práctica se trabajó con la estructura de datos **Cola (Queue)** en C#.  
Una cola funciona como una fila en el banco o en el cine: el primero que llega es el primero que se atiende (**FIFO: First In, First Out**).  

El objetivo fue **simular una cola estática** con operaciones básicas como insertar, eliminar, consultar y verificar su estado, utilizando un menú interactivo en consola.  

---

## Objetivos  
1. Comprender el funcionamiento de la estructura de datos **Cola**.  
2. Implementar una **cola estática** con arreglos en C#.  
3. Aplicar operaciones principales:  
   - **Enqueue (Insertar):** agregar un elemento al final.  
   - **Dequeue (Eliminar):** quitar el primer elemento.  
   - **Peek (Ver frente):** mostrar el primer elemento sin eliminarlo.  
   - **Verificar estados:** comprobar si la cola está vacía o llena.  
4. Incluir funciones adicionales:  
   - **Contains:** buscar si un elemento existe en la cola.  
   - **Count:** mostrar el número de elementos actuales.  

---

## Desarrollo  
La práctica se organizó en dos partes:  

1. **Clase `MyQueue`:**  
   - Maneja la cola internamente usando un arreglo de tamaño fijo.  
   - Contiene atributos como `Front`, `Rear`, `Size`, `Elements` y `Count`.  
   - Define métodos para insertar, eliminar, mostrar y verificar estados.  

2. **Clase principal con menú:**  
   - Permite al usuario seleccionar operaciones sobre la cola.  
   - Cada acción actualiza y muestra el estado actual de la cola en consola.  

---

## Ejemplo narrado  
- El usuario crea una cola con **capacidad 5**.  
- Inserta los números: `10, 20, 30`.  
- La cola queda: **[10, 20, 30]** (10 es el primero en salir).  
- Al consultar con **Peek**, se muestra el frente: **10**.  
- Al eliminar un elemento (**Dequeue**), se quita el **10**, dejando la cola: **[20, 30]**.  
- Luego inserta `40, 50, 60`. La cola se llena: **[20, 30, 40, 50, 60]**.  
- Si intenta insertar otro número, el programa indica que la cola está **llena**.  
- Al eliminar todos los elementos, la cola queda vacía y se confirma que no contiene datos.  

---

## Resultados  
- Se pudo **insertar y eliminar elementos siguiendo el orden FIFO**.  
- El programa detecta correctamente cuando la cola está **llena o vacía**.  
- El menú hizo más clara la interacción del usuario con la cola.  
- Funciones como **Contains** y **Count** dieron mayor utilidad al programa.  

---

## Conclusión  
- Se entendió cómo manejar los índices `Front` y `Rear` para controlar la cola.  
- El concepto FIFO se reforzó con ejemplos prácticos.  
- Se comprobó que las colas tienen aplicaciones reales, como gestión de filas o procesos.  
- La explicación combinada con ejemplos narrados facilita la comprensión del tema.  
