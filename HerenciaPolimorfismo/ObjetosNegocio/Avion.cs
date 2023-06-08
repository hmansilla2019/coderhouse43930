using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    public class Avion : Vehiculo, IComercial, IImpuestos
    {
        public Avion()
        {
            Color = "Blanco";
            Marca = "Renault";
            Modelo = "Jet";
        }

        public string CaracteristicasAlas { get; set; }
        public List<Motor> Motores { get; set; }

        // Overrida se usa para sobreescibir un metodo del padre que puede ser Virtual, (DEBE) abstract o override
        public override void Acelerar(int aceleracion)
        {
            _velocidad += aceleracion*100;
        }

        public decimal CalcularImpuestos()
        {
            return 20000;
        }

        public override void Frenar()
        {
            _velocidad = 0;
        }

      

        public void PedirAutorizacion()
        {
            Console.WriteLine("Autorizado");
        }
    }
}
