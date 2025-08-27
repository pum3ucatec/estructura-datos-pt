<h1 align="center">DOCUMENTANDO LA PRACTICA 6</h1>

**pasos:**

1. definir la clase **Cola** y añadir los siguientes parámetros:

- `private int[] elementos;` guarda los valores de la cola
- `private int frente, final;` Índices para el primer y último elemento
- `private int cantidad, tamaño;` // cantidad de elementos actuales y tamaño máximo.

2. insertamos **Enqueue** con la siguiente estructura:

`public void Enqueue(int valor)
{
    if (cantidad == tamaño)
    {
        Console.WriteLine(" Cola llena.");
        return;
    }
    final = (final + 1) % tamaño;
    elementos[final] = valor;
    cantidad++;
}`

- Indica que si la cola está llena no inserta ningún elemento.
- Utiliza final= (final+1) para regresar al inicio.
- Añade el valor en esa posición.
- Aumenta la cantidad.

3. insertamos **Dequeue** con la siguiente estructura:

`public int Dequeue()
{
    if (cantidad == 0)
    {
        Console.WriteLine(" Cola vacía.");
        return -1;
    }
    int valor = elementos[frente];
    frente = (frente + 1) % tamaño;
    cantidad--;
    return valor;
}`

- Si la cola está vacía muestra un mensaje " la cola está vacía" y retorna un **-1**

- Guarda el valor del frente.
- Utiliza la misma función que Enqueue \*\*(frente= frente+1) % tamaño
- Disminuye la cantidad.
- Retorna el valor eliminado.

4. Mostrar el frente de la cola con **Peek** con la siguiente estructura:

`public int Peek()
{
if (cantidad == 0)
throw new InvalidOperationException("Cola vacía.");
return elementos[frente];
}`

- Si la cola está vacía muestra una excepción "la cola esta vacia".
- Sino muestra el valor de enfrente.

5. Mostrar el estado de la cola con **Peek** con la siguiente estructura:

`public bool EstaVacia() => cantidad == 0;`

`public bool EstaLlena() => cantidad == tamaño;`

`public bool Contiene(int valor)`

- si esta vacio solo indica que la cola esta vaci.
- Si la cola esta llena, muestra en pantalla se mensaje.
- Si contiene valor muestra los elementos del frente.

6. Iniciamos la clase principal llamando a la clase que creamos **cola** con una cantidad de 5 espacios y definimos la variable opcion como entero **INT**.

`Cola cola = new Cola(5); int opcion;`

7. Iniciando un ciclo **DO** dentro de este con el siguiente menu:

   `Console.WriteLine("\n===== MENÚ COLA =====");
Console.WriteLine("2. Insertar (Enqueue)");
Console.WriteLine("1. Mostrar COLA");
Console.WriteLine("3. Eliminar (Dequeue)");
Console.WriteLine("4. Ver frente (Peek)");
Console.WriteLine("5. Verificar la capacidatotal de la cola");
Console.WriteLine("6. Verificar si uelemento existe en la cola");
Console.WriteLine("7. Verificar si la cola ntiene elementos");
Console.WriteLine("8. Verificar si la colestá llena");
Console.WriteLine("0. Salir");
Console.Write("Seleccione una opción: ");`

8. Iniciamos un **SWITCH** anidado y **CASE** para ejecutar y mostrar en pantalla las opciones del menu.

---

<h1 align= center>Para subir tu avance al repositorio se hace de la siguiente manera: </h1>

1. muevete a la carpeta de tu repositorio local.
2. dirigete a la rama **MASTER** y descarga los ultimos cambio con `git fetch` y `git pull`.
3. Crea tu nueva rama con el `comando git checkout -b "nombre de tu rama"`.
4. Dirigete a tu rama con el comando `git chekckout "nombre de tu rama"` y comienza a trabajar.
5. una vez finalizado tu avance utiliza los siguientes comandos

- `git add .` pasa a un estado de preparado o se mueven a **stating**
- `git commit -m "descripcion"` que guarda los cambios en tu historial local de git
- `git push --set-upstream origin "nombre-rama"` que permite subir los cambios al repositorio local.
