// See https://aka.ms/new-console-template for more information


//int numero2 = int.Parse(Console.ReadLine());

try
{
    int numero = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine("Ocurrio un error");
  //  Console.WriteLine(ex.Message);
	throw;
}











//Dictionary<string,string> modeloxMarca = new Dictionary<string,string>();

//modeloxMarca.Add("Ford", "Focus");
//modeloxMarca.Add("Peugeot", "205");
//modeloxMarca.Add("Renault", "Sendero");
//modeloxMarca.Add("Fiat", "Uno");
//modeloxMarca.Add("Chevrolet", "Corsa");

//Console.WriteLine("Los Modelos por Marca de Veihiculos son:");
//foreach (KeyValuePair<string,string> item in modeloxMarca)
//{
//    Console.WriteLine("Marca " + item.Key + " Modelo " + item.Value);
//}

//modeloxMarca.Remove("Ford");

//modeloxMarca["Fiat"] = "Duna";

//string modelo;

//if (modeloxMarca.ContainsKey("Fiat"))
//{
//    modeloxMarca.TryGetValue("Fiat", out modelo);
//    Console.WriteLine("El modelo para la marca Fiat es " + modelo);
//}

//Console.WriteLine("Los Modelos por Marca de Veihiculos son:");
//foreach (KeyValuePair<string, string> itemModelo in modeloxMarca)
//{
//    Console.WriteLine("Marca " + itemModelo.Key + " Modelo " + itemModelo.Value);
//}


//Console.ReadKey();


