# Guia paso a paso para tener lo necesario y poder trabajar con Git Hub
### 1. Descargar  e Instalar Git
 * [Enlace Directo Del Instalador](https://git-scm.com/downloads)

 ### 2. Descargar  e Instalar Net.
 * [Enlace Directo Del Instalador](https://dotnet.microsoft.com/es-es/download)

   - *Recomendación: Tener instaladas las versiones 9.0 y 8.0 de .NET, en caso de que el repositorio con el que trabajaremos haya sido creado con una versión diferente a la que tenemos en nuestro dispositivo, y así evitar problemas de compatibilidad*

 ### 3. Descargar  e Instalar VS Code
 * [Enlace Directo Del Instalador](https://code.visualstudio.com/)

### 4. Crear una cuenta en GitHub
 * Busca y haz clic en "Sign up" o "Registrarse".
 * Luego ingresa los datos que te solicite, por ejemplo: Correo electrónico, Contraseña (segura) y Nombre de usuario (único en GitHub).

  - *Recomendación: Utiliza o crea un correo electrónico o nombre de usuario fácil de recordar, ya que lo usarás siempre.*

  ### 5. Crear una clave SSH
 * Abres la terminal de Git Bash *(previamente instalada en el instalador 'GIT' del paso 1)*:
   * En la terminal copias y pegas:

ssh-keygen -t ed25519 -C "tu_correo_de_github@example.com"

* * Presiona Enter *(Varias veces de ser necesario hasta que te permita  volver a ingresar mas comandos)*. 

* Iniciar o poner en marcha el SSH agent:

  * En la terminal copias y pegas:

eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_ed25519

* Ingresar el siguiente comando y copiar la clave publica generada:

  * En la terminal copias y pegas:

cat ~/.ssh/id_ed25519.pub

* * Copia todo el texto que aparezca (empieza con: ssh-ed25519).

* Agregar la clave a GitHub
  * Ve a GitHub → Settings → SSH and GPG keys.
  * Clic en New SSH key.
  * Pega la clave pública copiada previamente de la terminal de Git Bash, generada en el paso anterior.
  * Guarda los cambios.

* Probar la conexión con GitHub:
  * Regresa a la terminal de Git Bash, copia y pega el siguiente comando: 

        ssh -T git@github.com

* * Si es la primera vez, escribe yes cuando pregunte.
 Si funciona, verás un mensaje como: Hi TU_USUARIO! You've successfully authenticated, but GitHub does not provide shell access.

 * ***¡Felicidades! Ya has generado tu clave SSH con éxito.***
