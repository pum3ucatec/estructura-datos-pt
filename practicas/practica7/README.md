# 📌 Proyecto: Cola con Nodos en C#

Este proyecto implementa una *estructura de datos tipo Cola (Queue)* utilizando *nodos enlazados* en el lenguaje C#.  
La aplicación incluye un *menú interactivo en consola* que permite realizar todas las operaciones fundamentales de una cola.

---

## 📂 Estructura del Proyecto

El programa se compone de tres clases:

1. *Principal.cs*  
   Contiene el método Main y el menú de opciones que permite al usuario interactuar con la cola.

2. *Nodo.cs*  
   Define la clase Nodo, que representa cada elemento dentro de la cola.  
   - Name: valor almacenado en el nodo.  
   - Next: referencia al siguiente nodo en la estructura.  

3. *Cola.cs*  
   Implementa la lógica de la cola enlazada con métodos para insertar, eliminar, buscar, contar, limpiar y mostrar elementos.

---

## ⚙️ Funcionalidades

El menú interactivo incluye las siguientes operaciones:

- *1. Mostrar Cola (View)*  
  Lista todos los elementos en orden de llegada.  

- *2. Insertar (Enqueue)*  
  Agrega un nuevo nodo al final de la cola.  

- *3. Eliminar (Dequeue)*  
  Elimina y devuelve el elemento que se encuentra al frente.  

- *4. Ver Frente (Peek)*  
  Muestra el primer elemento sin eliminarlo.  

- *5. Verificar si está Vacía (IsEmpty)*  
  Indica si la cola contiene o no elementos.  

- *6. Contar Elementos (Count)*  
  Retorna el número total de nodos en la cola.  

- *7. Limpiar Cola (Clear)*  
  Elimina todos los elementos de la cola.  

- *8. Buscar Elemento (Contains)*  
  Verifica si un valor específico existe dentro de la cola.  

- *9. Buscar Elemento y Mostrar Posición*  
  Busca un nombre específico en la cola y devuelve la posición que ocupa (empezando desde 1).  

- *10. Eliminar Elemento por Posición*  
  Elimina un nodo ubicado en una posición específica dentro de la cola (por índice comenzando en 1).  

- *0. Salir*  
  Finaliza el programa.  

---

## 🖥️ Ejemplo de Ejecución

```bash
===== MENÚ COLA con NODOS =====
1. Mostrar Cola
2. Insertar (Enqueue)
3. Eliminar (Dequeue)
4. Ver frente (Peek)
5. Verificar si está vacía
6. Contar elementos
7. Limpiar cola
8. Buscar elemento
9. Buscar elemento y mostrar posición
10. Eliminar elemento por posición
0. Salir
Seleccione una opción: 2
Ingrese el nombre a insertar: Juan
Elemento insertado.

Seleccione una opción: 2
Ingrese el nombre a insertar: Ana
Elemento insertado.

Seleccione una opción: 9
Ingrese el nombre a buscar: Ana
Elemento 'Ana' encontrado en la posición 2.

Seleccione una opción: 10
Ingrese la posición del elemento a eliminar: 1
Elemento eliminado: Juan
```

 
# 🛠️ Tecnologías
Lenguaje: C#

Framework: .NET Console Application

Paradigma: Programación Orientada a Objetos

# 📘 Conceptos Clave Aprendidos

Uso de nodos enlazados para implementar una cola dinámica.

Manejo de métodos básicos de estructuras de datos (Enqueue, Dequeue, Peek).

Validación de entradas en consola.

Encapsulamiento y buenas prácticas en el diseño de clases.