<h1 align="center">DOCUMENTANDO LOS EJERCICIOS DE RECURSIVIDAD</h1>

## 9. BuscarEnArregloRecursiva

1. Definir la clase BuscarEnArregloRecursiva y añadir el método recursivo:

```
public static bool Buscar(int[] arr, int i, int valor)
{
    if (i == arr.Length) return false;
    if (arr[i] == valor) return true;
    return Buscar(arr, i + 1, valor);
}
```

2. Crear función MostrarProceso que imprime cada comparación:

```
static void MostrarProceso(int[] arr, int valor)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Paso {i + 1}: comparando {arr[i]} con {valor}");
        if (arr[i] == valor)
        {
            Console.WriteLine($"Valor {valor} encontrado en la posición {i}");
            break;
        }
    }
}
```

3. Declarar la variable opcion tipo INT.

4. Iniciar ciclo DO para el menú con opciones:

```
Console.WriteLine("\n--- MENÚ BUSCAR EN ARREGLO ---");
Console.WriteLine("1. Buscar valor con proceso");
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
