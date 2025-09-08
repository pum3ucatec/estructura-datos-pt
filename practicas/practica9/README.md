<h1 align="center">Documentacion de la practica listas dobles</h1>

1. definimos la clase **NoDoble** con las propiedades:

- **Dato** de tipo **INT**
- **NodoSiguiente** y **NodoAnterior** que nos permite recorrer la lista adelante y atras.
- Una propiedad NoDoble con el parametro dato de tipo **INT** para manejar los metodos de si el nodo siguiente es null termina el programa.

2. definimos la clase **ListaDoble** con las propiedades:

- Para controlar el frente de la lista con el nombre **cabeza** de tipo null
- Para controlar el inal de la lista con el nombre **cola** de tipo null
- Medir la capacidad de la lista con el nombre **capacidadMaxima** es igual a capacidad
- Medir la catidad que almacena con el nombre **cantidad** inicializada en 0

3. definimos los metodos para mostrar, agregar, eliminar,etc. dentro de la lista doble.

- El metodo mostrar() permite recorrer la toda la lista y muestra en pantalla terminando en null.

- El metodo insertar() permite añadir datos mientras la lista no rebase la capacida maxima. en caso de no poder insertar se mostrara en pantalla un mensaje **"la lista esta llena"**

- El metodo Eliminar() elimina el primer nodo de la lista y muestra en pantalla el nodo que se elimino, si la lista esta vacia , muestra un mensaje **"que lista esta vacia y no se puede eliminar"**

- El metodo VerFrente() muestra el valor almacenado en la cabeza de la lista, si la lista esta vacia se muestra en pantalla.

- El metodo VerCapacidad() muestra la capacidad maxima de la lista

- El metodo existe(valor) busca un numero ingresado por teclado ,en caso de no encontrar muestra un mensaje.

- El metodo EstaVacia() verifica sila lista esta vacia y muestra en pantalla si hay valores dentro la lista.

- El metodo EstaLlena verifica si la lista esta a la maxima capacidad, muestra un mensaje si la lista esta llena o si aun tiene estapacio.

5.  Declaramos la clase **Program Main** y creamos el objeto lista con una capacidad de 8

6.  Iniciamos una sentencia **Do** para mostrar el menu:

        Console.WriteLine("\n===== MENÚ LISTA DOBLE =====");
        Console.WriteLine("1. Mostrar LISTA");
        Console.WriteLine("2. Insertar");
        Console.WriteLine("3. Eliminar");
        Console.WriteLine("4. Ver frente");
        Console.WriteLine("5. Verificar la capacidad total de la lista");
        Console.WriteLine("6. Verificar si un elemento existe en la lista");
        Console.WriteLine("7. Verificar si la lista no tiene elementos");
        Console.WriteLine("8. Verificar si la lista está llena");
        Console.WriteLine("0. Salir");
        Console.Write("Seleccione una opción: ");
        opcion = int.Parse(Console.ReadLine());

7.  Por ultimo definimos un **SWITCH** y el **CASE** para cada metodo

<h1 align="center"> Para subir tu avance al repositorio se hace de la siguiente manera:</h1>

1. muevete a la carpeta de tu repositorio local.
2. dirigete a la rama **MASTER** y descarga los ultimos cambio con `git fetch` y `git pull`
3. Crea tu nueva rama con el `comando git checkout -b "nombre de tu rama"`.
4. Dirigete a tu rama con el comando `git chekckout "nombre de tu rama"` y comienza a trabajar.
5. una vez finalizado tu avance utiliza los siguientes comandos

- `git add .` pasa a un estado de preparado o se mueven a **stating**
- `git commit -m "descripcion"` que guarda los cambios en tu historial local de git
- `git push --set-upstream origin "nombre-rama"` que permite subir los cambios al repositorio local.
