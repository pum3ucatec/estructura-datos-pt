**INDICE**
- [Documentación de la practica4](#documentación-de-la-practica4)
  - [1. Clase PIla](#1-clase-pila)
  - [2. Clase principal](#2-clase-principal)
    - [Menú interactivo:](#menú-interactivo)
    - [Opciones del menú:](#opciones-del-menú)
    - [Validación de entradas:](#validación-de-entradas)
    - [Interacción con la clase Pila:](#interacción-con-la-clase-pila)
# Documentación de la practica4
Se realizó la implementación de la estructura de datos tipo pila utilizando el lenguaje C#.
La pila es una estructura LIFO (Last In, First Out), donde el último elemento en ser agregado es el primero en ser removido.

Este proyecto incluye:

- La clase Pila, que encapsula toda la lógica de la estructura
- La interfaz de usuario mediante un menú en la consola.

Esta práctica sigue las siguientes convenciones de nombres:

- Clases y métodos → PascalCase 

- Variables locales y parámetros → camelCase 

---

## 1. Clase PIla
Como se menciono aqui esta toda la lógica de la estructura, a lo cual lo iremos explicando.

**Archivo:** [`Pila/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica4/practicas/practica4/Pila/Pila.cs)


- `elementos:` Lista privada (List<int>) que almacena los elementos de la pila.

- `Constructor Pila():` Inicializa la lista de elementos.

- `Push(int valor):` Agrega un elemento a la cima de la pila **(Add)** y muestra un mensaje de confirmación.

- `Pop():` Elimina y retorna el elemento de la cima de la pila.

    - Verifica si la pila está vacía antes de eliminar.

    - Si está vacía, retorna **-1** y muestra un mensaje.

- `Peek():` Devuelve el elemento de la cima sin eliminarlo.

    - Retorna **-1** si la pila está vacía.

- `Mostrar():` Imprime todos los elementos de la pila de cima a base.

- `IsEmpty():` Retorna true si la pila está vacía, false en caso contrario.

- `PushN(int cantidad):` Permite insertar múltiples elementos solicitando al usuario cada valor.

    - Valida que la entrada sea un número entero.

- `Count():` Devuelve la cantidad de elementos en la pila.

- `Clear():` Elimina todos los elementos de la pila y muestra un mensaje.

--- 

## 2. Clase principal

**Archivo:** [`Program/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica4/practicas/practica4/Pila/Program.cs)

### Menú interactivo:

- Permite al usuario seleccionar acciones sobre la pila mediante un bucle do...while.

- Usa switch para ejecutar la opción correspondiente.

### Opciones del menú:

1. Mostrar pila.

2. Insertar un elemento `(Push)`.

3. Eliminar el último elemento `(Pop)`.

4. Ver el elemento de la cima `(Peek)`.

5. Verificar si la pila está vacía `(IsEmpty)`.

6. Ver cantidad de elementos `(Count)`.

7. Vaciar la pila `(Clear)`.

8. Insertar varios elementos `(PushN)`.

9. Salir del programa.

### Validación de entradas:

Se usó `int.TryParse` para asegurar que las entradas del usuario sean números válidos.

### Interacción con la clase Pila:

- Cada opción del menú llama al método correspondiente de la clase Pila.

- Tambien se manejó mensajes claros para informar al usuario sobre el estado de la pila y los resultados de sus acciones.