# Microevaluación 1 – Configuración del Repositorio

---

## Parte 1: Instalación de Git Bash
Para comenzar, necesitamos instalar **Git Bash**, que nos permitirá trabajar con **Git** desde la consola.  
- Descarga Git Bash desde la página oficial.  
- Para verificar que quedó instalado correctamente, abre Git Bash y ejecuta:
git --version

## Parte 2: Instalación de .NET

Para poder trabajar con proyectos en C# u otros entornos compatibles, necesitamos instalar **.NET**.

### Pasos:

1. **Descargar .NET**
   - Abre tu navegador y busca **“.NET Windows”**.
   - Ingresa al sitio oficial y descarga la versión compatible con tu sistema operativo.

2. **Instalar .NET**
   - Ejecuta el instalador descargado.
   - Sigue las instrucciones en pantalla hasta finalizar la instalación.

3. **Verificar la instalación**
   - Abre **Git Bash** o la terminal de tu preferencia.
   - Escribe el siguiente comando para comprobar que .NET se instaló correctamente:
   dotnet --version

Si todo está correcto, verás un número de versión, por ejemplo:
7.0.400

## Parte 4: Configuración de la llave SSH

La **llave SSH** permite una conexión segura entre tu computadora y GitHub, evitando tener que ingresar tu usuario y contraseña cada vez que subas o descargues archivos.

### Pasos:

1. **Generar la llave SSH**
   - Abrir **Git Bash** y ejecuta el siguiente comando (reemplaza tu correo real):

   ssh-keygen -t ed25519 -C "tucorreo@gmail.com"
Activar el agente SSH

2. **Ejecutamos los siguientes comandos para activar el agente y añadir tu llave:**
eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_ed25519

**Copiar la llave pública**
Obtén la clave pública para pegarla en GitHub:

cat ~/.ssh/id_ed25519.pub

**Agregamos la llave a GitHub y verificamos la conexion y ver q todo funcione usando el comando**

ssh -T git@github.com

**a lo q deberia de salir**
Hi usuario, todo se ha conectado correctamente

## Paso 5: Se debe clonar el repositorio de la materia 
Se debe poner el comando: 
"git clone git@github.com:usuario/repositorio.git" (Esto dependiendo del URL que tengas en Github)

Debemos entrar a la carpeta del respositorio con el comando "cd repositorio"

## Paso 6: Subir tu primer tarea

Dentro del repositorio, crea una carpeta con tu nombre para organizar tus trabajos y archivos; por ejemplo, puedes usar `mkdir TuNombre/Microevaluacion1` y luego entrar a esa carpeta con `cd TuNombre/Microevaluacion1`.

Como último paso, agrega los cambios, haz el commit y súbelos a GitHub; por ejemplo: `git add TuNombre/Microevaluacion1/Respuesta.md`, luego `git commit -m "Microevaluación 1 - Documentación"` y finalmente `git push origin master`.
