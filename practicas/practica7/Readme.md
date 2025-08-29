#     Proyecto: Cola con Nodos en C#

Este proyecto implementa una **Cola** usando **Nodos enlazados** en el lenguaje C#.  
Una cola es una estructura de datos lineal que sigue la regla **FIFO (First In - First Out)**, es decir: el primero en entrar es el primero en salir.  

---

##  Clases usadas

### 🔹 Clase `Nodo`
- Representa cada elemento de la cola.
- Tiene:
  - `Name`: guarda el dato (ejemplo: "Patrick", "Kevin").
  - `Next`: guarda la referencia (el "siguiente nodo").
- Es como un bloquecito que apunta al que viene después.

### 🔹 Clase `Cola`
- Representa la cola como tal.
- Tiene:
  - `Front`: el primer elemento de la cola (la "cabeza").
  - `Rear`: el último elemento (la "cola").
- Contiene los métodos principales para manipular la cola:
  - `Enqueue(string name)` → insertar un dato al final.
  - `Dequeue()` → sacar el dato del frente.
  - `Count()` → contar los elementos.
  - `View()` → mostrar la cola en pantalla.
  - `Peek()` → ver cuál es el frente sin sacarlo.
  - `IsEmpty()` → verificar si está vacía.
  - `Clear()` → vaciar toda la cola.
  - `Contains(string name)` → buscar si un dato existe en la cola.

### 🔹 Clase `Principal`
- Contiene el **menú interactivo**.
- Permite al usuario elegir opciones para manipular la cola.

---

##  Opciones del Menú
1. **Mostrar Cola** → enseña todos los elementos de la cola en orden.  
2. **Insertar (Enqueue)** → agrega un nuevo nombre al final.  
3. **Eliminar (Dequeue)** → saca el elemento que está al frente.  
4. **Ver frente (Peek)** → muestra el primer elemento sin quitarlo.  
5. **Verificar si está vacía** → responde `true` o `false`.  
6. **Contar elementos (Count)** → dice cuántos hay en la cola.  
7. **Vaciar cola (Clear)** → elimina todos los nodos.  
8. **Buscar (Contains)** → revisa si un nombre existe en la cola.  

---

##  Ejemplo de uso

```bash
===== MENÚ COLA con NODOS =====
1. Mostrar Cola
2. Insertar (Enqueue)
3. Eliminar (Dequeue)
4. Ver frente (Peek)
5. Verificar si está vacía
6. Contar elementos
7. Vaciar Cola
8. Buscar en Cola
0. Salir
Seleccione una opción: 2
Ingrese el nombre a insertar: Patrick

Elemento agregado correctamente.
````
**Si le pido mostrar cola me saldra :**

```bash
Patrick | Kevin | Anthony |
````
