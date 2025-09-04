Ejercicios de Programación en C#

Este repositorio contiene 10 ejercicios en C# diseñados para practicar los fundamentos de programación: bucles, condicionales, operaciones aritméticas, validaciones y lógica interactiva con el usuario. Cada ejercicio está organizado en carpetas p1 a p10.

A continuación se explica qué hace cada ejercicio, para qué sirve y los comandos y conceptos importantes que utiliza.

Práctica 1: Contar del 1 al 10

Objetivo:
Mostrar los números del 1 al 10 en orden.

Para qué sirve:
Aprender a usar bucles para repetir acciones automáticamente.

Conceptos y comandos importantes:

for → Bucle que repite instrucciones un número determinado de veces.

int → Declara variables enteras.

Console.WriteLine → Muestra texto o números en pantalla.

Contador (i) → Variable que controla cuántas veces se repite la acción.

Funcionamiento:
El programa inicia un contador en 1 y lo incrementa hasta 10, mostrando cada número en pantalla.

Práctica 2: Sumar números del 1 al N

Objetivo:
Calcular la suma de todos los números desde 1 hasta un número ingresado por el usuario.

Para qué sirve:
Practicar acumuladores, bucles y entrada de datos del usuario.

Conceptos y comandos importantes:

while → Bucle que repite acciones mientras se cumpla una condición.

Console.ReadLine → Permite leer lo que escribe el usuario.

int.Parse → Convierte texto a número entero.

+= → Acumula valores en una variable.

Contador (i) → Controla la repetición hasta llegar al límite ingresado.

Funcionamiento:
El programa suma todos los números del 1 al número que el usuario ingrese y muestra el resultado.

Práctica 3: Tabla de multiplicar del 1 al 10

Objetivo:
Mostrar la tabla de multiplicar de un número dado por el usuario.

Para qué sirve:
Practicar bucles, operaciones aritméticas y presentación de resultados.

Conceptos y comandos importantes:

Multiplicación (*) → Realiza la operación matemática.

Interpolación de texto ($"") → Permite combinar texto y valores en una sola línea.

for → Repite la operación para todos los valores del 1 al 10.

Console.WriteLine → Muestra resultados en pantalla.

Funcionamiento:
Multiplica el número ingresado por los valores del 1 al 10 y muestra cada resultado.

Práctica 4: Mini menú interactivo

Objetivo:
Crear un menú que se repite hasta que el usuario decida salir.

Para qué sirve:
Aprender a usar condicionales y bucles de repetición.

Conceptos y comandos importantes:

do-while → Bucle que ejecuta primero y luego verifica si debe repetir.

if/else if/else → Ejecuta instrucciones según condiciones.

Console.ReadLine → Leer la opción del usuario.

int.Parse → Convertir texto a número para evaluar condiciones.

Console.WriteLine → Mostrar opciones y resultados.

Funcionamiento:
El usuario selecciona opciones del menú, el programa ejecuta la acción correspondiente y repite hasta que se elige “salir”.

Práctica 5: Contador regresivo del 10 al 1

Objetivo:
Hacer una cuenta regresiva y mostrar un mensaje final.

Para qué sirve:
Practicar bucles con decrementos y secuencias numéricas.

Conceptos y comandos importantes:

while → Bucle que repite mientras la condición sea verdadera.

i-- → Decrementa el valor del contador.

Console.WriteLine → Mostrar números y mensajes finales.

Funcionamiento:
El programa empieza en 10 y resta 1 cada paso hasta llegar a 1, luego muestra un mensaje final.

Práctica 6: Validar número positivo

Objetivo:
Pedir un número positivo al usuario y repetir hasta que sea válido.

Para qué sirve:
Aprender validaciones de datos y manejo de condiciones.

Conceptos y comandos importantes:

do-while → Ejecuta al menos una vez y repite hasta cumplir condición.

if → Verifica si el número es válido.

Console.ReadLine y int.Parse → Leer y convertir el número ingresado.

Comparaciones (>, <=) → Evaluar si el número cumple los requisitos.

Funcionamiento:
El programa solicita números hasta que el usuario ingrese uno mayor que cero.

Práctica 7: Suma de 5 números

Objetivo:
Pedir 5 números y calcular su suma total.

Para qué sirve:
Practicar bucles fijos, acumuladores y entrada de datos.

Conceptos y comandos importantes:

for → Repetir un número determinado de veces.

+= → Acumular los números en una variable.

Console.ReadLine y int.Parse → Leer y convertir números.

Console.WriteLine → Mostrar la suma final.

Funcionamiento:
Se suman cinco números ingresados por el usuario y se muestra el total.

Práctica 8: Detectar número primo

Objetivo:
Determinar si un número es primo.

Para qué sirve:
Practicar condicionales, operadores aritméticos y lógica de divisibilidad.

Conceptos y comandos importantes:

Operador módulo (%) → Obtener el resto de una división.

Bucle for con condición (i*i <= n) → Revisar posibles divisores.

break → Salir del bucle si se encuentra un divisor.

Variables booleanas (bool) → Guardar si el número es primo o no.

Console.WriteLine → Mostrar resultado final.

Funcionamiento:
El programa verifica si el número solo es divisible por 1 y él mismo.

Práctica 9: Primeros 10 números pares

Objetivo:
Mostrar los primeros 10 números pares.

Para qué sirve:
Practicar incrementos específicos y conteo controlado.

Conceptos y comandos importantes:

Contadores (contador) → Controlar cuántos números se han mostrado.

Incremento (numero += 2) → Avanzar al siguiente número par.

while → Repetir mientras no se alcance la cantidad deseada.

Console.WriteLine → Mostrar números en pantalla.

Funcionamiento:
Empieza en 2 y suma 2 cada vez, mostrando diez números pares consecutivos.

Práctica 10: Juego “Adivina el número”

Objetivo:
Crear un juego donde el usuario adivina un número secreto.

Para qué sirve:
Practicar números aleatorios, bucles y condicionales, así como interacción avanzada.

Conceptos y comandos importantes:

Random → Generar números aleatorios.

do-while → Repetir intentos hasta acertar.

if/else if → Dar pistas “más grande” o “más pequeño”.

Contador de intentos (intentos++) → Contar cuántas veces se probó.

Console.WriteLine → Mostrar instrucciones, pistas y resultados.

Funcionamiento:
El usuario adivina el número secreto y recibe pistas hasta acertar. Al final se muestra la cantidad de intentos.

Estructura de carpetas
practica1/
    p1/ → Contar del 1 al 10
    p2/ → Sumar del 1 al N
    p3/ → Tabla de multiplicar
    p4/ → Mini menú
    p5/ → Contador regresivo
    p6/ → Validar número positivo
    p7/ → Suma de 5 números
    p8/ → Detectar número primo
    p9/ → Primeros 10 números pares
    p10/ → Juego Adivina el número