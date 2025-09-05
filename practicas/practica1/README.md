# Documentación de la Practica1

La practica1 contiene ejercicios basicos en C# donde cada uno de ellos sigue las siguientes convenciones de nombres:

- Clases y métodos → PascalCase (**Ejemplo:** Ejercicio1, Main).

- Variables locales y parámetros → camelCase (**Ejemplo:** int i).

## 1. Contar del 1 al 10
Usar un bucle for para mostrar los números del 1 al 10 en pantalla


**Archivo:** [`p1-contar-1-al-10/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica1/practicas/practica1/p1-contar-1-al-10/Program.cs)


- Se utilizó un bucle for porque sabemos el número exacto de repeticiones, en este caso 10 veces.
  

  
### Ejemplo de salida

        1
        2
        3
        4
        5
        6
        7
        8
        9
        10

---

## 2. Sumar numeros del 1 al N

Pedir al usuario un número N y sumar todos los números del 1 hasta N usando while

**Archivo:** [`p2-sumar-numeros-del-1-al-N/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica1/practicas/practica1/p2-sumar-numeros-del-1-al-N/Program.cs)

- Se utiliza un bucle while porque el número de iteraciones depende de la entrada del usuario.

- La variable suma acumula el resultado de la suma progresiva.

- La variable contador empieza en 1 y se incrementa hasta llegar a N.

### Ejemplo de salida

     Ingrese un número N: 5
     La suma de los números del 1 al 5 es: 15

---
## 3. Tablas de multiplicar
Solicitar un número al usuario y mostrar su tabla de multiplicar del 1 al 10 usando for.

**Archivo:** [`p3-tablas-de-multiplicar/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica1/practicas/practica1/p3-tablas-de-multiplicar/Program.cs)

- Se utiliza un bucle for porque la tabla siempre va del 1 al 10.

- El formato de salida usa interpolación de cadenas ($"{variable}") para mostrar la multiplicación.

- El programa funciona con cualquier número entero ingresado por el usuario.

### Ejemplo de salida
Ingrese un número para ver su tabla de multiplicar: 7

    Tabla de multiplicar del 7:

    7 x 1 = 7
    7 x 2 = 14
    7 x 3 = 21
    7 x 4 = 28
    7 x 5 = 35
    7 x 6 = 42
    7 x 7 = 49
    7 x 8 = 56
    7 x 9 = 63
    7 x 10 = 70

---

## 4. Menu con while
Crear un pequeño menú que se repita hasta que el usuario elija salir (Ejemplo: 1.Saludar, 2.Sumar, 3.Salir)

**Archivo:** [`p4-menu-con-while/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica1/practicas/practica1/p4-Menu-con-while/Program.cs)

- Se utilizó un bucle do...while para garantizar que el menú se muestre al menos una vez.

- La estructura switch permite manejar múltiples opciones de forma clara.

- La opción 2 (Sumar) solicita dos números y muestra su suma.

- El menú se repite hasta que el usuario ingresa la opción 3 (Salir).
  
---
  
## 5. Contador regresivo
Mostrar una cuenta regresiva del 10 al 1 usando while.

**Archivo:** [`p5-contador-regresivo/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica1/practicas/practica1/p5-contador-regresivo/Program.cs)

- Se usa un bucle while decreciente, ya que la condición se cumple mientras contador >= 1.

- La variable contador empieza en 10 y se reduce en cada iteración con contador--.

- Cada número se imprime en consola hasta llegar al 1.

--- 

## 6. Validar entrada con do while
Pedir al usuario que introduzca un número positivo y seguir pidiendo hasta que lo haga correctamente.

**Archivo:** [`p6-validar-entrada/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica1/practicas/practica1/p6-validar-entrada/Program.cs)

- Se utiliza un bucle do...while porque al menos una vez se debe pedir al usuario que ingrese un número.

- La condición numeroPositivo <= 0 obliga a repetir el ingreso mientras no se cumpla que el número sea positivo.

- Una vez que el usuario introduce un número válido, el programa muestra el resultado y finaliza.

### Ejemplo de salida

    Ingrese un número positivo: -4
    Ingrese un número positivo: 0
    Ingrese un número positivo: 7
    Número válido ingresado: 7

---
## 7. Suma de 5 números ingresados por el usuario

Suma de 5 números ingresados por el usuario Pedir al usuario 5 números (uno por uno) y sumarlos usando for.

**Archivo:** [`p7-suma-de-num-ingresados/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica1/practicas/practica1/p7-suma-de-num-ingresados/Program.cs)

- Se utiliza un bucle for que se repite exactamente 5 veces para pedir 5 números al usuario.

- En cada iteración se solicita un número y se suma al acumulador suma.

- Al final, el programa muestra el total de la suma de los 5 números ingresados.
  
### Ejemplo de salida 

    Ingrese el número 1: 4
    Ingrese el número 2: 7
    Ingrese el número 3: 3
    Ingrese el número 4: 6
    Ingrese el número 5: 10
    La suma total es: 30

---
## 8. Detectar número primo
Usar un bucle for para determinar si un número ingresado por el usuario es primo o no.

**Archivo:** [`p8-numero-primo/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica1/practicas/practica1/p8-numero-primo/Program.cs)

- El programa pide un número y verifica si es primo.

- Se considera no primo cualquier número menor o igual a 1.

- Si se encuentra un divisor exacto (numero % i == 0), el número no es primo y se rompe el ciclo con break.

- Se usa un operador para mostrar directamente "Es primo" o "No es primo".

### Ejemplo de salida

    Ingrese un número para verificar si es primo: 7
    Es primo

    Ingrese un número para verificar si es primo: 12
    No es primo

---

## 9. Mostrar los primeros 10 números 
Mostrar en pantalla los primeros 10 números pares usando while.

**Archivo:** [`p9-detectar-numeros-pares/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica1/practicas/practica1/p9-detectar-numeros-pares/Program.cs)

- La variable num comienza en 2, el primer número par positivo.

- La variable pares lleva el conteo de cuántos números pares se han mostrado.

- El bucle while se ejecuta mientras pares < 10, es decir, se muestran exactamente 10 números pares.

- En cada iteración se imprime num, luego se incrementa en 2 (num += 2) para obtener el siguiente par.
  
---

## 10. Adivina el número (juego)
El sistema genera un número aleatorio del 1 al 50. El usuario intenta adivinarlo. 
Usar do-while hasta que acierte, indicando si es mayor o menor.

**Archivo:** [`p10-adivina-el-numero/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica1/practicas/practica1/p10-adivina-el-numero/Program.cs)

- Se crea un objeto Random para generar un número aleatorio entre 1 y 50 con random.Next(1, 51).

- La variable numeroSecreto guarda el número que el usuario debe adivinar.

- Se utiliza un bucle do...while para permitir que el usuario intente hasta acertar.

- En cada intento si el número ingresado es menor que el secreto, se muestra “El número secreto es mayor”.

- Si es mayor, se muestra “El número secreto es menor”.

- Cuando el usuario acierta, el bucle termina y se muestra el mensaje de felicitación.

