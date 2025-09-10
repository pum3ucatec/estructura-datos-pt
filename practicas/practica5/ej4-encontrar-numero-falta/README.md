<h1 align="center">DOCUMENTACION DE LOS EJERCICIOS DE ARREGLOS Y MATRICES</h1>

### 4. Encontrar el Número que Falta

1. Crear un arreglo con números consecutivos del 1 a n.

2. Eliminar aleatoriamente un número.

3. Calcular la suma esperada con la fórmula n\*(n+1)/2.

4. Restar la suma actual para encontrar el faltante.

```
int sumaEsperada = n * (n + 1) / 2;
int sumaActual = arreglo.Sum();
int numeroFaltante = sumaEsperada - sumaActual;
```

<h1 align= "center">Para subir tu avance al repositorio se hace de la siguiente manera:</h1>

1. Muevete a la carpeta de tu repositorio local.
   dirigete a la rama MASTER y descarga los ultimos cambio con `git fetch y git pull.`
2. Crea tu nueva rama con el comando `git checkout -b "nombre de tu rama".`
3. Dirigete a tu rama con el comando `git chekckout "nombre de tu rama"` y comienza a trabajar.
   una vez finalizado tu avance utiliza los siguientes comandos
4. `git add .` pasa a un estado de preparado o se mueven a stating
5. `git commit -m "descripcion"` que guarda los cambios en tu historial local de git
6. `git push --set-upstream origin "nombre-rama" `que permite subir los cambios al repositorio local.
