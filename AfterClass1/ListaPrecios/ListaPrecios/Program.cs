// See https://aka.ms/new-console-template for more information


using System.Xml.Schema;

float precioMaximoVenta = 0;
float precioMinimoVenta = 0;
float sumaPrecioVenta = 0;
float promedioPrecioVenta = 0;
// 20 Articulos
for (int i = 0; i < 3; i++)
{  // 1 Articulo
    // Datos que ingresa el usuario
    int codigo = 0;
    string descripcion=string.Empty;
    float precioUnitario = 0;
    string condicionIva=string.Empty;
    float porcentajeDescuento = 0;

    // Datos Calculados
    float montoDescuento = 0;
    float precioConDescuento = 0;
    float porcentajeIva = 0;
    float montoIva = 0;
    float precioSubtotal = 0;
    float porcentajeRentabilidad = 0;
    float montoRentabilidad = 0;
    float precioVenta = 0;

    // Cargar los datos
    Console.Write("Ingrese el Codigo del articulo: ");
    codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingrese la descripcion del articulo: ");
    descripcion = Console.ReadLine();
    
    Console.Write("Ingrese un precion Mayor a 0");
    precioUnitario = float.Parse(Console.ReadLine());
    while (precioUnitario<=0)
    {
        Console.Write("Ingrese un precion Mayor a 0");
        precioUnitario = float.Parse(Console.ReadLine());
    }
    Console.Write("Ingres Condicion Iva (E Exento I Responsable Inscripto NI Responsable no inscripto)");
    condicionIva = Console.ReadLine();


    Console.Write("Ingrese Descuento");
    porcentajeDescuento = float.Parse(Console.ReadLine());
    montoDescuento = CalcularMontoDescuento(porcentajeDescuento, precioUnitario);
    
    precioConDescuento = precioUnitario - montoDescuento;

    porcentajeIva = DeterminarPorcentajeIva(condicionIva);

    montoIva = CalcularMontoIva(precioConDescuento,porcentajeIva);

    precioSubtotal = precioConDescuento + montoIva;

    porcentajeRentabilidad = CalcularPorcentajeRentabilidad(precioUnitario);

    montoRentabilidad = CalcularMontoRentabilidad(precioSubtotal, porcentajeRentabilidad);

    precioVenta = precioSubtotal + montoRentabilidad;

    Console.WriteLine("El precio de venta es " + precioVenta);

    sumaPrecioVenta += precioVenta;
    if (precioVenta > precioMaximoVenta)
    {
        precioMaximoVenta = precioVenta;
    }

    if (precioMinimoVenta == 0)
    {
        precioMinimoVenta = precioVenta;
    }
    else if (precioVenta<precioMinimoVenta)
    {
        precioMinimoVenta = precioVenta;
    }

}

CalcularyMostrarEstadisticas(precioMaximoVenta,precioMinimoVenta,sumaPrecioVenta);

Console.ReadKey();





float CalcularMontoRentabilidad(float precioSubtotal, float porcentajeRentabilidad)
{
    return precioSubtotal * porcentajeRentabilidad / 100;
}

float CalcularPorcentajeRentabilidad(float pPrecioUnitario)
{
    float porcentaje = 0;
    if (pPrecioUnitario > 10000)
    {
        porcentaje = 30;
    }
    else if (pPrecioUnitario > 5000)
    {
        porcentaje = 35;
    }
    else
    {
        porcentaje = 40;
    }
    return porcentaje;
}

float CalcularMontoIva(float pPrecioConDescuento, float pPorcentajeIva)
{
    return pPrecioConDescuento * pPorcentajeIva / 100;
}

float DeterminarPorcentajeIva(string condicionIva)
{
    float porcentaje = 0;
    switch (condicionIva)
    {
        case "E":
            porcentaje = 0;
            break;
        case "I":
            porcentaje = 21;
            break;
        case "NI":
            porcentaje = 10.5f;
            break;
        default:
            porcentaje = 0;
            break;
    }
    return porcentaje;
}

float CalcularMontoDescuento(float pPorcentajeDescuento, float pPrecioUnitario)
{
    return pPrecioUnitario * pPorcentajeDescuento / 100;
}


float CalcularPromedioPrecioVenta(float sumaPrecioVenta, int cantidadArticulos)
{
    return sumaPrecioVenta / cantidadArticulos;
}


void CalcularyMostrarEstadisticas(float pPrecioMaximo, float pPrecioMinimo, float pSumaPrecioVenta)
{
    float promedioPrecioVenta = 0;
    Console.WriteLine("El precio Maximo es " + pPrecioMaximo);

    Console.WriteLine("El precio Minimo es " + pPrecioMinimo);

    promedioPrecioVenta = CalcularPromedioPrecioVenta(pSumaPrecioVenta, 20);

    Console.WriteLine("El promedio de precios es " + promedioPrecioVenta);

}



