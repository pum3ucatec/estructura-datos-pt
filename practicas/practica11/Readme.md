# Practica 10 
## Ejercicios de Recursividad en C#

Este documento contiene la explicación de 10 ejercicios clásicos de recursividad en C#, cada uno acompañado de su función recursiva y un programa completo para probarlo.

## 1. Factorial de un número

### Problema: 
Implementar una función que calcule el factorial de un número n.
### Explicación:

Caso base: 0! = 1 y 1! = 1.

Caso recursivo: n! = n × (n-1)!.

#### Ejemplo:

5! = 5 × 4 × 3 × 2 × 1 = 120

## 2. Suma de los primeros N números naturales

### Problema: 
Calcular la suma de los primeros n números.
### Explicación:

Caso base: S(0) = 0.

Caso recursivo: S(n) = n + S(n-1).

#### Ejemplo:

S(5) = 5 + 4 + 3 + 2 + 1 = 15

## 3. Secuencia de Fibonacci

### Problema: 
Calcular el término n de la sucesión de Fibonacci.
### Explicación:

Caso base: F(0) = 0, F(1) = 1.

Caso recursivo: F(n) = F(n-1) + F(n-2).

#### Ejemplo:

F(6) = 8

## 4. Potencia de un número

### Problema: 
Calcular base^exponente.
###  Explicación:

Caso base: x^0 = 1.

Caso recursivo: x^n = x × x^(n-1).

#### Ejemplo:

2^5 = 32

## 5. Invertir una cadena

### Problema: 
Invertir una cadena de texto.
### Explicación:

Caso base: Una cadena vacía o de 1 carácter ya está invertida.

Caso recursivo: Invertir el resto de la cadena y luego agregar el primer carácter al final.

#### Ejemplo:

"hola" → "aloh"

## 6. Contar dígitos de un número

###  Problema: 
Contar la cantidad de dígitos en un número positivo.
### Explicación:

Caso base: Si n = 0, retorna 0.

Caso recursivo: Contar(n) = 1 + Contar(n/10).

#### Ejemplo:

12345 → 5 dígitos

## 7. Máximo Común Divisor (MCD)

###  Problema: 
Calcular el MCD de dos números.
###  Explicación:
Se usa el algoritmo de Euclides.

Caso base: Si b = 0, entonces MCD(a, b) = a.

Caso recursivo: MCD(a, b) = MCD(b, a % b).

#### Ejemplo:

MCD(48, 18) = 6

## 8. Suma de un arreglo

###  Problema: 
Calcular la suma de todos los elementos de un arreglo.
### Explicación:

Caso base: Si llegamos al final del arreglo, retornamos 0.

Caso recursivo: Suma(arr, i) = arr[i] + Suma(arr, i+1).

#### Ejemplo:

[1,2,3,4,5] → 15

## 9. Buscar un elemento en un arreglo

### Problema: 
Determinar si un valor existe en un arreglo.
### Explicación:

Caso base: Si llegamos al final del arreglo, retornamos false.

Caso recursivo: Si el elemento en la posición i es igual al buscado → true.
Si no → buscar en la siguiente posición.

#### Ejemplo:

Buscar 3 en [1,2,3,4,5] → true
Buscar 10 en [1,2,3,4,5] → false

## 10. Convertir un número decimal a binario

### Problema: 
Convertir un número decimal a binario.
###  Explicación:

Caso base: Si n = 0, devolvemos cadena vacía.

Caso recursivo: Llamamos con n/2 y luego concatenamos n%2.

#### Ejemplo:

13 → "1101"