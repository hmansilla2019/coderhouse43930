using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    public class Moto : Vehiculo
    {
        public string DescripcionManubrio { get; set; }
        
        public Moto()
        {
            base.motor = new Motor();
            base.motor.RevolucionesMinuto = 5000;
            base.motor.CantidadCaballosFuerza = 500;
        }

        public Moto(int revolucionesMinuto, int cantidadCaballosFuerza)
        {
            base.motor = new Motor();
            base.motor.RevolucionesMinuto = revolucionesMinuto;
            base.motor.CantidadCaballosFuerza = cantidadCaballosFuerza;
        }

        public void CargarDatos()
        {
            base.Color = "Rojo";
            base.Marca = "Ford";
            base.Modelo = "Ka";
        }
        public void CargarDatos(string color, string marca, string modelo)
        {
            base.Color = color;
            base.Marca = marca;
            base.Modelo = modelo;
        }


    }
}
