<h1 align="center">DOCUMENTANDO LOS EJERCICIOS DE RECURSIVIDAD</h1>

## 5. InvertirCadenaRecursiva

1. Definir la clase InvertirCadenaRecursiva y añadir el método recursivo:

```
public static string Invertir(string cadena)
{
    if (cadena.Length <= 1) return cadena;
    return Invertir(cadena.Substring(1)) + cadena[0];
}
```

2. Crear función MostrarProceso que imprime la cadena invertida paso a paso:

```
static void MostrarProceso(string cadena)
{
    Console.WriteLine("Proceso:");
    for (int i = cadena.Length - 1; i >= 0; i--)
    {
        Console.Write(cadena[i]);
    }
    Console.WriteLine();
}
```

3. Declarar la variable opcion tipo INT.

4. Iniciar ciclo DO para el menú con opciones:

```
Console.WriteLine("\n--- MENÚ INVERTIR CADENA ---");
Console.WriteLine("1. Invertir cadena con proceso");
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
