# Práctica 4 – Implementación de una Pila en C#

En esta práctica se desarrolla una **pila personalizada** utilizando la clase genérica `Stack<int>` de C#.  
El programa implementa un menú interactivo que permite gestionar la pila con diversas operaciones.

---

## Descripción General

La pila es una estructura de datos que sigue el principio **LIFO (Last In, First Out)**, donde el último elemento en entrar es el primero en salir.  
El código implementa una clase llamada `MiPila`, que encapsula las funcionalidades principales de una pila, y un programa principal con menú para interactuar con ella.

---

## Funcionalidades Implementadas

### Clase `MiPila`
La clase incluye los siguientes métodos:

- **Agregar(int numero):** Inserta un elemento en la pila.  
- **AgregarVarios(int cantidad):** Permite ingresar múltiples elementos solicitando al usuario los valores.  
- **Quitar():** Elimina el último elemento agregado (operación *Pop*).  
- **VerTope():** Devuelve el elemento en la cima de la pila sin eliminarlo (operación *Peek*).  
- **EstaVacia():** Indica si la pila no contiene elementos.  
- **VerTodo():** Muestra todos los elementos actualmente en la pila.  
- **Total():** Retorna el número total de elementos almacenados.  
- **Vaciar():** Elimina todos los elementos de la pila.  

---

### Menú Interactivo
El programa principal (`Main`) despliega un menú con las siguientes opciones:

1. Ver pila.  
2. Añadir un elemento.  
3. Quitar el último.  
4. Consultar el tope.  
5. Verificar si está vacía.  
6. Mostrar total de elementos.  
7. Vaciar la pila.  
8. Añadir múltiples elementos.  
0. Salir del programa.  

Cada opción se ejecuta validando las entradas del usuario para evitar errores.

---

## Conceptos Aplicados
- **Estructuras de datos:** Pila (Stack).  
- **Encapsulamiento:** Uso de la clase `MiPila` para agrupar operaciones.  
- **Bucles y condicionales:** Control del menú interactivo.  
- **Validación de entradas:** Manejo de errores con `int.TryParse`.  
- **Colecciones genéricas:** Uso de `System.Collections.Generic.Stack<T>`.  

---

## Autor
Adrien Liev Condarco Gonzales

Práctica elaborada como parte del aprendizaje de **estructuras de datos y programación orientada a objetos en C#**.  
