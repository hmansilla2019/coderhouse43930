// See https://aka.ms/new-console-template for more information

// crear un arrar defininiendo su indice
using EjemplosArray;

string[] productosArray = new string[5];

productosArray[0] = "Notebook";
productosArray[1] = "Auriculares";
productosArray[2] = "Parlantes";
productosArray[3] = "Monitor";
productosArray[4] = "Teclado";

int[] iCantidadStock = new[] { 50, 100, 500, 200, 0 };


for (int i = 0; i < productosArray.Length; i++)
{
    Console.WriteLine("Producto: " + productosArray[i]);
}


for (int i = 0; i < iCantidadStock.Length; i++)
{
    Console.WriteLine("Stock: " + iCantidadStock[i]);
}


Producto[] arrayProductObject = new Producto[5];

Producto miProducto = new Producto();
miProducto.NombreProducto = "Computadora";
miProducto.CantidadStock = 100;

arrayProductObject[0] = miProducto;

miProducto = new Producto();
miProducto.NombreProducto = "Monitor";
miProducto.CantidadStock = 0;

arrayProductObject[1] = miProducto;

miProducto = new Producto();
miProducto.NombreProducto = "Teclado";
miProducto.CantidadStock = 20;

arrayProductObject[2] = miProducto;

miProducto = new Producto();
miProducto.NombreProducto = "Mouse";
miProducto.CantidadStock = 80;

arrayProductObject[3] = miProducto;

miProducto = new Producto();
miProducto.NombreProducto = "Auricular";
miProducto.CantidadStock = 50;

arrayProductObject[4] = miProducto;

foreach (Producto item in arrayProductObject)
{
    Console.WriteLine("Producto " + item.NombreProducto + " Stock " + item.CantidadStock);
}

Console.ReadKey();




