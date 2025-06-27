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
bool resultado = int.TryParse(entrada, out numero);

if (resultado){                                                 //verifico si es un numero entero
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
    string entrada1 = Console.ReadLine();
    int numero1;
    bool resultado1 = int.TryParse(entrada1, out numero1);

    Console.Write("Ingrese el segundo numero: ");
    string entrada2 = Console.ReadLine();
    int numero2;
    bool resultado2 = int.TryParse(entrada2, out numero2);

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
            if (numero2 != 0) {
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

    if (valido){
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