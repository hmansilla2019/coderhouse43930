// See https://aka.ms/new-console-template for more information
short sEdad;

// Hacer un progama que el usuario ingrese la edad y si es mayor o igual a
// 18 Indicar que es mayor de edad
Console.WriteLine("Ingrese su Edad");
sEdad = short.Parse(Console.ReadLine());

if (sEdad>=18) Console.WriteLine("Es Mayor de Edad");

// Hacer un programa donde se ingrese la edad
// Si es mayor o igual a 18 indicar Es Mayor de Edad
// Si es menor de 18 indicar que es Menor de Edad

if (sEdad < 18) Console.WriteLine("Es menor de Edad");
else Console.WriteLine("Es mayor de Edad");

// Si es mayor a 18 y a su vez es mayor que 60 "Es Jubilado"
// si es menor a 18 y ademas > 16 Puede Conducir
// si es menor a 10 es un niño
if (sEdad >= 18)
{
	if (sEdad > 65)
	{
		Console.WriteLine("Es Mayor de Edad y Es Jubilado");
	}
	else
	{
		Console.WriteLine("Es Mayor de Edad");
	}
}
else if (sEdad > 16)
	Console.WriteLine("Es menor de edad pero puede conducir");
else if (sEdad < 10)
	Console.WriteLine("Es un niño");

// 

float fSueldoBasico;
float fSalario =0f; // La suma del salario por esposa/o y los hijos
float fSueldoBruto; // sueldo basico + Salario
float fSueldoNeto; // sueldo bruto - impuesto
short sCantidadHijos;
char cEstadoCivil;

// si el sueldo basico es mayor a 100.000 restarle 10000 de Impuesto
// Si es Casado (C) sumarle al sueldo 1000 Salario por esposo/a
// Si tiene Hijos, por cada Hijo , sumarle 500
//  Calcular el sueldo bruto (sueldo basico + Salario)
// y el sueldo Neto (sueldo bruto - impuesto)

Console.WriteLine("Ingrese su Sueldo Basico");
fSueldoBasico = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese Estado Civil Si es Casado Ingrese (C) y si es Soltero (S)");
cEstadoCivil = char.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de Hijos");
sCantidadHijos = short.Parse(Console.ReadLine());

//if (cEstadoCivil == char.Parse("C"))
//{
//	fSalario = 1000f;
//	if (sCantidadHijos>0)
//	{
//		fSalario += sCantidadHijos * 500f;
//	}
//}
//else
//{
//    if (sCantidadHijos > 0)
//    {
//        fSalario += sCantidadHijos * 500f;
//    }
//}

if (cEstadoCivil == char.Parse("C") && sCantidadHijos > 0)
{
    fSalario += 1000f + sCantidadHijos * 500f;
}
else
{
	if (sCantidadHijos > 0)
	{
		fSalario += sCantidadHijos * 500f;
	}
	else if (cEstadoCivil == char.Parse("C"))
		fSalario += 1000f;
}

fSueldoBruto = fSueldoBasico + fSalario;

fSueldoNeto = fSueldoBruto;

if (fSueldoBasico>100000)
{
	fSueldoNeto = fSueldoBruto - 10000;
}


Console.WriteLine("El sueldo Basico es " + fSueldoBasico);

Console.WriteLine("El salario Familiar es " + fSalario);

Console.WriteLine("El sueldo Bruto es " + fSueldoBruto);


Console.WriteLine("El sueldo Neto es " + fSueldoNeto);


int iNumero1=5, iNumero2=6;
int iSuma = 5 + 3;
Console.WriteLine("La suma  de {0} y {2} es {0}",iNumero1,iNumero2, iSuma);


Console.ReadKey();






