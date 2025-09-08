<h1 align="center">DOCUMENTANDO LOS EJERCICIOS DE RECURSIVIDAD</h1>

## 3. FibonacciRecursivo

1. Definir la clase FibonacciRecursivo y añadir el método recursivo:

```
public static int CalcularFibonacci(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
}
```

2. Crear función MostrarProceso que imprime la secuencia hasta n:

```
static void MostrarProceso(int n)
{
    Console.Write("Proceso: ");
    for (int i = 0; i <= n; i++)
    {
        Console.Write(CalcularFibonacci(i) + " ");
    }
    Console.WriteLine();
}
```

3. Declarar la variable opcion tipo INT.

4. Iniciar ciclo DO para el menú con opciones:

```
Console.WriteLine("\n--- MENÚ FIBONACCI ---");
Console.WriteLine("1. Calcular Fibonacci con proceso");
Console.WriteLine("2. Salir");
```

5. Usar SWITCH para seleccionar las opciones y mostrar en pantalla el resultado.

<h1 align= center>Para subir tu avance al repositorio se hace de la siguiente manera: </h1>

1. muevete a la carpeta de tu repositorio local.
2. dirigete a la rama **MASTER** y descarga los ultimos cambio con `git fetch` y `git pull`.
3. Crea tu nueva rama con el `comando git checkout -b "nombre de tu rama"`.
4. Dirigete a tu rama con el comando `git chekckout "nombre de tu rama"` y comienza a trabajar.
5. una vez finalizado tu avance utiliza los siguientes comandos

- `git add .` pasa a un estado de preparado o se mueven a **stating**
- `git commit -m "descripcion"` que guarda los cambios en tu historial local de git
- `git push --set-upstream origin "nombre-rama"` que permite subir los cambios al repositorio local.
