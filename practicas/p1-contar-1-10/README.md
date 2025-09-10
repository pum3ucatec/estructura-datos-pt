<h1 align="center">DOCUMENTACION DE LOS EJERCICIOS BÁSICOS DE C#</h1>

## 1. Números del 1 al 10 en pantalla

1. Usar un ciclo **for** que inicie en 1 y termine en 10.
2. Mostrar cada número en pantalla con Console.WriteLine.

```
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
```

## 2. Números del 1 hasta N usando while (suma)

1. Solicitar al usuario un número N.

2. Usar un ciclo while para sumar los números desde 1 hasta N.

3. Imprimir el resultado final.

```
Console.WriteLine("Ingrese un número:");
int n = Convert.ToInt32(Console.ReadLine());
int suma = 0, m = 1;

while (m <= n)
{
    suma = suma + m;
    m++;
}
Console.WriteLine("La suma de los números del 1 al " + n + " es: " + suma);
```

## 3. Tabla de multiplicar del 1 al 10

1. Solicitar al usuario un número.

2. Usar un ciclo for para multiplicar el número por valores del 1 al 10.

3. Mostrar la tabla en pantalla.

```
Console.WriteLine("Ingresa un número:");
int numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine(numero + " x " + i + " = " + resultado);
}
```

## 4. Crear un menú con opciones

1. Creamos un ciclo do-while para mostrar un menú con 3 opciones:

`Saludar.`

`Sumar 2 + 2.`

`Salir.`

2. Usar un switch para manejar las opciones ingresadas de la siguiente manera.

int opcion;

```
do

{
    Console.WriteLine("Menú");
    Console.WriteLine("1. Saludar");
    Console.WriteLine("2. Sumar 2 + 2");
    Console.WriteLine("3. Salir");
    Console.Write("Elige una opción: ");
```

```
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Hola");
            break;
        case 2:
            Console.WriteLine("El resultado es: " + (2 + 2));
            break;
        case 3:
            Console.WriteLine("Bye");
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    if (opcion != 3)
    {
        Console.WriteLine("Presiona una tecla para continuar.");
        Console.ReadKey();
    }

} while (opcion != 3);
```

## 5. Contador regresivo

```
Declarar una variable con valor inicial 10.

Usar un ciclo while que decremente hasta 0.

Mostrar cada número en pantalla.

int iniciador = 10;
while (iniciador >= 0)
{
    Console.WriteLine(iniciador);
    iniciador--;
}
```

## 6. Validar entrada con do-while

1. Solicitar al usuario un número positivo.

2. Usar un ciclo do-while para seguir pidiendo mientras sea negativo o cero.

3. Mostrar un mensaje de confirmación.

```
int numero;
do
{
    Console.WriteLine("Introduce un número positivo:");
    numero = int.Parse(Console.ReadLine());
} while (numero <= 0);

Console.WriteLine("¡Felicidades, el número es positivo!");
```

### 7. Suma de 5 números ingresados por el usuario

1. Crear un ciclo for para pedir 5 números.

2. Ir acumulando la suma en una variable.

3. Mostrar el resultado final.

```
int suma = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write("Número " + i + ": ");
    int num = int.Parse(Console.ReadLine());
    suma += num;
}
Console.WriteLine("La suma es: " + suma);
```

### 8. Detectar número primo

1. Solicitar un número al usuario.

2. Verificar si es menor que 2 → no es primo.

3. Usar un ciclo for para comprobar si tiene divisores.

4. Mostrar el resultado.

```
Console.WriteLine("Ingrese un número para verificar si es primo:");
int num = int.Parse(Console.ReadLine());

if (num < 2)
{
    Console.WriteLine("El número no es primo");
}
else
{
    int x;
    for (x = 2; x <= num / 2; x++)
    {
        if (num % x == 0) break;
    }
    Console.WriteLine(x > num / 2 ? "El número es primo" : "El número no es primo");
}
```

### 9. Mostrar los primeros 10 números pares

1. Solicitar un número inicial al usuario.

2. Usar un ciclo while para mostrar los siguientes 10 pares.

3. Validar si el número es par antes de imprimirlo.

```
Console.WriteLine("Ingrese un número:");
int nPar = int.Parse(Console.ReadLine());

int contador = 0;
while (contador < 10)
{
    if (nPar % 2 == 0)
    {
        Console.WriteLine(nPar);
        contador++;
    }
    nPar++;
}
```

### 10. Adivina el número (juego)

1. Generar un número aleatorio entre 1 y 50.

2. Usar un ciclo do-while para que el usuario intente adivinarlo.

3. Indicar si el número ingresado es mayor o menor.

4. Terminar cuando el usuario acierte.

```
Random random = new Random();
int numeroAl = random.Next(1, 51);
int numeroU;

do
{
    Console.WriteLine("Adivina el número entre 1 y 50:");
    numeroU = int.Parse(Console.ReadLine());

    if (numeroU < numeroAl)
        Console.WriteLine("El número es mayor");
    else if (numeroU > numeroAl)
        Console.WriteLine("El número es menor");
    else
        Console.WriteLine("¡Adivinaste!");
} while (numeroU != numeroAl);
```
