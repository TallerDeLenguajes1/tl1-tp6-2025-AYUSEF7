// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); 
int a; 
int b; 
a=10;
b=a; 
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b); 

//Ejercicio 1
Console.WriteLine("Ingrese un numero");
string entrada = Console.ReadLine();
int numero;

if (int.TryParse(entrada, out numero)){                             //verifico si es un numero entero
    Console.WriteLine("Es un numero valido.");

    if (numero > 0){
        int invertido = 0;

        while (numero > 0){
            int digito = numero % 10;
            invertido = (invertido * 10) + digito;
            numero = numero / 10;
        }

        Console.WriteLine("Número invertido: " + invertido);
        
    } else {
        Console.WriteLine("El número debe ser mayor que 0.");
    }
}
else{
    Console.WriteLine("La entrada no es un número válido.");
}

//Ejercicio 2

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n--- Calculadora Basica ---");
    Console.Write("Seleccione una opcion (1-4): ");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    string opcion = Console.ReadLine();

    Console.Write("Ingrese el primer numero: ");
    string e1 = Console.ReadLine();
    int numero1;
    bool resultado1 = int.TryParse(e1, out numero1);

    Console.Write("Ingrese el segundo numero: ");
    string e2 = Console.ReadLine();
    int numero2;
    bool resultado2 = int.TryParse(e2, out numero2);

    double resultadoC1 = 0;
    bool valido = true;

    switch (opcion)
    {
        case "1":
            resultadoC1 = numero1 + numero2;
            break;
        case "2":
            resultadoC1 = numero1 - numero2;
            break;
        case "3":
            resultadoC1 = numero1 * numero2;
            break;
        case "4":
            if (numero2 != 0){
                resultadoC1 = numero1 / numero2;
            } else {
                Console.WriteLine("No se puede dividir por cero.");
            }
            break;
        default:
            Console.WriteLine("Opción inválida.");
            valido = false;
            break;
    }

    if (valido)
    {
        Console.WriteLine("Resultado: " + resultadoC1);
    }

    Console.Write("¿Desea realizar otra operacion?\nSI[1]\nNO[0] ");
    string siOno = Console.ReadLine();
    if (siOno == "1"){
        continuar = true;
    } else {
        continuar = false;
    }
}

//Ejercicio 3

Console.WriteLine("Ingrese un número: ");
string entrada1 = Console.ReadLine();
float numero3;

if (float.TryParse(entrada1, out numero3)){
    Console.WriteLine("\n--- Operaciones Matemáticas ---");

    Console.WriteLine($"Valor absoluto: {Math.Abs(numero3)}");                      //valor absoluto
    Console.WriteLine($"Cuadrado: {Math.Pow(numero3, 2)}");                         //potencia al cuadrado

    if (numero3 >= 0){                                                              //raiz cuadrada
        Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero3)}");
    } else {
        Console.WriteLine("Raíz cuadrada: No definida para negativos");
    }
        
    Console.WriteLine($"Seno: {Math.Sin(numero3)}");                                //seno
    Console.WriteLine($"Coseno: {Math.Cos(numero3)}");                              //coseno
    Console.WriteLine($"Parte entera (truncate): {Math.Truncate(numero3)}");        //La parte entera de un tipo float.
    
} else {
    Console.WriteLine("No ingresó un número válido.");
    return;
}

Console.WriteLine("\nIngrese el primer número: ");
string entrada2 = Console.ReadLine();
float n1;

Console.WriteLine("Ingrese el segundo número: ");
string entrada3 = Console.ReadLine();
float n2;


if (float.TryParse(entrada2, out n1) && float.TryParse(entrada3, out n2)){          //control de que los 2 sean digitos
    Console.WriteLine("\n--- Comparación ---");

    Console.WriteLine($"Máximo: {Math.Max(n1, n2)}");
    Console.WriteLine($"Mínimo: {Math.Min(n1, n2)}");
} else {
    Console.WriteLine("Uno o ambos valores no son válidos.");
}

//Ejercicio 4

//Ingreso de la cadena original
Console.WriteLine("Ingrese una cadena de texto: ");
string cadena1 = Console.ReadLine();

//Mostrar longitud
Console.WriteLine($"Longitud de la cadena: {cadena1.Length}");

//Concatenar con otra cadena
Console.WriteLine("Ingrese una segunda cadena para concatenar: ");
string cadena2 = Console.ReadLine();

string concatenada = cadena1 + " " + cadena2;
Console.WriteLine("Cadenas concatenadas: " + concatenada);

//Extraer subcadena
if (cadena1.Length >= 3){
    string subcadena = cadena1.Substring(0, 3);                                     // Extrae los primeros 3 caracteres(posicion 0,1,2)
    Console.WriteLine("Subcadena (primeros 3 caracteres): " + subcadena);
} else {
    Console.WriteLine("La cadena es muy corta para extraer una subcadena de 5 caracteres.");
}

//Operación matemática y resultado en texto
Console.WriteLine("Ingrese el primer número: ");
string ingreso1 = Console.ReadLine();
Console.WriteLine("Ingrese el segundo número: ");
string ingreso2 = Console.ReadLine();

int num1, num2;
if (int.TryParse(ingreso1, out num1) && int.TryParse(ingreso2, out num2))
{
    int suma = num1 + num2;
    Console.WriteLine("La suma de " + num1.ToString() + " y de " + num2.ToString() + " es igual a: " + suma.ToString());
}
else
{
    Console.WriteLine("Error: uno de los valores ingresados no es un número válido.");
}

//Recorrer la cadena con foreach
Console.WriteLine("Caracteres de la primera cadena:");
foreach (char caracter in cadena1){
    Console.WriteLine(caracter);
}

//Buscar una palabra dentro de la cadena
Console.WriteLine("Ingrese una palabra a buscar en la primera cadena: ");
string palabra = Console.ReadLine();
if (cadena1.Contains(palabra)){
    Console.WriteLine($"La palabra \"{palabra}\" fue encontrada en la cadena.");
} else {
    Console.WriteLine($"La palabra \"{palabra}\" NO fue encontrada.");
}

//Convertir a mayúsculas y minúsculas
Console.WriteLine("En mayusculas: " + cadena1.ToUpper());
Console.WriteLine("En minusculas: " + cadena1.ToLower());

//Separar con Split()
Console.WriteLine("Ingrese una cadena separada por comas (,): ");
string cadenaConSeparador = Console.ReadLine();

string[] partes = cadenaConSeparador.Split(',');
Console.WriteLine("Elementos separados:");
foreach (string parte in partes){
    Console.WriteLine(parte);
}

//Resolver ecuación simple tipo "582+2"
Console.WriteLine("Ingrese una ecuación simple (por ejemplo 582+2): ");
string ecuacion = Console.ReadLine();

int nro1, nro2;

if (ecuacion.Contains("+")){
    string[] elementos = ecuacion.Split('+');
    if (int.TryParse(elementos[0], out nro1) && int.TryParse(elementos[1], out nro2)){
        Console.WriteLine($"Resultado de la suma: {nro1 + nro2}");
    }
}
else if (ecuacion.Contains("-")){
    string[] elementos = ecuacion.Split('-');
    if (int.TryParse(elementos[0], out nro1) && int.TryParse(elementos[1], out nro2)){
        Console.WriteLine($"Resultado de la resta: {nro1 - nro2}");
    }
}
else if (ecuacion.Contains("*")){
    string[] elementos = ecuacion.Split('*');
    if (int.TryParse(elementos[0], out nro1) && int.TryParse(elementos[1], out nro2)){
        Console.WriteLine($"Resultado de la multiplicación: {nro1 * nro2}");
    }
}
else if (ecuacion.Contains("/")){
    string[] elementos = ecuacion.Split('/');
    if (int.TryParse(elementos[0], out nro1) && int.TryParse(elementos[1], out nro2)){
        if (nro2 != 0) {
            Console.WriteLine($"Resultado de la división: {(double)nro1 / nro2}");
        } else {
            Console.WriteLine("Error: no se puede dividir por cero.");
        }
    }
} else {
    Console.WriteLine("No se reconoció ningún operador válido (+, -, *, /).");
}