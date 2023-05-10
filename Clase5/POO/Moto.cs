using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Moto : Vehiculo
    {
        protected int _cantidadCilindradas;

        public Moto()
        {
        
            this._cantidadCilindradas = 500;
        }

        public int CantidadCilindradas
        {
          get { return this._cantidadCilindradas; }
            set {
                this._cantidadCilindradas = value;
                }
        }


        public override Vehiculo CargarDatosObjeto()
        {
            base.CargarDatosObjeto();
            this._cantidadCilindradas = 1200;

            return this;
        }
      
        public override void Verificar()
        {
            HelperPantalla.MostrarMensajeConSalto("Verificado");
        }

    }
}
