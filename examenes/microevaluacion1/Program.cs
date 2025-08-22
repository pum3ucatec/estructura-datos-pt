// See https://aka.ms/new-console-template for more information




bool salir = false;

while (!salir)
{
    Console.WriteLine("bienvenido a la calculadora");
    Console.WriteLine("menu de opciones");
    Console.WriteLine("1. suma");
    Console.WriteLine("2. resta");
    Console.WriteLine("3. multiplicacion");
    Console.WriteLine("4. division");
    Console.WriteLine("5. modulo");
    Console.WriteLine("6. potencia");
    Console.WriteLine("7. raiz");
    Console.WriteLine("8. salir");

    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Has seleccionado suma");
            Console.WriteLine("Ingresa 2 numeros");
            int sum1 = int.Parse(Console.ReadLine());
            int sum2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma de " + sum1 + " y " + sum2 + " es: " + (sum1 + sum2));
            break;

        case 2:
            Console.WriteLine("Has seleccionado resta");
            Console.WriteLine("Ingresa 2 numeros");
            int res1 = int.Parse(Console.ReadLine());
            int res2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La resta de " + res1 + " y " + res2 + " es: " + (res1 - res2));
            break;

        case 3:
            Console.WriteLine("Has seleccionado multiplicacion");
            Console.WriteLine("Ingresa 2 numeros");
            int mul1 = int.Parse(Console.ReadLine());
            int mul2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La multiplicacion de " + mul1 + " y " + mul2 + " es: " + (mul1 * mul2));
            break;

        case 4:
            Console.WriteLine("Has seleccionado división");
            Console.WriteLine("Ingresa 2 números");
            int div1 = int.Parse(Console.ReadLine());
            int div2 = int.Parse(Console.ReadLine());

            if (div2 != 0)
                Console.WriteLine("La división de " + div1 + " y " + div2 + " es: " + (div1 / div2));
            else
                Console.WriteLine("Error: No se puede dividir entre cero.");
            break;

        case 5:
            Console.WriteLine("Has seleccionado calculo de modulo");
            Console.WriteLine("Ingresa 2 numeros");
            int mod1 = int.Parse(Console.ReadLine());
            int mod2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El modulo de " + mod1 + " y " + mod2 + " es: " + (mod1 % mod2));
            break;

        case 6:
            Console.WriteLine("Has seleccionado potencia");
            Console.WriteLine("Ingresa la base y el exponente");
            double pot1 = double.Parse(Console.ReadLine());
            double pot2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"La potencia de {pot1} elevado a {pot2} es: {Math.Pow(pot1, pot2)}");
            break;

        case 7:
            Console.WriteLine("Has seleccionado raiz");
            Console.WriteLine("Ingresa 1 numero");
            double raiz1 = double.Parse(Console.ReadLine());
            Console.WriteLine("La raiz de " + raiz1 + " es " + Math.Sqrt(raiz1));
            break;

        case 8:
            Console.Clear();
            Console.WriteLine("Saliendo");
            salir = true;
            break;


        default:
            Console.WriteLine("Opción no válida, por favor intente de nuevo.");
            break;
    }

    if (!salir)
    {
        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
        Console.ReadKey();
    }
}