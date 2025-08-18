# *ESTRUCTURA DE DATOS*  _Configuración para usar el repositorio de la materia:_

## 1. Prerequisitos:

- **VS Code**, haz click pra descargar: **[Download VSCode](https://code.visualstudio.com/download)**

    - Instalar con la configuracion predeterminada
    - Instalar extensiones para el lenguaje de programacion que se usara: - **_C# Dev Kit by Microsoft_**

- **Git**, haz click para descargar: **[Download Git](https://git-scm.com/downloads)**
    - Instalar con la configuracion predeterminada
    - Confirma que este instalado en tu terminal 

        <pre> git --version </pre>

- **Dotnet Version 8.0 o 9.0**, haz click para descargar: **[Download Dotnet](https://dotnet.microsoft.com/en-us/download)**
    - Instalar con la configuracion predeterminada
    - Confirma que este instalado en tu terminal o en Git Bash

        <pre> dotnet --version</pre>

- **Cuenta en GitHub**, haz click para visitar **[GitHub](https://github.com/login)**
    - Registrate con nombre de usuario y correo faciles de recordar

---

## 2. Configuracion de llave SSH en GitHub:

- Revisar si existe una llave SSH:
    <pre>ls -la ~/.ssh</pre>
    Si ves archivos como id_rsa y id_rsa.pub o id_ed25519 y id_ed25519.pub, significa que tienes una clave creada.
- - - 
*Si no existe una llave:*
- - - 
### 2.1. Creacion de llave SSH 
- Ingresa los siguientes comandos en Git Bash:
    - Crea una nueva llave SSH:
    <pre>ssh-keygen -t ed25519 -C "tu_correo_de_github@hotmail.com"</pre>
    Presiona *Enter* para aceptar la ruta por defecto

    - Inicia el agente SSH y agrega la llave:
    <pre>
    eval "$(ssh-agent -s)"
    ssh-add ~/.ssh/id_ed25519</pre>

    - Copiar la clave publica
    <pre>cat ~/.ssh/id_ed25519.pub</pre>
    __*Copia todo el texto que aparece*__

### 2.2 Agregar llave SSH a GitHub
- Ir a **[GitHub → Settings → SSH and GPG keys](https://github.com/settings/keys)**
  - Click en el boton **New SSH key**, pega el contenido, dale el nombre de tu dispositivo y guardalo.

---

## 3. Clonar el repositorio de la materia de GitHub

- Desde tu terminal crea y entra a la carpeta en la que vas a trabajar:
    <pre>
    mkdir "nombre_carpeta"
    cd nombre_carpeta </pre>

- Copia el URL del repositorio y pegalo:
    <pre>
    git clone [URL del repositorio]
    cd repositorio</pre>

- Vincular cuenta de Git con el repositorio: (*Solo se hace la primera vez*)
    <pre>
    git config user.name "Nombre de usuario"
    git config user.email "email@example.com"
</pre>

Usa el mismo nombre de usuario y correo que tienes en **[GitHub](https://github.com/login)**

---

## 4. Crear y cambiar de rama
- Crear una rama y cambiarte a ella
    <pre>git checkout -b NombreRama
</pre>

---

## 5. Crear y ejecutar un proyecto en C#

Una vez dentro de la carpeta y rama en la que se va a trabajar
- Abre VS Code desde Git Bash
    <pre>code . </pre>
- Crea una nueva carpeta para trabajar *Ej: "ejercicio1"*
- Haz click derecho sobre el nombre de la carpeta y haz click en *"Open in Integrated Terminal"* o *"Abrir Terminal Integrada"*
- Asegurate que esta dentro de la carpeta creada *Ej: ucatec/estructura-datos/ejercicio1* 
    - Si no estas, entra usando el comando <pre>cd </pre> 
- Ahora crea una aplicación de consola con el siguiente comando:
  <pre>dotnet new console</pre>

- Para ejecutar usa este comando:

  <pre>dotnet run</pre>

---

## 6. Subir cambios a GitHub

- Ver estado:
    <pre>git status</pre>

- Agregar todos los cambios:
    <pre>git add .</pre>

- Crear un commit:
    <pre>git commit -m "descripcion de los cambios realizados"</pre>

- Subir los cambios a GitHub:
    <pre>git push</pre>
    - La primera vez te puede salir un error, copia el texto que te da y ejecutalo:
        <pre>--set-upstream origin NombreRama</pre>

