using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var miEcuela = new Escuela("Macor School");
            miEcuela.tipoEscuela = TiposEscuela.Preescolar;

            Console.WriteLine(miEcuela);
        }
    }
}
