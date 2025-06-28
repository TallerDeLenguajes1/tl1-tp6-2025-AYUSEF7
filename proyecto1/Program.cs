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

//Ejercicio 3

Console.WriteLine("Ingrese un número: ");
string entrada1 = Console.ReadLine();
float numero3;

if (float.TryParse(entrada1, out numero3)){
    Console.WriteLine("\n--- Operaciones Matemáticas ---");

    Console.WriteLine($"Valor absoluto: {Math.Abs(numero3)}");                      //valor absoluto
    Console.WriteLine($"Cuadrado: {Math.Pow(numero3, 2)}");                         //potencia al cuadrado
    if (numero3 >= 0)                                                               //raiz cuadrada
        Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero3)}");
    else
        Console.WriteLine("Raíz cuadrada: No definida para negativos");
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
