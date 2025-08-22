# PASOS DE INSTALACION DE HERRAMIENTAS Y CONFIGURACION DE REPOSITORIO DE GITHUB

## Herramientas necesarias:

1. Intala [Git Bash](https://git-scm.com/downloads).

2. Instala [VS Code](https://code.visualstudio.com/download).

3. Instala [Dotnet](https://dotnet.microsoft.com/es-es/).

## Configuración de llave SSH en GitHub:

1. Verifica si tienes una llave SSH ya configurada con el comando: `ls -al ~/.ssh`. si aparece un archivo con extension `.pub`, ya tienes una llave creada, caso contrario continua con el paso 2.

2. Crea tu llave SSH con el comando:`ssh-keygen -t ed25519 -C "tu_correo_de_github@example.com"` y remplaza **"tu_correo_de_github@example.com"** por tu correo electronico con la que te registraste en github.

3. Inicia el agente SSH con el siguiente comando junto con la clave generica que creara un **.pub**:  
   `eval "$(ssh-agent -s)"`  
   `ssh-add ~/.ssh/id_ed25519`

4. Copia la llave publica con el siguiente comando:  
   `cat ~/.ssh/id_ed25519.pub` que generara una clave publica. copia todo el texto que aparezca.

5. Agrega la llave a **Github** desde:

- **Configuraciones** selecciona
- **SSH and GPG Keys**,
- **New SSH Key**,
- Pega la llave publica y **Guardar**

6. Prueba la conexion con el comando `ssh -T git@github.com`. Si todo esta bien aparecera el siguiente mensaje:  
   **Hi TU_USUARIO! You've successfully authenticated, but GitHub does not provide shell access.**

7. Guarda la configuracion y sube al repositorio remoto con el comando `git push -u origin master`

## Clonar un repositorio de Github

Para clonar un repositorio solo se debe de ejecutar el siguiente comando:`git clone git@github.com:usuario/repositorio.git`

## Creacion y uso de ramas

1. Para crear una rama nueva desde la rama **master** ingresa el siguiente comando:
   `git checkout -b NombreDeTuRama`

2. Para moverse entre ramas utiliza el siguiente comando:  
   `git checkout NombreDeLaRama`

3. Para verificar en que rama te encuentras ejecuta:
   `git branch`  
   mostrara en pantalla: `*NombreRama` con las letras de color verde.

4. Para guardar los cambios ejecuta los siguientes comandos:

- **git add .**
- **git commit -m "agregando archivos a mi rama"**
- **git push -u origin NombreDeTuRama**  
  sin afectar a la rama `Master`
