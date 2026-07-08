//  Condicionales y Operadores Lógicos
// Aca lo que vamos a ver son los condicionales y operadores logicos, que nos van a permitir tomar decisiones en nuestro programa.

//Estos son If , Else If y Else, que nos permiten tomar decisiones en nuestro programa.
//Tambien tenemos el Switch, que nos permite tomar decisiones en nuestro programa de una manera mas ordenada y legible.

/*
IF:
Permite ejecutar un bloque de código si una condición es verdadera.

ELSE IF:
Permite evaluar otra condición si la anterior fue falsa.

ELSE:
Se ejecuta cuando ninguna condición anterior se cumple.
*/

//Ejemplo de If, Else If y Else
int edadPersona1 = 18;
int edadPersona2 = 20;

if (edadPersona1 > edadPersona2)
{
    Console.WriteLine("La persona 1 es mayor que la persona 2");
}
else if (edadPersona1 < edadPersona2)
{
    Console.WriteLine("La persona 1 es menor que la persona 2");
}




//_Ahora vamos con un ejemplo distinto:
edadPersona1 = 18;
edadPersona2 = 18;

if (edadPersona1 >= edadPersona2)
{
    Console.WriteLine("La persona 1 es mayor o igual que la persona 2");
}
else if (edadPersona1 == edadPersona2)
{
    Console.WriteLine("La persona 1 es igual a la persona 2");
}

// Vamos con un ejemplo con string

string sexoPersona1 = "Hombre";

if ((edadPersona1 > edadPersona2) && (sexoPersona1 == "Hombre"))
{
    Console.WriteLine("La persona 1 es mayor que la persona 2 y es hombre");
}
else if ((edadPersona1 < edadPersona2) || (sexoPersona1 == "Hombre"))
{
    Console.WriteLine("La persona 1 es menor que la persona 2 y es hombre");
}

// Vamos con otro ejercicio 

int x = 10;
int y = 5;
int z = 3;

// Queremos que se cumpla: 
// (x > 5 && y < 10 && z == 3))
if (x > 5 && y < 10 && z == 3)
{
    Console.WriteLine("Se cumple la condición");
}
else
{
    Console.WriteLine("No se cumple la condición");
}


// Vamos con otro ejemplo, pero ahora con el operador de negación (!)
string sexo = "hombre";
if (sexo != "hombre")
{
    Console.WriteLine("No es hombre");
}
else
{
    Console.WriteLine("Es hombre");
}

//Ahora probamos con el operador booleano
bool usuarioAlta = true;
if (usuarioAlta)
{
    Console.WriteLine("El usuario esta dado de alta");
}
else
{
    Console.WriteLine("El usuario no esta dado de alta");
}


bool usuarioPremium = false;

if(usuarioAlta && usuarioPremium)
{
    //
}

string nacionalidad = "Argentino";

if (nacionalidad == "Uruguayo")
{
    Console.WriteLine("El usuario es de Uruguayo");
}

else if (nacionalidad == "Argentino")
{
    Console.WriteLine("El usuario es de Argentino");
}

else if (nacionalidad == "Español")
{
    Console.WriteLine("El usuario es de Español");
}

else
{
    Console.WriteLine("El usuario es de nacionalidad desconocida");
}

//Ahora vamos a ver el Switch, que nos permite tomar decisiones en nuestro programa de una manera mas ordenada y legible.
nacionalidad = "Dominicano";
switch (nacionalidad)
{
    case "Uruguayo":
        Console.WriteLine("El usuario es de Uruguayo");
        break;
    case "Argentino":
        Console.WriteLine("El usuario es de Argentino");
        break;
    case "Español":
        Console.WriteLine("El usuario es de Español");
        break;
    default:
        Console.WriteLine("El usuario es de nacionalidad desconocida");
        break;
}

//Escribe un programa que ingrese por teclado la edad, el nombre y el sexo
//Si es mayor de 18 y es hombre, que muestre Felicidades NOMBRE_AQUI eres un hombre y mayor de edad
//Si es mayor de 18 y es mujer, que muestre Felicidades NOMBRE_AQUI eres una mujer y mayor de edad
//sino se cumple ninguna de las condiciones anteriores, que muestre: "eres menor"
//Programa que busque en la cadena "esto es una cadena de prueba porque estoy empezando a programar en Csharp" las palabras prueba y programar
// si lo encuentra que imprima por pantalla "Encontrado"

