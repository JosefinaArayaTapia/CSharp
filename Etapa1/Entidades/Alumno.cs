using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string IdAlumno { get; set; }
        /// <summary>
        /// Constructor de Alunno
        /// </summary>
        /// <returns>Alunno</returns>
        public Alumno() => IdAlumno = Guid.NewGuid().ToString();


    }
}