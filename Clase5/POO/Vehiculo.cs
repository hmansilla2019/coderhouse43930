using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Vehiculo
    {
        #region Constructores
        public Vehiculo()
       {
            this._color = string.Empty;
            this._cantidadPuertas = 0;
            this._motor = string.Empty;
            this._velocidad = 0;
            this._cantidadRuedas = 0;
            this._marca = string.Empty;
            this._combustible = string.Empty;
            this._tieneAireAcondicionado = false;
            this.pantalla = new HelperPantalla();
        }

        public Vehiculo(int numeroChasis,
                        string color, 
                        short cantidadPuertas,
                        string motor,
                        short cantidadRuedas,
                        string marca,
                        string combustible,
                        bool tieneAireAcondicionado,
                        string fabricante
            )
        {
            this.NumeroChasis = numeroChasis;
            this._color = color;
            this._cantidadPuertas = cantidadPuertas;
            this._motor = motor;
            this._velocidad = 0;
            this._cantidadRuedas = cantidadRuedas;
            this._marca = marca;
            this._combustible = combustible;
            this._tieneAireAcondicionado = tieneAireAcondicionado;
            this.Fabricante = fabricante;
            this.pantalla = new HelperPantalla();
        }

        #endregion

        #region Atributos
        private string _color;
        private short _cantidadPuertas;
        private string _motor;
        // no tendra Setter sera de solo lectura implementando Getter
        // a travez del metodo Acelerar y del metodo Frenar
        // se modificaran sus valores
        // siendo al momento de construirse la velocidad 0
        private int _velocidad;
        private short _cantidadRuedas;
        private string _marca;
        private string _combustible;
        // No se podra modificar ni acceder directamente
        // se setea el default en el constructor
        // Podemos hacer un metodo que sea AgregarAireAcondicionado
        // que le asigne true al atributo por ejemplo
        // Se implementa una propiedad de solo lectura
        private bool _tieneAireAcondicionado;

        private HelperPantalla pantalla;

        #endregion

        #region Propiedades

        // Autoimplementada, el atributo esta implicito en la
        // Propiedad
        public string Fabricante { get; set; }

        // Autoimplementada de solo lectura
        // Inicializo en el constructor y 
        // puedo tener un metodo que lo pueda modificar
        // en algun contexto, pero lo hace el metodo interno
        // de la clase en estos casos
        public int NumeroChasis { get; }


        public string Color
        { 
            get { return _color; }
            set { _color = value; }
        }
        
        // getter con logica en el get
        // podria tener logica al momento de hacer el Get
        public string Marca
        {
            get {
                if (!string.IsNullOrEmpty(_marca))
                {
                    return _marca;
                }
                else
                {
                    return "Sin Marca";
                }
                 
            
            }
            set { _marca = value; }
        }

        public short CantidadPuertas
        {
            get { return _cantidadPuertas; }
            set { _cantidadPuertas = value; }
        }

        public string Motor
        {
            get { return _motor; }
            set { _motor = value; }
        }

        public short CantidadRuedas
        {
            get { return _cantidadRuedas; }
            set { _cantidadRuedas = value; }
        }

        public string Combustible
        {
            get { return _combustible; }
            set { _combustible = value; }
        }

        // Propiedad de solo lectura
        public int Velocidad
        {
            get { return _velocidad; }
        }
        public bool TieneAireAcondicionado
        {
            get { return _tieneAireAcondicionado; }
        }
        #endregion


        #region Metodos
        // Metodo
        public bool TienePuertas()
        {
            return _cantidadPuertas > 0;
        }

        public void Acelerar(int aceleracion)
        {
            _velocidad += aceleracion;
        }

        public void Frenar()
        {
            _velocidad = 0;
        }

        public void PonerAireAcondicionado()
        {
            _tieneAireAcondicionado = true;
        }


        /// <summary>
        /// Si realizo acciones de consola
        /// Puedo crear este metodo y pedirle la informacion
        /// al objeto, en este caso a Vehiculo
        /// </summary>
        /// <param name="vehiculo"></param>
        internal void MostrarDatosObjeto(Vehiculo vehiculo)
        {
            this.pantalla.MostrarMensajeConSalto("Color: " + vehiculo.Color);
            this.pantalla.MostrarMensajeConSalto("Cantidad de Ruedas: " + vehiculo.CantidadRuedas);
            if (vehiculo.TienePuertas())
            {
                this.pantalla.MostrarMensajeConSalto("Cantidad de Puertas: " + vehiculo.CantidadRuedas);
            }
            else
            {
                this.pantalla.MostrarMensajeConSalto("El Vehiculo no tiene puertas");
            }
            if (vehiculo.TieneAireAcondicionado)
            {
                this.pantalla.MostrarMensajeConSalto("Tiene aire acondicionado");
            }
            else
            {
                this.pantalla.MostrarMensajeConSalto("No Tiene aire acondicionado");
            }
            this.pantalla.MostrarMensajeConSalto("Motor: " + vehiculo.Motor);
            this.pantalla.MostrarMensajeConSalto("Combustible: " + vehiculo.Combustible);
            this.pantalla.MostrarMensajeConSalto("Nro de Chasis: " + vehiculo.NumeroChasis);
            this.pantalla.MostrarMensajeConSalto("Fabricante: " + vehiculo.Fabricante);
            this.pantalla.MostrarMensajeConSalto("Marca: " + vehiculo.Marca);

        }

        /// <summary>
        /// La clase principal pide al usuario los datos
        /// y crea el objeto a traves de su constructor
        /// </summary>
        /// <returns></returns>
        public Vehiculo CargarDatosObjeto()
        {
            string color = string.Empty;
            short cantidadPuertas = 0;
            short cantidadRuedas = 0;
            string marca = string.Empty;
            string combustible = string.Empty;
            string sTieneAireAcondicionado = "NO";
            bool bTieneAireAcondicionado = false;
            string motor = string.Empty;
            int numeroChasis = 0;
            string fabricante = string.Empty;

            this.pantalla.MostrarMensajeSinSalto("Ingrese Color: ");
            color = this.pantalla.IngresarDato();

            this.pantalla.MostrarMensajeSinSalto("Ingrese Cantidad de puertas: ");
            cantidadPuertas = short.Parse(this.pantalla.IngresarDato());

            this.pantalla.MostrarMensajeSinSalto("Ingrese Cantidad de ruedas: ");
            cantidadRuedas = short.Parse(this.pantalla.IngresarDato());

            this.pantalla.MostrarMensajeSinSalto("Ingrese Marca: ");
            marca = this.pantalla.IngresarDato();

            this.pantalla.MostrarMensajeSinSalto("Ingrese Combustible: ");
            combustible = this.pantalla.IngresarDato();

            this.pantalla.MostrarMensajeSinSalto("Ingrese si tiene Aire Acondicionado (SI o NO: ");
            sTieneAireAcondicionado = this.pantalla.IngresarDato();

            if (sTieneAireAcondicionado == "SI")
                bTieneAireAcondicionado = true;
            
            this.pantalla.MostrarMensajeSinSalto("Ingrese Motor: ");
            motor = this.pantalla.IngresarDato();


            this.pantalla.MostrarMensajeSinSalto("Ingrese Numero de Chasis: ");
            numeroChasis = int.Parse(this.pantalla.IngresarDato());

            this.pantalla.MostrarMensajeSinSalto("Ingrese Fabricante: ");
            fabricante = this.pantalla.IngresarDato();


            return new Vehiculo(numeroChasis, color, cantidadPuertas, motor, cantidadRuedas, marca, combustible, bTieneAireAcondicionado, fabricante);

        }

        /// <summary>
        /// Este metodo recibe por referencia el objeto para
        /// Que la velocidad del objeto se actualice y
        /// luego de ejecutarse el metodo tome la 
        /// ultima velocidad (En este caso sera 0)
        /// </summary>
        /// <param name="vehiculo"></param>
        internal void Conducir(ref Vehiculo vehiculo)
        {
            // Salgamos un rato a manejar con nuestro vehiculo
            this.pantalla.MostrarMensajeConSalto("Arrancar su velocidad actual es " + vehiculo.Velocidad + "km/h");
            vehiculo.Acelerar(50);
            vehiculo.Acelerar(50);
            vehiculo.Acelerar(50);
            this.pantalla.MostrarMensajeConSalto("Cuidado va muy rapido " + vehiculo.Velocidad + "km/h");
            vehiculo.Acelerar(-50);
            vehiculo.Acelerar(-50);
            this.pantalla.MostrarMensajeConSalto("Gracias por bajar la velocidad " + vehiculo.Velocidad + "km/h");
            this.pantalla.MostrarMensajeConSalto("Por favor frena");
            vehiculo.Frenar();
            this.pantalla.MostrarMensajeConSalto("Gracias por frenar su vehiculo se detuvo " + vehiculo.Velocidad + "km/h");

        }

        /// <summary>
        /// El metodo permite acelerar y termina cuando la 
        /// Velocidad ya es menor o igual a cero
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <param name="aceleracion"></param>
        internal void Conducir(ref Vehiculo vehiculo, int pAceleracion)
        {
            int aceleracion = pAceleracion;
           
            vehiculo.Acelerar(aceleracion);
            this.pantalla.MostrarMensajeConSalto("Velocidad Inicial: " + vehiculo.Velocidad + "km/h");
            this.pantalla.MostrarMensajeConSalto("------------------------------------------------------------");

            while (vehiculo.Velocidad > 0)
            {
                // Si supera la velocidad permitida le indico que la baje
                while (vehiculo.Velocidad > 150)
                {
                    this.pantalla.MostrarMensajeConSalto("Cuidado va muy rapido baje la velocidad no debe superar los 150 Km/h. Velocidad Actual: " + vehiculo.Velocidad + "km/h");
                    this.pantalla.MostrarMensajeSinSalto("Acelere Indicando aceleracion negativa para reducir(-): ");
                    aceleracion = int.Parse(this.pantalla.IngresarDato());
                    vehiculo.Acelerar(aceleracion);
                    this.pantalla.MostrarMensajeConSalto("------------------------------------------------------------");
                }
                // si desacelero a 0 o menos sale del ciclo
                // porque ya llego
                if (vehiculo.Velocidad <= 0)
                {
                    break;
                }
                this.pantalla.MostrarMensajeConSalto("------------------------------------------------------------");
                this.pantalla.MostrarMensajeConSalto("Velocidad Actual: " + vehiculo.Velocidad + "km/h");
                this.pantalla.MostrarMensajeSinSalto("Acelere Indicando aceleracion: ");
                aceleracion = int.Parse(this.pantalla.IngresarDato());
                vehiculo.Acelerar(aceleracion);
            }
            this.pantalla.MostrarMensajeConSalto("------------------------------------------------------------");
            
            // aqui significa que la velocidad es 0 o menos
            vehiculo.Frenar();
            this.pantalla.MostrarMensajeConSalto("------------------------------------------------------------");

            this.pantalla.MostrarMensajeConSalto("Ha llegado a destino");
            this.pantalla.MostrarMensajeConSalto("------------------------------------------------------------");

        }








        #endregion
    }

}