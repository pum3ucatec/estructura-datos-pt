# Pregunta 2

## Enunciado

Espiral en una Matriz Escribe un programa que recorra e imprima los elementos de una matriz en forma de espiral. 

Ejemplo:

```text
[ 1   2   3 ]
[ 4   5   6 ]   --> [1, 2, 3, 6, 9, 8, 7, 4, 5].
[ 7   8   9 ]
```
Realizar la documentacion en un archivo README.md, este archivo debe tener una explicacion de lo utilizando, como por ejemplo si se uso PascalCase, que comando necesito para hacer correr, y lo que veas conveniente. 

---

### 1. Resolución del Problema

Este proyecto se realizó con el lenguaje de programación de **C#**, el ejercicco imprime los elementos de una matriz en forma de espiral, comenzando desde la esquina superior izquierda y avanzando hacia la derecha, abajo, izquierda y arriba, hasta recorrer todos los elementos.


#### 1.1. Explicación del Problema

Dada una matriz bidimensional, el objetivo es recorrerla en orden espiral.
  
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

---

### Convenciones de Código

- **PascalCase**:  
  - Para nombres de clases y métodos.  
  Ejemplo: `Practica2`, `OrdenEspiral`.  

- **camelCase**:  
  - Para variables locales e índices.  
  Ejemplo: `arriba`, `abajo`, `izq`, `der`.

- **Comentarios**:  
  - Explican cada parte del recorrido (derecha, abajo, izquierda, arriba).

---

### Cómo Ejecutar


1. Clonar o descargar el repositorio.

```bash
git clone URL
```

- **ADICIONAL**: Tambien puedes ingresar a este enlace para tener una vista desde GitHub

	https://github.com/pum3ucatec/estructura-datos-pt/tree/ChilenoJennifer/ExamenParcial


2.  Descarga la rama del estudiante, en este caso:

```bash
git pull origin ChilenoJennifer/ExamenParcial
```

3. Cambiate a la rama del estudiante 

```bash
git checkout ChilenoJennifer/ExamenParcial
```

4. Abre el VSCode y compila el archivo en la terminal o consola de Visual Studio:

	- Para eso se debe de tener de antemano el VSCode instalado, al igual que git y .NET 

	- Para abrir el Visual Studio Code se debe realiar este comando en el git bash

```bash
code .
```

- Poner ete comando en la terminal integrado del VScode (Asegurate de estar en el archivo correcto, en este caso Practica2 (Program.cs)).

```bash
dotnet run
```

Salida:
`1, 2, 3, 6, 9, 8, 7, 4, 5`
