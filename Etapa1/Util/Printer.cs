using System;
using static System.Console;
namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int largo = 10)
        {
            var linea = "".PadLeft(largo, '=');
            WriteLine(linea);
        }
        public static void DibujarTitulo(string Titulo)
        {
            DibujarLinea(100);
            WriteLine("Cursos de la Escuela : " + Titulo);
            DibujarLinea(100);

        }
    }

}