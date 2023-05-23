1. ¿String es un tipo por valor o un tipo por referencia?
En C#, `string` es un tipo por referencia. Esto significa que cuando se crea una 
variable de tipo `string`, en realidad se almacena una referencia a la ubicación de 
la cadena de texto en la memoria. Si asignas una cadena a otra variable, ambas variables 
apuntarán a la misma ubicación en memoria.

2. ¿Qué secuencias de escape tiene el tipo `string`?
El tipo `string` en C# admite varias secuencias de escape que se utilizan para 
representar caracteres especiales dentro de una cadena de texto. Algunas de las secuencias 
de escape comunes son:

- `\"`: Comillas dobles (")
- `\'`: Comilla simple (')
- `\\`: Barra invertida (\)
- `\n`: Nueva línea
- `\r`: Retorno de carro
- `\t`: Tabulación horizontal
- `\b`: Retroceso
- `\f`: Avance de página
- `\uXXXX`: Representación Unicode de 4 dígitos (por ejemplo, `\u0041` representa el carácter 'A')

3. ¿Qué sucede cuando se utiliza el carácter `@` y `$` antes de una cadena de texto?
- Al utilizar el carácter `@` antes de una cadena de texto (por ejemplo, `@"mi cadena"`), se crea una cadena de texto literal. Esto significa que los caracteres de escape, como `\n` o `\t`, no se interpretan y se consideran parte del contenido de la cadena.

- Al utilizar el carácter `$` antes de una cadena de texto (por ejemplo, `$"mi cadena"`), se habilita la interpolación de cadenas. La interpolación de cadenas permite incrustar expresiones dentro de la cadena utilizando la sintaxis `{expresión}`. Las expresiones se evalúan y su resultado se inserta en la cadena en tiempo de ejecución.

Por ejemplo:
//C#
int edad = 25;
string nombre = "Juan";

// Interpolación de cadenas con $
string mensaje = $"Mi nombre es {nombre} y tengo {edad} años.";

Console.WriteLine(mensaje); // Salida: Mi nombre es Juan y tengo 25 años.
//C#FIN

En el ejemplo anterior, las variables `nombre` y `edad` se insertan dentro de la cadena utilizando la interpolación de cadenas con el carácter `$`. Esto evita la necesidad de concatenar cadenas manualmente y hace que el código sea más legible.