<h1 align="center">DOCUMENTANDO LOS EJERCICIOS DE RECURSIVIDAD</h1>

## 2. SumaRecursiva

1. Definir la clase **SumaRecursiva** y añadir el método recursivo:

```
public static int CalcularSuma(int n)
{
    if (n == 0) return 0;
    return n + CalcularSuma(n - 1);
}
```

2. Crear función MostrarProceso que imprime la suma paso a paso:

```
static void MostrarProceso(int n)
{
    int suma = 0;
    for (int i = 1; i <= n; i++)
    {
        suma += i;
        Console.WriteLine($"Paso {i}: suma = {suma}");
    }
}
```

3. Declarar la variable opcion tipo INT.

4. Iniciar ciclo DO para el menú con opciones:

```
Console.WriteLine("\n--- MENÚ SUMA ---");
Console.WriteLine("1. Calcular suma con proceso");
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
