using System;

namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public string Nombre { get; set; }
        public string IdAAsignatura { get; set; }
        /// <summary>
        /// Constructor de Asignatura
        /// </summary>
        /// <returns>Asignatura</returns>
        public Asignatura() => IdAAsignatura = Guid.NewGuid().ToString();


    }
}