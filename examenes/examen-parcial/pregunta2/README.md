<h1 align="center"> DOCUMENTACION DEL PRIMER EXAMEN-PARCIAL PREGUNTA 2 </h1>

## DESARROLLO DEL EJERCICIO 2:

- Definimos un **arreglo de tipo entero `int[]`** con el nombre **numeros** que contiene una secuencia de enteros del 1 al _n_, pero con uno o varios valores faltantes.

- Llamamos a la función **EncontrarFaltantes** que recibe el arreglo como parámetro y retorna una lista de enteros con los números faltantes. Se llama de la siguiente manera:  
  **`List<int> faltantes = EncontrarFaltantes(numeros);`**

- Mostramos en pantalla el resultado con la palabra reservada  
  **`Console.WriteLine(string.Join(", ", faltantes));`**, que concatena y muestra los números faltantes separados por comas.  
  En caso de que la lista esté vacía, se imprime el mensaje **"No falta ningún número"**.

- Dentro de la función **EncontrarFaltantes** definimos lo siguiente:
  - Calculamos el **valor máximo** dentro del arreglo para conocer hasta qué número debería ir la secuencia completa.
  - Guardamos los números existentes en un **HashSet**, lo que nos permite verificar rápidamente si un número está presente o no en el arreglo.
  - Recorremos con un bucle **FOR** desde **1 hasta el valor máximo**, y todos los números que **no estén en el HashSet** se agregan a la lista de faltantes.

int max = 0;
foreach (int num in arr)
if (num > max) max = num; // encontrar el mayor valor

    HashSet<int> conjunto = new HashSet<int>(arr);
    List<int> faltantes = new List<int>();

    for (int i = 1; i <= max; i++)
    {
        if (!conjunto.Contains(i))
            faltantes.Add(i);
    }

    return faltantes;

### Ejemplo de resultado final

- Arreglo de entrada: [1, 2, 3, 4, 6]

- Valor máximo: 6

- Esperado: [1, 2, 3, 4, 5, 6]

- Comparación con HashSet: falta el 5.

- Resultado final: 5

<h1 align="center">Subir el archivo al repositorio: </h1>

Para subir tu avance al repositorio se hace de la siguiente manera:

1. muevete a la carpeta de tu repositorio local.
2. dirigete a la rama **MASTER** y descarga los ultimos cambio con `git fetch` y `git pull`.
3. Crea tu nueva rama con el `comando git checkout -b "nombre de tu rama"`.
4. Dirigete a tu rama con el comando `git chekckout "nombre de tu rama"` y comienza a trabajar.
5. una vez finalizado tu avance utiliza los siguientes comandos

- `git add .` pasa a un estado de preparado o se mueven a **stating**
- `git commit -m "descripcion"` que guarda los cambios en tu historial local de git
- `git push --set-upstream origin "nombre de la rama"` que permite subir los cambios al repositorio local.
