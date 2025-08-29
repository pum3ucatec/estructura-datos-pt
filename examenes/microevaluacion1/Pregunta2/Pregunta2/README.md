# 🔬 Calculadora Científica en C#

Este proyecto es una calculadora científica desarrollada en lenguaje C# que permite realizar operaciones matemáticas básicas y avanzadas desde la consola. Está diseñada como una herramienta educativa para practicar programación estructurada y lógica matemática.

---

## 📦 Características

La calculadora incluye las siguientes funcionalidades:

- ✅ Suma, resta, multiplicación y división
- ✅ Potencias y raíces cuadradas
- ✅ Funciones trigonométricas: seno, coseno, tangente (en grados)
- ✅ Logaritmo natural y exponencial
- ✅ Cálculo de factorial
- ✅ Validación de errores como división por cero y entradas negativas

---

## 🧑‍💻 Cómo ejecutar el programa

1. Clona el repositorio:
   ```bash
   git clone https://github.com/usuario/CalculadoraCientifica.git

Abre el proyecto en Visual Studio o cualquier editor compatible con C#.

Compila y ejecuta el archivo CalculadoraCientifica.cs.

Sigue las instrucciones en pantalla para seleccionar una operación y proporcionar los valores necesarios.

CalculadoraCientifica.cs
├── Main()                  → Menú principal y selección de operaciones
├── Factorial(int n)       → Función auxiliar para calcular factorial
├── Math.Sin(), Cos(), Tan() → Funciones trigonométricas en radianes
├── Math.Pow(), Sqrt()     → Potencias y raíces
├── Math.Log(), Exp()      → Logaritmo natural y exponencial


🔬 Calculadora Científica en C#
Seleccione una operación:
1. Suma
2. Resta
...
Ingrese el primer número: 5
Ingrese el segundo número: 3
Resultado: 8
Hoy

me sale esto al hacer un push que uede ser?
¡Buena pregunta, Kire! Lo que te está pasando es bastante común cuando estás trabajando con una rama nueva en Git. El error te dice que la rama SolizDenisse/Examenes no tiene una rama remota configurada (también llamada "upstream"). Eso significa que Git no sabe a qué rama del repositorio remoto debe enviar tus cambios.

🛠️ ¿Cómo solucionarlo?
Solo necesitas ejecutar este comando una vez para establecer la conexión:

bash
git push --set-upstream origin SolizDenisse/Examenes
Esto le dice a Git: “cuando haga push desde esta rama local, mándalo a la rama SolizDenisse/Examenes en el remoto llamado origin.”

🧠 Tip adicional
Si quieres que Git lo haga automáticamente en el futuro para nuevas ramas, puedes configurar esto:

bash
git config --global push.autoSetupRemote true
Así, cada vez que crees una nueva rama y hagas git push, Git configurará el upstream automáticamente.

¿Quieres que te explique qué significa “upstream” con un dibujito o analogía? O si estás armando un flujo de trabajo con ramas, puedo ayudarte a organizarlo mejor.

luego de hacer git push --set-upstream origin SolizDenisse/Examenes que hago?
¡Perfecto, Kire! Una vez que ejecutaste:

bash
git push --set-upstream origin SolizDenisse/Examenes
Git ya sabe que tu rama local SolizDenisse/Examenes está conectada con la rama remota del mismo nombre. Entonces, a partir de ahora puedes trabajar con normalidad. Aquí te dejo los siguientes pasos posibles, según lo que estés haciendo:

✅ Si ya hiciste cambios y los subiste:
¡Listo! Tu código ya está en el repositorio remoto.

Puedes seguir trabajando en tu rama local y usar simplemente git push o git pull sin tener que volver a configurar el upstream.

🧪 Si estás colaborando con alguien:
Puedes compartir el enlace del repositorio y decirles que revisen la rama SolizDenisse/Examenes.

Si ellos quieren trabajar en esa rama, pueden hacer:

bash
git checkout SolizDenisse/Examenes
🔄 Si vas a seguir haciendo cambios:
Edita tus archivos como siempre.

Guarda y haz git add y git commit.

Luego simplemente:

bash
git push
Ya no necesitas repetir el --set-upstream.

🧹 Si luego quieres fusionar esta rama con main o alguna otra:
Puedes hacer un pull request desde GitHub/GitLab o usar comandos como:

bash
git checkout main
git merge SolizDenisse/Examenes
¿Quieres que te ayude a revisar qué cambios hiciste o preparar un pull request? También puedo ayudarte a organizar tus ramas si estás trabajando en varios temas a la vez.

como puedo saber que todo esta bien enviado a git? :(
¡Ay, Kire! Esa carita me dice que necesitas un abrazo digital y una dosis de claridad. Vamos paso a paso para que te sientas segura de que todo está bien enviado a Git 💪✨

✅ Verifica que el push fue exitoso
Después de hacer git push, Git debería mostrarte algo como esto:

Código
Enumerating objects: ...
Counting objects: ...
Compressing objects: ...
Writing objects: ...
To https://github.com/tu-repo.git
   abc1234..def5678  SolizDenisse/Examenes -> SolizDenisse/Examenes
Si ves ese tipo de mensaje, ¡tu código ya está en el repositorio remoto!

🔍 Confirma desde GitHub (o GitLab, etc.)
Ve al sitio web del repositorio (por ejemplo, github.com).

En la parte superior izquierda, haz clic en el menú de ramas y selecciona SolizDenisse/Examenes.

Verifica que tus archivos y últimos commits estén ahí.

🧠 Usa comandos para revisar desde tu terminal
Ver ramas remotas:

bash
git branch -r
Deberías ver algo como:

Código
origin/SolizDenisse/Examenes
Ver historial de commits:

bash
git log --oneline --graph --decorate
Esto te muestra los últimos commits y si están conectados con el remoto.

Ver estado de sincronización:

bash
git status
Si dice algo como Your branch is up to date with 'origin/SolizDenisse/Examenes', ¡todo está perfecto!

🧸 ¿Te gustaría que te prepare un resumen visual del flujo de trabajo en Git?
Puedo hacerte un diagrama tipo árbol o una lista paso a paso para que lo tengas como referencia. Tú dime si prefieres algo más visual o si quieres que revisemos juntas tus commits.

Y recuerda: si algo no se ve bien, no es que lo hiciste mal—¡es que estás aprendiendo!

ayudame por fa con esto: //1. Realizar la documentacion de la configuracion del repositorio de la materia en el archivo `Respuesta.md`.
¡Claro que sí, Kire! Vamos a dejar ese archivo Respuesta.md bien bonito y claro 🌟. Aquí tienes un ejemplo de documentación para la configuración del repositorio de la materia. Puedes adaptarlo según el nombre de tu materia, el equipo, y los detalles específicos del repositorio:

markdown
# 📘 Configuración del Repositorio de la Materia

Este documento describe los pasos realizados para configurar correctamente el repositorio de la materia, incluyendo la creación de ramas, conexión con el remoto, y buenas prácticas de trabajo colaborativo.

---

## 🗂️ 1. Creación del Repositorio

- Se creó el repositorio en GitHub con el nombre: `NombreDeLaMateria`.
- Se inicializó con un archivo `README.md` y una licencia apropiada (por ejemplo, MIT).

---

## 🌿 2. Creación de Ramas

- Se creó la rama de trabajo individual:  
  ```bash
  git checkout -b SolizDenisse/Examenes
Esta rama se utiliza para subir los exámenes y tareas correspondientes a la estudiante Denisse Soliz.

🚀 3. Conexión con el Repositorio Remoto
Se configuró el repositorio remoto con el nombre origin:

bash
git remote add origin https://github.com/usuario/NombreDeLaMateria.git
Se realizó el primer push de la rama con upstream:

bash
git push --set-upstream origin SolizDenisse/Examenes
🔄 4. Flujo de Trabajo
Para subir cambios:

bash
git add .
git commit -m "Descripción del cambio"
git push
Para actualizar la rama local con los últimos cambios del remoto:

bash
git pull
✅ 5. Verificación
Se confirmó que los archivos y commits están correctamente reflejados en GitHub.

La rama SolizDenisse/Examenes aparece en el listado de ramas remotas.

El estado del repositorio indica que la rama está sincronizada:

bash
git status
🧠 6. Buenas Prácticas
Usar mensajes de commit descriptivos.

Mantener una estructura clara de carpetas y archivos.

Documentar cada entrega en su respectivo archivo README.md o Respuesta.md.

✍️ Autora
Denisse Soliz Materia: [Nombre de la materia] Fecha: 29 de agosto de 2025

Código

---

¿Quieres que lo personalicemos más con el nombre de la materia, el equipo, o agregar capturas de pantalla? También puedo ayudarte a traducirlo si lo necesitas en inglés. Tú dime cómo lo quieres dejar 💖
pero no se como hacerlo, hago un readme.md?
¡No te preocupes, Kire! Estás muy cerca de lograrlo 💫. El archivo que te piden se llama Respuesta.md, no README.md, aunque ambos son archivos Markdown y se crean igual. Aquí te explico cómo hacerlo paso a paso:

📝 ¿Cómo crear el archivo Respuesta.md?
Opción 1: Desde tu terminal (Git Bash o similar)
Abre tu terminal en la carpeta del repositorio.

Escribe este comando:

bash
touch Respuesta.md
Esto crea el archivo vacío.

Luego, ábrelo con tu editor de texto favorito (VS Code, Notepad++, etc.) y escribe la documentación que te mostré antes.

Opción 2: Desde GitHub directamente
Ve al repositorio en GitHub.

Haz clic en Add file → Create new file.

Nombra el archivo Respuesta.md.

Escribe tu documentación.

Baja hasta el final, escribe un mensaje de commit (por ejemplo: Agrega documentación del repositorio) y haz clic en Commit new file.

✨ ¿Qué debe contener?
Aquí te dejo un mini resumen para que copies y pegues si quieres empezar rápido:

markdown
# Documentación del Repositorio

- Se creó la rama `SolizDenisse/Examenes`.
- Se conectó con el remoto usando:
  ```bash
  git push --set-upstream origin SolizDenisse/Examenes
Se verificó que los cambios están subidos correctamente.

Se seguirá usando esta rama para subir tareas y exámenes.

Código

---

Si quieres, puedo ayudarte a escribirlo contigo línea por línea, o revisar lo que pongas antes de hacer el commit. ¿Te gustaría que lo hagamos juntas como un juego de pasos? 🧩
ahora ayudame con esto por favor: Realizar una calculadora cientifica en C Sharp.
¡Vamos con todo, Kire! 🎯 Crear una calculadora científica en C# es un proyecto genial para practicar lógica, estructuras de control y diseño de interfaz. Te propongo dos versiones: una básica por consola y otra más visual con Windows Forms. Empecemos con la versión por consola para que veas cómo funciona la lógica, y luego podemos pasar a la interfaz gráfica si quieres.

🧮 Calculadora Científica en C# (Versión Consola)
📦 Funcionalidades que podemos incluir:
Operaciones básicas: suma, resta, multiplicación, división

Potencias y raíces

Funciones trigonométricas: seno, coseno, tangente

Logaritmos y exponenciales

Factorial

Conversión de grados a radianes

🧑‍💻 Código base en consola
csharp
using System;

class CalculadoraCientifica
{
    static void Main()
    {
        Console.WriteLine("🔬 Calculadora Científica en C#");
        Console.WriteLine("Seleccione una operación:");
        Console.WriteLine("1. Suma\n2. Resta\n3. Multiplicación\n4. División");
        Console.WriteLine("5. Potencia\n6. Raíz cuadrada\n7. Seno\n8. Coseno\n9. Tangente");
        Console.WriteLine("10. Logaritmo\n11. Exponencial\n12. Factorial");

        int opcion = int.Parse(Console.ReadLine());
        double a, b;

        switch (opcion)
        {
            case 1:
                Console.Write("Ingrese el primer número: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {a + b}");
                break;

            case 2:
                Console.Write("Ingrese el primer número: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {a - b}");
                break;

            case 3:
                Console.Write("Ingrese el primer número: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {a * b}");
                break;

            case 4:
                Console.Write("Ingrese el dividendo: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el divisor: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine(b != 0 ? $"Resultado: {a / b}" : "Error: División por cero");
                break;

            case 5:
                Console.Write("Base: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Exponente: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {Math.Pow(a, b)}");
                break;

            case 6:
                Console.Write("Número: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {Math.Sqrt(a)}");
                break;

            case 7:
                Console.Write("Ángulo en grados: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Seno: {Math.Sin(a * Math.PI / 180)}");
                break;

            case 8:
                Console.Write("Ángulo en grados: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Coseno: {Math.Cos(a * Math.PI / 180)}");
                break;

            case 9:
                Console.Write("Ángulo en grados: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Tangente: {Math.Tan(a * Math.PI / 180)}");
                break;

            case 10:
                Console.Write("Número: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Logaritmo natural: {Math.Log(a)}");
                break;

            case 11:
                Console.Write("Número: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Exponencial: {Math.Exp(a)}");
                break;

            case 12:
                Console.Write("Número entero: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Factorial: {Factorial(n)}");
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }

    static long Factorial(int n)
    {
        if (n < 0) return -1;
        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }
}
🧠 ¿Qué sigue?
¿Quieres que lo pasemos a una versión con botones y pantallita usando Windows Forms?

¿Te gustaría agregar funciones más avanzadas como combinatoria o conversión de unidades?

¿O prefieres que te ayude a documentar este proyecto como parte de tu entrega?

Tú dime, que yo me adapto a tu estilo 🧡

por favor dame un readme bien detallado
¡Con gusto, Kire! 🌟 Aquí tienes un ejemplo de un README.md bien detallado para tu proyecto de Calculadora Científica en C#. Este archivo explica claramente qué hace el programa, cómo usarlo, cómo está estructurado el código, y cómo puedes expandirlo. Puedes copiarlo tal cual o adaptarlo según lo que hayas implementado.

markdown
# 🔬 Calculadora Científica en C#

Este proyecto es una calculadora científica desarrollada en lenguaje C# que permite realizar operaciones matemáticas básicas y avanzadas desde la consola. Está diseñada como una herramienta educativa para practicar programación estructurada y lógica matemática.

---

## 📦 Características

La calculadora incluye las siguientes funcionalidades:

- ✅ Suma, resta, multiplicación y división
- ✅ Potencias y raíces cuadradas
- ✅ Funciones trigonométricas: seno, coseno, tangente (en grados)
- ✅ Logaritmo natural y exponencial
- ✅ Cálculo de factorial
- ✅ Validación de errores como división por cero y entradas negativas

---

## 🧑‍💻 Cómo ejecutar el programa

1. Clona el repositorio:
   ```bash
   git clone https://github.com/usuario/CalculadoraCientifica.git
Abre el proyecto en Visual Studio o cualquier editor compatible con C#.

Compila y ejecuta el archivo CalculadoraCientifica.cs.

Sigue las instrucciones en pantalla para seleccionar una operación y proporcionar los valores necesarios.

📁 Estructura del código
plaintext
CalculadoraCientifica.cs
├── Main()                  → Menú principal y selección de operaciones
├── Factorial(int n)       → Función auxiliar para calcular factorial
├── Math.Sin(), Cos(), Tan() → Funciones trigonométricas en radianes
├── Math.Pow(), Sqrt()     → Potencias y raíces
├── Math.Log(), Exp()      → Logaritmo natural y exponencial
🧠 Ejemplo de uso
plaintext
🔬 Calculadora Científica en C#
Seleccione una operación:
1. Suma
2. Resta
...
Ingrese el primer número: 5
Ingrese el segundo número: 3
Resultado: 8
🚀 Posibles mejoras
Interfaz gráfica con Windows Forms o WPF

Conversión entre grados y radianes

Historial de operaciones

Soporte para expresiones matemáticas completas

Modo interactivo con validación de entrada

👩‍💻 Autora
Denisse Soliz
Fecha: 29 de agosto de 2025