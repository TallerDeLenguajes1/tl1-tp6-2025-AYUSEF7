[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

_¿string es un tipo por valor o un tipo por referencia?
string es un tipo por referencia en C#, porque internamente es un objeto.
Sin embargo, se comporta como si fuera por valor porque es inmutable: cada vez que se modifica, se crea una nueva cadena en memoria.

_¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape son combinaciones que empiezan con \ y representan caracteres especiales dentro de un string. Algunas comunes son:

Secuencia	Significado
    \n	    Nueva línea (salto de línea)
    \t	    Tabulación (tab)
    \\	    Barra invertida (\)
    \"	    Comilla doble (")
    \'	    Comilla simple (')
    \r	    Retorno de carro
    \b	    Retroceso (backspace)
    \0	    Fin de cadena (null)

_¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
@: permite usar cadenas literales, sin interpretar secuencias de escape (\n, \t, etc.). Muy útil para rutas de archivos:
string ruta = @"C:\Users\Alvaro\Documentos";

$: habilita interpolación de cadenas, o sea, permite insertar variables dentro del texto:
int edad = 25;
string mensaje = $"Tengo {edad} años.";

🔁 Se pueden combinar @$ o $@:
string nombre = "Ana";
string ruta = @$"C:\Usuarios\{nombre}\Documentos";