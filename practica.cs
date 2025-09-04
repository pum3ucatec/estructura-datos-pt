using System;

namespace EjerciciosBucles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIOS DE BUCLES EN C# ===");
            
            // Ejercicio 1: Contar del 1 al 10
            Console.WriteLine("\n🔁 1. CONTAR DEL 1 AL 10");
            Contar1Al10();
            
            // Ejercicio 2: Sumar números del 1 al N
            Console.WriteLine("\n🔁 2. SUMAR NÚMEROS DEL 1 AL N");
            Sumar1AlN();
            
            // Ejercicio 3: Tablas de multiplicar
            Console.WriteLine("\n🔁 3. TABLAS DE MULTIPLICAR");
            TablaMultiplicar();
            
            // Ejercicio 4: Menú con do-while
            Console.WriteLine("\n🔁 4. MENÚ INTERACTIVO");
            MenuInteractivo();
            
            // Ejercicio 5: Contador regresivo
            Console.WriteLine("\n🔁 5. CONTADOR REGRESIVO");
            ContadorRegresivo();
            
            // Ejercicio 6: Validar entrada
            Console.WriteLine("\n🔁 6. VALIDAR ENTRADA POSITIVA");
            ValidarEntradaPositiva();
            
            // Ejercicio 7: Suma de 5 números
            Console.WriteLine("\n🔁 7. SUMA DE 5 NÚMEROS");
            Sumar5Numeros();
            
            // Ejercicio 8: Detectar número primo
            Console.WriteLine("\n🔁 8. DETECTOR DE NÚMEROS PRIMOS");
            DetectarPrimo();
            
            // Ejercicio 9: Primeros 10 números pares
            Console.WriteLine("\n🔁 9. PRIMEROS 10 NÚMEROS PARES");
            Primeros10Pares();
            
            // Ejercicio 10: Adivina el número
            Console.WriteLine("\n🔁 10. ADIVINA EL NÚMERO (JUEGO)");
            AdivinaElNumero();
        }
        
        /// <summary>
        /// Ejercicio 1: Usa un bucle for para mostrar los números del 1 al 10
        /// </summary>
        static void Contar1Al10()
        {
            Console.WriteLine("Contando del 1 al 10:");
            
            // Bucle for que inicia en 1, termina en 10, incrementando de 1 en 1
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); // Salto de línea al final
        }
        
        /// <summary>
        /// Ejercicio 2: Pide un número N y suma todos los números del 1 hasta N usando while
        /// </summary>
        static void Sumar1AlN()
        {
            Console.Write("Ingrese un número N: ");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int contador = 1;
            
            // Bucle while que se ejecuta mientras el contador sea menor o igual a N
            while (contador <= n)
            {
                suma += contador; // Acumula la suma
                contador++;       // Incrementa el contador
            }
            
            Console.WriteLine($"La suma de los números del 1 al {n} es: {suma}");
        }
        
        /// <summary>
        /// Ejercicio 3: Muestra la tabla de multiplicar del número ingresado del 1 al 10
        /// </summary>
        static void TablaMultiplicar()
        {
            Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
            int numero = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Tabla de multiplicar del {numero}:");
            
            // Bucle for para multiplicar del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
        
        /// <summary>
        /// Ejercicio 4: Menú que se repite hasta que el usuario elija salir
        /// </summary>
        static void MenuInteractivo()
        {
            int opcion;
            
            // Bucle do-while que garantiza al menos una ejecución
            do
            {
                Console.WriteLine("\n=== MENÚ ===");
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Sumar dos números");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                
                opcion = int.Parse(Console.ReadLine());
                
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("¡Hola! Bienvenido al programa.");
                        break;
                    case 2:
                        Console.Write("Ingrese primer número: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese segundo número: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"La suma es: {a + b}");
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del menú...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
                
            } while (opcion != 3); // Se repite hasta que se elija salir (opción 3)
        }
        
        /// <summary>
        /// Ejercicio 5: Muestra cuenta regresiva del 10 al 1 usando while
        /// </summary>
        static void ContadorRegresivo()
        {
            int contador = 10;
            
            Console.WriteLine("Cuenta regresiva:");
            
            // Bucle while que decrementa desde 10 hasta 1
            while (contador >= 1)
            {
                Console.WriteLine(contador);
                contador--; // Decrementa el contador
            }
            Console.WriteLine("¡Despegue!");
        }
        
        /// <summary>
        /// Ejercicio 6: Pide un número positivo y sigue pidiendo hasta que sea válido
        /// </summary>
        static void ValidarEntradaPositiva()
        {
            int numero;
            
            // Bucle do-while que garantiza al menos una ejecución
            do
            {
                Console.Write("Ingrese un número positivo: ");
                numero = int.Parse(Console.ReadLine());
                
                if (numero <= 0)
                {
                    Console.WriteLine("Error: Debe ingresar un número positivo. Intente nuevamente.");
                }
                
            } while (numero <= 0); // Se repite mientras el número no sea positivo
            
            Console.WriteLine($"¡Correcto! Ha ingresado: {numero}");
        }
        
        /// <summary>
        /// Ejercicio 7: Pide 5 números al usuario y los suma usando for
        /// </summary>
        static void Sumar5Numeros()
        {
            int suma = 0;
            
            Console.WriteLine("Ingrese 5 números:");
            
            // Bucle for que se ejecuta exactamente 5 veces
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Número {i}: ");
                int numero = int.Parse(Console.ReadLine());
                suma += numero; // Acumula la suma
            }
            
            Console.WriteLine($"La suma total es: {suma}");
        }
        
        /// <summary>
        /// Ejercicio 8: Determina si un número es primo usando for
        /// </summary>
        static void DetectarPrimo()
        {
            Console.Write("Ingrese un número para verificar si es primo: ");
            int numero = int.Parse(Console.ReadLine());
            bool esPrimo = true;
            
            // Un número primo es divisible solo por 1 y por sí mismo
            // Verificamos divisores desde 2 hasta la raíz cuadrada del número
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false; // Si encuentra divisor, no es primo
                    break;           // Sale del bucle anticipadamente
                }
            }
            
            // Los números menores o iguales a 1 no son primos
            if (numero <= 1)
            {
                esPrimo = false;
            }
            
            if (esPrimo)
            {
                Console.WriteLine($"{numero} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} NO es un número primo.");
            }
        }
        
        /// <summary>
        /// Ejercicio 9: Muestra los primeros 10 números pares usando while
        /// </summary>
        static void Primeros10Pares()
        {
            int contador = 0;  // Cuenta los números pares encontrados
            int numero = 0;    // Número actual a verificar
            
            Console.WriteLine("Los primeros 10 números pares son:");
            
            // Bucle while que se ejecuta hasta encontrar 10 números pares
            while (contador < 10)
            {
                if (numero % 2 == 0) // Verifica si el número es par
                {
                    Console.Write(numero + " ");
                    contador++; // Incrementa el contador de pares encontrados
                }
                numero++; // Pasa al siguiente número
            }
            Console.WriteLine(); // Salto de línea al final
        }
        
        /// <summary>
        /// Ejercicio 10: Juego para adivinar un número aleatorio del 1 al 50
        /// </summary>
        static void AdivinaElNumero()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 51); // Genera número aleatorio entre 1 y 50
            int intentos = 0;
            int intentoUsuario;
            bool adivinado = false;
            
            Console.WriteLine("¡Bienvenido a 'Adivina el Número'!");
            Console.WriteLine("He pensado en un número entre 1 y 50. ¿Puedes adivinarlo?");
            
            // Bucle while que continúa hasta que el usuario adivine
            while (!adivinado)
            {
                Console.Write("Ingresa tu intento: ");
                intentoUsuario = int.Parse(Console.ReadLine());
                intentos++;
                
                if (intentoUsuario == numeroSecreto)
                {
                    adivinado = true;
                    Console.WriteLine($"¡Felicidades! Adivinaste el número {numeroSecreto} en {intentos} intentos.");
                }
                else if (intentoUsuario < numeroSecreto)
                {
                    Console.WriteLine("El número es mayor. Intenta nuevamente.");
                }
                else
                {
                    Console.WriteLine("El número es menor. Intenta nuevamente.");
                }
            }
        }
    }
}
