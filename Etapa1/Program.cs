using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {

            var escuela = new Escuela("Plazti", 2005, TiposEscuela.Primaria, Ciudad: "Santiago", Pais: "Chile");
            var arregloCursos = new Curso[3];
            arregloCursos[0] = new Curso() { Nombre = "101" };
            arregloCursos[1] = new Curso() { Nombre = "201" };
            arregloCursos[2] = new Curso() { Nombre = "301" };

            Console.WriteLine(escuela);

            System.Console.WriteLine("===============");
            ImprimirCursosWhile(arregloCursos);
            ImprimirCursosFor(arregloCursos);
            ImprimirCursosdoWhile(arregloCursos);
            ImprimirCursosForEach(arregloCursos);

        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            Console.WriteLine("ForEach");
            foreach (var Curso in arregloCursos)
            {

                Console.WriteLine($"Nombre: {Curso.Nombre}");
                Console.WriteLine($"Id: {Curso.UniqueId}");
            }
        }

        private static void ImprimirCursosdoWhile(Curso[] arregloCursos)
        {
            Console.WriteLine("Do While");
            int contador = 0;
            do
            {

                Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}");
                Console.WriteLine($"Id: {arregloCursos[contador].UniqueId}");
                contador++;

            } while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            Console.WriteLine("For");
            for (int i = 0; i < arregloCursos.Length; i++)
            {

                Console.WriteLine($"Nombre: {arregloCursos[i].Nombre}");
                Console.WriteLine($"Id: {arregloCursos[i].UniqueId}");

            }
        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            Console.WriteLine("While");
            int contador = 0;
            while (contador < arregloCursos.Length)
            {

                Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}");
                Console.WriteLine($"Id: {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }
    }
}
