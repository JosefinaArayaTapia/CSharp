namespace CoreEscuela.Entidades
{

    class Escuela
    {
        string nombre;

        public string Nombre
        {
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int AñodeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        // Constructor Antiguo
        // public Escuela(string Nombre, int AñoCreacion)
        // {

        //     this.Nombre = Nombre;
        //     AñodeCreacion = AñoCreacion;
        // }

        //Nuevo Constructor
        public Escuela(string Nombre, int AñoCreacion) => (this.Nombre, AñodeCreacion) = (Nombre, AñoCreacion);

    }

}