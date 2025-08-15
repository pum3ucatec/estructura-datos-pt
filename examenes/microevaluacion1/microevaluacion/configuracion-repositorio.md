# 📘 Guía Completa: Git Bash, VS Code, .NET y GitHub

Este documento te explica paso a paso cómo:

- Descargar e iniciar **Git Bash**, **Visual Studio Code** y **.NET**.
- Crear una cuenta en **GitHub** y conectarla con **Git Bash**.
- Crear ramas y llaves SSH para trabajar con repositorios.
- Ejecutar proyectos con **.NET** y abrirlos en **VS Code**.

---

## 1️⃣ Instalación de Herramientas
![imagen del git bash](documentacion/imagenes/gitbash.png)
### 1.1 _Instalar Git Bash_
- 📥 Descargar desde: [https://git-scm.com/](https://git-scm.com/)
- Instalar con las opciones por defecto.
- Verificar instalación:
  ```bash
  git --version

1.2 Instalar Visual Studio Code

![imagen del vscode](documentacion/imagenes/vscode.png)

📥 Descargar desde: https://code.visualstudio.com/

Instalar con configuración predeterminada.

Recomendado: instalar extensión GitHub Pull Requests and Issues.

1.3 Instalar .NET SDK
📥 Descargar desde: https://dotnet.microsoft.com/en-us/download

![imagen del dotnet](documentacion/imagenes/dotnet.png)

Verificar instalación:

bash
Copiar
Editar
dotnet --version
2️⃣ Creación de Cuenta en GitHub
Ir a: https://github.com/

Hacer clic en Sign up.

Completar:

Nombre de usuario

Correo electrónico

Contraseña segura

Confirmar el correo electrónico.

3️⃣ Configuración de Git con tus Datos
Abrir Git Bash y configurar tus datos de GitHub:

bash
Copiar
Editar
git config --global user.name "TuNombreDeUsuario"
git config --global user.email "tu_correo@ejemplo.com"
4️⃣ Generar y Conectar una Llave SSH
4.1 Generar la clave
bash
Copiar
Editar
ssh-keygen -t ed25519 -C "tu_correo@ejemplo.com"
Presionar Enter para aceptar la ruta por defecto.

Ingresar (o no) una contraseña.

4.2 Copiar la clave pública
bash
Copiar
Editar
cat ~/.ssh/id_ed25519.pub
Copiar el contenido que se muestra.

4.3 Agregar clave SSH a GitHub
Ir a: Configuración de SSH en GitHub

Clic en New SSH key, pegar la clave y guardar.

4.4 Probar conexión
bash
Copiar
Editar
ssh -T git@github.com
5️⃣ Conectar y Clonar un Repositorio
Clonar con SSH:

bash
Copiar
Editar
git clone git@github.com:usuario/repositorio.git
Entrar a la carpeta:

bash
Copiar
Editar
cd nombre-del-repositorio
6️⃣ Crear y Gestionar Ramas
Ver ramas existentes:

bash
Copiar
Editar
git branch
Crear nueva rama:

bash
Copiar
Editar
git checkout -b nombre-de-la-rama
Cambiar de rama:

bash
Copiar
Editar
git checkout nombre-de-la-rama
Subir rama al repositorio remoto:

bash
Copiar
Editar
git push -u origin nombre-de-la-rama
7️⃣ Abrir y Ejecutar Proyectos
7.1 Abrir Git Bash
Buscar Git Bash en el menú de inicio y abrirlo.

7.2 Abrir VS Code desde Git Bash
bash
Copiar
Editar
code .
7.3 Ejecutar un proyecto .NET
Crear proyecto:

bash
Copiar
Editar
dotnet new console -n MiProyecto
Entrar al proyecto:

bash
Copiar
Editar
cd MiProyecto
Ejecutar:

bash
Copiar
Editar
dotnet run
🔗 Recursos Útiles
📖 Documentación de Git

📖 Documentación de VS Code

📖 Documentación de .NET

📖 Documentación de GitHub

yaml
Copiar
Editar

---

Este archivo está listo para guardarse como **`README.md`** y subirlo a tu repositorio.  
Si quieres, puedo ahora prepararte **una versión con iconos y emojis para cada paso** para que se vea más llamativo cuando lo abras en GitHub.







Tú dijiste:
en uno solo para copiar y ya


ChatGPT Plus
Listo, aquí tienes el README.md listo para copiar y pegar tal cual en tu repositorio, todo en uno solo archivo:

markdown
Copiar
Editar
# 📘 Guía Completa: Git Bash, VS Code, .NET y GitHub

Este documento te explica paso a paso cómo:

- Descargar e iniciar **Git Bash**, **Visual Studio Code** y **.NET**.
- Crear una cuenta en **GitHub** y conectarla con **Git Bash**.
- Crear ramas y llaves SSH para trabajar con repositorios.
- Ejecutar proyectos con **.NET** y abrirlos en **VS Code**.

---

## 1️⃣ Instalación de Herramientas

### 1.1 _Instalar Git Bash_
- 📥 Descargar desde: [https://git-scm.com/](https://git-scm.com/)
- Instalar con las opciones por defecto.
- Verificar instalación:
  ```bash
  git --version
1.2 Instalar Visual Studio Code
📥 Descargar desde: https://code.visualstudio.com/

Instalar con configuración predeterminada.

Recomendado: instalar extensión GitHub Pull Requests and Issues.

1.3 Instalar .NET SDK
📥 Descargar desde: https://dotnet.microsoft.com/en-us/download

Verificar instalación:

bash
Copiar
Editar
dotnet --version
2️⃣ Creación de Cuenta en GitHub
Ir a: https://github.com/

Hacer clic en Sign up.

Completar:

Nombre de usuario

Correo electrónico

Contraseña segura

Confirmar el correo electrónico.

3️⃣ Configuración de Git con tus Datos
Abrir Git Bash y configurar tus datos de GitHub:

bash
Copiar
Editar
git config --global user.name "TuNombreDeUsuario"
git config --global user.email "tu_correo@ejemplo.com"
4️⃣ Generar y Conectar una Llave SSH
4.1 Generar la clave
bash
Copiar
Editar
ssh-keygen -t ed25519 -C "tu_correo@ejemplo.com"
Presionar Enter para aceptar la ruta por defecto.

Ingresar (o no) una contraseña.

4.2 Copiar la clave pública
bash
Copiar
Editar
cat ~/.ssh/id_ed25519.pub
Copiar el contenido que se muestra.

4.3 Agregar clave SSH a GitHub
Ir a: Configuración de SSH en GitHub

Clic en New SSH key, pegar la clave y guardar.

4.4 Probar conexión
bash
Copiar
Editar
ssh -T git@github.com
5️⃣ Conectar y Clonar un Repositorio
Clonar con SSH:

bash
Copiar
Editar
git clone git@github.com:usuario/repositorio.git
Entrar a la carpeta:

bash
Copiar
Editar
cd nombre-del-repositorio
6️⃣ Crear y Gestionar Ramas
Ver ramas existentes:

bash
Copiar
Editar
git branch
Crear nueva rama:

bash
Copiar
Editar
git checkout -b nombre-de-la-rama
Cambiar de rama:

bash
Copiar
Editar
git checkout nombre-de-la-rama
Subir rama al repositorio remoto:

bash
Copiar
Editar
git push -u origin nombre-de-la-rama
7️⃣ Abrir y Ejecutar Proyectos
7.1 Abrir Git Bash
Buscar Git Bash en el menú de inicio y abrirlo.

7.2 Abrir VS Code desde Git Bash
bash
Copiar
Editar
code .
7.3 Ejecutar un proyecto .NET
Crear proyecto:

bash
Copiar
Editar
dotnet new console -n MiProyecto
Entrar al proyecto:

bash
Copiar
Editar
cd MiProyecto
Ejecutar:

bash
Copiar
Editar
dotnet run
🔗 Recursos Útiles
📖 Documentación de Git

📖 Documentación de VS Code

📖 Documentación de .NET

📖 Documentación de GitHub