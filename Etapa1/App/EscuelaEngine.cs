using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
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
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {

            foreach (var c in Escuela.Cursos)
            {
                foreach (var al in c.Alumnos)
                {
                    var listaEvaluaciones = new List<Evaluaciones>();
                    foreach (var a in c.Asignaturas)
                    {

                        for (int i = 0; i < 5; i++)
                        {
                            var NombreA = $"Evaluacion - {a.Nombre}";
                            Random rnd = new Random();
                            double minimum = 0.0;
                            double maximum = 5.0;
                            double val = (rnd.NextDouble() * (maximum - minimum) + minimum);
                            var Nota = (float)Math.Round(val, 2);

                            listaEvaluaciones.Add(new Evaluaciones()
                            {
                                Nombre = NombreA,
                                AlumnoEvaluado = al,
                                AsignaturaEvaluacion = a,
                                Nota = Nota
                            }
                            );
                            c.Evaluaciones = listaEvaluaciones;

                        }

                    }



                }

            }

        }

        private void CargarAsignaturas()
        {
            foreach (var Curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre="Matematicas"},
                    new Asignatura{Nombre="Lenguaje"},
                    new Asignatura{Nombre="Ciencias"},
                    new Asignatura{Nombre="Fisica"},
                    new Asignatura{Nombre="Esducacion Fisica"}
                };
                Curso.Asignaturas = listaAsignaturas;

            }
        }

        private List<Alumno> GenerarAlumnosAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.IdAlumno).Take(cantidad).ToList();

        }

        public void CargarCursos()
        {
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
            Random rnd = new Random();
            foreach (var c in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 10);
                c.Alumnos = GenerarAlumnosAzar(cantRandom);
            }



        }
    }

}
