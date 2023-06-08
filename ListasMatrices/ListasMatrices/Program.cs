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

Producto producto = new Producto();

List<Producto> lista = new List<Producto>();

lista = producto.ListarProductos();

foreach (var item in lista)
{
    Console.WriteLine("Id: " + item.Id);

    Console.WriteLine("Descripcion: " + item.Descripciones);

    Console.WriteLine("Costo: " + item.Costo);

    Console.WriteLine("PrecioVenta: " + item.PrecioVenta);

    Console.WriteLine("Id: " + item.Id);

    Console.WriteLine("Id: " + item.Id);


}



Console.ReadKey();
