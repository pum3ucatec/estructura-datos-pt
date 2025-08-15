# **Documentación de Configuración y Uso del Repositorio**


## 1. Instalación de Herramientas

### 1.1. Instalar **.NET SDK**

1. Ir a la página oficial: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/es-es/download)
2. Descargar la versión **.NET SDK** más reciente (según tu sistema operativo).
3. Instalar siguiendo las instrucciones del asistente.

Verificar instalación:
```bash
dotnet --version

1.2. Instalar Git

Página oficial: https://git-scm.com/

Descargar e instalar Git (usa las opciones por defecto).

Verificar:

git --version

1.3. Instalar Visual Studio Code

Ir a: https://code.visualstudio.com/

Descargar e instalar para tu sistema.

Instalar extensiones recomendadas:

C# (Microsoft)

GitLens

.NET Install Tool

1.4. Instalar Git Bash (si no se instaló con Git)

Descargar desde https://gitforwindows.org/

Instalar usando valores por defecto.

2. Configuración Inicial de Git

Configura tu usuario y correo (solo la primera vez):

git config --global user.name "Tu Nombre"
git config --global user.email "tu.email@example.com"

3. Crear un Repositorio Local y Conectarlo a GitHub
3.1. Crear un repositorio en GitHub

Iniciar sesión en GitHub.

Clic en New Repository.

Asignar nombre y descripción, luego Create Repository.

3.2. Crear el repositorio localmente
mkdir nombre-del-proyecto
cd nombre-del-proyecto
git init

3.3. Conectar repositorio local con GitHub
git remote add origin https://github.com/usuario/nombre-del-proyecto.git
git branch -M main
git push -u origin main

4. Clonar un Repositorio
4.1. Clonar un repositorio propio
git clone https://github.com/usuario/nombre-del-proyecto.git

4.2. Clonar un repositorio ajeno (sin permisos de escritura)
git clone https://github.com/otro-usuario/repositorio.git


Podrás leer y descargar, pero no subir cambios sin hacer un fork.

5. Crear una Rama, Realizar Cambios y Subirlos
5.1. Crear y cambiarte a una nueva rama
git checkout -b nombre-de-la-rama

5.2. Realizar cambios

Edita los archivos en VS Code.

Guarda los cambios.

5.3. Agregar y confirmar cambios
git add .
git commit -m "Descripción clara de los cambios"

5.4. Subir cambios a GitHub
git push -u origin nombre-de-la-rama

6. Actualizar tu Rama con la Versión más Reciente de main
git checkout main
git pull origin main
git checkout nombre-de-la-rama
git merge main

7. Recomendaciones

Usa nombres de ramas descriptivos: feature/login, fix/bug-issue42.

Realiza commits pequeños y claros.

Antes de subir cambios, asegúrate de actualizar tu rama para evitar conflictos.


Si quieres, puedo hacer una **versión más visual con diagramas de flujo** en Markdown para que se entienda mejor todo el proceso.  
¿Quieres que te la prepare así también?


















📄 Respuesta.md para la carpeta QuelaliGaston/Microevaluacion1
# Documentación de la Configuración del Repositorio para la Materia

## 1. Instalación de Herramientas Necesarias

### ✅ Git Bash

1. Descargar Git desde el sitio oficial: https://git-scm.com/
2. Ejecutar el instalador y seguir los pasos por defecto.
3. Verificar instalación abriendo Git Bash y ejecutando:

```bash
git --version

✅ .NET SDK

Descargar el SDK de .NET (versión actual recomendada): https://dotnet.microsoft.com/en-us/download

Elegir la versión compatible con tu sistema operativo.

Verificar instalación ejecutando:

dotnet --version

2. Crear Cuenta en GitHub

Ir a https://github.com

Registrarse con correo, usuario y contraseña.

Confirmar el correo electrónico.

3. Configurar Llave SSH
🔐 Generar llave SSH

Abrir Git Bash.

Ejecutar:

ssh-keygen -t ed25519 -C "tucorreo@ejemplo.com"


Presionar Enter para aceptar la ruta por defecto (/c/Users/TuUsuario/.ssh/id_ed25519)

Luego:

eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_ed25519

📋 Copiar la clave pública
cat ~/.ssh/id_ed25519.pub


Copiar la salida.

🔗 Agregar llave a GitHub

Ir a GitHub > Settings > SSH and GPG Keys

Click en New SSH key

Pegar la clave copiada.

Guardar.

✅ Verificar conexión
ssh -T git@github.com


Si todo está bien, debería salir:

Hi tuUsuario! You've successfully authenticated...

4. Clonar Repositorio de la Materia
git clone git@github.com:Usuario/repositorio-de-la-materia.git
cd repositorio-de-la-materia

5. Crear Carpeta Personal y Subir Primer Commit
🗂 Crear carpeta y archivo
mkdir NombreApellido/Microevaluacion1
cd NombreApellido/Microevaluacion1
touch Respuesta.md


O si usas Windows:

echo. > Respuesta.md

📝 Agregar contenido

Edita Respuesta.md con esta documentación (como lo estás haciendo ahora).

💾 Guardar, agregar y hacer commit
git add NombreApellido/Microevaluacion1/Respuesta.md
git commit -m "Microevaluación 1 - Documentación"
git push origin main  # o la rama correspondiente

🧠 Notas Finales

Asegúrate de estar en la rama correcta (git branch)

Verifica con git status antes de hacer commit

Puedes usar code . para abrir VS Code desde Git Bash (si tienes instalado el atajo)