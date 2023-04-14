// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Mundo!");

// Variables
// Declaracion
// tipo nombre[="HUGO"];
string sNombre;
int iEdad;

Console.WriteLine("Ingrese su nombre");

// Asignacion
sNombre = Console.ReadLine();

Console.WriteLine("Ingrese su Edad");

// Asignacion
//iEdad = int.Parse(Console.ReadLine());
iEdad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bienvenido " + sNombre);

Console.ReadKey();
// siguiente instruccion
