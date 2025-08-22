# Documentación Examen Parcial
## Jorge Sebastian Torrico Pinto

## Pregunta 1

### Enunciado

Encontrar el Número que Falta En un arreglo de números del 1 al n, falta un número. Encuentra cuál es. 

Ejemplo: [1, 2, 4, 5, 6] → Falta 3.

Rearlizar la documentacion en un archivo README.md, este archivo debe tener una explicacion de lo utiliz ando, como por ejemplo si se uso PascalCase, que comando necesito para hacer correr, y lo que veas conveniente. 

---

### 1. Resolución 

Emplear el lenguaje **C#** para resolverlo, diseñando un programa que permita encontrar un número faltante dentro de un arreglo que detalla una secuencia linwal del `1` al `6`. 
El número faltante es `4`

#### 1.1. Explicación del Problema

* Primeramente, declarar un arreglo con números consecutivos del `1` al `n`, con un número faltante

  En este caso:  
`[1, 2, 3, 5, 6] → Falta 4`

* **numeros.Length** devuelve cuantos elementos hay. Al faltar uno, el total debería ser **5 + 1 = 6**

  `int n = numeros.Length + 1; `

* Luego, se usa la **fórmula de suma aritmética**:

    `Sum = n * (n + 1) / 2`

* Luego se calcula la suma total, de 1 hasta a n:

    `int sumaTotal = n * (n + 1) / 2;`


* Recorremos el arreglo y sumamos todos sus elementos:

    1 + 2 + 4 + 5 + 6 = 18.
    
     `int sumaArreglo = 0;
        foreach (int num in numeros)
        {
            sumaArreglo += num;
        }`
* Se calcua la diferencia: 21 - 18 = 3. Ese es el número faltante. Y finalmente se muestra el resulrado en la consola:

    `int faltante = sumaTotal - sumaArreglo;`
    `Console.WriteLine($"El número faltante es: {faltante}");
    }
}`


---

### 2. Convenciones de Código

- **PascalCase**:  
  - Se usa para nombres de clases y métodos.  
  	Ejemplo: `Main`.  

- **CamelCase**
    - Usado para variables
      
      Ejemplo: `SumaTotal`.

- **snake_case**
    - Usado para el nombre de la carpeta de la pregunta
      
      Ejemplo: `pregunta_1`.

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

- Ubicarse en **pregunta_1**. Poner el sgte. comando en la terminal integrado del VScode.

```bash
dotnet run
```

El programa deberia devolver el mensaje de: `El número que falta es: 4`