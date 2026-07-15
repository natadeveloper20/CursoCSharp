//Bucles - 3 Parte del curso de C# - 2026


//Empezamos primero mostrando el uso de un contador, que es una variable que nos permite contar cuantas veces se ha ejecutado un bucle, o cuantas veces se ha realizado una acción.
int contador = 0;

Console.WriteLine(contador);

contador = contador + 1;
contador = contador + 1;

Console.WriteLine(contador);

contador++;
Console.WriteLine(contador);

//Ahora vamos a ver el bucle For

for (int i = 0; i < 5; i++)
{
    int valorDeI = i;
    Console.WriteLine($"Valor de i: {i}");
}

//Ahora vamos a ver el bucle While

int j = 0;
while(j < 5)
{
    Console.WriteLine($"Valor de j: {j}");
    j++;
}

//Ahora vamos a ver Do While
int k = 0;
do
{
    Console.WriteLine($"Valor de k: {k}");
    k++;
} while (k < 5);

//Ejercicio 1:
//Desafio bucle for, hasta 10 y que indique si el numero (el incremento) en cuestion es par o no 
//Para saber si es par el numero, usa el operador %2, es decir numero %2 == 0, esto retorna true si es par, false si es impar.

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"El numero {i} es par");
        
    }
    else
    {
        Console.WriteLine($"El numero {i} es impar");
        
    }
}

