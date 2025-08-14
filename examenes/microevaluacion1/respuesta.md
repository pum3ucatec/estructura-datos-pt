# Manual Técnico: Git, GitHub, SSH y Proyecto en C#

# Manual Técnico: Git, GitHub, SSH y Proyecto en C#

## 1. Instalación de Git
1. Descargar Git desde: [https://git-scm.com/downloads](https://git-scm.com/downloads)
2. Instalar con la configuración por defecto.
3. Verificar instalación:
   ```bash
   git --version
   ```

---

## 2. Instalación de .NET SDK
1. Descargar desde: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. Instalar con opciones por defecto.
3. Verificar instalación:
   ```bash
   dotnet --version
   ```

---

## 3. Instalación de Visual Studio Code
1. Descargar desde: [https://code.visualstudio.com/](https://code.visualstudio.com/)
2. Instalar con opciones por defecto.
3. Instalar extensiones recomendadas:
   - **C#** (Microsoft)
   - **GitLens** (para ver historial y cambios en Git)

---

## 4. Configuración de Git y SSH

### 4.1 Configuración inicial de Git
```bash
git config --global user.name "Tu Nombre"
git config --global user.email "tu@email.com"
git config --list
```

### 4.2 Generar clave SSH para GitHub
```bash
ssh-keygen -t ed25519 -C "tu@email.com"
```
- Presionar **Enter** para la ubicación por defecto.
- (Opcional) Escribir passphrase o dejar en blanco.

### 4.3 Agregar clave SSH al agente
```bash
eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_ed25519
```

### 4.4 Agregar clave a GitHub
1. Copiar la clave pública:
   ```bash
   cat ~/.ssh/id_ed25519.pub
   ```
2. Ir a **GitHub → Settings → SSH and GPG keys → New SSH key**.
3. Pegar el contenido y guardar.
4. Probar conexión:
   ```bash
   ssh -T git@github.com
   ```

---

## 5. Clonar un repositorio de GitHub
```bash
git clone git@github.com:Usuario/Repositorio.git
cd Repositorio
```

---

## 6. Crear y cambiar de rama en Git

### 6.1 Crear nueva rama y cambiarte a ella
```bash
git checkout -b nombre_rama
```

### 6.2 Cambiar a una rama existente
```bash
git checkout nombre_rama
```

### 6.3 Subir rama a GitHub
```bash
git push -u origin nombre_rama
```

---

## 7. Subir cambios a GitHub

### 7.1 Ver estado
```bash
git status
```

### 7.2 Agregar cambios
```bash
git add .
```

### 7.3 Crear commit
```bash
git commit -m "Descripción de los cambios"
```

### 7.4 Subir cambios
```bash
git push
```

---

## 8. Crear un proyecto en C#
### 8.1 Proyecto en carpeta actual
```bash
dotnet new console
```

### 8.2 Proyecto en carpeta nueva
```bash
dotnet new console -n NombreProyecto
```

Para ejecutar:
```bash
dotnet run
```


**Autor:** _Juan David Candia Maldonado_  
**Fecha:** _14/8/2025_
**Materia** _Estructura de Datos 1_

