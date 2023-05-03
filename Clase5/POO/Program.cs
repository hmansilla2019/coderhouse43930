using System.Net.Security;

namespace POO
{
    // Creo una clase para mi aplicacion Principal
    class ProbarObjetosYClases
    {
        // En un contexto de consola
        // Es necesario crear un metodo estatico llamado
        // Main que se ejecuta automaticamente cuando se
        // instancia la clase
        // La clase se instancia automaticamente
        // al ejecutar la aplicacion de consola
        // Antes de net 5 existia dentro del archivo Program
        // la Clase Program (eso no dejo de existir pero
        // la genera en tiempo de ejecucion
        // lo mismo el metodo Main
        // si necesito implementar el metodo Main
        // lo podemos realizar como se muestra en este
        // ejemplo
        static void Main(string[] args)
        {
            // Helper para manejo de datos en pantalla
            HelperPantalla pantalla = new HelperPantalla();

            int aceleracionInicial = 0;
         
            // Creo un objeto con el constructor
            // sin parametro donde se setean los
            // Valores por default
            Vehiculo miVehiculoDefault = new Vehiculo();
            miVehiculoDefault.MostrarDatosObjeto(miVehiculoDefault);
            pantalla.MostrarMensajeConSalto("------------------------------------------------------------");
            // Salgamos un rato a manejar con nuestro vehiculo
            pantalla.MostrarMensajeConSalto("Salgamos en nuestro vehiculo");
            miVehiculoDefault.Conducir(ref miVehiculoDefault);
            pantalla.MostrarMensajeConSalto("Luego de haber conducido su velocidad es " + miVehiculoDefault.Velocidad + "km/h");
            pantalla.MostrarMensajeConSalto("------------------------------------------------------------");
           
            Vehiculo miVehiculoCustom =new Vehiculo().CargarDatosObjeto();
            
            pantalla.MostrarMensajeConSalto("------------------------------------------------------------");
            miVehiculoCustom.MostrarDatosObjeto(miVehiculoCustom);
            pantalla.MostrarMensajeConSalto("------------------------------------------------------------");
            
            // Salgamos un rato a manejar con nuestro vehiculo
            // Se hace sobre carga del metodo
            // Salgamos un rato a manejar con nuestro vehiculo
            pantalla.MostrarMensajeConSalto("Salgamos en nuestro vehiculo");
            pantalla.MostrarMensajeSinSalto("Acelere Indicando aceleracion: ");
            aceleracionInicial = int.Parse(pantalla.IngresarDato());
            miVehiculoCustom.Conducir(ref miVehiculoCustom, aceleracionInicial);
            pantalla.MostrarMensajeConSalto("------------------------------------------------------------");
            pantalla.MostrarMensajeConSalto("Luego de haber conducido su velocidad es " + miVehiculoDefault.Velocidad + "km/h");
            Console.ReadKey();
        }



    }
}


