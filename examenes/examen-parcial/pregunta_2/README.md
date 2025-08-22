# Documentación Examen Parcial
## Jorge Sebastian Torrico Pinto

## Pregunta 2

### Enunciado

Espiral en una Matriz Escribe un programa que recorra e imprima los elementos de una matriz en forma de espiral. 

Ejemplo:

```text
[ 1   2   3 ]
[ 4   5   6 ]   --> [1, 2, 3, 6, 9, 8, 7, 4, 5].
[ 7   8   9 ]
```
Realizar la documentacion en un archivo README.md, este archivo debe tener una explicacion de lo utilizando, como por ejemplo si se uso PascalCase, que comando necesito para hacer correr, y lo que veas conveniente. 

---

### 1. Resolución 

Emplear el lenguaje **C#** para resolverlo, este programa imprime los elementos de una matriz en forma de espiral, comenzando desde la esquina superior izquierda y avanzando hacia la derecha, abajo, izquierda y arriba, hasta recorrer todos los elementos.


#### 1.1. Explicación del Problema

Dada una matriz bidimensional de 3x3, el objetivo es recorrerla en orden espiral.

En VSCode se importan las sgtes. librerías:
- **System** para consola.

- **Collections.Generic** para usar List<T>.
  
Ejemplo: 

**Entrada:**


```text
[ 1   2   3 ]
[ 4   5   6 ]   
[ 7   8   9 ]
```

**Salida:**

```text
[1, 2, 3, 6, 9, 8, 7, 4, 5]
```

**En resumen** : El programa usa cuatro límites y un while para recorrer la matriz en capas hasta cubrir todo en espiral.

---

### 2. Convenciones de Código

- **PascalCase**:  
  - Se usa para nombres de clases y métodos.  
  	Ejemplo: `Main`.  

- **CamelCase**
    - Usado para variables y métodos
      
      Ejemplo: `RecorrerEsprirql`.

- **snake_case**
    - Usado para el nombre de la carpeta de la pregunta
      
      Ejemplo: `pregunta_2`.

- **kebab-case**
    - Usado para el nombre de la carpeta del examen.
      
      Ejemplo: `examen-parcial`.


---

### 3.  Cómo Ejecutar

1. Clonar o descargar el repositorio.

```bash
git clone url del repositorio
```


2.  Descarga la rama del estudiante, en este caso:

```bash
git pull origin TorricoSebastian/examen-parcial
```
3. Cambiate a la rama del estudiante 

```bash
git checkout TorricoSebastian/examen-parcial
```


4. Abre el VSCode y compila el archivo en la trminal, teniendo instalado el git y Dotnet.


	- Para abrir el Visual Studio Code se debe realiar este comando en el git bash

```bash
code .
```

- Ubicarse en **pregunta_2**. Poner el sgte. comando en la terminal integrado del VScode.

```bash
dotnet run
```

El programa deberia devolver la lista de los números en orden espiral: `Recorrido en espiral: 1, 2, 3, 6, 9, 8, 7, 4, 5`