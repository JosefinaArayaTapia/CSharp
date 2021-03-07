using System;

namespace CoreEscuela.Entidades
{
    public class Evaluaciones
    {
        public string Nombre { get; set; }
        public string IdAEvaluaciones { get; set; }

        public Alumno AlumnoEvaludado { get; set; }
        public Asignatura AsignaturaEvaludacion { get; set; }

        public float Nota { get; set; }




        /// <summary>
        /// Constructor de Asignatura
        /// </summary>
        /// <returns>Asignatura</returns>
        public Evaluaciones() => IdAEvaluaciones = Guid.NewGuid().ToString();


    }
}