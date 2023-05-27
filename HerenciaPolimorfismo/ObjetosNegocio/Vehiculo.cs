namespace ObjetosNegocio
{
    public class Vehiculo
    {
        public string Color { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Motor motor { get; set; }

        protected int _velocidad;

        public int Velocidad
        {
            get { return _velocidad; }
        }

        // El virtual se usa para indicar que el metodo se puede sobreescribir en una clase hija
        // podes aplicar polimorfismo derivado
        public virtual void Acelerar (int aceleracion)
        {
            _velocidad += aceleracion;
        }

        public virtual void Frenar()
        {
            _velocidad =0;
        }

        public Vehiculo()
        {
            _velocidad = 0;
        
        }


    }
}