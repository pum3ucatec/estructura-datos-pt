# **PASOS PARA INSTALAR GIT**
## Descargar
1) Git, Descargar desde la pagina oficial
https://git-scm.com/downloads

Si esta instalado correctamente poner el siguiente comando en la terminal

(git --version)

2) .NET SDK Descargar desde la pagina oficial https://dotnet.microsoft.com/download


Si esta instalado correctamente poner el siguiente comando en la terminal

(dotnet --version)

3) Visual Studio Code https://code.visualstudio.com/



## **-----------------------------------------------------------------------------**
![alt text](image.png)

![alt text](image-1.png)

![alt text](image-2.png)

## **-----------------------------------------------------------------------------**

## Configuracion de Git y SSH
 **Primera configuracion de Git**
 **Configurar Git por primera vez**


 Comandos

- git config --global user.name "Tu Nombre"
- git config --global user.email "tu@email.com"
- git config --list

**Generar la llave SSH para GitHub**

Comando

- ssh-keygen -t ed25519 -C "tu@email.com"

**Agregar la llave SSH**

- eval "$(ssh-agent -s)"
- ssh-add ~/.ssh/id_ed25519

**Agregar la clave a GitHub**

- cat ~/.ssh/id_ed25519.pub
- Ir a GitHub → Settings → SSH and GPG keys → New SSH key.
Ponemos el contenido y guardarmos.

## Clonar un repositorio en GitHub

Ir a la pagina de GitHub, ve a tu rama y copia el enlace de la partes donde dice CODE ir a SSH

Comando
- git clone git@github.com:Usuario/Repositorio.git
- cd Proyecto

## Crear rama en Git bash

- git branch  nombre de la rama
- git checkout -b nombre de la rama
- git branch  Verifica en que rama estas 

## Como hacer cambios y subirlos
- git branch Verfica si esta en la rama que queremos cambiar
- git status Verifica el estado de cambio
- git add . Verifica todos los cambios
- git commit -m "Descripción"   Confirmar el cambio
- git push origin nombre-de-la-rama  Si es la primera vez que subir
- push sube  el repositorio

## Comandos para subir tu rama a GitHub por primera vez

- git status 
Muestra el estado de tu repositorio
- git add .
Agrega todos los cambios (archivos nuevos, modificados y eliminados).
- git status 
Poner otra vez este comando que sirve para confirmar  lo cambios para continuar con un commit
- git commit -m "Descripción el que tu quieras"
Guarda los cambios preparados en el historial de git 
- git log opcional para confirmar el commit
- git push 



## En el Visual estudio Code, entrar la carpeta y hacer correr
 
- crear una carpeta, click derecho terminal del ejercicio 
- cd practicas/p2-sumar-numeros-del-1-al-n  --> ubicar depende el nombre después de / p2, p..
Para entrar a la carpeta y trabajar de ahí.
- dotnet new console
Crea un nuevo proyecto en la consola en C#
- Control s para guardar
-  dotnet run 
Compila y ejecuta el proyecto actual, cada vez que tenga que hacer correr tengo que poner el comando.
  


