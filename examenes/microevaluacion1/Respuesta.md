# GUIA PARA LA CONFIGURACIÓN DEL REPOSITORIO

## Requisitos previos 

### 1. Iniciar sesión en Github
- Crear una cuenta en Hithub
- Inicia sesión en el navegador
### 2. Instalación de Git
- Descarga Git: **[Download Git](https://git-scm.com/downloads)**

  - *Descargalo para Windows*
- Instalar con la configuracion predeterminada
- Abre git bash y verifica la instalación
  

---


<pre> git --version </pre>

---


### 3. Instalación de VS Code

- Descarga VS Code: **[Download VS Code](https://code.visualstudio.com/download)**

- Instalar con la configuracion predeterminada
- Verifica la instalción en git bash:
---


<pre> code --version </pre>

---

- Instala la  extension:

  - C# Dev Kit 
  - Este te ayuda con el autocompletado y la depuración sin complicarte, es joya.


### 4. Instalacion Dotnet

- Descargar Dotnet: **[Download Dotnet](https://dotnet.microsoft.com/en-us/download)**
- Instalar con la configuracion predeterminada
- Versiones disponibles:

  - .NET 9.0 → Compatible solo con ciertas versiones de VS Code.
  - NET 8.0 → Recomendado por ser más estable.
- Elije el que mejor se adapte a ti.


  
---

<pre> dotnet --version</pre>

---



### 4. Configuracion Git y clave SSH

- Configuracion inicial Git

---

<pre>git config --global user.name "Tu nombre"

git config --global user.email "tu_correo@example.com"</pre>

---

Usa el mismo correo que tienes en **[GitHub](https://github.com/login)**

---

#### 4.1. Generar y agragar clave SSH a GitHub

- Generar clave SSH

---

<pre>ssh-keygen -t ed25519 -C "tu_correo_de_github@hotmail.com"
</pre>

---

- Levantar al agente SSH y agregar una clave

---

<pre>eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_ed25519
</pre>

---

- Copiar la clave publica

---

<pre>cat ~/.ssh/id_ed25519.pub</pre>

---

**_¡¡¡Copia su contenido!!!_**

---

- Agregar la clave a GitHub

  - Ir a **[GitHub → Settings → SSH and GPG keys](https://github.com/settings/keys)**
  - Click en **New SSH key** y pega el contenido y guardalo

### 5. Clonar un repositorio de GitHub

- Crea una carpeta para clonar ahi tu repositorio

---

<pre>
mkdir "nombre_de_tu_carpeta"
cd nombre_de_tu_carpeta
</pre>

---

- Clonar un repositorio

---

<pre>git clone git@github.com:usuario/repositorio.git

cd repositorio</pre>

---

### 6. Crear y cambiar de rama

- Crear una rama
  ***
  <pre>git branch nombre_de_la_rama
  </pre>
  ***
- Crear una rama y cambiarte a ella

---

 <pre>git checkout -b nombre_rama
</pre>

---

- Cambiarte a la nueva rama

---

 <pre>git checkout nombre_rama
</pre>

---

### 7. Crear y ejecutar un proyecto en C#

- Crear una carpeta que vaya a contener el proyecto
- Abre desde la terminal
- En la terminal:

  - `dotnet new console`

- Para ejecutar:

  - `dotnet run`

### 8. Subir cambios a GitHub

- Ver estado

---

<pre>git status</pre>

- Agregar todos los cambios

---

<pre>git add .</pre>

- Crear un commit

---

<pre>
git commit -m "mensaje con los cambios realizados"
</pre>

---

- Subir los cambios a GitHub

---

<pre>
git push
</pre>

---