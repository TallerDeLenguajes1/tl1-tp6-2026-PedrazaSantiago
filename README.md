## 1. ¿`strin` es un tipo por valor o un tipo por referencia?

El tipo string en C# es un tipo por referencia. Esto significa que la variable no almacena el texto directamente, sino que guarda una dirección de memoria

## 2. ¿Qué secuencias de escape tiene el tipo string?

Las secuencias de escape más importantes en C# son:

\n  Inserta un salto de linea 
\t Inserta una tabulación horizontal 
\ Permite introducir una comilla doble dentro de la cadena sin cerrarla
\\ Muestra una barra invertida 
\0 Representa el caracter nulo, utilizado para indicar el fin de una cadena
\ Permite introducir una comilla simple

## 3. ¿Qué sucede cuando se utiliza el carácter @ y $ antes de una cadena de texto?

El caracter @ le indica al compilador que ignore todas las secuencias de escape y procese el texto exactamente de la forma en que está escrito.
El caracter $ habilita la interpolacion de cadenas, permitiendo incrustar variables, constantes o expresiones de C# directamente dentro del texto utilizando llaves {}
