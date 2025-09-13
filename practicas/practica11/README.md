# Práctica11: Ejercicios con recursividad
En esta práctica se presentan 10 problemas clásicos resueltos con recursividad.

Esta práctica sigue las siguientes convenciones de nombres:

- Clases y métodos → PascalCase

- Variables locales y parámetros → camelCase

---

## 1. Factorial de un número

**Pregunta:**  Implementar una función que calcule el factorial de un número `n`.

**Archivo:** [`e1-factorial-de-un-numero/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica11/practicas/practica11/e1-factorial-de-un-n%C3%BAmero/Program.cs)

- La clase Ejercicio1 contiene el método Factorial y el método principal Main.

- El método Factorial(int n):

    - Recibe un número entero n.

    - Si n es 0 o 1, devuelve 1 (caso base de la recursión).

    - En caso contrario, multiplica n por el factorial de n - 1, aplicando recursividad.

- En Main se pide al usuario un número, que se guarda en la variable num.

**Ejemplo de salida**

        === Factorial ===
        Ingresa un número: 5
        El factorial de 5 es: 120

        === Factorial ===
        Ingresa un número: -3
        El factorial no está definido para números negativos.

       
## 2. Suma de los primeros N números naturales

**Pregunta:**  Calcular la suma de los primeros `n` números naturales.

**Archivo:** [`e2-suma-de-numeros/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica11/practicas/practica11/e2-suma-de-n%C3%BAmeros/Program.cs)

- La clase Ejercicio_2 contiene un método recursivo llamado Suma y el método principal Main.

- El método Suma(int n):

     - Si n es 0, devuelve 0 (caso base de la recursión).

     - En caso contrario, devuelve n + Suma(n - 1).

     - Esto significa que va acumulando los números desde n hasta 1.

- En Main se pide al usuario un número entero n y se guarda en la variable n.

- Se llama al método Suma(n), y el resultado se almacena en la variable resultado.

- Finalmente, se muestra en consola la suma de los primeros n números enteros positivos.

**Ejemplo de salida**

       === Suma de N números ===
       Ingresa un número: 6
       La suma de los primeros 6 números es: 21

---

## 3. Secuencia de Fibonacci

**Pregunta:**  Calcular el término `n` de la secuencia de Fibonacci.

**Archivo:** [`e3-secuencia-de-fibonacci/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica11/practicas/practica11/e3-secuencia-de-fibonacci/Program.cs)


- La clase Ejercicio3 contiene el método Fibonacci (calcula el n-ésimo término) y MostrarFibonacci (muestra la secuencia recursivamente).

- Fibonacci(n) devuelve:

    - 0 si n == 0,

    - 1 si n == 1,

    - Fibonacci(n-1) + Fibonacci(n-2) en otro caso.

- MostrarFibonacci(n, i = 0) imprime desde F(0) hasta F(n) usando recursión.

- En Main, se pide un número n y se imprime la secuencia hasta ese término.

**Ejemplo de salida**

```
=== Fibonacci Recursivo ===
Ingresa un número: 7
La secuencia de Fibonacci hasta el término 7 es:
0 1 1 2 3 5 8 13

```
---

## 4. Potencia de un número

**Pregunta:**  Calcular `base^exponente` (base elevado al exponente).

**Archivo:** [`e4-potencia-de-un-numero/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica11/practicas/practica11/e4-potencia-de-un-n%C3%BAmero/Program.cs)

- La clase Ejercicio4 contiene el método Potencia que calcula baseNum elevado a exp recursivamente.

- La Potencia(baseNum, exp) funciona así:

     - Si exp == 0, devuelve 1.

     - Si exp > 0, devuelve baseNum * Potencia(baseNum, exp - 1).

     - Si exp < 0, devuelve 1 / Potencia(baseNum, -exp) para manejar exponentes negativos.

- En Main, se pide al usuario la base y el exponente, y se muestra el resultado.


**Ejemplo de salida**

```
=== Potencia Recursiva ===
Ingresa la base: 8
Ingresa el exponente: 5
8^5 = 32768

```

---

## 5. Invertir una cadena

**Pregunta:**  Invertir una cadena de texto.

**Archivo:** [`e5-invertir-una-cadena/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica11/practicas/practica11/e5-invertir-una-cadena/Program.cs)

- La clase Ejercicio5 contiene el método Invertir, que invierte una cadena de forma recursiva.
  
- Cuando la cadena tiene 1 carácter o está vacía, ya no se necesita invertir.

- La función simplemente devuelve la cadena tal cual y el caso base detiene la recursión.

- Llamada recursiva:

    - Se llama a Invertir con la subcadena que excluye el primer carácter (Substring(1)).

    - Luego se añade el primer carácter al final.

    - Esto hace que los caracteres se “vayan acumulando al final” hasta que se llega al caso base.


**Ejemplo de salida**

```
=== Invertir Cadena ===
Ingresa una cadena: Isabel
La cadena invertida es: lebasI
```

---

## 6. Contar dígitos de un número

**Pregunta:**  Contar la cantidad de dígitos que tiene un número entero positivo.

**Archivo:** [`e6-contar-digitos/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica11/practicas/practica11/e6-contar-digitos/Program.cs)

La clase Ejercicio6 contiene el método ContarDigitos, que cuenta los dígitos de un número entero de forma recursiva.
- Caso base
     - Cuando el número es menor que 10 (un solo dígito), devuelve 1.

     - Detiene la recursión.

- Llamada recursiva:
     - Divide n entre 10 para eliminar el último dígito.

     - Suma 1 por cada llamada recursiva hasta llegar al caso base.

     - En Main, se pide al usuario un número y se imprime cuántos dígitos tiene.
  
**Ejemplo de salida**

```
=== Contar Dígitos ===
Ingresa un número: 34567
El número 34567 tiene 5 dígitos.

```
---

## 7. Máximo Común Divisor (MCD)

**Pregunta:**  Calcular el máximo común divisor (MCD) de dos números.

**Archivo:** [`e7-maximo-comun-divisor/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica11/practicas/practica11/e7-maximo-comun-divisor/Program.cs)

- La clase Ejercicio7 contiene el método MinimoComunDivisor, que calcula el MCD de dos números usando el algoritmo de Euclides.

- En Main, se piden dos números al usuario (num1 y num2).

- Posterior a ello se llama a MinimoComunDivisor(num1, num2) para obtener el resultado y se guarda en la variable resultado.

Finalmente, se imprime el MCD de los dos números ingresados.

**Ejemplo de salida**

```
=== Calcular MCD ===
Ingresa el primer número: 24
Ingresa el segundo número: 18
El MCD de 24 y 18 es: 6

```

---

## 8. Suma de un arreglo

**Pregunta:**  Calcular la suma de todos los elementos de un arreglo.

**Archivo:** [`e8-suma-de-un-arreglo/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica11/practicas/practica11/e8-suma-de-un-arreglo/Program.cs)

- La clase Ejercicio8 contiene el método SumaArreglo, que calcula la suma de los elementos de un arreglo de manera recursiva.

- En Main, se pide al usuario la cantidad de elementos del arreglo y se leen uno por uno, guardándolos en `arr`.

- Se llama a `SumaArreglo(arr, n)` para obtener la suma total de los elementos y se guarda en la variable resultado.

- Finalmente, se muestra en pantalla la suma del arreglo ingresado.

**Ejemplo de salida**

```
=== Suma de Arreglo ===
Ingresa la cantidad de elementos: 4
Elemento 1: 5
Elemento 2: 3
Elemento 3: 7
Elemento 4: 2
La suma del arreglo es: 17

```

---

## 9. Buscar un elemento en un arreglo

**Pregunta:**  Determinar si un número existe en un arreglo.

**Archivo:** [`e9-buscar-un-elemento/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica11/practicas/practica11/e9-buscar-un-elemento/Program.cs)

- La clase Ejercicio9 contiene el método BuscarElemento, que verifica si un valor existe dentro de un arreglo.

- En Main, se pide al usuario la cantidad de elementos del arreglo y se leen uno por uno, guardándolos en `arr`.

- Luego se pide al usuario el valor que desea buscar y se llama a `BuscarElemento(arr, n, valor)` para determinar si está presente.

- Finalmente, se muestra en pantalla un mensaje indicando si el elemento fue encontrado o no.

**Ejemplo de salida**

```
=== Buscar Elemento ===
Ingresa la cantidad de elementos: 5
Elemento 1: 3
Elemento 2: 7
Elemento 3: 1
Elemento 4: 9
Elemento 5: 4
Ingresa el valor a buscar: 7
Elemento encontrado.

```
---

## 10. Convertir un número decimal a binario

**Pregunta:**  Convertir un número decimal en su representación binaria.

**Archivo:** [`e10-convertir-de-decimal-a-binario/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica11/practicas/practica11/e10-convertir-de-decimal-a-binario/Program.cs)

- La clase Ejercicio10 contiene el método DecimalBinario, que convierte un número decimal a su representación binaria de manera recursiva.

- En Main, se pide al usuario un número entero y se guarda en la variable num.

- Se llama a `DecimalBinario(num)` para obtener la cadena con el número en binario y se almacena en binario.

- Finalmente, se imprime en pantalla la representación binaria del número ingresado.

**Ejemplo de salida**

```
=== Decimal a Binario Recursivo ===
Ingresa un número entero: 10
El número 10 en binario es: 1010

```
