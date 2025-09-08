<h1 align="center"> DOCUMENTACION PRACTICA 8</h1>

1. `<h1 align=center> </h1>` esta estructura funciona para centrar los textos dentro de markdown

<h1 align="center">Explicacion del desarrollo de la practica 8</h1>

1.  Declaramos la variable **Nodo**, **ListaSimple** y las propiedades de los mismo de tipo publico que son **Dato**, **NodoSiguiente**, **CantidadMaxima**, **Cantidad**
2.  Definimos el constructor con el tipo de dato y nombre del dato y lo que almacenara
3.  Definimos los metodos/acciones que hara las listas simples, estructurandolas de la siguiente manera:

        public void Mostrar()
        {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo actual = cabeza;
        Console.Write("Lista: ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
         }

indicando que si no hay datos ingresados la lista esta vacia caso contrario, si la tabla tiene datos **mostrara** el valor inicial y el siguiente hasta llegar al final donde el valor sera .

        public void Insertar(int dato)
        {
        if (cantidad >= capacidadMaxima)
        {
            Console.WriteLine("La lista está llena. No se puede insertar más.");
            return;
        }

        Nodo nuevo = new Nodo(dato);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
        cantidad++;
        }

nos idica que si la cola excede la capacidad, la cola esta llena, mientras que si ingresamos un nuevo dato y el valor es distinto de nulo se insertara un valor al final de la lista.

        public void Eliminar()
        {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía, no se puede eliminar.");
            return;
        }
        Console.WriteLine("Se eliminó: " + cabeza.Dato);
        cabeza = cabeza.Siguiente;
        cantidad--;
        }

Si queremos eliminar un dato no indica que si la tabla esta vacia nos muestra el mensaje que la lista esta vacia, en caso de que exista el dato se elimina el valor que esta al frente de la lista.

    public void VerFrente()
    {
        if (cabeza == null)
            Console.WriteLine("La lista está vacía.");
        else
            Console.WriteLine("Frente: " + cabeza.Dato);
    }

Para ver el frente de la fila se indica que si el valor es nulo se muestra en pantalla que la lista esta vacia, sino muestra el primer daoto de la cola.

    public void VerCapacidad()
    {
        Console.WriteLine($"Capacidad máxima: {capacidadMaxima}");
    }

Para verificar el tamaño de la fila simplemente se llama a la propiedad capacidadMaxima mediante un `Console.WriteLine`

    public void Existe(int valor)
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            if (actual.Dato == valor)
            {
                Console.WriteLine($"El elemento {valor} existe en la lista.");
                return;
            }
            actual = actual.Siguiente;
        }
        Console.WriteLine($"El elemento {valor} NO existe en la lista.");
    }

Para verificar si un elemento existe, verificamos que mientras el elemento actual sea distinto de null se muestra los elementos de la lista, sino se muestra un mensaje "el elemento no existe."

    public void EstaVacia()
    {
        Console.WriteLine(cabeza == null ? "La lista está vacía." : "La lista tiene elementos.");
    }

Para verificar que esta vacio la lista debe de ser distinto de null , caso contrario mostrar un mensaje que la lista tiene elementos.

    public void EstaLlena()
    {
        Console.WriteLine(cantidad >= capacidadMaxima ? "La lista está llena." : "La lista NO está llena.");
    }

Para verificar que esta lleno, si la cantidad es mayor o igual a la capacidad maxima, la lista indica que esta llena, sino la lista no esta llena.

4.Definimos la clases **Program** y el **Main** creando un objeto lista 5. definimos un valor de tipo int y un estructuramos el menu con un sentencia repetitiva "Do".

     Console.WriteLine("\n MENÚ LISTA SIMPLE");
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

6. Con sus respectivo switch y case para seleccionar cada opcion a realizar en las listas simples

<h1 align= "center">Para subir tu avance al repositorio se hace de la siguiente manera:</h1>

1. Muevete a la carpeta de tu repositorio local.
   dirigete a la rama MASTER y descarga los ultimos cambio con `git fetch y git pull.`
2. Crea tu nueva rama con el comando `git checkout -b "nombre de tu rama".`
3. Dirigete a tu rama con el comando `git chekckout "nombre de tu rama"` y comienza a trabajar.
   una vez finalizado tu avance utiliza los siguientes comandos
4. `git add .` pasa a un estado de preparado o se mueven a stating
5. `git commit -m "descripcion"` que guarda los cambios en tu historial local de git
6. `git push --set-upstream origin "nombre-rama" `que permite subir los cambios al repositorio local.
