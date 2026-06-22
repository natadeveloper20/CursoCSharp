// See https://aka.ms/new-console-template for more information



///1 introduccion a Variables y Tipos de Datos
//
//Primero empezamos con lo básico, imprimir un mensaje en la consola.

Console.WriteLine("Hello, World!");
/*
///Declaración y uso de variables

//Ahora vamos a declarar una variable de tipo string y asignarle un valor.
string miCadena = "Hola esta es mi cadena";
Console.WriteLine(miCadena);

//Ahora vamos a cambiar los argumentos de la variable usando un empty string y luego asignarle un nuevo valor.
miCadena = string.Empty;
Console.WriteLine(miCadena);

//Ahora vamos a introduccir datos que el usuario ingrese por consola y luego imprimirlo.
Console.WriteLine("Meta su nombre por consola...");
string tuNombre = Console.ReadLine()!;



//Ahora vamos a declarar una variable de tipo int pero usando un convert y asignarle un valor.
Console.WriteLine("Escribe tu edad por consola...");
string entradaEdad = Console.ReadLine()!;
int edad = Convert.ToInt32(entradaEdad);
Console.WriteLine("Tu Nombres es: " + tuNombre + "Tu edad es: " + edad); 
*/


//En este ejercicio vamos a concatenar dos variables de tipo string y luego imprimirlo en la consola.
string nombre = "Juan";
string apellido = "Perez";

//el console.writeline es para imprimmir en consola.
Console.WriteLine (nombre + " " + apellido);


//-------------------



//1) ..............Tipos de datos = Numeros...............
/*
//Declaramos una variable de tipo int y le asignamos un valor.
int numero1 = 10;
int numero2 = 20;
int resultado = numero1 + numero2;
Console.WriteLine("La suma de " + numero1 + " y " + numero2 + " es igual a: " + resultado);

Console.WriteLine(numero1 - numero2);
Console.WriteLine(numero1 * numero2);
Console.WriteLine(numero1 / numero2);

//Ahora vamos a convertir un string a un int usando el metodo Convert.ToInt32() y luego imprimirlo en la consola.
Console.WriteLine("Escribe un numero por consola...");  
string num1 = "10";
string num2 = "20";
int resultadoparseo = Convert.ToInt32(num1) + Convert.ToInt32(num2);
Console.WriteLine("La suma de " + num1 + " y " + num2 + " es igual a: " + resultadoparseo);

--------------------------


/*
//Ahora vamos a hacer los tipos de datos de: float, double y decimal y luego imprimirlo en la consola.
float f = 1f / 3f;
double d = 1d / 3d;
decimal m = 1m / 3m;

Console.WriteLine($"float: {f}");
Console.WriteLine($"double: {d}");
Console.WriteLine($"decimal: {m}");

//Ahora vamos hacer un ejercicio de finanzas para poner en practica los tipos de datos de float, double y decimal.

decimal salario = 1205.25m;
decimal aumentoSalarial = 10.10m;

Console.WriteLine("Aumento (Mal Hecho) " + salario + aumentoSalarial);

float resultadoFinal = (float) (salario + aumentoSalarial);

Console.WriteLine("Aumento (Bien Hecho) " + resultadoFinal);

*/


/*

//Ahora vamos hacer ejercicios de Bool y Var

bool esMayorDeEdad = false;
Console.WriteLine(esMayorDeEdad);

//Ahora vamos a cambiar el valor de la variable bool a true y luego imprimirlo en la consola.
esMayorDeEdad = true;
Console.WriteLine(esMayorDeEdad);

//Ahora vamos a mostrar y explicar sobre los tipos de datos de Var.

var variableCualquiera = "Una candena cualquiera";  

var edad = 23; 

var floatVar = 1f; 

var esMayor = true;

*/



/*
Ejercicio: Escribir un programa que pida 2 numeros por pantalla, luego los sume y muestre el resultado (Tienes que convertir el string a int)

El siguiente ejercicio es igual que el anterior pero que sean tres numeros. 

*/

//Ahora vamos a hacer el ejercicio de los dos numeros.

Console.WriteLine("Escribir el primer numero por consola...");
string num1 = Console.ReadLine()!;
Console.WriteLine("Escribir el segundo numero por consola...");
string num2 = Console.ReadLine()!;
int resultadoSuma = Convert.ToInt32 (num1) + Convert.ToInt32(num2);
Console.WriteLine("La suma de " + num1 + " y " + num2 + " es igual a: " + resultadoSuma);

//Ahora el ejercicio de los tres numeros.

Console.WriteLine("Escribir el tercer numero por consola...");
string num3 = Console.ReadLine()!;
int resultadoSuma3 = Convert.ToInt32(num1) + Convert.ToInt32(num2) + Convert.ToInt32(num3);
Console.WriteLine("La suma de " + num1 + ", " + num2 + " y " + num3 + " es igual a: " + resultadoSuma3);
