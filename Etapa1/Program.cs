using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {

            var escuela = new Escuela("Plazti", 2005, TiposEscuela.Primaria, Ciudad: "Santiago", Pais: "Chile");


            Console.WriteLine(escuela);
        }
    }
}
