// See https://aka.ms/new-console-template for more information

// Ingresar la nota de 10 alumnos
// Indicar cantidad de alumnos cuya nota es >= 7
// Indicar cantidad de alumnos cuya nota esta es >= 4 y menor a 7
// indicar cantidad de alumnos cuya nota es menor a 4
// Indicar promedio de notas del curso = suma de las notas / la cantidad de alumnos (10)

short sNota = 0;
short sCantidadMayorIgual7 = 0;
short sCantidadMayorIgual4 = 0;
short sCantidadMenor4 = 0;
const short cAlumnos = 10;
short sSumaNotas = 0;
float fPromedio = 0f;

short sCantidadAlumnos = 0;
short sContador = 1;

for (int i = 0; i < cAlumnos; i++)
{

	Console.WriteLine("Ingrese la nota");
	sNota = short.Parse(Console.ReadLine());
	if (sNota>=7)
	{
		sCantidadMayorIgual7++;
	}
	else if (sNota>=4)
	{
		sCantidadMayorIgual4++;
	}
	else
	{
		sCantidadMenor4++;
	}
	sSumaNotas += sNota;
    // sSumaNotas = sSumaNotas + sNota;
}

Console.WriteLine("Cantidad de alumnos con nota mayor igual a 7 :" + sCantidadMayorIgual7);

Console.WriteLine("Cantidad de alumnos con nota mayor igual a 4 :" + sCantidadMayorIgual4);

Console.WriteLine("Cantidad de alumnos con nota menor a 4 :" + sCantidadMenor4);

fPromedio = sSumaNotas / cAlumnos;

Console.WriteLine("El promedio es " + fPromedio);

Console.ReadKey();

// crear un programa donde ingresen la cantidad de notas que
// indique el docente y realizar la misma operacion

sNota = 0;
sCantidadMayorIgual7 = 0;
sCantidadMayorIgual4 = 0;
sCantidadMenor4 = 0;
sSumaNotas = 0;
fPromedio = 0f;

Console.WriteLine("Ingrese Cantidad de Alumnos");
sCantidadAlumnos = short.Parse(Console.ReadLine());

while (sContador<=sCantidadAlumnos)
{

    Console.WriteLine("Ingrese la nota");
    sNota = short.Parse(Console.ReadLine());
    if (sNota >= 7)
    {
        sCantidadMayorIgual7++;
    }
    else if (sNota >= 4)
    {
        sCantidadMayorIgual4++;
    }
    else
    {
        sCantidadMenor4++;
    }
    sSumaNotas += sNota;

    sContador++;
}

Console.ReadKey();