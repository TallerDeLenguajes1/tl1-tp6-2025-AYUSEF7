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
