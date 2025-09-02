Ejercicios de Programación en C#

Este repositorio contiene 10 ejercicios básicos de programación en C#, cada uno con su explicación detallada y ejecutable desde Program.cs. Los ejercicios están organizados en carpetas p1 a p10.

Ejercicio 1: Contar del 1 al 10

Descripción: Mostrar en pantalla los números del 1 al 10 usando un bucle for.

Código principal:

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}


Explicación:

Queremos mostrar del 1 al 10.

for es un bucle que repite acciones: empieza en 1, termina en 10, sumando de uno en uno.

Dentro del bucle mostramos cada número en pantalla.

Resultado esperado:

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

Ejercicio 2: Sumar números del 1 al N

Descripción: Sumar todos los números desde 1 hasta un número ingresado por el usuario.

Código principal:

int suma = 0;
int i = 1;
while (i <= n)
{
    suma += i;
    i++;
}
Console.WriteLine($"La suma de 1..{n} es {suma}");


Explicación:

Creamos un contador i y una variable suma.

Mientras i no supere n, sumamos i a suma y aumentamos i.

Mostramos el resultado final.

Ejemplo de ejecución:

Escribe N: 5
La suma de 1..5 es 15

Ejercicio 3: Tabla de multiplicar del 1 al 10

Descripción: Mostrar la tabla de multiplicar de un número ingresado por el usuario, del 1 al 10.

Código principal:

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}


Explicación:

for recorre los números del 1 al 10.

Multiplicamos el número ingresado por cada valor de i y mostramos el resultado.

Ejemplo:

Número: 3
3 x 1 = 3
3 x 2 = 6
...
3 x 10 = 30

Ejercicio 4: Mini menú

Descripción: Crear un menú que se repite hasta que el usuario decida salir.

Código principal:

do
{
    Console.WriteLine("1) Saludar");
    Console.WriteLine("2) Sumar 2 + 2");
    Console.WriteLine("3) Salir");
    opcion = int.Parse(Console.ReadLine());
    if (opcion == 1)
        Console.WriteLine("¡Hola!");
    else if (opcion == 2)
        Console.WriteLine("2 + 2 = 4");
    else if (opcion != 3)
        Console.WriteLine("Opción no válida");
} while (opcion != 3);


Explicación:

do-while repite el menú al menos una vez y continúa mientras la opción no sea 3.

Dependiendo de la opción, ejecuta una acción o muestra mensaje de error.

Ejercicio 5: Contador regresivo del 10 al 1

Descripción: Contar de 10 a 1 y mostrar un mensaje final.

Código principal:

int i = 10;
while (i >= 1)
{
    Console.WriteLine(i);
    i--;
}
Console.WriteLine("¡Despegue!");


Explicación:

Contador inicia en 10 y va disminuyendo hasta 1.

Cada número se imprime y luego restamos 1.

Al final mostramos un mensaje de finalización.

Ejercicio 6: Validar número positivo

Descripción: Pedir un número positivo al usuario, repitiendo la solicitud si ingresa cero o negativo.

Código principal:

do
{
    Console.Write("Escribe un número positivo: ");
    numero = int.Parse(Console.ReadLine());
    if (numero <= 0)
        Console.WriteLine("Número no válido, intenta de nuevo.");
} while (numero <= 0);


Explicación:

do-while asegura que el usuario ingrese un número mayor que 0.

Si el número es incorrecto, muestra mensaje y pide nuevamente.

Ejercicio 7: Suma de 5 números

Descripción: Solicitar 5 números al usuario y calcular la suma total.

Código principal:

int suma = 0;
for (int i = 1; i <= 5; i++)
{
    int num = int.Parse(Console.ReadLine());
    suma += num;
}
Console.WriteLine($"La suma de los 5 números es: {suma}");


Explicación:

Bucle for se repite 5 veces para pedir cada número.

Sumamos cada número al total y mostramos el resultado al final.

Ejercicio 8: Detectar número primo

Descripción: Determinar si un número ingresado por el usuario es primo.

Código principal:

bool esPrimo = true;
for (int i = 2; i * i <= n; i++)
{
    if (n % i == 0)
    {
        esPrimo = false;
        break;
    }
}


Explicación:

Un número primo solo es divisible por 1 y él mismo.

Revisamos si hay algún divisor desde 2 hasta la raíz del número.

Si encontramos uno, no es primo y detenemos el bucle.

Ejercicio 9: Primeros 10 números pares

Descripción: Mostrar los primeros 10 números pares.

Código principal:

int contador = 0;
int numero = 2;
while (contador < 10)
{
    Console.WriteLine(numero);
    numero += 2;
    contador++;
}


Explicación:

Comenzamos en 2 y sumamos 2 cada vez.

Contamos cuántos pares se han mostrado hasta llegar a 10.

Ejercicio 10: Juego “Adivina el número”

Descripción: Juego donde el usuario adivina un número secreto del 1 al 50, recibiendo pistas.

Código principal:

Random rnd = new Random();
int secreto = rnd.Next(1, 51);
int intento;
int intentos = 0;

do
{
    intento = int.Parse(Console.ReadLine());
    intentos++;
    if (intento < secreto)
        Console.WriteLine("Más grande");
    else if (intento > secreto)
        Console.WriteLine("Más pequeño");
} while (intento != secreto);

Console.WriteLine($"¡Correcto! El número era {secreto}. Intentos: {intentos}");


Explicación:

Generamos un número aleatorio entre 1 y 50.

Repetimos mientras el usuario no adivine.

Damos pistas “más grande” o “más pequeño”.

Al acertar, mostramos el número y cantidad de intentos.