# Examen de Jennifer Chileno

## Pregunta 1

### Enunciado

Encontrar el Número que Falta En un arreglo de números del 1 al n, falta un número. Encuentra cuál es. 

Ejemplo: [1, 2, 4, 5, 6] → Falta 3.

Rearlizar la documentacion en un archivo README.md, este archivo debe tener una explicacion de lo utiliz ando, como por ejemplo si se uso PascalCase, que comando necesito para hacer correr, y lo que veas conveniente. 

---

### 1. Resolución del problema  

Este proyecto se realizó con el lenguaje de programación **C#** para resolver el problema de encontrar un número faltante en un arreglo que contiene números del `1` al `n`, pero con uno ausente, en este caso el `8`.


#### 1.1. Explicación del Problema

Dado un arreglo con números consecutivos del `1` al `n`, falta un número en la secuencia. 

En este caso:  
`[1, 2, 3, 4, 5, 6, 7, 9, 10] → Falta 8`

El programa utiliza la **fórmula de suma aritmética**:
`Sum = n * (n + 1) / 2`

Luego resta la suma real del arreglo para obtener el número faltante.

---

### 2. Convenciones de Código

- **PascalCase**:  
  - Se usa para nombres de clases y métodos.  
  	Ejemplo: `Practica1`, `Main`.  

- **camelCase**:  
  - Se usa para variables locales.  
  Ejemplo: `esSum`, `acSum`.

- **Comentarios**:  
  - Un poco de explicaciíon de las variables simplificadas y que se hara en el código.

---

### 3.  Cómo Ejecutar

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

- Poner ete comando en la terminal integrado del VScode (Asegurate de estar en el archivo correcto en este caso Pregunta1 (Program.cs)).

```bash
dotnet run
```

El programa deberia devolver el mensaje de: `El número que falta es: 8`