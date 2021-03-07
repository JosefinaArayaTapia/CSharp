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
                    WriteLine(cursos.Nombre);
                }
            }

        }
    }
}
