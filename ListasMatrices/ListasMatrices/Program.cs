//// Listas
//// Declaracion
//List<string> productos = new List<string> { "Gaseosa", "Galletitas", "Aceite" };

//// Add: Agrega un elemento a la lista
//productos.Add("Pan");
//productos.Add("Leche");
//Console.WriteLine("La lista de productos tiene " + productos.Count);

//List<int> precios = new List<int>();

//// Add: Agrega un elemento a la lista
//precios.Add(100);
//precios.Add(200);
//precios.Add(300);
//precios.Add(100);
//precios.Add(500);
//Console.WriteLine("La lista de precios tiene " + precios.Count);


//// Remove: Elimina la primera ocurrencia
//precios.Remove(100);
//Console.WriteLine("La lista de precios tiene " + precios.Count);

//// Clear: Elimina todos los elementos de una lista
////productos.Clear();

//// Count: Cantidad de elementos de una lista
//Console.WriteLine("La lista de Productos tiene " + productos.Count);

//// Insert: Enserto en una posicion determinada un objeto
//precios.Insert(2, 1000);
//Console.WriteLine("El Objeto de la posicion 2 es " + precios[2].ToString());


//// Ordenar las listas
//precios.Sort();
//productos.Sort();
//Console.WriteLine("Lista de productos");
//foreach (var producto in productos)
//{
//    Console.WriteLine(producto);
//}

//Console.WriteLine("Lista de precios");
//foreach (var precio in precios)
//{
//    Console.WriteLine(precio);
//}

using ListasMatrices;
List<Producto> productos = new List<Producto>();
Producto producto = new Producto();

producto.Descripcion = "Leche";
producto.Precio = 500;

productos.Add(producto);

productos.Add(new Producto() { Descripcion="Agua", Precio=1000 });
productos.Add(new Producto() { Descripcion = "Pan", Precio = 700 });
productos.Add(new Producto() { Descripcion = "Aceite", Precio = 1200 });
productos.Add(new Producto("Fideos", 600));
productos.Add(new Producto("Tomate", 800));
productos.Add(new Producto("Gaseosa", 700));


Console.WriteLine("Primera Lista");
foreach (var item in productos)
{
    Console.WriteLine("Descripcion: " + item.Descripcion + " - Precio: " + item.Precio.ToString());
}



Producto[] producto2 =
{
    new Producto() { Descripcion="Coca Cola", Precio=700 },
    new Producto() { Descripcion="Cigarrillos", Precio=1200 },
    new Producto() { Descripcion="Naranja", Precio=500 },
    new Producto() { Descripcion="Fosforos", Precio=300 }
};

Producto productoLista = new Producto();
productoLista.InsertarEnLista(producto2);


Console.WriteLine("Segunda Lista");
foreach (var item in productoLista.Productos)
{
    Console.WriteLine("Descripcion: " + item.Descripcion + " - Precio: " + item.Precio.ToString());
}

Console.WriteLine("Tercera Lista");
List<Producto> productosList = producto2.ToList();
foreach (var item in productosList)
{
    Console.WriteLine("Descripcion: " + item.Descripcion + " - Precio: " + item.Precio.ToString());
}


Console.WriteLine("Cuarta Lista");
Producto[] productoArray = productosList.ToArray();
foreach (var item in productoArray)
{
    Console.WriteLine("Descripcion: " + item.Descripcion + " - Precio: " + item.Precio.ToString());
}









Console.ReadKey();
