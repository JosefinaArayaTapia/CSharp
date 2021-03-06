using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;


namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {

            var escuela = new Escuela("New Platzi", 2005, TiposEscuela.Primaria, Ciudad: "Santiago", Pais: "Chile");

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

            escuela.Cursos = listaCursos;
            escuela.Cursos.Add(new Curso() { Nombre = "401" });

            var otraListaCursos = new List<Curso>(){
                new Curso() { Nombre = "501" },
                new Curso() { Nombre = "601" },
                new Curso() { Nombre = "701" }
            };


            escuela.Cursos.AddRange(otraListaCursos);

            escuela.Cursos.Remove

            ImprimirCursosEscuela(escuela);



        }



        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("======================================================");
            WriteLine("Cursos de la Escuela : " + escuela.Nombre);
            WriteLine("======================================================");
            if (escuela?.Cursos != null)
            {
                foreach (var cursos in escuela.Cursos)
                {
                    WriteLine(cursos.Nombre);
                }
            }

        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            WriteLine("ForEach");
            foreach (var Curso in arregloCursos)
            {

                WriteLine($"Nombre: {Curso.Nombre}");
                WriteLine($"Id: {Curso.UniqueId}");
            }
        }

        private static void ImprimirCursosdoWhile(Curso[] arregloCursos)
        {
            WriteLine("Do While");
            int contador = 0;
            do
            {

                WriteLine($"Nombre: {arregloCursos[contador].Nombre}");
                WriteLine($"Id: {arregloCursos[contador].UniqueId}");
                contador++;

            } while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            Console.WriteLine("For");
            for (int i = 0; i < arregloCursos.Length; i++)
            {

                WriteLine($"Nombre: {arregloCursos[i].Nombre}");
                WriteLine($"Id: {arregloCursos[i].UniqueId}");

            }
        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            WriteLine("While");
            int contador = 0;
            while (contador < arregloCursos.Length)
            {

                WriteLine($"Nombre: {arregloCursos[contador].Nombre}");
                WriteLine($"Id: {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }
    }
}
