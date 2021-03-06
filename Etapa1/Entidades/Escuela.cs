using System.Collections.Generic;
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
        public TiposEscuela TipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }

        public Escuela(string Nombre, int AñoCreacion) => (this.Nombre, AñodeCreacion) = (Nombre, AñoCreacion);
        public Escuela(string Nombre, int AñoCreacion, TiposEscuela tipos, string Pais = "", string Ciudad = "")
        {
            (this.Nombre, AñodeCreacion) = (Nombre, AñoCreacion);
            this.Pais = Pais;
            this.Ciudad = Ciudad;
            TipoEscuela = tipos;


        }
        public override string ToString()
        {
            string newLine = System.Environment.NewLine;

            return $"Nombre= \"{Nombre}\", Tipo={TipoEscuela} {newLine} Pais={Pais}, Ciudad={Ciudad}";

        }

    }

}