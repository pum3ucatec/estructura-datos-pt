# 📌 Proyecto: Implementación de una Cola con Nodos en C#

Este proyecto implementa una **estructura de datos tipo Cola (Queue)** utilizando **nodos enlazados** en el lenguaje C#.  
Incluye un menú interactivo por consola que permite realizar todas las operaciones básicas sobre la cola.

---

## 📂 Estructura del Proyecto

El proyecto consta de **tres clases principales**:

1. **Program.cs**  
   Contiene el método `Main` y el menú interactivo que permite al usuario gestionar la cola desde la consola.

2. **Nodo.cs**  
   Define la clase `Nodo`, que representa cada elemento de la cola.  
   - `Name`: valor almacenado en el nodo.  
   - `Next`: referencia al siguiente nodo en la estructura.  

3. **Cola.cs**  
   Implementa la lógica de la cola mediante nodos enlazados. Contiene todos los métodos fundamentales para manipular la estructura.

---

## ⚙️ Funcionalidades Implementadas

La aplicación permite gestionar la cola mediante un menú con las siguientes opciones:

- **1. Mostrar Cola (`View`)**  
  Lista todos los elementos en orden de llegada.

- **2. Insertar (`Enqueue`)**  
  Agrega un nuevo elemento al final de la cola.

- **3. Eliminar (`Dequeue`)**  
  Extrae el elemento al frente de la cola (si existe).

- **4. Ver Frente (`Peek`)**  
  Muestra el primer elemento de la cola sin eliminarlo.

- **5. Verificar si está Vacía (`IsEmpty`)**  
  Indica si la cola no contiene elementos.

- **6. Contar Elementos (`Count`)**  
  Devuelve el número de elementos en la cola.

- **7. Limpiar Cola (`Clear`)**  
  Elimina todos los elementos de la estructura.

- **8. Buscar en la Cola (`Contains`)**  
  Verifica si un valor específico existe dentro de la cola.

- **0. Salir**  
  Finaliza la ejecución del programa.

---

## 🖥️ Ejemplo de Uso

```bash
===== MENÚ DE COLA (NODOS) =====
1. Mostrar Cola
2. Insertar (Enqueue)
3. Eliminar (Dequeue)
4. Ver Frente (Peek)
5. Verificar si está Vacía
6. Contar Elementos
7. Limpiar Cola (Clear)
8. Buscar en la Cola (Contains)
0. Salir
Seleccione una opción:
```

Ejemplo de interacción:

```
Ingrese el valor a insertar: Juan
✅ 'Juan' fue insertado en la cola.

Ingrese el valor a insertar: Ana
✅ 'Ana' fue insertado en la cola.

Contenido de la cola:
Juan | Ana |
```

🛠️ Tecnologías Utilizadas

- Lenguaje: C#

- Framework: .NET Console Application

- Paradigma: Programación Orientada a Objetos

📘 Aprendizajes Clave

- Implementación de estructuras de datos dinámicas en C#.

- Uso de nodos enlazados para simular una cola.

- Buenas prácticas en el diseño de clases (Nodo y Cola).

- Validación de entradas y manejo de excepciones básicas en consola.

### 👨‍💻 Autor
Desarrollado como proyecto académico de estructuras de datos en C#.

Autor: Adrien Liev Condarco Gonzales