# Cómo Trabajar en un Repositorio

## 1. ¿Cómo configurar todo para trabajar con Git y GitHub?

A continuación el paso a paso para poder trabajar con los repositorios de la materia.

### 🛠 Paso 1: Instalar Git Bash

Primero descarga *Git Bash* desde la página oficial:  
https://git-scm.com/

Es la consola que se usa para trabajar con Git (que es el sistema de control de versiones que usamos). La instalación es sencilla, solo hay que darle "Siguiente" a todo y dejarlo por defecto.

Para verificar que todo quedó bien, abre Git Bash y escribe:

```bash
git --version


Si sale algo como git version 2.xx, está bien.

⚙ Paso 2: Instalar .NET SDK

Como estamos trabajando con C#, necesitamos el .NET SDK (que es el entorno donde se ejecuta todo).

Lo descargas desde:
https://dotnet.microsoft.com/download

Elige la versión para tu sistema operativo y verifica que funcione con:

dotnet --version

Paso 3: Crear cuenta en GitHub

Entra a https://github.com y crea una cuenta.
Es importante confirmar el correo para poder usar todas las funciones.

Paso 4: Crear y usar una llave SSH

Esto sirve para que GitHub te reconozca sin tener que escribir tu usuario y contraseña cada vez que subes algo.

En Git Bash escribe:

ssh-keygen -t ed25519 -C "tucorreo@gmail.com"


Presiona  Enter varias veces hasta que termine.

Luego activa el agente SSH:

eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_ed25519


Copia la llave pública con:

cat ~/.ssh/id_ed25519.pub


Ve a GitHub > Settings > SSH and GPG Keys > "New SSH Key", y pega ahí la clave.

Para verificar que todo funcionó:

ssh -T git@github.com


Si sale algo como "Hi tuUsuario! Has conectado bien", ya está.

Paso 5: Clonar el repositorio de la materia

Para tener una copia del repositorio en tu computadora, puedes usar tu SSH (clonar con SSH):

git clone git@github.com:usuario/repositorio.git


Después entra a la carpeta:

cd repositorio

Paso 6: Crear mi carpeta y subir una tarea

Dentro del repositorio, haz una carpeta con tu nombre para poner tu trabajo:

mkdir SuarezLuis/Microevaluacion1
cd SuarezLuis/Microevaluacion1

Posteriormente puedes entrar a Vs Code con:

code .

Creas tu archivo de respuestas:

New File > Respuesta.md (usa la extensión del archivo como desees)


Después, concluyendo los cambios, realiza el commit y lo subes a GitHub:

git add .
git commit -m "Microevaluación 1 - Documentación"
git push
git push --set-upstream origin

✅ Con eso ya todo listo para trabajar

Ahora ya puedes usar Git para controlar cambios, y subir prácticas a GitHub sin problemas.