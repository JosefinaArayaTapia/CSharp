using System;
using System.Collections.Generic;
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;


namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var EngineEscuela = new EscuelaEngine();
            EngineEscuela.Inicializar();

            ImprimirCursosEscuela(EngineEscuela.Escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.DibujarTitulo(escuela.Nombre);
            if (escuela?.Cursos != null)
            {
                foreach (var cursos in escuela.Cursos)
                {
                    WriteLine($"Curso - {cursos.Nombre}");
                    // ImprimirAlumnos(cursos.Alumnos);
                    ImprimirEvaluaciones(cursos.Evaluaciones);
                }
            }

        }
        private static void ImprimirAsignaturas(Curso Cursos)
        {
            WriteLine("Cursos");

            foreach (var asignatura in Cursos.Asignaturas)
            {
                WriteLine("-> " + asignatura.Nombre);
            }

        }
        private static void ImprimirAlumnos(List<Alumno> Alumnos)
        {
            WriteLine("ALUMNOS: " + Alumnos.Count);

            foreach (var alumno in Alumnos)
            {
                WriteLine("--> " + alumno.Nombre);
            }

        }
        private static void ImprimirEvaluaciones(List<Evaluaciones> evaluaciones)
        {
            WriteLine($"Evaluaciones: {evaluaciones.Count}");
            foreach (var e in evaluaciones)
            {
                WriteLine($"{e.AlumnoEvaluado.Nombre} - {e.AsignaturaEvaluacion.Nombre}-{e.Nota}");

            }

        }





    }
}
