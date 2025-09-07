# Práctica 4 - Estructura de Datos (Pilas)

## Ejercicio 1: Implementación de una Pila en C#

Este programa implementa una pila utilizando la clase `Stack<int>` de .NET, añadiendo operaciones básicas y un menú interactivo para el usuario.

### Funcionalidades

El programa permite realizar las siguientes operaciones sobre la pila:

1. **Ver pila** → Muestra todos los elementos de la pila (de arriba hacia abajo).
2. **Insertar elemento (Push)** → Agrega un número a la pila.
3. **Eliminar elemento (Pop)** → Quita el último número insertado.
4. **Consultar cima (Peek)** → Muestra el elemento en la parte superior de la pila.
5. **Revisar si está vacía** → Verifica si la pila no contiene elementos.
6. **Vaciar pila (Clear)** → Elimina todos los elementos de la pila.
7. **Insertar varios elementos** → Permite ingresar múltiples valores separados por espacios.
8. **Salir** → Finaliza la ejecución del programa.

### Estructura del Código

- **Clase `MiPila`**  
  Implementa los métodos principales para manejar la pila:
  - `Agregar(int numero)` → Inserta un elemento.  
  - `Quitar()` → Elimina el elemento superior.  
  - `VerTope()` → Devuelve el valor en la cima.  
  - `EstaVacia()` → Indica si la pila está vacía.  
  - `Vaciar()` → Elimina todos los elementos.  
  - `MostrarTodo()` → Recorre e imprime los elementos.

- **Clase `Programa`**  
  Contiene el método `Main`, que implementa un menú interactivo en consola para acceder a las operaciones.

### Ejemplo de Uso

===== MENÚ PILA =====

Ver pila

Insertar elemento

Eliminar elemento

Consultar cima

Revisar si está vacía

Vaciar pila

Insertar varios elementos

Salir
Elige una opción: 2
Número a insertar: 15
Insertado: 15