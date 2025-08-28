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
0. Salir
Seleccione una opción: 2
Ingrese el nombre a insertar: Juan
Elemento insertado.

Seleccione una opción: 2
Ingrese el nombre a insertar: Ana
Elemento insertado.

Seleccione una opción: 1
Contenido de la cola:
Sebas | Juanma | Jose Gabriel |
```

## 🛠️ Tecnologías
Lenguaje: C#

Framework: .NET Console Application

Paradigma: Programación Orientada a Objetos

## 📘 Conceptos Clave Aprendidos 

Uso de nodos enlazados para implementar una cola dinámica.

Manejo de métodos básicos de estructuras de datos (Enqueue, Dequeue, Peek).

Validación de entradas en consola.

Encapsulamiento y buenas prácticas en el diseño de clases.