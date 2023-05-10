using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Auto : Vehiculo
    {
        public Auto()
        {
            
        }

      

        public override void Verificar()
        {
            HelperPantalla.MostrarMensajeConSalto("Verificada la moto");
        }

        public override void CambioAceite()
        {
            HelperPantalla.MostrarMensajeConSalto("Cambio Aceite Auto");
        }

    }
}
