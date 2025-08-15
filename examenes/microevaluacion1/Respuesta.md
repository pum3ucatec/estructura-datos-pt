# GUIA PARA LA CONFIGURACIÓN DEL REPOSITORIO

## Requisitos previos 

### 1. Iniciar sesión en Github
- Crear una cuenta en Hithub
- Inicia sesión en el navegador
### 2. Instalación de Git
- Descarga Git: **[Download Git](https://git-scm.com/downloads)**

  - *Descargalo para Windows*
- Acepta todos los terminos
- Realiza la instalación
- Abre git bash y verifica la instalación
  

---


<pre> git --version </pre>

---


### 3. Instalación de VS Code

- Descarga VS Code: **[Download VS Code](https://code.visualstudio.com/download)**

- Acepta todos los terminos 
- Realiza la instalción
- Verifica la instalción en git bash:
---


<pre> code --version </pre>

---

- Instala la  extension:

  - C# Dev Kit 
  - Este te ayuda con el autocompletado y la depuración sin complicarte, es joya.


### 4. Instalacion Dotnet

- Descargar Dotnet: **[Download Dotnet](https://dotnet.microsoft.com/en-us/download)**
- Acepta todos los terminos
- Realiza la instalación
- Versiones disponibles:

  - .NET 9.0 → Este es compatible solo con ciertas versiones de VS Code.
  - NET 8.0 → Se recomienda este por ser más estable.
- Elije el que mejor se adapte a ti.

- En git bash verifica la instalacion:
  
---

<pre> dotnet --version</pre>

---

## Pasos para crear tu carpeta y repositorio local

#### 1. Abre Git Bash y crea la carpeta del proyecto:

---

<pre>mkdir tu_proyecto

cd tu_proyecto</pre>

---
#### 2. Inicia git
---
<pre>git init</pre>
---

#### 3. Configura tu nombre y correo este debe coincidir con el de tu cuenta de GitHub:
---
<pre>git config user.name "TuNombre"
git config user.email "tucorreo@ejemplo.com"</pre>
---
#### 4. Crea un archivo Inicial
---
<pre>echo "# Mi primer proyecto" > README.md</pre>
---

#### 5. Guarda los cambios en Git
---
<pre>git add README.md
git commit -m "Primer commit"
</pre>
---

#### 6. Verfica el estado 
---
<pre>git status</pre>
---

## Crear repositorio remoto en GitHub

- En GitHub, haz clic en New Repository.

- Nómbralo igual que tu carpeta local (opcional).

- No marques la opción Add a README file.

- Clic en Create Repository.
## Generar y agragar clave SSH a GitHub

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

**_¡¡¡Copia todo el texto!!!_**

---

## Agregar la clave a GitHub

  - Ve a **[GitHub → Settings → SSH and GPG keys](https://github.com/settings/keys)**
  - Click en **New SSH key** y pega el contenido y guardalo

## Pasos para clonar un repositorio existente

#### 1. Copiar la URL desde GitHub (Code → SSH o HTTPS).

#### 2. En la carpeta donde lo guardarás:
#### 3. Ejecutar


---

<pre>git clone URL-de-la-repo
</pre>

---
#### 4. Entra a la carpeta
---

<pre>cd nombre-repo
</pre>

---

## Crear y usar  ramas
#### 1. Ver ramas existentes
---

<pre>git branch
</pre>

---

#### 2. Crear una rama
  ***
  <pre>git branch nombre_de_la_rama
  </pre>

#### 3. Cambiar a la nueva rama

---

 <pre>git checkout  nombre_rama
</pre>

---

#### 4. Hacer cambios y confirmarlos

---

 <pre>ggit add .
git commit -m "Mensaje describiendo cambios"
</pre>

---

#### 5. Subir la rama a GITGUB

---

 <pre>git push -u origin nombre-de-la-rama
</pre>

---

## Crear y ejecutar un proyecto en C#

- Crear una carpeta que vaya a contener el proyecto
- Abre desde la terminal
- En la terminal:

  - `dotnet new console`

- Para ejecutar:

  - `dotnet run`

## Subir cambios a GitHub

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