# **Documentación de Configuración y Uso del Repositorio**


## 1. Instalación de Herramientas

1.1. Instalar **Git**

Página oficial: https://git-scm.com/downloads

Descargar e instalar Git (usa las opciones por defecto).

Verificar:

```bash
git --version
```

Deberia salir la version 
ej. `git version 2.50.0.windows.1`


1.2. Instalar **Git Bash** (si no se instaló con Git)

Descargar desde https://gitforwindows.org/

Instalar usando valores por defecto.


1.3. Instalar **.NET SDK**

1. Ir a la página oficial: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/es-es/download)
2. Descargar la versión **.NET SDK** más reciente (según tu sistema operativo, puede ser la version 8 o 9).
3. Instalar siguiendo las instrucciones del asistente.

Verificar instalación en la terminal que uses (Recomendacion: Usar Git Bash):

```bash
dotnet --version
```

Deberia salir la version que descargaste.
ej. `9.0.304`


1.3. Instalar **Visual Studio Code**

Ir a: https://code.visualstudio.com/

Descargar e instalar para tu sistema.


1. Instalar extensiones recomendadas:

	- C# (Microsoft)
	- C# Dev Kit
	- GitHub Copilot
	- .NET Install Tool

## 2. Crear  Cuenta en GitHub

Ir a https://github.com

Registrarse con correo, usuario y contraseña (Confirmar el correo electrónico).

Si ya tienes solo inicia sesion.

## 3.  Configurar Llave SSH en GitHub

1. Verificar si ya tienes una llave SSH
En **Git Bash**:

```bash
ls -al ~/.ssh
```
Si te sale algo relaccionado con `id_ed25519` o `id_ed25519.pub`. Ya tienes una llave, si no, sigue los siguientes pasos:

Ejecutar:

```bash
ssh-keygen -t ed25519 -C "tucorreo@ejemplo.com"
```

Presionar Enter para aceptar la ruta por defecto `(/c/Users/TuUsuario/.ssh/id_ed25519)`

Luego:

```bash
eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_ed25519
```
Copiar la clave pública
```bash
cat ~/.ssh/id_ed25519.pub
```

Copiar la salida.


**3.1.** Agregar llave a GitHub

- Ir a GitHub > Settings > SSH and GPG Keys

- Click en New SSH key

- Pegar la clave copiada.

- Guardar.

Verificar conexión
```bash
ssh -T git@github.com
```

Si todo está bien, debería salir:

`Hi tuUsuario! You've successfully authenticated...`


## 4.  Configuración Inicial de Git

Configura tu usuario y correo (solo la primera vez):

```bash
git config --global user.name "Tu Nombre"
git config --global user.email "tu.email@example.com"
```

## 5. Clonar Repositorio de la Materia

En el GitHub hay un boton verde que pone Code, al presionarlo sale 3 opciones, entrar al SSH y copiar la URL.

```bash
git clone git@github.com:Usuario/repositorio-de-la-materia.git

cd repositorio-de-la-materia
```

## 6. Crear una Rama, Realizar Cambios y Subirlos

6.1. Crear y cambiarte a una nueva rama

```bash
git checkout -b nombre-de-la-rama
```

6.2. Realizar cambios

Edita los archivos en VS Code.

Guarda los cambios.

6.3. Agregar y confirmar cambios

```bash
git add .

git commit -m "Descripción clara de los cambios"
```

6.4. Subir cambios a GitHub
```bash
git push -u origin nombre-de-la-rama
```

## 7. Actualizar tu Rama con la Versión más Reciente de main

Si vuelves a trabajar en tu rama u otra, siempre se debe actualizar.

```bash
git checkout main

git pull origin main

git checkout nombre-de-la-rama
```

## 8. Recomendaciones

Realiza commits pequeños y claros.

Antes de subir cambios, asegúrate de actualizar tu rama para evitar conflictos.
