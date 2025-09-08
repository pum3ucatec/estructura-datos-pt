# Práctica 4 – Pila en C#

**Nombre:** Edwin Escross  
**Carrera:** Ingeniería de Sistemas  
**Práctica:** Pila en C#

---

##  Descripción General

Esta práctica consiste en implementar una pila en C#, una estructura de datos tipo **LIFO (Last In, First Out)**, donde el último elemento que entra es el primero que sale.  
Se desarrolló un programa con un **menú interactivo** que permite al usuario realizar diferentes operaciones sobre la pila, visualizando sus cambios en tiempo real.

---

##  Objetivos

- Comprender el funcionamiento de la estructura de datos **pila**.  
- Crear una clase **Pila** con métodos que permitan manipularla de manera segura y eficiente.  
- Separar la lógica de la pila de la interfaz de usuario.  
- Aprender a implementar operaciones básicas de pilas como: **insertar, eliminar, consultar la cima, limpiar y mostrar visualmente**.

---

## Funcionalidades Implementadas

El programa permite realizar las siguientes operaciones sobre la pila:

- **Mostrar pila:** Visualización de todos los elementos desde la cima hasta la base.  
- **Insertar (Push):** Agregar un elemento a la cima de la pila.  
- **Insertar N elementos (Push N):** Agregar varios elementos consecutivos a la pila.  
- **Eliminar (Pop):** Quitar el elemento que está en la cima de la pila.  
- **Ver cima (Peek):** Consultar cuál es el elemento superior sin eliminarlo.  
- **Verificar si está vacía:** Determinar si la pila tiene elementos o está vacía.  
- **Limpiar pila (Clear):** Eliminar todos los elementos de la pila.  
- **Salir:** Finalizar el programa.

---

##  Explicación de la Implementación

- Se creó una clase **Pila** que contiene todos los métodos necesarios para manejar los elementos internamente usando una **lista dinámica**.  
- Los métodos principales son:  
  - **Push:** Inserta un elemento en la cima.  
  - **Pop:** Elimina y retorna el elemento superior.  
  - **Peek:** Consulta el elemento de la cima sin eliminarlo.  
  - **IsEmpty:** Verifica si la pila está vacía.  
  - **Mostrar:** Presenta los elementos de la pila de manera visual.  
  - **Clear:** Elimina todos los elementos.  
- La clase **Program** contiene el menú interactivo y el método `Main`, donde el usuario selecciona las operaciones a realizar sobre la pila.  
- La separación de la clase Pila y el menú permite **reutilizar la pila en otros proyectos** y mantener el código organizado y profesional.

---

##  Ejemplo de Uso

- El usuario inserta varios números en la pila.  
- Puede mostrar la pila para ver su estado actual.  
- Puede eliminar el último número insertado.  
- Consultar cuál es el elemento de la cima sin eliminarlo.  
- Limpiar toda la pila para reiniciar el proceso.

---

## Notas finales

- Refuerza el manejo de **estructuras de datos tipo LIFO (pila)**.  
- Permite practicar **inserción, eliminación, consulta y visualización de elementos**.  
- Fundamental para **entender cómo funcionan las pilas y su importancia en programación y algoritmos**.  
- Prepara para **estructuras de datos más complejas** en proyectos futuros.
