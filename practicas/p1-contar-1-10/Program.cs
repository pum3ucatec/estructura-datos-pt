// See https://aka.ms/new-console-template for more information

/*#ejercicio 1 números del 1 al 10 en pantalla. */
for (int i = 1; i <= 10; i++)
{

    Console.WriteLine(+i);
}

Console.WriteLine("--------------------------------------------------");

/*#ejercicio 2  números del 1 hasta N usando while.*/
Console.WriteLine("ingrese un numero:");
int n = Convert.ToInt32(Console.ReadLine());
int suma = 0;
int m = 1;

while (m <= n)
{
    suma = suma + m;
    m++;
}
Console.WriteLine("la suma de los numeros del 1 al " + n + " es:" + suma);


Console.WriteLine("--------------------------------------------------");


/*#ejercicio 3 multiplicar del 1 al 10 usando for.*/
Console.WriteLine("ingresa un numero");
int numero = int.Parse(Console.ReadLine());
int inic = 1;
inic++;

for (inic = 1; inic <= 10; inic++)
{
    int resultado = inic * numero;
    Console.WriteLine(numero + " x " + inic + " = " + resultado);
}

Console.WriteLine("---------------------------------------------------");


/*#ejercicio 4 crear un menu*/
int opcion;

do
{

    Console.WriteLine(" menu");
    Console.WriteLine("1. saludar");
    Console.WriteLine("2. sumar 2 + 2");
    Console.WriteLine("3. salir");
    Console.Write("elige una opcion: ");


    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("hola");
            break;
        case 2:
            Console.WriteLine("el resultado es:" + (2 + 2));
            break;
        case 3:
            Console.WriteLine("bye");
            break;
        default:
            Console.WriteLine("Opcion no valida.");
            break;
    }


    if (opcion != 3)
    {
        Console.WriteLine("presiona una tecla para continuar.");
        Console.ReadKey();
    }

} while (opcion != 3);

Console.WriteLine("---------------------------------------------------");

/*ejercicio 5 contador regresivo*/

int iniciador = 10;
int res = 1;
res--;
while (iniciador >= 0)
{
    Console.WriteLine(iniciador);
    iniciador--;
}

Console.WriteLine("---------------------------------------------------");


/*6. Validar entrada con do-while
Pedir al usuario que introduzca un 
número positivo y seguir pidiendo hasta que lo haga correctamente.*/

numero = 1;

do
{
    Console.WriteLine("inttroduce un numero positivo");
    numero = int.Parse(Console.ReadLine());

} while (numero <= 0);

Console.WriteLine("felicidades el numero es positivo");

Console.WriteLine("---------------------------------------------------");

/*7. Suma de 5 números ingresados por el usuario
Pedir al usuario 5 números (uno por uno) y sumarlos usando for.*/

int numer;
int sum = 0;

for (int z = 1; z <= 5; z++)
{
    Console.Write("numero :" + z + " :");
    numer = int.Parse(Console.ReadLine());
    sum += numer;
}

Console.WriteLine("la suma es: " + sum);

Console.WriteLine("---------------------------------------------------");

/* 8. Detectar número primo
Usar un bucle for para determinar si un número ingresado por el usuario es primo o no.*/

Console.WriteLine("ingrese un número para verificar si es primo:");
int numI = int.Parse(Console.ReadLine());

if (numI < 2)
{
    Console.WriteLine("el numero no es primo");
}

else
{
    int x;
    for (x = 2; x <= numI / 2; x++)
    {
        if (numI % x == 0)
            break;
    }
    Console.WriteLine(x > numI / 2 ? "el numero es primo" : "el numero no es primo");
}

Console.WriteLine("---------------------------------------------------");

/*9. Mostrar los primeros 10 números pares
Mostrar en pantalla los primeros 10 números pares usando while.*/


Console.WriteLine("ingrese un numero :");
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


Console.WriteLine("---------------------------------------------------");


/*10. Adivina el número (juego)
El sistema genera un número aleatorio del 1 al 50.
El usuario intenta adivinarlo.
Usar do-while hasta que acierte, indicando si es mayor o menor.*/


Random random = new Random();
int numeroAl = random.Next(1, 51);
int numeroU;

do
{
    Console.WriteLine("adivina el numero entre 1 y 50:");
    numeroU = int.Parse(Console.ReadLine());

    if (numeroU < numeroAl)
    {
        Console.WriteLine("el numero es mayor");
    }
    else if (numeroU > numeroAl)
    {
        Console.WriteLine("el numero es menor");
    }
    else
    {
        Console.WriteLine("adivinaste");
    }

} while (numeroU != numeroAl);