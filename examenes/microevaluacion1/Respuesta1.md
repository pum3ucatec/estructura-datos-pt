Crear una rama desde `master`

```
QuelaliGaston/Microevaluacion1
```

1. Realizar la documentacion de la configuracion del repositorio de la materia en el archivo `Respuesta.md`.
2. Realizar una calculadora cientifica en C Sharp.

Nota: Responder ambas preguntas dentro de esta carpeta.

## EJERCICIO 1

# Configuración del Repositorio de la Materia

Este documento brinda el paso a paso cómo configurar el repositorio clonado de la materia con **Visual Studio Code** usando **Git y GitHub**.

---

## 1. Requisitos previos

Antes de comenzar, Debemos asegurarnos de tener instalado lo siguiente:

- [Git](https://git-scm.com/)
- [Visual Studio Code](https://code.visualstudio.com/)
- Una cuenta en [GitHub](https://github.com/)

  **Esto es escencial para configurar el repositorio**
---

## 2. Configurar Git con tus datos

Abrir la terminal de Git Bash y ejecutar:

```bash
git config --global user.name "TuNombreEnGitHub"
git config --global user.email "tu_correo_de_github@example.com"

```
como ejemplo:
```bash
git config --global user.name "Alvaro1672"
git config --global user.email "Sahoneroalvaro@gmail.com"
```

**Posterior a ello se debe verificar si esta configurado correctamente con el siguiente comando:**

```bash
git config --list
```

## 3. Generar y Agregar la clave SSH 
  **1. Crear la clave SSH**
  ```bash
  ssh-keygen -t ed25519 -C "tu_correo_de_github@gmail.com"
``` 

- Cuando te pregunte la ruta presiona automaticamente la tecla ENTER para usar la ruta determinada.

- Cuando te pregunte por una contraseña puedes colocarla para tener mas seguridad o dejarla vacia.

**2. verificacion de la exitencia de la carpeta SSH**

Para la verificacion de Existencia de 

```
ls -al ~/.ssh
```


**3.Copiar la clave pública:**

```
cat ~/.ssh/id_ed25519.pub
```

- Copia todo el texto que aparezca.

- Agregala a GitHub:

**Debes seguir los iguientes pasos:**

1. Ir a GitHub → Settings → SSH and GPG Keys → New SSH Key.

2. Pegar la clave y guardar.

**4. Probar conexión:**

```
ssh -T git@github.com
```


Si esta todo correcto, este mostrará algo como:

```
Hi usuario! You've successfully authenticated...
```


## 4. Clonar el repositorio de la materia

- Paso 1. En la terminal de VSCode se debe escribir el siguiente comando:

```
git clone git@github.com:usuario/nombre-repositorio.git
```

- Paso 2. Entrar a la carpeta:

```
cd nombre-repositorio
```

## 5. Crear y cambiar de rama (branch)

```
git checkout -b MiRama
```

- Para volver a master escribe el siguiente comando:

```
git checkout master
```

## 6. Añadir cambios y hacer commit

1. Verificar estado:

```
git status
```

2. Agregar archivos:

```
git add .
```

3. Hacer commit:

```
git commit -m "Descripción del cambio"
```

## 7. Subir cambios al repositorio remoto

```
git push -u origin MiRama
```

## 8. Verificar archivos de un commit específico

1. Para listar los commits:

```
git log --oneline
```

2. Ver archivos de un commit:

```
git show --name-only ID_DEL_COMMIT
```

**Con estos pasos, tendrás tu repositorio configurado y listo para trabajar en la materia.**


## Ejercicio 2
```

using System;
using System.Globalization;

class CalculadoraCientifica
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Calculadora científica (5 operaciones)");
        Console.WriteLine("--------------------------------------");

        while (true)
        {
            Console.WriteLine("\nSelecciona una opción:");
            Console.WriteLine("1) Potencia (a^b)");
            Console.WriteLine("2) Raíz cuadrada (√a)");
            Console.WriteLine("3) Seno (sin(x) en radianes)");
            Console.WriteLine("4) Coseno (cos(x) en radianes)");
            Console.WriteLine("5) Logaritmo natural (ln(x))");
            Console.WriteLine("0) Salir");
            Console.Write("Opción: ");

            string opcion = Console.ReadLine()?.Trim();

            if (opcion == "0")
            {
                Console.WriteLine("Saliendo... ¡Hasta luego!");
                break;
            }

            try
            {
                switch (opcion)
                {
                    case "1":
                        EjecutarPotencia();
                        break;
                    case "2":
                        EjecutarRaizCuadrada();
                        break;
                    case "3":
                        EjecutarSeno();
                        break;
                    case "4":
                        EjecutarCoseno();
                        break;
                    case "5":
                        EjecutarLogaritmo();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta de nuevo.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada no válida: por favor ingresa números en el formato correcto.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    static double LeerNumero(string prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine()?.Trim();
        // Acepta coma o punto como separador decimal en función de la cultura invariante
        if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double result) ||
            double.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out result))
        {
            return result;
        }
        throw new FormatException("No es un número válido.");
    }

    static void EjecutarPotencia()
    {
        double a = LeerNumero("Base a: ");
        double b = LeerNumero("Exponente b: ");
        double resultado = Math.Pow(a, b);
        Console.WriteLine($"{a} ^ {b} = {resultado}");
    }

    static void EjecutarRaizCuadrada()
    {
        double a = LeerNumero("Número (a >= 0): ");
        if (a < 0)
        {
            Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo (en esta versión).");
            return;
        }
        double resultado = Math.Sqrt(a);
        Console.WriteLine($"√{a} = {resultado}");
    }

    static void EjecutarSeno()
    {
        double x = LeerNumero("Ángulo en radianes: ");
        double resultado = Math.Sin(x);
        Console.WriteLine($"sin({x}) = {resultado}");
    }

    static void EjecutarCoseno()
    {
        double x = LeerNumero("Ángulo en radianes: ");
        double resultado = Math.Cos(x);
        Console.WriteLine($"cos({x}) = {resultado}");
    }

    static void EjecutarLogaritmo()
    {
        double a = LeerNumero("Número (a > 0): ");
        if (a <= 0)
        {
            Console.WriteLine("El logaritmo natural solo está definido para números positivos.");
            return;
        }
        double resultado = Math.Log(a); // log natural
        Console.WriteLine($"ln({a}) = {resultado}");
    }
}

```