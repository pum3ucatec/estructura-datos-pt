
# Microevaluación 1 – Configuración del Repositorio

## 1. ¿Cómo configuré todo para trabajar con Git y GitHub?

A continuación, te cuento paso a paso lo que hice para preparar mi entorno de trabajo para la materia. Esto me permite programar en C#, gestionar mis proyectos con Git y subirlos fácilmente a GitHub.

---

## ⚙ Paso 2: Instalación del SDK de .NET
Como trabajamos con C#, necesitamos instalar el .NET SDK, que es el kit de desarrollo que permite compilar y ejecutar nuestros programas en este lenguaje.

Lo descargué desde la página oficial:
👉 https://dotnet.microsoft.com/download

Elegí la versión para Windows, ejecuté el instalador y seguí los pasos hasta finalizar.

## 🧑‍💻 Paso 3: Crear una cuenta en GitHub 
Entré a GitHub, que es la plataforma donde vamos a subir y compartir nuestros proyectos.

Ahí me registré con mi correo electrónico. Es importante confirmar el correo desde el mail que te envían, porque si no, no se pueden usar algunas funciones, como subir código con SSH.

## 🔐 Paso 4: Configurar una clave SSH
Para evitar tener que escribir mi usuario y contraseña cada vez que subo algo a GitHub, configuré una clave SSH, que funciona como una identificación segura.
Desde Git Bash, generé la clave con este comando (reemplazando por mi correo):

ssh-keygen -t ed25519 -C "tucorreo@ejemplo.com"

Presioné Enter varias veces sin escribir nada, y se generaron dos archivos: uno es la clave privada (que no se debe compartir) y el otro es la pública (que sí se usa para configurar GitHub).

Después, activé el agente SSH con estos comandos:

bash
Copiar código
eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_ed25519
Para copiar mi clave pública, ejecuté:

bash
Copiar código
cat ~/.ssh/id_ed25519.pub
Copié todo lo que apareció y lo pegué en mi cuenta de GitHub:
👉 GitHub > Settings > SSH and GPG Keys > New SSH Key

Le puse un nombre y pegué la clave pública.

Luego verifiqué que todo funcione ejecutando:

bash
Copiar código
ssh -T git@github.com
Si aparece un mensaje como:
Hi tuUsuario! You've successfully authenticated...
entonces la conexión está bien configurada.

## 📂 Paso 5: Clonar el repositorio de la materia
Con la clave SSH funcionando, ya pude clonar (copiar) el repositorio de la materia a mi computadora. Usé este comando, con la URL correspondiente al repositorio:

git clone git@github.com:usuario/repositorio.git


Después entré a la carpeta del repositorio:

cd repositorio

## 📌 Paso 6: Crear mi carpeta y subir la tarea

Dentro del repositorio, creé una carpeta con mi nombre para subir ahí mi trabajo:

mkdir QuelaliGaston/Microevaluacion1
cd QuelaliGaston/Microevaluacion1


Para empezar, creé un archivo vacío donde escribiría las respuestas:

echo. > Respuesta.md


Luego hice lo necesario para subirlo a GitHub:

Agregué el archivo al seguimiento de Git:

git add QuelaliGaston/Microevaluacion1/Respuesta.md


Hice un commit con un mensaje descriptivo:

git commit -m "Microevaluación 1 - Documentación"


Envié los cambios al repositorio en GitHub:

git push origin main


(o el nombre correcto de la rama, si no es "main")

