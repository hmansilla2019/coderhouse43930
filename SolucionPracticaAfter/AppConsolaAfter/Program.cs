
namespace AppConsolaAfter
{
    class AppConsoleClass
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ibgrese como quiere cargar la lista por Programa principal (1) o por el Objeto (2)");

            if (int.Parse(Console.ReadLine())== 1)
            {
                Console.WriteLine("Lista de Empleados Cargada desde Helper");
                // Cargo lista por Helper desde el Main
                Helper.CargaryMostrarLista();
            }
            else
            {

                Empleado empleado = new Empleado();
                Helper.CargarLista(ref empleado);

                Console.WriteLine("Lista de Empleados Cargada en Objeto desde helper");
                Helper.MostrarLista(empleado.listaEmpleados);
            }

            Console.ReadKey();
        
        }


    }




}
