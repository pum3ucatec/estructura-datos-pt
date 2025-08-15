# 📄 Documentación de Configuración del Repositorio

Este documento explica paso a paso cómo instalar **Git** y **.NET SDK**, configurar un repositorio local y trabajar con ramas de manera correcta.

---

## 🛠 1. Instalación de Git

### 🔹 Windows
1. Ir a la página oficial: [https://git-scm.com/downloads](https://git-scm.com/downloads)
2. Descargar el instalador para Windows.
3. Ejecutar el instalador y aceptar las opciones por defecto.

Para comprobar que Git está instalado:
```bash
git --version
```
Ejemplo de salida:
```
git version 2.45.1.windows.1
```
## 🛠 2. Instalacion de .NET SDK
### Windows
1. Ir a la página oficial: https://dotnet.microsoft.com/en-us/download
2. Descargar la versión SDK (no solo el runtime).
3. Instalar siguiendo las instrucciones.

Para comprobar que Git está instalado:
```bash
dotnet --version
```
Ejemplo de salida:
```
8.0.100
```
## 🛠 3. Configuracion 

Configura tu nombre y correo (estos datos aparecerán en los commits):
```
git config --global user.name "Tu Nombre"
git config --global user.email "tu.email@dominio.com"
```
Ver configuracion:
```
git config --list
```
## 🛠 4. Clonación de un repositorio
### Windows
Para clonar un repositorio remoto a tu máquina local:
```
git clone https://github.com/usuario/repositorio.git
```
Ejemplo:
```
git clone https://github.com/pum3ucatec/estructura-datos-pt.git
```
Esto creará una carpeta con el contenido del repositorio.
🌿 5. Ver ramas existentes

Listar ramas locales:
```
git branch
```

Listar todas las ramas (locales y remotas):
```
git branch -a
```
🆕 6. Crear una nueva rama

Para crear una rama desde master o main:
```
git checkout -b nombre-de-la-rama
```

Ejemplo:
```
git checkout -b RamalloJuan/Practica1
```
🔄 7. Cambiar de rama
```
git checkout nombre-de-la-rama
```

Ejemplo:
```
git checkout RamalloJuan/Practica2
```

En versiones nuevas de Git también puedes usar:
```
git switch nombre-de-la-rama
```
📤 8. Subir cambios al repositorio remoto

Agregar los archivos modificados:
```
git add .
```

Guardar los cambios con un mensaje:
```
git commit -m "Descripción de los cambios"
```

Subir la rama al repositorio remoto:
```
git push -u origin nombre-de-la-rama
```
