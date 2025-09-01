<h1 align="center"> DOCUMENTANDO LA PRACTICA 7</h1>

1. Definimos la clase **Nodo** con los parametros privados de la siguiente manera:

`public string Dato { get; set; }
public Nodo siguiente { get; set; }`

    public Nodo(string dato)
    {
        Dato = dato;
        siguiente = null;
    }`

2. Tambien definimos la clase **Cola** con los parametros privados de la siguiente manera:

`private Nodo frente;
    private Nodo final;
    private int cantidad;`

    public Cola()
    {
        frente = null;
        final = null;
        cantidad = 0;
    }

3. Definimos los parametros de las funcionalidades de la cola como ser:

- ### Enqueue:

  Nodo nuevo = new Nodo(valor);

        if (IsEmpty())
        {
            frente = nuevo;
            final = nuevo;
        }
        else
        {
            final.siguiente = nuevo;
            final = nuevo;
        }
        cantidad++;
        Console.WriteLine($"{valor} agregado a la cola.");`

- ### Dequeue:

  public string Dequeue()

  {
  if (IsEmpty())
  {
  Console.WriteLine("La cola está vacía.");
  return null;
  }
  string valor = frente.Dato;
  frente = frente.siguiente;
  cantidad--;
  if (IsEmpty())
  {
  final = null;
  }
  Console.WriteLine($"{valor} eliminado de la cola.");
  return valor;
  }

- ### Peek:

  public void Peek()

  {
  if (IsEmpty())
  {
  Console.WriteLine("La cola está vacía.");
  }
  else
  {
  Console.WriteLine($"El frente de la cola es: {frente.Dato}");
  }
  }

- ### IsEmpty:

  public bool IsEmpty()
  {
  return frente == null;
  }

- ### Count:

  public int Count()
  {
  return cantidad;
  }

- ### Clear:

  public void Clear()
  {
  frente = null;
  final = null;
  cantidad = 0;
  Console.WriteLine("Cola vaciada.");
  }

- ### Contains:

  public bool Contains(string valor)
  {
  Nodo actual = frente;
  while (actual != null)
  {
  if (actual.Dato.Equals(valor, StringComparison.OrdinalIgnoreCase))
  return true;
  actual = actual.siguiente;
  }
  return false;
  }

- ### Search(buscar) y eliminar:

  public void Search(string valor)
  {
  if (IsEmpty())
  {
  Console.WriteLine("La cola está vacía.");
  return;
  }

        Nodo actual = frente;
        Nodo anterior = null;

        while (actual != null && !actual.Dato.Equals(valor, StringComparison.OrdinalIgnoreCase))
        {
            anterior = actual;
            actual = actual.siguiente;
        }

        if (actual == null)
        {
            Console.WriteLine($"{valor} no encontrado en la cola.");
            return;
        }

        if (anterior == null)
        {

            frente = frente.siguiente;
            if (frente == null)
                final = null; // La cola queda vacía
        }
        else
        {
            anterior.siguiente = actual.siguiente;
            if (actual == final)
                final = anterior;
        }

        cantidad--;
        Console.WriteLine($"{valor} eliminado de la cola.");

  }

**cada uno de estos nos permite realizar las acciones dentro de la cola**

4. Definimos la clase principal llamando a la funcionalidad **Cola** y definimos la variable opcion como entero **INT** para escoger las opciones.

5. Se inicia una condicion repetitiva **DO** para mostrar el menu:

   `Console.WriteLine("\n===== MENÚ COLA con NODOS =====");
Console.WriteLine("1. Mostrar Cola");
Console.WriteLine("2. Insertar (Enqueue)");
Console.WriteLine("3. Eliminar (Dequeue)");
Console.WriteLine("4. Ver frente (Peek)");
Console.WriteLine("5. Verificar si está vacía");
Console.WriteLine("6. Contar elementos");
Console.WriteLine("7. Vaciar cola");
Console.WriteLine("8. Buscar elemento (Contains)");
Console.WriteLine("9. Eliminar de la cola en cualquier posicion");
Console.WriteLine("0. Salir");
Console.Write("Seleccione una opción: ");`

6. Finalmente se inicia un **Switch** con sus respectivos **Case** para poder ejecutar cada una de las opciones del menu.

<h1 align= center>Para subir tu avance al repositorio se hace de la siguiente manera: </h1>

1. muevete a la carpeta de tu repositorio local.
2. dirigete a la rama **MASTER** y descarga los ultimos cambio con `git fetch` y `git pull`.
3. Crea tu nueva rama con el `comando git checkout -b "nombre de tu rama"`.
4. Dirigete a tu rama con el comando `git chekckout "nombre de tu rama"` y comienza a trabajar.
5. una vez finalizado tu avance utiliza los siguientes comandos

- `git add .` pasa a un estado de preparado o se mueven a **stating**
- `git commit -m "descripcion"` que guarda los cambios en tu historial local de git
- `git push --set-upstream origin "nombre-rama"` que permite subir los cambios al repositorio local.
