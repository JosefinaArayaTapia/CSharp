using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("New Platzi", 2005, TiposEscuela.Primaria, Ciudad: "Santiago", Pais: "Chile");
            Curso[] arregloCursos = {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso() { Nombre = "301" }
            };

            var listaCursos = new List<Curso>(){
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso() { Nombre = "301" }
            };

            Escuela.Cursos = listaCursos;
            Escuela.Cursos.Add(new Curso() { Nombre = "401" });

            var otraListaCursos = new List<Curso>(){
                new Curso() { Nombre = "501" },
                new Curso() { Nombre = "601" },
                new Curso() { Nombre = "701" }
            };


            Escuela.Cursos.AddRange(otraListaCursos);

            Curso tmp = new Curso { Nombre = "801" };
            Escuela.Cursos.Add(tmp);
        }
    }

}
