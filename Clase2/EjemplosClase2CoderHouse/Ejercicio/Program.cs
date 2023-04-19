// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

const int iContrasenia = 12345678;
//int iContraseniaIngresada = 0;
Console.WriteLine("Ingrese su Contraseña");
//iContraseniaIngresada = int.Parse(Console.ReadLine());

if (iContrasenia == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Bienvenido");
}
else
{
    Console.WriteLine("Ingrese su Contraseña Nuevamente");
   // iContraseniaIngresada = int.Parse(Console.ReadLine());
    if (iContrasenia == int.Parse(Console.ReadLine()))
    {
        Console.WriteLine("Bienvenido");
    }
    else
    {
        Console.WriteLine("Debe reiniciar el sistema");
    }
}

Console.ReadKey();


