<h1 align="center">DOCUMENTANDO LOS EJERCICIOS DE RECURSIVIDAD</h1>

## 6. ContarDigitosRecursivo

1. Definir la clase ContarDigitosRecursivo y añadir el método recursivo:

```
public static int Contar(int n)
{
    if (n == 0) return 0;
    return 1 + Contar(n / 10);
}
```

2. Crear función MostrarProceso que imprime cada división paso a paso:

```
static void MostrarProceso(int n)
{
    int i = 1;
    while (n > 0)
    {
        Console.WriteLine($"Paso {i}: {n} / 10 = {n / 10}");
        n /= 10;
        i++;
    }
}
```

3. Declarar la variable opcion tipo INT.

4. Iniciar ciclo DO para el menú con opciones:

```
Console.WriteLine("\n--- MENÚ CONTAR DÍGITOS ---");
Console.WriteLine("1. Contar dígitos con proceso");
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
