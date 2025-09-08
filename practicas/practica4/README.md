# Documentacion del ejercicio de pilas

## Implementacion de funciones para ingresar un numero determinado de datos y limpiar la pila.

1. Se crea una pila con el tipo de dato entero **INT** y el nombre del objeto **pila**, de la siguiente manera: `Stack<int> pila = new Stack<int>();`
   .

2. Declaramos una variable opcion de tipo entero **INT**

3. Abrimos un sentencia repetitiva **DO** para el menu con las siguientes opciones

   Menú de Pila

- Push (Push insertar elemento)
- Pop (eliminar elemento)
- Peek (ver elemento superior)
- Count (cantidad de elementos)
- Clear (limpiar pila)
- Push 'n' (insertar un número específico)
- Salir

4. Dentro de la sentencia repetitiva **DO** habra un **SWITCH** anidado para elegir las distintas opciones del menu.

- El primer caso para insertar un elemento con la funcion:

  **`pila.push(valor);`**

- En la segundo caso permite eliminar el elemento en la parte superior de la pila y se utiliza una sentencia selectiva **IF** y **ELSE**, determinando que si la pila contiene elementos este elimina el ultimo elemento ingresado. Si esta vacia muestra un mensaje. Para eliminar un elemento de la pila se utiliza la siguiente funcion :

**`pila.Pop()`**

- El tercer caso permite ver el elemento superior utilizando sentencia **IF** y **ELSE** determinando que si la pila contiene elementos este muestra el ultimo elemento ingresado. Si esta vacia muestra un mensaje. Para mostrar un elemento de la pila se utiliza la siguiente funcion :

**`pila.Peek()`**

- El cuarto caso permite contar la cantidad de elementos en la pila. Para mostrar los elementos de la pila se utiliza la siguiente funcion y se muestra con un **Console.WriteLine**:

**`pila.Count`**

- La quinta opcion permite vaciar la pila. Para vaciar la pila se utiliza la siguiente funcion:

**`pila.Clear();`**

- La sexta opcion permite ingresar 'n' de elementos que elija el usuario a traves de un bucle **FOR** y siendo insertados con la funcion:

**`pila.Push();`**

- Tambien se agrego la opcion de salida del menu y un manejo de error si el usuario no ingresa un numero dentro la lista del menu

Para subir tu avance al repositorio se hace de la siguiente manera:

1. muevete a la carpeta de tu repositorio local.
2. dirigete a la rama **MASTER** y descarga los ultimos cambio con `git fetch` y `git pull`.
3. Crea tu nueva rama con el `comando git checkout -b "nombre de tu rama"`.
4. Dirigete a tu rama con el comando `git chekckout "nombre de tu rama"` y comienza a trabajar.
5. una vez finalizado tu avance utiliza los siguientes comandos

- `git add .` pasa a un estado de preparado o se mueven a **stating**
- `git commit -m "descripcion"` que guarda los cambios en tu historial local de git
- `git push --set-upstream origin "nombre-rama"` que permite subir los cambios al repositorio local.
