// See https://aka.ms/new-console-template for more information
string sNombre;
string sApellido;
int iDNI;
int iEdad;
Double dAltura;
int iNumero1, iNumero2, iSuma;

const string sNombreComercio = "Supermercado Pepito";

Console.WriteLine(sNombreComercio);

Console.WriteLine("Ejercicio 1");

Console.WriteLine("Ingrese su Nombre");
sNombre = Console.ReadLine();

Console.WriteLine("Ingrese su Apellido");
sApellido = Console.ReadLine();

Console.WriteLine("Ingrese su DNI");
iDNI = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su EDAD");
iEdad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su Altura");
dAltura = double.Parse(Console.ReadLine());

Console.WriteLine("Sus datos son los siguientes verifique por favor");
Console.WriteLine("Nombre: " + sNombre);
Console.WriteLine("Apellido: " + sApellido);
Console.WriteLine("DNI: " + iDNI);
Console.WriteLine("Edad: " + iEdad);
Console.WriteLine("Altura: " + dAltura);


Console.WriteLine("Ejercicio 2");
Console.WriteLine("Ingrese primer numero");
iNumero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segundo numero");
iNumero2 = int.Parse(Console.ReadLine());

iSuma = iNumero1 + iNumero2;
Console.WriteLine("La suma es: " + iSuma);

// Console.WriteLine("La suma es: " + iNumero1 + iNumero2);


Console.WriteLine("Ejercicio 3");

Console.WriteLine(sNombre + " El Profe " + sApellido);


Console.ReadKey();
