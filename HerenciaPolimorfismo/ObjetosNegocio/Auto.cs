using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    public class Auto : Vehiculo
    {
        public string DetallesCarroceria { get; set; }

        public override void Acelerar(int aceleracion)
        {
            _velocidad += aceleracion;
        }

        public override void Frenar()
        {
            _velocidad= 0;
        }
    }
}
