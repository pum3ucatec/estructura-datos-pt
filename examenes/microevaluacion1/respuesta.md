# Microevaluación 1 – Configuración del Repositorio

## 1. ¿Cómo configurar todo para trabajar con Git y GitHub?

### Paso 1: Instalar Git Bash

Primero que nada, hay que descargar **Git Bash** desde la página oficial  
Es una consola que se usa para trabajar con Git (que es el sistema de control de versiones).
Para verificar que todo quedó bien, abrí Git Bash y escribí: "git --version"


### Paso 2: Instalar el Dot Net

Seguido de eso debemos buscar el Dot net mediante el buscador de google y bajar la version compatible con Windows
Una vez instalado debemos verificar que todo va bien; debemos abrir el Git Bash y poner el comando "dotnet --version"


### Paso 3: La cuenta de Github es indispensable

Este paso es sencillo. lo unico que tenemos que hacer es entrar a Github mediante el navegador web y crearnos una cuenta 
con nuestro correo, este sera indispensable para todo lo que se llevara mas adelante.

### Paso 4: Crear y usar una llave SSH 

1. Debemos abrir el Git Bash e insertar el comando "ssh-keygen -t ed25519 -C "tucorreo@ejemplo.com"
2. Luego de esto debemos activar el agente de SSH con el comando:

"eval "$(ssh-agent -s)
ssh-add ~/.ssh/id_ed25519"

3. Seguido de esto, nos devolvera llave publica que se ve asi: "cat ~/.ssh/id_ed25519.pub"
4. Ahi debemos ir a GitHub > Settings > SSH and GPG Keys > "New SSH Key", y pegar ahi la clave, luego guardarla.
5. Para poder verificar que todo ha salido correctamente, debemos poner el comando "ssh -T git@github.com"

Si todo ha salido bien despues de poner ese ultimo comando, la terminal debe devolverte algo como: "Hola o Hi usuario, todo se ha conectado correctamente"

### Paso 5: Se debe clonar el repositorio de la materia 

- Se debe poner el comando: "git clone git@github.com:usuario/repositorio.git"   (Esto dependiendo del URL que tengas en Github)
- Siguiente a eso debemos entrar a la carpeta del respositorio con el comando "cd repositorio"

### Paso 6: Subir tu primer tarea

- Dentro del repositorio hay que poner una carpeta con nuestro respectivo nombre para poder subir los trabajos/archivos

Los comandos son:
mkdir QuelaliGaston/Microevaluacion1
cd QuelaliGaston/Microevaluacion1

(Este ejemplo esta con el nombre de nuestro docente)

- Como ultimo paso debemos agregar los cambios, hacer el commit y subirlo a Github:

git add QuelaliGaston/Microevaluacion1/Respuesta.md
git commit -m "Microevaluación 1 - Documentación"
git push origin master











