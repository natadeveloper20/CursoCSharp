// 4 Estructuras de Datos


//Aca le llamamos arrays
string[] numeros = {"Manzana", "Banana", "Cereza"};

/*
Console.WriteLine(numeros[0]);
Console.WriteLine(numeros[1]);
Console.WriteLine(numeros[2]);
*/

// Ahora vamos a recorrer el array con un bucle for
for  (int   i = 0 ; i < 3; i++)
{
    Console.WriteLine(numeros[i]);
}

//Vamos con otro ejemplo, ahora con un array de enteros
int [] edades = {25, 5, 10, 2};

//Ahora le agregamos un contador para sumar las edades
int edadAcumulada = 0;
for (int i = 0; i < edades.Length; i++)
{
    edadAcumulada += edades[i];
}
Console.WriteLine("La suma de las edades es: " + edadAcumulada);

//Ahora vamos a cambiar el valor de un elemento del array
edades[2] = 125;
//Primero en corchetes va el indice del elemento que queremos cambiar, y luego le asignamos el nuevo valor
Console.WriteLine(edades[2]);

//Ahora vamos a recorrer el array con un bucle for, pero esta vez vamos a usar la propiedad Length del array para determinar el número de elementos

for (int i = 0; i < edades.Length; i++)
{
    Console.WriteLine(edades[i]);
}

//Ahora vamos con listas, que son un tipo de estructura de datos más flexible que los arrays


List<string> nombres = new List<string>();
nombres.Add("Ana");
nombres.Add("Luis");
nombres.Add("Carlos");

//Ahora vamos a mostrar en pantalla la posicion de un elemento de la lista, en este caso el elemento "Carlos"
Console.WriteLine(nombres[2]);

//Si quiere remover un elemento de la lista, podemos usar el método Remove, que recibe como parámetro el elemento que queremos eliminar

if (nombres.Contains("Carlos"))
{
    nombres.Remove("Carlos");
}


//nombres.Clear();

//Ahora vamos a recorrer la lista con un bucle foreach, que es más sencillo que el bucle for, ya que no necesitamos un contador
List<string> cantantes = new List<string>();
cantantes.Add("Maddona");
cantantes.Add("Ceratti");

List<string> personas = new List<string>();
personas.AddRange(cantantes);
personas.AddRange(nombres);

Console.WriteLine("Fin de la listas");

foreach (string nombre in personas)
{
    Console.WriteLine($"personas: {nombre}");
}

//Ahora vamos a ver la capacidad de la lista, que es el número de elementos que puede contener antes de tener que redimensionarse
int elementosEnLista = personas.Capacity;
Console.WriteLine($"La capacidad de la lista es: {elementosEnLista}");
//Ahora damos una limpieza a la lista, para que quede vacía y podamos ver que la capacidad de la lista sigue siendo la misma
personas.Clear();

//Ahora vamos a ver los diccionarios, que son una estructura de datos que nos permite almacenar pares de clave-valor, donde cada clave es única y se utiliza para acceder a su valor correspondiente
Dictionary<string, int> edadesPersonas = new Dictionary<string, int>();

edadesPersonas["Ana"] = 30;
edadesPersonas["Luis"] = 25;
edadesPersonas["Carlos"] = 28;
edadesPersonas["Ana"] = 31;

edadesPersonas.Add("Ana cabrera", 58);
//edadesPersonas.Add("Ana cabrera", 58); // Esto nos va a dar un error, ya que la clave "Ana cabrera" ya existe en el diccionario

Dictionary<string, List<double>> notasEstudiantes = new Dictionary<string, List<double>>();
notasEstudiantes.Add("Ana", new List<double> { 8.5, 9.0, 6.5 });
notasEstudiantes.Add("Luis", new List<double> { 4.0, 6.0, 9.5 });

//Ahora vamos a declarar una lista de notas para un estudiante llamado Carlos, y luego vamos a agregar esa lista las notas de carlos
List<double> notasCarlos = new List<double>();
notasCarlos.Add(5);
notasCarlos.Add(5.2);
notasCarlos.Add(7.2);


//Ahora vamos a sacar el promedio con un bucle foreach, recorriendo el diccionario de notasEstudiantes, y para cada estudiante vamos a recorrer su lista de notas, sumando las notas y dividiendo entre el número de notas para sacar el promedio

double promedioCarlos  = notasCarlos.Average();

notasEstudiantes["Carlos"] = notasCarlos;

foreach (var estudiante in notasEstudiantes)
{
    double promedio = estudiante.Value.Average();
    Console.WriteLine($"El promedio de {estudiante.Key} es: {promedio}");
}
