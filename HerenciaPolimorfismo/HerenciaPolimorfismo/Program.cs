using ObjetosNegocio;

Vehiculo vehiculo = new Vehiculo();
vehiculo.Marca = "Chevrolet";
vehiculo.Modelo = "Corsa";
vehiculo.Color = "Azul";

Console.WriteLine("Velocidad actual:" + vehiculo.Velocidad);
vehiculo.Acelerar(50);

Console.WriteLine("Velocidad actual:" + vehiculo.Velocidad);
vehiculo.Frenar();

Console.WriteLine("Velocidad actual:" + vehiculo.Velocidad);

Avion avion = new Avion();
avion.CaracteristicasAlas = "Alas largas";

Console.WriteLine("Velocidad actual:" + avion.Velocidad);

avion.Acelerar(50);
Console.WriteLine("Velocidad actual:" + avion.Velocidad);


avion.Frenar();
Console.WriteLine("Velocidad actual:" + avion.Velocidad);


Console.ReadKey();