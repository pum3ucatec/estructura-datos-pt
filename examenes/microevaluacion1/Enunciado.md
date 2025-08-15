<!--Encabezados-->
# Como descargar e instalar git-VScode-Dotnet

# Que es Git?:

**Git es un sistema de control de veriones distribucion (DVCS) de codigo abierto, diseñado para rastrear cambios en archivos de software, especialmente codigo fuente, y coordinar el trabajo de varios desarrolladores en un mismo proyecto.**

**Tambien es una de las herramientas con las cuales se esta trabajando en la clase de Estructura de Datos y nos ayuda con respecto a la clonacion la parte de pasar la carpeta local a la parte remote y muchas cosas más.**

**Enlace de descarga:**
[Git.](https://git-scm.com/downloads "Descargale :3") 

# Requisitos minimos de Git:

* Se recomienda tener al menos 1GB de RAM (aunque 2GB de RAM o más son preferibles para un mejor rendimiento)

* 50MB de espacio libro en el disco duro para la instalacion (pero se debe considerar espacio adicional para los repositorios.)

# Como saber que esta correctamente instalado:

**Podemos buscar en el buscador como "Git Bash" o tambien presionar "windows+R" y escribimos "cmd" luego presionar "Enter" a continuacion se nos abrira la terminal solo seria colocar:**

git --version

**Deberia de salir la vercion que descargamos ya sea "8.0 o 9.0" eso nos indicaria que la version esta correctamente instalada.**

![Git logo](https://upload.wikimedia.org/wikipedia/commons/e/e0/Git-logo.svg)

# Comandos de Git:

**Con Git contamos con variedad de comandos para poder hacer nuestros trabajo en equipo:**

# Comandos basicos
* **git init** => Crea un nuevo repositorio Git en la carpeta actual

* **git clone** <url> => Clona un repositorio remoto en tu maquina local

* **git status** => Muestra el estao actual de los archivos (Cambios nuevos, borrados.)

* **git add** => Añade todos los archivos modificados y nuevos al staging.

* **git commit -m "mensaje"** => Guardar los cambios en el historialcon un mensaje.

* **git log** => Muestra el historial de commits.

* **git diff**=> Muestra las diferencias entre los cambios y el ultimo commit.

# Ramas y remoto:

* **git branch** => Lista de las ramas locales.

* **git branch < nombre >** => Crea una nueva rama.

* **git remote -v** =>Lista de los remotos configurados.

* **git remote add origin < url >** => Conecta el repositorio local con uno remoto.

* **git fetch** => Descarga cambios del remoto sin aplicarlos.

* **git pull** => Descarga y combina cambios del remoto.

* **git push** => Sube los cambios locales al remoto.

# Utiles de Git:

* **git rm < archivo >** => Elimina un archivo de repo y del disco.

* **git cofing --global user.name"nombre de cuenta github"** =>Configura tu nombre Globalmente.

* **git config --global user.email"tu correo electronico de github"** => Configura tu email globalmente.
---
# VScode:

# Que es VScode?:

**Visual Studio Code es un editor de codigo fuente ligero pero potentedesarrollado por Microsoft, gratuito, de codigo abierto y de multiplaforna.**

**Asi como git esta herramienta nos brindara mejor ayuda a la hora de estar programando complementandose una a la otra para poder trabajar con el equipo.**

**Enlace de descarga:**

[VScode](https://code.visualstudio.com/download "Descargale :3")

# Requisitos minimos de VScode:

* al igual que git necesita al menos 1GB de RAM.

* Un procesador de 1.6 GHz o superio.

* Espacio en el disco duro para la instalacion (Generalmente menos de 500MB para la instalacion basica).

* Adicionalmente se recomienda una resolucion minima de 720p (para una experiencia optima de usuario).


![VScode logo](https://upload.wikimedia.org/wikipedia/commons/9/9a/Visual_Studio_Code_1.35_icon.svg)


# Lenguaje de programacion con el que se trabajo:

 **A la hora de hacer la programacion se esta traajando con el lenguaje de programacion de C#.**

* **link de aprendizaje para C#** [Aqui.](https://www.w3schools.com/cs/index.php "Ejercicios de repaso o aprendizaje.")

---

# Dotnet:

# Que es Dotnet?:

**NET es una plataforma de desarrollo gratuita, de código abierto y multiplataforma de Microsoft para crear diferentes tipos de aplicaciones, como web, escritorio, móviles, juegos e IoT.**

**tambien nos sirve para la complementacion de VScode con el cual vamos a poder correr nuestro codigo en el lenguaje de C# junto con Git con diferentes comandos.**

# Requisitos minimos para dotnet:

* Un procesador con al menos 1GHz

* 512 MB de RAM

* Para windows se recomienda .NET Framework 4.8, compatible con windows 10

# Como saber que esta correctamente instalado:

**Para ver que se instalo correctamente podemos hacerlo de diferentes maneras como ser wimdows+R cmd y colocar:**

"dotnet --version"

**O tambien entrando desde la terminal de Git bash colocando de igual manera:**

"dotnet --version"


![Dotnet logo](https://upload.wikimedia.org/wikipedia/commons/7/7d/Microsoft_.NET_logo.svg)

**Una ves terminemos nuestro proyecto en VScode abrimos de manera nueva terminal y ponemos abrir una nueva terminal a la flecha más y abrirla desde ahi con la terminal de Git bash donde pondremos lo siguiente.**

"dotnet run"

**Que lo que ara que empieze a correr o ejecutar nuestro codigo.**