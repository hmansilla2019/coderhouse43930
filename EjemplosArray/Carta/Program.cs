// See https://aka.ms/new-console-template for more information


Dictionary<string, Dictionary<string, double>> menu = new Dictionary<string, Dictionary<string, double>>();

menu.Add("Bebidas", new Dictionary<string, double> {{ "Coca Cola", 100},
                                                    { "Seven Up",100 },
                                                    { "Fanta",100},
});

menu.Add("Entradas", new Dictionary<string, double> {{ "vite tone", 800},
                                                    { "Rabas",1000 },
                                                    { "Fiambre",200},
});

menu.Add("Plato Principal", new Dictionary<string, double> {{ "Lomo", 1000},
                                                    { "Milanesa",500 },
                                                    { "Pasta",800},
});


Console.WriteLine("Seccion\t\t\t\t\tProducto\t\tPrecio");

foreach (KeyValuePair<string,Dictionary<string,Double>> seccion in menu)
{
    Console.WriteLine("{0}", seccion.Key);
    foreach (KeyValuePair<string,double> precio in seccion.Value)
    {
        Console.WriteLine("\t\t\t\t\t{0}\t\t{1}", precio.Key, precio.Value);
    }
}

Console.ReadKey();
